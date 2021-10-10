using Comp.HR.LeaveManagement.Application.DTOs.Common;
using Comp.HR.LeaveManagement.Domain;

namespace Comp.HR.LeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}