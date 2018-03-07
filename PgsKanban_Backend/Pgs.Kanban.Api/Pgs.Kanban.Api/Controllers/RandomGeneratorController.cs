using Microsoft.AspNetCore.Mvc;
using Pgs.Kanban.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pgs.Kanban.Api.Controllers
{
    [Route("api/[controller]")]
    public class RandomGeneratorController : Controller
    {
        private RandomGeneratorService _randomGeneratorService;

        public RandomGeneratorController()
        {
            _randomGeneratorService = new RandomGeneratorService();
        }

        [HttpGet]
        //[Route("[action]")]
        public IActionResult GetRandomNumber()
        {
            return Ok(_randomGeneratorService.GenerateRandomNumber());
        }

        [HttpGet]
        [Route("{maxValue}")]
        public IActionResult GetRandomNumberInRange(int maxValue)
        {
            return Ok(_randomGeneratorService.GenerateRandomNumber(maxValue));
        }
    }
}
