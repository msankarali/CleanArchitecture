using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Exceptions;
using Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using Comp.HR.LeaveManagement.Domain;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveRequestRepository.GetAsync(request.Id);

            if (leaveType == null)
                throw new NotFoundException(nameof(LeaveRequest), request.Id);

            await _leaveRequestRepository.DeleteAsync(leaveType);

            return Unit.Value;
        }
    }
}