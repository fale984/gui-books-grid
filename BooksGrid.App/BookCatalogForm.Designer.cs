namespace BooksGrid.App
{
    partial class bookCatalogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookInStockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookBindingColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bookDescriptionColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleColumn,
            this.bookAuthorColumn,
            this.bookYearColumn,
            this.bookPriceColumn,
            this.bookInStockColumn,
            this.bookBindingColumn,
            this.bookDescriptionColumn});
            this.booksDataGridView.Location = new System.Drawing.Point(12, 161);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(760, 388);
            this.booksDataGridView.TabIndex = 0;
            this.booksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellContentClick);
            this.booksDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.booksDataGridView_RowPrePaint);
            // 
            // bookTitleColumn
            // 
            this.bookTitleColumn.DataPropertyName = "Title";
            this.bookTitleColumn.HeaderText = "Title";
            this.bookTitleColumn.Name = "bookTitleColumn";
            // 
            // bookAuthorColumn
            // 
            this.bookAuthorColumn.DataPropertyName = "Author";
            this.bookAuthorColumn.HeaderText = "Author";
            this.bookAuthorColumn.Name = "bookAuthorColumn";
            // 
            // bookYearColumn
            // 
            this.bookYearColumn.DataPropertyName = "Year";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.bookYearColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookYearColumn.HeaderText = "Year";
            this.bookYearColumn.Name = "bookYearColumn";
            // 
            // bookPriceColumn
            // 
            this.bookPriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.bookPriceColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookPriceColumn.HeaderText = "Price";
            this.bookPriceColumn.Name = "bookPriceColumn";
            // 
            // bookInStockColumn
            // 
            this.bookInStockColumn.DataPropertyName = "InStock";
            this.bookInStockColumn.HeaderText = "In Stock";
            this.bookInStockColumn.Name = "bookInStockColumn";
            // 
            // bookBindingColumn
            // 
            this.bookBindingColumn.DataPropertyName = "Binding";
            this.bookBindingColumn.HeaderText = "Binding";
            this.bookBindingColumn.Name = "bookBindingColumn";
            // 
            // bookDescriptionColumn
            // 
            this.bookDescriptionColumn.HeaderText = "Description";
            this.bookDescriptionColumn.Name = "bookDescriptionColumn";
            this.bookDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookDescriptionColumn.Text = "View";
            this.bookDescriptionColumn.UseColumnTextForButtonValue = true;
            // 
            // bookCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.booksDataGridView);
            this.Name = "bookCatalogForm";
            this.Text = "Book Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookYearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookInStockColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bookBindingColumn;
        private System.Windows.Forms.DataGridViewButtonColumn bookDescriptionColumn;
    }
}

