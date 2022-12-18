using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveAllocation;

namespace PS.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; } = null!;
    }
}
