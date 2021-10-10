using Comp.HR.LeaveManagement.Application.DTOs.Common;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}