using System.Collections.Generic;
using Comp.HR.LeaveManagement.Application.DTOs;
using Comp.HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        
    }
}