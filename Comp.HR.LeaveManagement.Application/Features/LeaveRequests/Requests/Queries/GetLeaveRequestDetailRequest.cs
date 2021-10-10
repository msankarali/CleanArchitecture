using Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}