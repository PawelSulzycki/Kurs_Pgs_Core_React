using Microsoft.EntityFrameworkCore;
using Pgs.Kanban.Domain.Dtos;
using Pgs.Kanban.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class BoardService
    {
        private readonly KanbanContext _context;

        public BoardService()
        {
            _context = new KanbanContext();
        }

        public BoardDto GetBoard()
        {
            var board = _context.Boards
                .Include(b => b.Lists)
                .LastOrDefault();

            //singleOrDefault wyrzuci wyjatek jak jest wiecej niz jeden, stosuje sie do id

            if (board == null)
            {
                return null;
            }

            //auto maper

            var boardDto = new BoardDto()
            {
                Id = board.Id,
                Name = board.Name,
                Lists = board.Lists.Select(l => new ListDto()
                {
                    Id = l.Id,
                    Name = l.Name,
                    BoardId = l.BoardId
                }).ToList()
            };

            return boardDto;
        }

        public BoardDto CreateBoard(CreateBoardDto createBoardDto)
        {
            var board = new Board()
            {
                Name = createBoardDto.Name
            };

            _context.Boards.Add(board);
            _context.SaveChanges();

            var boardDto = new BoardDto()
            {
                Id = board.Id,
                Name = board.Name
            };

            return boardDto;
        }
    }
}
