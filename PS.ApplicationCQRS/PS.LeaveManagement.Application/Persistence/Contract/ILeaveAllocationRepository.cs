using PS.LeaveManagement.Application.DTOs.LeaveAllocation;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Persistence.Contract
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocationDto> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocationDto>> GetLeaveAllocationsWithDetails();
        Task ChangeApprovalStatus(LeaveAllocation leaveAllocation, bool? approvalStatus);
    }
}
