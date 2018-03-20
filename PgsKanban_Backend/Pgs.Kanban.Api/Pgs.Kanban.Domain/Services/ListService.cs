using Pgs.Kanban.Domain.Dtos;
using Pgs.Kanban.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class ListService
    {
        private readonly KanbanContext _context;

        public ListService()
        {
            _context = new KanbanContext();
        }

        public ListDto AddList(AddListDto addListDto)
        {
            if(!_context.Boards.Any(x=>x.Id == addListDto.BoardId))
            {
                return null;
            }

            var list = new List()
            {
                Name = addListDto.Name,
                BoardId = addListDto.BoardId
            };

            _context.Lists.Add(list);
            _context.SaveChanges();

            var listDto = new ListDto()
            {
                Id = list.Id,
                Name = list.Name,
                BoardId = list.BoardId
            };

            return listDto;
        }
    }
}
