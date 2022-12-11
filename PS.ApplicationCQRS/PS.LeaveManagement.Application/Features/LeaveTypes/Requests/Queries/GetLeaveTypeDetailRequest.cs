using MediatR;
using PS.LeaveManagement.Application.DTOs.LeaveType;

namespace PS.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
