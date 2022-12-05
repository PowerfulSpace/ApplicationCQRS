using PS.LeaveManagement.Application.DTOs.Common;

namespace PS.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto,ILeaveAllocationDto
    {
        public int LeaveTypeId { get; set; }
        public int NumberIfDays { get; set; }
        public int Period { get; set; }
    }
}
