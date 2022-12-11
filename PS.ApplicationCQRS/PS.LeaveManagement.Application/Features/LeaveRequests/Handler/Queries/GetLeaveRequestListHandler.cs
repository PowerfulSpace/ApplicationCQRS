using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;
using PS.LeaveManagement.Application.Features.LeaveRequests.Request.Queries;
using PS.LeaveManagement.Application.Persistence.Contract;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Handler.Queries
{
    public class GetLeaveRequestListHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestListHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leaveRequest);
        }
    }
}
