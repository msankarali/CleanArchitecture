using Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}