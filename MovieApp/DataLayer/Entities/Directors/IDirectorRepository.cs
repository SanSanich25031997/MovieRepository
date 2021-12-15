using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Directors
{
    public interface IDirectorRepository
    {
        List<Director> GetAll();
        List<string> GetMovieNamesById(int id);
        List<Director> GetByName(string name);
        Director GetById(int id);
    }
}
