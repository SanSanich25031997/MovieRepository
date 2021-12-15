using DataLayer.Entities.ActorMovieRelations;
using DataLayer.Entities.Actors;
using DataLayer.Entities.Directors;
using DataLayer.Entities.Genres;
using DataLayer.Entities.MovieGenreRelations;
using DataLayer.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ActorMovieRelation> ActorMovieRelations { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenreRelation> MovieGenreRelations { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
