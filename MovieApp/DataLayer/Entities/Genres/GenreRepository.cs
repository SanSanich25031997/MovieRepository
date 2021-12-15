using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities.Genres
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationContext context;

        public GenreRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public List<Genre> GetAll()
        {
            return context.Genres.ToList();
        }

        public List<Genre> GetByName(string name)
        {
            return context.Genres.ToList().Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList(); ;
        }

        public List<Genre> GetByMovieId(int movieId)
        {
            var movieGenreRelations = context.MovieGenreRelations.ToList();
            var genresData = context.Genres;
            var genres = new List<Genre>();

            if (movieGenreRelations.Count() != 0 && genresData.Count() != 0)
            {
                var genreIds = movieGenreRelations.Where(x => x.MovieId == movieId).Select(x => x.GenreId).ToList();

                foreach (var genreId in genreIds)
                {
                    var genre = genresData.FirstOrDefault(x => x.Id == genreId);
                    genres.Add(genre);
                }
            }

            return genres;
        }
    }
}
