using MovieApp.Models.Filters;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Actors
{
    public class ActorViewModelList
    {
        public List<ActorViewModelItem> Actors { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public int ActorsCount { get; set; }
    }
}
