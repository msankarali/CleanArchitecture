using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using Comp.HR.LeaveManagement.Domain;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(command.LeaveTypeDto);

            leaveType = await _leaveTypeRepository.AddAsync(leaveType);

            return leaveType.Id;
        }
    }
}