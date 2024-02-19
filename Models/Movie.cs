using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheyShoot.Models
{
    public class Movie
    {
        [Name("RANK")]
        public string Rank { get; set; }

        [Name("OLD RANK")]
        public string OldRank { get; set; }

        [Name("TITLE")]
        public string Title { get; set; }

        [Name("DIRECTOR")]
        public string Director { get; set; }

        [Name("DATE")]
        public string Date { get; set; }

        [Name("COUNTRY")]
        public string Country { get; set; }

        [Name("TIME")]
        public int Time { get; set; }
    }
}
