using BooksGrid.Core.Models;
using System;
using System.IO;
using System.Linq;

namespace BooksGrid.Core.Managers
{
    /// <summary>
    /// Reads a catalog from a CSV file
    /// </summary>
    public class CsvCatalogReader : ICatalogReader
    {
        const string yesString = "yes";
        const char fieldSeparator = ';';

        ///<inheritdoc cref="ICatalogReader"/>
        public Catalog ReadCatalog(string source)
        {
            var books = File.ReadAllLines(source)
                .Skip(1)
                .Select(x => ParseBookRow(x))
                .Where(x => x != null);

            var catalog = new Catalog();
            catalog.Books = books.ToList();

            return catalog;
        }

        /// <summary>
        /// Converts line with fields to Book
        /// </summary>
        /// <param name="line">Book row</param>
        /// <returns>Parsed book or null if error</returns>
        public Book ParseBookRow(string line)
        {
            try
            {
                var fields = line.Split(fieldSeparator);

                var book = new Book
                {
                    Title = fields[0],
                    Author = fields[1],
                    Year = Convert.ToInt32(fields[2]),
                    Price = Convert.ToDouble(fields[3].Replace(',','.')), // Prices are stored with comma decimal
                    InStock = yesString.Equals(fields[4], StringComparison.InvariantCultureIgnoreCase),
                    Binding = fields[5],
                    Description = fields[6]
                };

                return book;
            }
            catch (Exception)
            {
                // not a valid book
                return null;
            }

        }
    }
}
