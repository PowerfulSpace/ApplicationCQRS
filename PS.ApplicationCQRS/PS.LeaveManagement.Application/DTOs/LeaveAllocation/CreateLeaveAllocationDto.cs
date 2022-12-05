namespace PS.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto : ILeaveAllocationDto
    {
        public int LeaveTypeId { get; set; }
        public int NumberIfDays { get; set; }
        public int Period { get; set; }
    }
}
