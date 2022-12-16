using E2AFlix.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E2AFlix.Infra.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Filmes> Filme { get; set; }
        public DbSet<Musicas> Musica { get; set; }

    }
}

