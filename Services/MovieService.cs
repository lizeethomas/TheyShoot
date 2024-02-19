using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheyShoot.Models;

namespace TheyShoot.Services
{
    public class MovieService
    {
        private string _filePath = "C:/Users/tlizee/CODE/C#_12/TheyShoot/Data/theyshootpictures.csv";
        private List<Movie> movies;
        private List<Func<Movie, bool>> predicates;

        public MovieService()
        {
            movies = new CSVService<Movie>().Read(_filePath);
            predicates = new List<Func<Movie, bool>> { m => true };
        }
        public List<Movie> GetMovies()
        {
            return movies.Where(m => predicates.All(predicate => predicate(m))).ToList();
        }

        public void AddPredicate(Func<Movie, bool> additionalPredicate)
        {
            predicates.Add(additionalPredicate);
        }

        public void RemovePredicate(Func<Movie, bool> predicateToRemove)
        {
            predicates.Remove(predicateToRemove);
        }

        public void ResetPredicate()
        {
            predicates.Clear();
        }
    }
}