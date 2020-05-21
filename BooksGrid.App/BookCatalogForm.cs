using BooksGrid.App.Resources;
using BooksGrid.App.Utilities;
using BooksGrid.Core.Managers;
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
        private ICatalogReader catalogReader;
        private Catalog catalog;

        public bookCatalogForm()
        {
            InitializeComponent();
            loadResources();

            catalogReader = new CsvCatalogReader();
            booksDataGridView.AutoGenerateColumns = false;
        }

        private void loadResources()
        {
            highLightColor = ColorTranslator.FromHtml(StyleResources.HighlightColor);
            gradientGenerator = new RgbGradientGenerator();
        }

        private void loadBooks()
        {
            try
            {
                catalog = catalogReader.ReadCatalog(openBooksFileDialog.FileName);

                bookBindingColumn.DataSource = catalog.Bindings;
                booksDataGridView.DataSource = catalog.Books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred reading the file, " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verify the button is for the description
            if (booksDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex != -1)
            {
                MessageBox.Show(catalog.Books[e.RowIndex].Description, "Description");
            }
        }

        private void booksDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var rowBook = catalog.Books[e.RowIndex];
            // If the book is out of stock highlight the row
            if (!rowBook.InStock)
            {
                booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = highLightColor;
            }

            // The price font color changes according to the value
            booksDataGridView.Rows[e.RowIndex].Cells[bookPriceColumn.Name].Style.ForeColor =
                gradientGenerator.GetColorForValueInRange(rowBook.Price, catalog.MinimumPrice, catalog.MaximumPrice);
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openBooksFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = openBooksFileDialog.FileName;
                loadBooks();
            }
        }
    }
}
