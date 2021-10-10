using System.Collections.Generic;
using Comp.HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {

    }
}