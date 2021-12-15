using MovieApp.Models.Pages;
using MovieApp.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class MovieViewModelList
    {
        public List<MovieViewModelItem> Movies { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public int MoviesCount { get; set; }
    }
}
