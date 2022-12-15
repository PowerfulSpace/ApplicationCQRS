using MediatR;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Request.Commands
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
