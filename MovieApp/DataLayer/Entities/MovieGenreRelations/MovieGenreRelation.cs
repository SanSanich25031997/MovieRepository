using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.MovieGenreRelations
{
    public class MovieGenreRelation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
