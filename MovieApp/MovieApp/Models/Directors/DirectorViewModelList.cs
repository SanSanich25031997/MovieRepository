using MovieApp.Models.Pages;
using MovieApp.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Directors
{
    public class DirectorViewModelList
    {
        public List<DirectorViewModelItem> Directors { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public int DirectorsCount { get; set; } 
    }
}
