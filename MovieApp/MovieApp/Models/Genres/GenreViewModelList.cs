using MovieApp.Models.Filters;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Genres
{
    public class GenreViewModelList
    {
        public List<GenreViewModelItem> Genres { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public int GenresCount { get; set; }
    }
}
