using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Actors
{
    public interface IActorRepository
    {
        List<Actor> GetAll();
        List<string> GetMovieNamesById(int id);
        List<Actor> GetByName(string name);
        List<Actor> GetByMovieId(int movieId);
    }
}
