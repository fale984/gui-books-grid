using BooksGrid.App.Resources;
using BooksGrid.App.Utilities;
using BooksGrid.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksGrid.App
{
    public partial class bookCatalogForm : Form
    {
        private Color highLightColor;

        private IGradientGenerator gradientGenerator;

        private double minPrice;

        private double maxPrice;

        public List<Book> Books { get; set; }

        public List<string> Bindings { get; set; }

        public bookCatalogForm()
        {
            InitializeComponent();
            loadResources();
            loadBooks();

            bookBindingColumn.DataSource = Bindings;

            booksDataGridView.AutoGenerateColumns = false;
            booksDataGridView.DataSource = Books;
        }

        private void loadResources()
        {
            highLightColor = ColorTranslator.FromHtml(StyleResources.HighlightColor);
            gradientGenerator = new RgbGradientGenerator();
        }

        private void loadBooks()
        {
            Books = new List<Book>
            {
                new Book { Title="Book 1", Author="Author 1", Year=1990, Price=22.5, InStock=true, Binding="Paperback", Description="Long description 1" },
                new Book { Title="Book 2", Author="Author 2", Year=1975, Price=9.99, InStock=false, Binding="Hardcover", Description="Long description 2" }
            };

            Bindings = Books.Select(x => x.Binding).Distinct().ToList();

            minPrice = Books.Min(x => x.Price);
            maxPrice = Books.Max(x => x.Price);
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verify the button is for the description
            if (booksDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex != -1)
            {
                MessageBox.Show(Books[e.RowIndex].Description, "Description");
            }
        }

        private void booksDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var rowBook = Books[e.RowIndex];
            // If the book is out of stock highlight the row
            if (!rowBook.InStock)
            {
                booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = highLightColor;
            }

            // The price font color changes according to the value
            booksDataGridView.Rows[e.RowIndex].Cells[bookPriceColumn.Name].Style.ForeColor =
                gradientGenerator.GetColorForValueInRange(rowBook.Price, minPrice, maxPrice);
        }
    }
}
