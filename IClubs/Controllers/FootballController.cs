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
            var result = await Task.FromResult<string>("Playing Football");
            return Ok(result);
        
        }



        /// <summary>
        /// passing Football
        /// </summary>
        /// <returns></returns>
        [HttpPost("passing_football")]
        public async Task<IActionResult> passingFootball()
        {
            var result = await Task.FromResult<string>("passing Football");
            return Ok(result);

        }

        /// <summary>
        /// "Goal Keeper Catching The Ball
        /// </summary>
        /// <returns></returns>
        [HttpPost("goal_keeper_catching_ball")]
        public async Task<IActionResult> CatchingBall()
        {
            var result = await Task.FromResult<string>("Goal Keeper Catching The Ball");
            return Ok(result);

        }


        /// <summary>
        /// player run with ball
        /// </summary>
        /// <returns></returns>
        [HttpPost("player_run_with_ball")]
        public async Task<IActionResult> RunWithBall()
        {
            var result = await Task.FromResult<string>("player run with ball");
            return Ok(result);

        }



        /// <summary>
        /// player hit ball
        /// </summary>
        /// <returns></returns>
        [HttpPost("player_hit_ball")]
        public async Task<IActionResult> hitBall()
        {
            var result = await Task.FromResult<string>("yhe player hits ball");
            return Ok(result);

        }

    }
}
