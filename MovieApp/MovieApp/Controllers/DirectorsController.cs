using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly IDirectorViewModelListBuilder directorViewModelListBuilder;

        public DirectorsController(IDirectorViewModelListBuilder directorViewModelListBuilder)
        {
            this.directorViewModelListBuilder = directorViewModelListBuilder;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 5, string name = "")
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            return View(directorViewModelListBuilder.Build(pageNumber, pageSize, name));
        }
    }
}
