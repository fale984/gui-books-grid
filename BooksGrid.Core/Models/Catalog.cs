using System.Collections.Generic;
using System.Linq;

namespace BooksGrid.Core.Models
{
    /// <summary>
    /// Stores information to display the book collection
    /// </summary>
    public class Catalog
    {
        private List<Book> books;

        public List<Book> Books
        {
            get { return books; }
            set
            {
                books = value;
                UpdateCatalog();
            }
        }

        public List<string> Bindings { get; private set; }

        public double MinimumPrice { get; private set; }

        public double MaximumPrice { get; private set; }

        public List<Book> GetBooksInStock()
        {
            if (books == null)
            {
                return null;
            }

            return books.Where(x => x.InStock).ToList();
        }

        public void RemoveBooksOutOfStock()
        {
            books = GetBooksInStock();
            UpdateCatalog();
        }

        private void UpdateCatalog()
        {
            if (books == null)
            {
                Bindings = null;
                MinimumPrice = 0;
                MaximumPrice = 0;
            }
            else
            {
                Bindings = books.Select(x => x.Binding).Distinct().ToList();
                MinimumPrice = books.Count > 0 ? books.Min(x => x.Price) : 0;
                MaximumPrice = books.Count > 0 ? books.Max(x => x.Price) : 0;
            }
        }
    }
}
