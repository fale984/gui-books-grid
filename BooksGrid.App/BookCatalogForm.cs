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

        public bookCatalogForm()
        {
            InitializeComponent();
            LoadBooks();

            booksDataGridView.DataSource = Books;
        }

        private void LoadBooks()
        {
            Books = new List<Book>
            {
                new Book { }
            };
        }
    }
}
