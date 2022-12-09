using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;

namespace PS.LeaveManagement.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
