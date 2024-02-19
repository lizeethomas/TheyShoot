using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheyShoot.Services
{
    public class CSVService<T>
    {
        public List<T> Read(string filePath)
        {
            List<T> records;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<T>().ToList();
            }

            return records;
        }
    }
}
