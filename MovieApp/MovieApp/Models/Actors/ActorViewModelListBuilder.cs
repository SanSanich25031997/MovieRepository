using DataLayer.Entities.Actors;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Actors
{
    public class ActorViewModelListBuilder : IActorViewModelListBuilder
    {
        private readonly IActorRepository actorRepository;

        public ActorViewModelListBuilder(IActorRepository actorRepository)
        {
            this.actorRepository = actorRepository;
        }

        public ActorViewModelList Build(int pageNumber, int pageSize, string name)
        {
            var actors = new List<Actor>();

            if(!string.IsNullOrEmpty(name))
            {
                actors = actorRepository.GetByName(name);
            }
            else
            {
                actors = actorRepository.GetAll();
            }          

            var count = actors.Count;
            var items = new List<ActorViewModelItem>();
            var outputActors = actors.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            foreach(var actor in outputActors)
            {
                var moviesList = actorRepository.GetMovieNamesById(actor.Id);
                var movies = "";

                for(int i = 0; i < moviesList.Count; i++)
                {
                    if(i == moviesList.Count - 1)
                    {
                        movies += $"{moviesList[i]}";
                    }
                    else
                    {
                        movies += $"{moviesList[i]}, ";
                    }
                }

                items.Add(new ActorViewModelItem
                { 
                    FullName = actor.Name + " " + actor.LastName,
                    ImageUrl = actor.ImageUrl,
                    Country = actor.Country,
                    Age = (int)(DateTime.Now.Subtract(actor.BirthDate).TotalDays / 365.25),
                    Description = actor.Description,
                    Movies = movies
                });
            }

            var viewModel = new ActorViewModelList
            {
                Actors = items,
                PageViewModel = new PageViewModel(count, pageNumber, pageSize),
                FilterViewModel = new Filters.FilterViewModel(name),
                ActorsCount = count
            };

            return viewModel;
        }
    }
}
