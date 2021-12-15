using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.ActorMovieRelations
{
    public class ActorMovieRelation
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
    }
}
