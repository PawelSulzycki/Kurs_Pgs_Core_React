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

        [HttpPost]
        public IActionResult AddNumber([FromBody]int number)
        {
            _randomGeneratorService.AddNumberToList(number);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteNumber(int number)
        {
            _randomGeneratorService.DeleteNumber(number);
            return NoContent();
        }

        [HttpGet]
        [Route("AllNumbers")]
        public IActionResult GetAllNumbers()
        {
            return Ok(_randomGeneratorService.GetAllNumbers());
        }
    }
}
