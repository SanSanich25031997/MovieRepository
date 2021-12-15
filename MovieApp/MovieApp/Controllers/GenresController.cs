using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class GenresController : Controller
    {
        private readonly IGenreViewModelListBuilder genreViewModelListBuilder;

        public GenresController(IGenreViewModelListBuilder genreViewModelListBuilder)
        {
            this.genreViewModelListBuilder = genreViewModelListBuilder;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 5, string name = "")
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            return View(genreViewModelListBuilder.Build(pageNumber, pageSize, name));
        }
    }
}
