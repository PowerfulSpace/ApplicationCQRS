using PS.LeaveManagement.Domain.Common;

namespace PS.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        /// <summary>
        /// Name - имя
        /// DefaultDays - дни по умолчанию
        /// </summary>
        public string Name { get; set; } = null!;
        public int DefaultDays { get; set; }
    }
}
