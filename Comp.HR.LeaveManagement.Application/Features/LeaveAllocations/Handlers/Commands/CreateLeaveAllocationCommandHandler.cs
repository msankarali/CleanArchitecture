using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using Comp.HR.LeaveManagement.Domain;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);

            leaveAllocation = await _leaveAllocationRepository.AddAsync(leaveAllocation);

            return leaveAllocation.Id;
        }
    }
}