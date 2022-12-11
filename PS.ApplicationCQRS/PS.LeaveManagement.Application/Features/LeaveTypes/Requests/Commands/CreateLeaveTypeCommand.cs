using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;
using PS.LeaveManagement.Application.Responses;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; } = null!;
    }
}
