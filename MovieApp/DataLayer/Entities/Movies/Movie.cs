using DataLayer.Entities.Actors;
using DataLayer.Entities.Directors;
using DataLayer.Entities.Genres;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public Director Director { get; set; }
        public int DirectorId { get; set; }
    }
}
