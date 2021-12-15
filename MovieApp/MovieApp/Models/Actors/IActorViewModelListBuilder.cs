using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Actors
{
    public interface IActorViewModelListBuilder
    {
        ActorViewModelList Build(int pageNumber, int pageSize, string name);
    }
}
