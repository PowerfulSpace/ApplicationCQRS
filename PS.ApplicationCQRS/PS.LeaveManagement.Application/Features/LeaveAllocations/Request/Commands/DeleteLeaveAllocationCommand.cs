using MediatR;

namespace PS.LeaveManagement.Application.Features.LeaveAllocations.Request.Commands
{
    public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
