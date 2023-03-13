using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoMarketing.Controllers.Features.Appointment
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentController(IMediator mediator) => _mediator = mediator;

        [HttpGet("appointments")]
        public async Task<IActionResult> GetSessions(DateTime date) =>
            await Task.FromResult(Ok(_mediator.Send(new GetAppointments.Query(date))));
    }
}
