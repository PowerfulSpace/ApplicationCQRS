namespace PS.LeaveManagement.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifidedDate { get; set; }
        public string? ModifidedBy { get; set; }
    }
}
