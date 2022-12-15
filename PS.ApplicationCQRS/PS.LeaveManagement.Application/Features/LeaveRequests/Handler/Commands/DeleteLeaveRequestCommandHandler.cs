using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.Exceptions;
using PS.LeaveManagement.Application.Features.LeaveRequests.Request.Commands;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Handler.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(LeaveRequest),request.Id);

            await _leaveRequestRepository.Delete(leaveRequest);

            return Unit.Value;
        }
    }
}
