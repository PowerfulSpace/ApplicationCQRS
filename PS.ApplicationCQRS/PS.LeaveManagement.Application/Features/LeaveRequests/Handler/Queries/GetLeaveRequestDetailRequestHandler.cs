using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;
using PS.LeaveManagement.Application.Features.LeaveRequests.Request.Queries;
using PS.LeaveManagement.Application.Persistence.Contract;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Handler.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}
