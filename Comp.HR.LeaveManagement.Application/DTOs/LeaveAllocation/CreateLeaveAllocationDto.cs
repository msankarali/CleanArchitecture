﻿using Comp.HR.LeaveManagement.Application.DTOs.Common;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}