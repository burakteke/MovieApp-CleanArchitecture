using Movie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Application.Interfaces
{
    public interface IMovieRepository
    {
        List<MovieDomain> GetAllMovies();
    }
}
