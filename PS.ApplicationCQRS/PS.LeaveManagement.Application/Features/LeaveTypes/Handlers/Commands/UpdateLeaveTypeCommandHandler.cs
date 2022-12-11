using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType.Validators;
using PS.LeaveManagement.Application.Exceptions;
using PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validatorResult.IsValid == false)
                throw new ValidationException(validatorResult);

            var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);

            if(leaveType is null)
                throw new NotFoundException(nameof(LeaveType), request.LeaveTypeDto.Id);

            _mapper.Map(request.LeaveTypeDto, leaveType);

            await _leaveTypeRepository.Update(leaveType);

            return Unit.Value;
        }
    }
}
