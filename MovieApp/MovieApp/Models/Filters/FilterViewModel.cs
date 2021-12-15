using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Filters
{
    public class FilterViewModel
    {
        public string EnteredName { get; set; }

        public FilterViewModel(string enteredName)
        {
            EnteredName = enteredName;
        }
    }
}
