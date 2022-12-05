using PS.LeaveManagement.Application.DTOs.Common;

namespace PS.LeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDto :BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; } = null!;
        public int DefaultDays { get; set; }
    }
}
