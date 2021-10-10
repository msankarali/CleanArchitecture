using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using Comp.HR.LeaveManagement.Domain;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(request);

            leaveRequest = await _leaveRequestRepository.AddAsync(leaveRequest);

            return leaveRequest.Id;
        }
    }
}