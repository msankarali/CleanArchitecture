﻿using FluentValidation;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());
        }
    }
}