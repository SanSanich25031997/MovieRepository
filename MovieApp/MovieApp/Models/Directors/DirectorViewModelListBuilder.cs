using DataLayer.Entities.Directors;
using MovieApp.Models.Filters;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Directors
{
    public class DirectorViewModelListBuilder : IDirectorViewModelListBuilder
    {
        private readonly IDirectorRepository directorRepository;

        public DirectorViewModelListBuilder(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public DirectorViewModelList Build(int pageNumber, int pageSize, string name)
        {
            var directors = new List<Director>();

            if(!string.IsNullOrEmpty(name))
            {
                directors = directorRepository.GetByName(name);
            }
            else
            {
                directors = directorRepository.GetAll();
            }

            var count = directors.Count;
            var items = new List<DirectorViewModelItem>();
            var outputDirectors = directors.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            foreach(var director in outputDirectors)
            {
                var moviesList = directorRepository.GetMovieNamesById(director.Id);
                var movies = "";

                for (int i = 0; i < moviesList.Count; i++)
                {
                    if (i == moviesList.Count - 1)
                    {
                        movies += $"{moviesList[i]}";
                    }
                    else
                    {
                        movies += $"{moviesList[i]}, ";
                    }
                }

                items.Add(new DirectorViewModelItem
                { 
                    FullName = director.Name + " " + director.LastName,
                    ImageUrl = director.ImageUrl,
                    Country = director.Country,
                    Age = (int)(DateTime.Now.Subtract(director.BirthDate).TotalDays / 365.25),
                    Description = director.Description,
                    Movies = movies
                });
            }

            var viewModel = new DirectorViewModelList
            {
                Directors = items,
                PageViewModel = new PageViewModel(count, pageNumber, pageSize),
                FilterViewModel = new FilterViewModel(name),
                DirectorsCount = count
            };

            return viewModel;
        }
    }
}
