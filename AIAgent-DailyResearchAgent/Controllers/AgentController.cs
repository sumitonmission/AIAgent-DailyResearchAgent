using AIAgent_DailyResearchAgent.Services;
using Microsoft.AspNetCore.Mvc;

namespace AIAgent_DailyResearchAgent.Controllers
{
    [ApiController]
    [Route("api/agent")]
    public class AgentController : ControllerBase
    {
        private readonly AgentService _agent;

        public AgentController(AgentService agent)
        {
            _agent = agent;
        }

        [HttpPost]
        public async Task<IActionResult> Run([FromBody] string goal)
        {
            var result = await _agent.RunAgent(goal);
            return Ok(result);
        }
    }
}
