using Microsoft.AspNetCore.Mvc;
using Pgs.Kanban.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pgs.Kanban.Api.Controllers
{
    [Route("api/[controller]")]
    public class BoardController : Controller
    {
        private readonly BoardService _boardService;

        public BoardController()
        {
            _boardService = new BoardService();
        }

        [HttpGet]
        public IActionResult GetBoard()
        {
            var response = _boardService.GetBoard();

            if(response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
