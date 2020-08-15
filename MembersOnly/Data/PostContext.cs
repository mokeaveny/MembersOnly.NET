using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembersOnly.Models;
using Microsoft.EntityFrameworkCore;

namespace MembersOnly.Data
{
    public class PostContext : DbContext
    {
         public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Post");
        }
    }
}
