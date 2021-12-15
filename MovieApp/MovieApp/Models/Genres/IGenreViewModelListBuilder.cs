using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Genres
{
    public interface IGenreViewModelListBuilder
    {
        GenreViewModelList Build(int pageNumber, int pageSize, string name);
    }
}
