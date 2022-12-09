using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;
using PS.LeaveManagement.Application.Features.LeaveType.Requests.Queries;
using PS.LeaveManagement.Application.Persistence.Contract;

namespace PS.LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeListRequestHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetLeaveTypesWithDetails();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
