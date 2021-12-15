using DataLayer.Entities.Genres;
using MovieApp.Models.Filters;
using MovieApp.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Genres
{
    public class GenreViewModelListBuilder : IGenreViewModelListBuilder
    {
        private readonly IGenreRepository genreRepository;

        public GenreViewModelListBuilder(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public GenreViewModelList Build(int pageNumber, int pageSize, string name)
        {
            var genres = new List<Genre>();

            if(!string.IsNullOrEmpty(name))
            {
                genres = genreRepository.GetByName(name);
            }
            else
            {
                genres = genreRepository.GetAll();
            }

            var count = genres.Count;
            var items = new List<GenreViewModelItem>();
            var outputGenres = genres.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            foreach(var genre in outputGenres)
            {
                items.Add(new GenreViewModelItem
                {
                    Name = genre.Name,
                    Description = genre.Description
                });
            }

            var viewModel = new GenreViewModelList
            {
                Genres = items,
                PageViewModel = new PageViewModel(count, pageNumber, pageSize),
                FilterViewModel = new FilterViewModel(name),
                GenresCount = count
            };

            return viewModel;
        }
    }
}
