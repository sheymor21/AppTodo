using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class NotasContext : DbContext
    {
        public DbSet<Notas> notes { get; set; }

        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Notas.db");
    }

    public class Notas
    {
        public int NotasId { get; set; }
        public DateTime fecha{get;set;}
        public string Contenido { get; set; }
        public bool completada { get; set; }

    }
}
