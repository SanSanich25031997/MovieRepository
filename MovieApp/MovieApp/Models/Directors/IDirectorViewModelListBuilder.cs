using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Directors
{
    public interface IDirectorViewModelListBuilder
    {
        DirectorViewModelList Build(int pageNumber, int pageSize, string name);
    }
}
