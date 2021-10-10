﻿using Comp.HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}