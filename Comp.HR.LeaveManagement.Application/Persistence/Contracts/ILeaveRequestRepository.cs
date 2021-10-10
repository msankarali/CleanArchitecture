using System.Collections.Generic;
using System.Threading.Tasks;
using Comp.HR.LeaveManagement.Domain;

namespace Comp.HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync();
    }
}