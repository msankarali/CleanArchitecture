﻿using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using FluentValidation;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public UpdateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;

            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present.");
        }
    }
}