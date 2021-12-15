using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorViewModelListBuilder actorViewModelListBuilder;

        public ActorsController(IActorViewModelListBuilder actorViewModelListBuilder)
        {
            this.actorViewModelListBuilder = actorViewModelListBuilder;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 5, string name = "")
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            return View(actorViewModelListBuilder.Build(pageNumber, pageSize, name));
        }
    }
}
