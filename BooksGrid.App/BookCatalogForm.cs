using BooksGrid.App.Resources;
using BooksGrid.App.Utilities;
using BooksGrid.Core.Managers;
using BooksGrid.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BooksGrid.App
{
    public partial class BookCatalogForm : Form
    {
        private IGradientGenerator gradientGenerator;
        private ICatalogReader catalogReader;
        private Color highLightColor;
        private Catalog catalog;
        private List<Book> visibleBooks;
        private bool showingOutOfStock;

        public BookCatalogForm(IGradientGenerator gradientGenerator, ICatalogReader catalogReader)
        {
            this.gradientGenerator = gradientGenerator;
            this.catalogReader = catalogReader;

            InitializeComponent();

            booksDataGridView.AutoGenerateColumns = false;
            showingOutOfStock = true;
            highLightColor = ColorTranslator.FromHtml(StyleResources.HighlightColor);
        }

        // Handles clicks on grid
        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the click was to display the description
            if (booksDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex != -1)
            {
                MessageBox.Show(visibleBooks[e.RowIndex].Description, "Description");
            }

            // If the click was to change stock
            if (booksDataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn
                && e.RowIndex != -1)
            {
                var cell = booksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (!showingOutOfStock && cell != null && (bool)cell.Value == true)
                {
                    booksDataGridView.DataSource = null;
                    visibleBooks.RemoveAt(e.RowIndex);
                    booksDataGridView.DataSource = visibleBooks;
                }
            }
        }

        // Handles row paint
        private void booksDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var rowBook = visibleBooks[e.RowIndex];
            // If the book is out of stock highlight the row
            if (!rowBook.InStock)
            {
                booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = highLightColor;
            }
            else
            {
                booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }

            // The price font color changes according to the value
            booksDataGridView.Rows[e.RowIndex].Cells[bookPriceColumn.Name].Style.ForeColor =
                gradientGenerator.GetColorForValueInRange(rowBook.Price, catalog.MinimumPrice, catalog.MaximumPrice);
        }

        // Handles select file
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openBooksFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = openBooksFileDialog.FileName;
                loadBooks();
            }
        }

        // Loads selected file
        private void loadBooks()
        {
            try
            {
                catalog = catalogReader.ReadCatalog(openBooksFileDialog.FileName);
                visibleBooks = catalog.Books;
                bookBindingColumn.DataSource = catalog.Bindings;
                booksDataGridView.DataSource = visibleBooks;

                toggleVisibleButton.Enabled = true;
                deleteStockButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred reading the file, " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Handles toggle visible click
        private void toggleVisibleButton_Click(object sender, EventArgs e)
        {
            if (showingOutOfStock)
            {
                // Hide books out of stock
                visibleBooks = catalog.GetBooksInStock(); ;
                toggleVisibleButton.Text = "Show out of Stock";
            }
            else
            {
                // Show all books
                visibleBooks = catalog.Books;
                toggleVisibleButton.Text = "Hide out of Stock";
            }
            booksDataGridView.DataSource = visibleBooks;

            showingOutOfStock = !showingOutOfStock;
        }

        private void deleteStockButton_Click(object sender, EventArgs e)
        {
            catalog.RemoveBooksOutOfStock();

            if (showingOutOfStock)
            {
                // Hide books out of stock
                visibleBooks = catalog.GetBooksInStock(); ;
            }
            else
            {
                // Show all books
                visibleBooks = catalog.Books;
            }

            booksDataGridView.DataSource = visibleBooks;
        }
    }
}
