using PS.LeaveManagement.Application.DTOs.Common;
using PS.LeaveManagement.Application.DTOs.LeaveType;

namespace PS.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto, ILeaveRequestDto
    {
        public LeaveTypeDto LeaveType { get; set; } = null!;
        public int LeaveTypeId { get; set; }

        public string? RequestComments { get; set; } = null!;
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateActioned { get; set; }
    }
}
