using System.Collections.Generic;
using Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
    {

    }
}