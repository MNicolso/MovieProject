using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieProject.Models;

namespace MovieProject.Data
{
    public class MovieProjectContext : DbContext
    {
        public MovieProjectContext(DbContextOptions<MovieProjectContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}
