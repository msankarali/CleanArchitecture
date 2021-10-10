using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Comp.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetAsync(request.Id);

            await _leaveTypeRepository.DeleteAsync(leaveType);

            return Unit.Value;
        }
    }
}