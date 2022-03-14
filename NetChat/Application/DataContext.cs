using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>().HasData(
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "DotNetCore",
                    Description = "Canal dedidaco a dot net"
                },
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "Minecraft",
                    Description = "Canal dedidaco a Minecraft"
                },
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "React Js",
                    Description = "Canal dedidaco a React Js"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
