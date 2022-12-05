using PS.LeaveManagement.Domain.Common;

namespace PS.LeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        /// <summary>
        /// LeaveType - Тип отпуска
        /// LeaveTypeId - Id типа отпуска
        /// NumberIfDays - Количество дней
        /// Period - период
        /// </summary>
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int NumberOfDays { get; set; }        
        public int Period { get; set; }
    }
}
