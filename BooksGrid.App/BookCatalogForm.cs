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
        public List<Book> Books { get; set; }

        public List<string> Bindings { get; set; }

        public bookCatalogForm()
        {
            InitializeComponent();
            LoadBooks();

            bookBindingColumn.DataSource = Bindings;

            booksDataGridView.AutoGenerateColumns = false;
            booksDataGridView.DataSource = Books;
        }

        private void LoadBooks()
        {
            Books = new List<Book>
            {
                new Book { Title="Book 1", Author="Author 1", Year=1990, Price=22.5, InStock=true, Binding="Paperback", Description="Long description 1" },
                new Book { Title="Book 2", Author="Author 2", Year=1975, Price=9.99, InStock=false, Binding="Hardcover", Description="Long description 2" }
            };

            Bindings = Books.Select(x => x.Binding).Distinct().ToList();
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verify the button is for the description
            if (booksDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex != -1)
            {
                var rowBook = Books[e.RowIndex];
                MessageBox.Show(rowBook.Description, "Description");
            }
        }
    }
}
