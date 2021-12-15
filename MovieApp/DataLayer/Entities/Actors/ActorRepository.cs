using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities.Actors
{
    public class ActorRepository : IActorRepository
    {
        private readonly ApplicationContext context;

        public ActorRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public List<Actor> GetAll()
        {
            return context.Actors.ToList();
        }

        public List<string> GetMovieNamesById(int id)
        {
            var actorMovieRelations = context.ActorMovieRelations;
            var movies = context.Movies;
            var movieNames = new List<string>();

            if(actorMovieRelations.Count() != 0 && movies.Count() != 0)
            {
                var movieIds = actorMovieRelations.Where(x => x.ActorId == id).Select(x => x.MovieId).ToList();

                foreach(var movieId in movieIds)
                {
                    var movie = movies.FirstOrDefault(x => x.Id == movieId);
                    movieNames.Add(movie?.Name);
                }
            }

            return movieNames;
        }

        public List<Actor> GetByName(string name)
        {
            return context.Actors.ToList().Where(x => x.Name.ToLower().Contains(name.ToLower())
                || x.LastName.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Actor> GetByMovieId(int movieId)
        {
            var actorMovieRelations = context.ActorMovieRelations.ToList();
            var actorsData = context.Actors;
            var actors = new List<Actor>();

            if (actorMovieRelations.Count() != 0 && actorsData.Count() != 0)
            {
                var actorIds = actorMovieRelations.Where(x => x.MovieId == movieId).Select(x => x.ActorId).ToList();

                foreach (var actorId in actorIds)
                {
                    var actor = actorsData.FirstOrDefault(x => x.Id == actorId);
                    actors.Add(actor);
                }
            }

            return actors;
        }
    }
}
