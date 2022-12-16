using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveAllocation;

namespace PS.LeaveManagement.Application.Features.LeaveAllocations.Request.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
