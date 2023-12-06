using Hangfire;
using HangfireSampleProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace HangfireSampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangfireController : ControllerBase
    {

        [HttpGet("RecurringJobPlan")]
        public async Task<IActionResult> RecurringJobPlan()
        {
            RecurringJob.AddOrUpdate<IEmailService>(
                            nameof(IEmailService),
                            job => job.Send(),
                            Cron.Daily);

            return Ok();
        }
    }
}
