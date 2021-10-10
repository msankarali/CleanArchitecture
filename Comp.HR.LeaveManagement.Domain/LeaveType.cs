using System;
using System.Collections.Generic;
using System.Text;
using Comp.HR.LeaveManagement.Domain.Common;

namespace Comp.HR.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
