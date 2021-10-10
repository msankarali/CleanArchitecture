using Comp.HR.LeaveManagement.Application.DTOs.LeaveType;
using Comp.HR.LeaveManagement.Application.Responses;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}