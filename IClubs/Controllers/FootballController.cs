using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        /// <summary>
        /// PlayIngFootball
        /// </summary>
        /// <returns></returns>
        [HttpPost("play_football")]
        public async Task<IActionResult> PlayIngFootball()
        {
            var result = await Task.FromResult<string>("Playing Football1");
            return Ok(result);
        
        }



        /// <summary>
        /// passing Football
        /// </summary>
        /// <returns></returns>
        [HttpPost("passing_football")]
        public async Task<IActionResult> passingFootball()
        {
            var result = await Task.FromResult<string>("passing Football1");
            return Ok(result);

        }


        /// <summary>
        /// "Goal Keeper Catching The Ball
        /// </summary>
        /// <returns></returns>
        [HttpPost("goal_keeper_catching_ball")]
        public async Task<IActionResult> CatchingBall()
        {
            var result = await Task.FromResult<string>("Goal Keeper Catching The Ball2");
            return Ok(result);

        }
    }
}
