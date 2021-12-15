using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Movies
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        List<Movie> GetByName(string name);
    }
}
