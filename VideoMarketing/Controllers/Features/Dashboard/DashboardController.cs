using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoMarketing.Controllers.Features.Dashboard
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DashboardController(IMediator mediator) => _mediator = mediator;

        [HttpGet("workout-plan")]
        public async Task<IActionResult> GetWorkoutPlan() => await Task.FromResult(Ok(_mediator.Send(new GetWorkOutPlan.Query())));
    }
}
