using Microsoft.AspNetCore.Mvc;
using Pgs.Kanban.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pgs.Kanban.Api.Controllers
{
    [Route("api/[controller]")]

    public class NumberController : Controller
    {
        private NumberService _numberService;

        public NumberController()
        {
            _numberService = new NumberService();
        }

        [HttpPost]
        public IActionResult AddNumber([FromBody]int number)
        {
            _numberService.AddNumberToList(number);
            return NoContent();
        }

        [HttpDelete]
        [Route("{number}")]
        public IActionResult DeleteNumber(int number)
        {
            _numberService.DeleteNumber(number);
            return NoContent();
        }

        [HttpGet]
        [Route("AllNumbers")]
        public IActionResult GetAllNumbers()
        {
            return Ok(_numberService.GetAllNumbers());
        }
    }
}
