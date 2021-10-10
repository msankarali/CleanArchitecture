using System.Collections.Generic;
using Comp.HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        
    }
}