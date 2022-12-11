using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; } = null!;
    }
}
