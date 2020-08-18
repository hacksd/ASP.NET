using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blogapp.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> BlogPost { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        
        
        }
    }
}
