using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using FluentValidation;

namespace Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;

            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));
        }
    }
}