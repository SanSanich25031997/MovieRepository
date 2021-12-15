using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationContext context;

        public MovieRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public List<Movie> GetAll()
        {
            var movies = context.Movies;
            return movies.Count() == 0 ? new List<Movie>() : movies.ToList();
        }

        public List<Movie> GetByName(string name)
        {
            return context.Movies.ToList().Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList(); ;
        }
    }
}
