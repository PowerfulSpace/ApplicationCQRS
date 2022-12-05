using PS.LeaveManagement.Application.DTOs.Common;

namespace PS.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto, ILeaveRequestDto
    {
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; } = null!;
        public bool Cancelled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
