using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
