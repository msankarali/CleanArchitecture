﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Comp.HR.LeaveManagement.Domain;

namespace Comp.HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetailsAsync(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}