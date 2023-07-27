using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.Models;

namespace Movie.Data
{
    public class McMovieContext : DbContext
    {
        public McMovieContext (DbContextOptions<McMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie.Models.Movie> Movie { get; set; } = default!;
    }
}
