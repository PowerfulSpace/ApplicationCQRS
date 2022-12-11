using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType.Validators;
using PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Application.Responses;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
                leaveType = await _leaveTypeRepository.Add(leaveType);

                response.Success = true;
                response.Message = "Creation successful";
                response.Id = leaveType.Id;
            }

            return response;
        }
    }
}
