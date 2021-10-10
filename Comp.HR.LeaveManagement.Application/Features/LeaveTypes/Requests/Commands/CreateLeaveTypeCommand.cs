using Comp.HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}