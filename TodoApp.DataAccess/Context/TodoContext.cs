using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataAccess.Configurations;
using TodoApp.Entities.Domains;

namespace TodoApp.DataAccess.Context
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
        }

        public DbSet<Work> Works { get; set; }
    }
}
