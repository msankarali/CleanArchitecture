using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}