using AutoMapper;
using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;
using PS.LeaveManagement.Application.Features.LeaveType.Requests.Queries;
using PS.LeaveManagement.Application.Persistence.Contract;

namespace PS.LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailRequestHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetLeaveTypeWithDetails(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
