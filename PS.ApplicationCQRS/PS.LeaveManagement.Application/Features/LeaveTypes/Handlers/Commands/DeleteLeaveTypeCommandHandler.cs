using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.Exceptions;
using PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);

            if(leaveType == null )
                throw new NotFoundException(nameof(LeaveType), request.Id);

            await _leaveTypeRepository.Delete(leaveType);

            return Unit.Value;
        }
    }
}
