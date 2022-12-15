using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Request.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; } = null!;

        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; } = null!;
    }
}
