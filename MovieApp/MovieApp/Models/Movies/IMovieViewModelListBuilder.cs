using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public interface IMovieViewModelListBuilder
    {
        MovieViewModelList Build(int pageNumber, int pageSize, string name);
    }
}
