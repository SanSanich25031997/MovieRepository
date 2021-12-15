using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Entities.Directors
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ApplicationContext context;

        public DirectorRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public List<Director> GetAll()
        {
            return context.Directors.ToList();
        }

        public List<string> GetMovieNamesById(int id)
        {
            return context.Movies.Where(x => x.DirectorId == id).Select(x => x.Name).ToList();
        }

        public List<Director> GetByName(string name)
        {
            return context.Directors.ToList().Where(x => x.Name.ToLower().Contains(name.ToLower())
                || x.LastName.ToLower().Contains(name.ToLower())).ToList(); ;
        }

        public Director GetById(int id)
        {
            return context.Directors.FirstOrDefault(x => x.Id == id);
        }
    }
}
