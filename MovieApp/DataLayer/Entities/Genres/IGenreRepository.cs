using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Genres
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();
        List<Genre> GetByName(string name);
        List<Genre> GetByMovieId(int movieId);
    }
}
