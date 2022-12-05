using PS.LeaveManagement.Application.DTOs.LeaveType;
using PS.LeaveManagement.Domain;

namespace PS.LeaveManagement.Application.Persistence.Contract
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<LeaveTypeDto> GetLeaveTypeWithDetails(int id);
        Task<List<LeaveTypeDto>> GetLeaveTypesWithDetails();
        Task ChangeApprovalStatus(LeaveType leaveTypeDto, bool? approvalStatus);
    }
}
