using PS.LeaveManagement.Application.DTOs.LeaveRequest;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Persistence.Contract
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocationDto> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocationDto>> GetLeaveAllocationsWithDetails();
        Task ChangeApprovalStatus(LeaveType leaveAllocation, bool? approvalStatus);
    }
}
