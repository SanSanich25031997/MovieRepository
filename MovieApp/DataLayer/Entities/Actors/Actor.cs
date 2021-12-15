using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Actors
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
    }
}
