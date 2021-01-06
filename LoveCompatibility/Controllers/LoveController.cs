using System;
using System.Threading.Tasks;
using LoveCompatibility.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoveCompatibility.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoveController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetCompatibility(string nameOne, string nameTwo, CalculationModes mode)
        {
            try
            {
                return Ok(LoveUtils.GetPercentage(nameOne.ToLower(), nameTwo.ToLower(), mode));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting a compatibility score");
            }
        }
    }
}