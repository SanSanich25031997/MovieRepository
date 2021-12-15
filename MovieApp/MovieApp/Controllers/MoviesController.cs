using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieViewModelListBuilder movieViewModelListBuilder;

        public MoviesController(IMovieViewModelListBuilder movieViewModelListBuilder)
        {
            this.movieViewModelListBuilder = movieViewModelListBuilder;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 5, string name = "")
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            return View(movieViewModelListBuilder.Build(pageNumber, pageSize, name));
        }

        public IActionResult Watch(string url, string imageUrl)
        {
            ViewBag.Url = url;
            ViewBag.ImageUrl = imageUrl;
            return View();
        }
    }
}
