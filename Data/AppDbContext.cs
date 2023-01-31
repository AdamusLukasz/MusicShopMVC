using Microsoft.EntityFrameworkCore;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(a => new
            {
                a.ActorId,
                a.MovieId
            });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(f => f.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(f => f.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Actor_Movie>? Actors_Movies { get; set; }
        public DbSet<Cinema>? Cinemas { get; set; }
        public DbSet<Producer>? Producers { get; set; }
    }
}
