﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Comp.HR.LeaveManagement.Domain;
using Comp.HR.LeaveManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Comp.HR.LeaveManagement.Persistence
{
    public class HrLeaveManagementDbContext : DbContext
    {
        public HrLeaveManagementDbContext(DbContextOptions<HrLeaveManagementDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrLeaveManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}