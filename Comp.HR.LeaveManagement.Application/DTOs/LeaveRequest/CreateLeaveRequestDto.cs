using System;
using Comp.HR.LeaveManagement.Application.DTOs.Common;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
    }
}