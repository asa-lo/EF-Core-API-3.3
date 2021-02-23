using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class AlbumsContext : DbContext
    {
        public AlbumsContext(DbContextOptions<AlbumsContext> options) : base(options)
        {

        }
        public DbSet<Albums> Albums { get; set; }
    }
}
