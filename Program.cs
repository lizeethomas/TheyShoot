
using System.Linq.Expressions;
using TheyShoot.Models;
using TheyShoot.Services;

Func<Movie, bool> directorPredicate = m => true;


var movieService = new MovieService();

var selectedMovies = new List<Movie>();

directorPredicate = m => m.Director.Contains("Scorsese");
movieService.AddPredicate(directorPredicate);

Func<Movie, bool> predicate = m => m.Date >= 1990;
movieService.AddPredicate(predicate);
//movieService.RemovePredicate(predicate);

selectedMovies = movieService.GetMovies();
selectedMovies.ForEach(m => Console.WriteLine(m.Title));





//var moviesFromCountry = movies.Where(m => m.Country == "Italy").ToList();
//moviesFromCountry.ForEach(m => Console.WriteLine(m.Title));

//var countries = movies.Select(m => m.Country).Distinct().ToList();

//var moviesByCountry = movies.GroupBy(m => m.Country)
//                                .Select(g => new { Country = g.Key, Count = g.Count() })
//                                .ToList();
//moviesByCountry.OrderByDescending(c => c.Count).ToList().ForEach(c => Console.WriteLine($"{c.Country}: {c.Count}"));

//var topDirectors = movies.GroupBy(m => m.Director).ToList()
//                            .Select(g => new { Director = g.Key, Count = g.Count() })
//                            .OrderByDescending(d => d.Count)
//                            .Take(10)
//                            .ToList();
//topDirectors.ForEach(Console.WriteLine);

//int start = 1890;
//for (int i = 0; i  < 14; i++)
//{
//    selectedMovies = movieService.GetMovies(m => m.Date >= start + i * 10 && m.Date < start + (i + 1) * 10);
//    int nb = selectedMovies.Count();
//    Console.WriteLine($"{start + i * 10}'s => " + nb);
//}
//Console.WriteLine($"DATE => {movies.Average(m => m.Date)}\nTIME => {movies.Average(m => m.Time)}");