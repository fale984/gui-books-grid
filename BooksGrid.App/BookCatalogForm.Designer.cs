namespace BooksGrid.App
{
    partial class BookCatalogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookInStockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookBindingColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bookDescriptionColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openInstructionsLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openBooksFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.instructionsToggleLabel = new System.Windows.Forms.Label();
            this.toggleVisibleButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.deleteStockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleColumn,
            this.bookAuthorColumn,
            this.bookYearColumn,
            this.bookPriceColumn,
            this.bookInStockColumn,
            this.bookBindingColumn,
            this.bookDescriptionColumn});
            this.booksDataGridView.Location = new System.Drawing.Point(12, 144);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(760, 405);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            this.bookYearColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.bookYearColumn.HeaderText = "Year";
            this.bookYearColumn.Name = "bookYearColumn";
            // 
            // bookPriceColumn
            // 
            this.bookPriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "0";
            this.bookPriceColumn.DefaultCellStyle = dataGridViewCellStyle12;
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
            // openInstructionsLabel
            // 
            this.openInstructionsLabel.AutoSize = true;
            this.openInstructionsLabel.Location = new System.Drawing.Point(13, 13);
            this.openInstructionsLabel.Name = "openInstructionsLabel";
            this.openInstructionsLabel.Size = new System.Drawing.Size(230, 13);
            this.openInstructionsLabel.TabIndex = 1;
            this.openInstructionsLabel.Text = "Select a CSV file to view the books information.";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(16, 29);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(478, 20);
            this.fileNameTextBox.TabIndex = 2;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(500, 27);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openBooksFileDialog
            // 
            this.openBooksFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openBooksFileDialog.Title = "Open catalog";
            // 
            // instructionsToggleLabel
            // 
            this.instructionsToggleLabel.AutoSize = true;
            this.instructionsToggleLabel.Location = new System.Drawing.Point(13, 63);
            this.instructionsToggleLabel.Name = "instructionsToggleLabel";
            this.instructionsToggleLabel.Size = new System.Drawing.Size(292, 13);
            this.instructionsToggleLabel.TabIndex = 4;
            this.instructionsToggleLabel.Text = "If you want to hide or show the books out of stock click here";
            // 
            // toggleVisibleButton
            // 
            this.toggleVisibleButton.Enabled = false;
            this.toggleVisibleButton.Location = new System.Drawing.Point(311, 58);
            this.toggleVisibleButton.Name = "toggleVisibleButton";
            this.toggleVisibleButton.Size = new System.Drawing.Size(131, 23);
            this.toggleVisibleButton.TabIndex = 5;
            this.toggleVisibleButton.Text = "Hide out of Stock";
            this.toggleVisibleButton.UseVisualStyleBackColor = true;
            this.toggleVisibleButton.Click += new System.EventHandler(this.toggleVisibleButton_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(13, 116);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(129, 13);
            this.creditsLabel.TabIndex = 6;
            this.creditsLabel.Text = "Made by Francisco Lopez";
            // 
            // deleteStockButton
            // 
            this.deleteStockButton.Enabled = false;
            this.deleteStockButton.Location = new System.Drawing.Point(311, 87);
            this.deleteStockButton.Name = "deleteStockButton";
            this.deleteStockButton.Size = new System.Drawing.Size(131, 23);
            this.deleteStockButton.TabIndex = 7;
            this.deleteStockButton.Text = "Delete out of Stock";
            this.deleteStockButton.UseVisualStyleBackColor = true;
            this.deleteStockButton.Click += new System.EventHandler(this.deleteStockButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "If you want to delete the books out of stock click here";
            // 
            // BookCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteStockButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.toggleVisibleButton);
            this.Controls.Add(this.instructionsToggleLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.openInstructionsLabel);
            this.Controls.Add(this.booksDataGridView);
            this.Name = "BookCatalogForm";
            this.Text = "Book Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label openInstructionsLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openBooksFileDialog;
        private System.Windows.Forms.Label instructionsToggleLabel;
        private System.Windows.Forms.Button toggleVisibleButton;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Button deleteStockButton;
        private System.Windows.Forms.Label label1;
    }
}

