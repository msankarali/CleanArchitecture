using Comp.HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}