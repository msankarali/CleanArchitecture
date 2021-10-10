using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comp.HR.LeaveManagement.Application.DTOs.LeaveType;
using Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using Comp.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using Comp.HR.LeaveManagement.Application.Responses;
using MediatR;

namespace Comp.HR.LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<LeaveTypeDto>>> Get() => Ok(await _mediator.Send(new GetLeaveTypeListRequest()));

        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDto>> Get(int id) => Ok(await _mediator.Send(new GetLeaveTypeDetailRequest { Id = id }));

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> PostAsync([FromBody] CreateLeaveTypeDto createLeaveTypeDto) =>
            Ok(await _mediator.Send(new CreateLeaveTypeCommand { LeaveTypeDto = createLeaveTypeDto }));


        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] LeaveTypeDto leaveTypeDto)
        {
            var command = new UpdateLeaveTypeCommand { LeaveTypeDto = leaveTypeDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveTypeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
