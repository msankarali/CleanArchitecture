using Comp.HR.LeaveManagement.Application.DTOs.Common;

namespace Comp.HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}