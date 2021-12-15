using DataLayer.Entities.Actors;
using DataLayer.Entities.Directors;
using DataLayer.Entities.Genres;
using DataLayer.Entities.Movies;
using MovieApp.Models.Filters;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Movies
{
    public class MovieViewModelListBuilder : IMovieViewModelListBuilder
    {
        private readonly IMovieRepository movieRepository;
        private readonly IActorRepository actorRepository;
        private readonly IDirectorRepository directorRepository;
        private readonly IGenreRepository genreRepository;

        public MovieViewModelListBuilder(IMovieRepository movieRepository, IActorRepository actorRepository,
            IDirectorRepository directorRepository, IGenreRepository genreRepository)
        {
            this.movieRepository = movieRepository;
            this.actorRepository = actorRepository;
            this.directorRepository = directorRepository;
            this.genreRepository = genreRepository;
        }

        public MovieViewModelList Build(int pageNumber, int pageSize, string name)
        {
            var movies = new List<Movie>();

            if(!string.IsNullOrEmpty(name))
            {
                movies = movieRepository.GetByName(name);
            }
            else
            {
                movies = movieRepository.GetAll();
            }

            var count = movies.Count;
            var items = new List<MovieViewModelItem>();
            var outputMovies = movies.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            foreach(var movie in outputMovies)
            {
                var director = directorRepository.GetById(movie.DirectorId);
                var actorsList = actorRepository.GetByMovieId(movie.Id);
                var genresList = genreRepository.GetByMovieId(movie.Id);
                var actors = "";
                var genres = "";
                
                for(int i = 0; i < actorsList.Count; i++)
                {
                    if (i == actorsList.Count - 1)
                    {
                        actors += $"{actorsList[i]?.Name + " " + actorsList[i]?.LastName}";
                    }
                    else
                    {
                        actors += $"{actorsList[i]?.Name + " " + actorsList[i]?.LastName}, ";
                    }
                }

                for(int i = 0; i < genresList.Count; i++)
                {
                    if(i == genresList.Count - 1)
                    {
                        genres += $"{genresList[i]?.Name}";
                    }
                    else
                    {
                        genres += $"{genresList[i]?.Name}, ";
                    }
                }

                items.Add(new MovieViewModelItem
                {
                    Name = movie.Name,
                    Year = movie.Year,
                    Country = movie.Country,
                    Description = movie.Description,
                    Url = movie.Url,
                    ImageUrl = movie.ImageUrl,
                    Director = director?.Name + " " + director?.LastName,
                    Actors = actors,
                    Genres = genres
                });
            }

            var viewModel = new MovieViewModelList
            {
                Movies = items,
                PageViewModel = new PageViewModel(count, pageNumber, pageSize),
                FilterViewModel = new FilterViewModel(name),
                MoviesCount = count
            };

            return viewModel;
        }
    }
}
