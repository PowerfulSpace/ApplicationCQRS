using PS.LeaveManagement.Domain.Common;

namespace PS.LeaveManagement.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        /// <summary>
        /// LeaveType - Тип отпуска
        /// LeaveTypeId - Id типа отпуска
        /// RequestComments - запрос коментариев
        /// Approved - одобренный
        /// Cancelled - отменено
        /// StartDate - дата начала
        /// EndDate - дата окончания
        /// DateRequested - дата запроса
        /// DateActioned - дата действия
        /// </summary>
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string? RequestComments { get; set; }      
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateActioned { get; set; }
    }
}
