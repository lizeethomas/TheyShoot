
using TheyShoot.Models;
using TheyShoot.Services;


string data = "C:\\Users\\tlizee\\CODE\\C#_12\\TheyShoot\\Data\\theyshootpictures.csv";
List<Movie> movies = new CSVService<Movie>().Read(data);


var moviesFromCountry = movies.Where(m => m.Country == "Philippines").ToList();
//moviesFromCountry.ForEach(m => Console.WriteLine(m.Title));

var countries = movies.Select(m => m.Country).Distinct().ToList();

var moviesByCountry = movies.GroupBy(m => m.Country)
                                .Select(g => new { Country = g.Key, Count = g.Count() })
                                .ToList();
//moviesByCountry.OrderByDescending(c => c.Count).ToList().ForEach(c => Console.WriteLine($"{c.Country}: {c.Count}"));

var topDirectors = movies.GroupBy(m => m.Director).ToList()
                            .Select(g => new { Director = g.Key, Count = g.Count() })
                            .OrderByDescending(d => d.Count)
                            .Take(10)
                            .ToList();
//topDirectors.ForEach(Console.WriteLine);

var moviesFromDirector = movies.Where(m => m.Director.Contains("Hitchcock")).ToList();
//moviesFromDirector.ForEach(m => {Console.WriteLine(m.Title);});