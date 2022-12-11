using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Request.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
