using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveRequest;

namespace PS.LeaveManagement.Application.Features.LeaveRequests.Request.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
}
