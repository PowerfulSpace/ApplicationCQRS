using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using PS.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Application.Responses;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveAllocations.Handler.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, BaseCommandResponse>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator = new CreateLeaveAllocationDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.CreateLeaveAllocationDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                response.Message = "Creation Failed";
            }
            else
            {
                var leaveAllocation = _mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDto);
                await _leaveAllocationRepository.Add(leaveAllocation);

                response.Success = true;
                response.Message = "Creation Successful";
                response.Id = leaveAllocation.Id;
            }
                
            return response;
        }
    }
}
