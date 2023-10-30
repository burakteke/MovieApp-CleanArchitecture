using Movie.Application.Interfaces;
using Movie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private List<MovieDomain> movies = new List<MovieDomain>()
        {
            new MovieDomain() { Id = 1, Name = "Pardon", Cost = 120  },
            new MovieDomain() { Id = 2, Name = "Gora", Cost = 110  }
        };
        public List<MovieDomain> GetAllMovies()
        {
            return movies;
        }
    }
}
