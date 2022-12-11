using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;
using PS.LeaveManagement.Application.Responses;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Request.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; } = null!;
    }
}
