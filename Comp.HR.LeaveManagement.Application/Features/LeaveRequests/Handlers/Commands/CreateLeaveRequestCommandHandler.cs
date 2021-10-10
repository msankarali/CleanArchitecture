using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Contracts.Infrastructure;
using Comp.HR.LeaveManagement.Application.Contracts.Persistence;
using Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators;
using Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Models;
using Comp.HR.LeaveManagement.Domain;
using MediatR;
using ValidationException = Comp.HR.LeaveManagement.Application.Exceptions.ValidationException;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository leaveTypeRepository,
            IEmailSender emailSender,
            IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _emailSender = emailSender;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto, cancellationToken);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveRequest = _mapper.Map<LeaveRequest>(request);

            leaveRequest = await _leaveRequestRepository.AddAsync(leaveRequest);

            var email = new Email
            {
                To = "sample@mail.com",
                Body =
                    $"Your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate:D} " +
                    $"has been submitted successfully",
                Subject = "Leave Request Submitted"
            };

            try
            {
                await _emailSender.SendEmailAsync(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return leaveRequest.Id;
        }
    }
}