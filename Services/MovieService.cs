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
        private string _filePath = "C:\\Users\\tlizee\\CODE\\C#_12\\TheyShoot\\Data\\theyshootpictures.csv";
        public List<Movie> movies;

        public MovieService()
        {
            movies = new CSVService<Movie>().Read(_filePath);
        }

        public List<Movie> GetAll()
        {
            return movies;
        }

        public List<Movie> GetMovies(Func<Movie, bool> predicate)
        {
            return movies.Where(predicate).ToList();
        }

        public List<Movie> GetMoviesFromCountry(string country)
        {
            return movies.Where(m => m.Country == country).ToList();
        }

        public List<Movie> GetMoviesFromDirector(string director)
        {
            return movies.Where(m => m.Director.Contains(director)).ToList();
        }
    }
}
