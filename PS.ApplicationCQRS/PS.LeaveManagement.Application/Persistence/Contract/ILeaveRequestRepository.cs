using PS.LeaveManagement.Application.DTOs.LeaveRequest;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Persistence.Contract
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequestDto> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequestDto>> GetLeaveRequestsWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus);
    }
}
