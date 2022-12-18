using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveAllocation;
using PS.LeaveManagement.Application.Responses;

namespace PS.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; } = null!;
    }
}
