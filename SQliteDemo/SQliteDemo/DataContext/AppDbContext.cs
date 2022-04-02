using Microsoft.EntityFrameworkCore;
using SQliteDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQliteDemo.DataContext
{
    public class AppDbContext : DbContext
    {

        string DbPath = string.Empty;

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }


        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albumes { get; set; }

        public DbSet<Cancion> Canciones { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");

        }

    }
}
