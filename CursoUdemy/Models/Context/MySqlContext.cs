﻿using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.Models.Context
{
    public class MySqlContext : DbContext
    {
        protected MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
