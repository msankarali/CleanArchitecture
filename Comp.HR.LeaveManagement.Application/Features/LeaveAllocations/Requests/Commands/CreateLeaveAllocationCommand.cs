using Comp.HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}