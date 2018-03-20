using Microsoft.EntityFrameworkCore;
using Pgs.Kanban.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain
{
    public class KanbanContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PgsKanban;Trusted_Connection=True;");
        }

        //virtual tutaj tez mokowac baze danych tylko podczas testowania
        public DbSet<Board> Boards { get; set; }
        public DbSet<List> Lists { get; set; }
    }
}
