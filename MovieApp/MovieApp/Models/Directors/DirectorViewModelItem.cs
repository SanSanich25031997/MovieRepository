using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Directors
{
    public class DirectorViewModelItem
    {
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Movies { get; set; }
    }
}
