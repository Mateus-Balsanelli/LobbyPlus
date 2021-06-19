using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }

        public DbSet<Game> games { get; set; }

        public DbSet<Page> pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.UserName)
                    .HasMaxLength(80);

            modelBuilder.Entity<User>()
                .HasData(
                new User { UserId = 1, UserName = "Mateus", Password = "teste", Registered = DateTime.Now, Admin = true , Email = "teste@teste", GenrePreferred = "FPS"},
                new User { UserId = 2, UserName = "teste", Password = "teste", Registered = DateTime.Now, Admin = true , Email = "teste@teste", GenrePreferred = "FPS"},
                new User { UserId = 3, UserName = "alner", Password = "teste", Registered = DateTime.Now, Admin = true , Email = "teste@teste", GenrePreferred = "FPS"}
                );
        }
    }
}
