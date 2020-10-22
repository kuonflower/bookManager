namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.bookDataSet = new BookManager.BookDataSet();
            this.bookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet1 = new BookManager.BookDataSet();
            this.bookDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.著者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookDataGrid
            // 
            this.bookDataGrid.AutoGenerateColumns = false;
            this.bookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書名DataGridViewTextBoxColumn,
            this.著者DataGridViewTextBoxColumn,
            this.値段DataGridViewTextBoxColumn});
            this.bookDataGrid.DataSource = this.bookDataTableBindingSource;
            this.bookDataGrid.Location = new System.Drawing.Point(100, 61);
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowTemplate.Height = 21;
            this.bookDataGrid.Size = new System.Drawing.Size(358, 150);
            this.bookDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "書名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "著者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "値段";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(178, 284);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(100, 19);
            this.bookName.TabIndex = 4;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(178, 329);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 19);
            this.author.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(178, 367);
            this.price.Mask = "00000";
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 19);
            this.price.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(284, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(284, 365);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDataSetBindingSource
            // 
            this.bookDataSetBindingSource.DataSource = this.bookDataSet;
            this.bookDataSetBindingSource.Position = 0;
            // 
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "BookDataTable";
            this.bookDataTableBindingSource.DataSource = this.bookDataSet;
            // 
            // bookDataSetBindingSource1
            // 
            this.bookDataSetBindingSource1.DataSource = this.bookDataSet;
            this.bookDataSetBindingSource1.Position = 0;
            // 
            // bookDataSet1
            // 
            this.bookDataSet1.DataSetName = "BookDataSet";
            this.bookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDataTableBindingSource1
            // 
            this.bookDataTableBindingSource1.DataMember = "bookDataTable";
            this.bookDataTableBindingSource1.DataSource = this.bookDataSet1;
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            // 
            // 著者DataGridViewTextBoxColumn
            // 
            this.著者DataGridViewTextBoxColumn.DataPropertyName = "著者";
            this.著者DataGridViewTextBoxColumn.HeaderText = "著者";
            this.著者DataGridViewTextBoxColumn.Name = "著者DataGridViewTextBoxColumn";
            // 
            // 値段DataGridViewTextBoxColumn
            // 
            this.値段DataGridViewTextBoxColumn.DataPropertyName = "値段";
            this.値段DataGridViewTextBoxColumn.HeaderText = "値段";
            this.値段DataGridViewTextBoxColumn.Name = "値段DataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.MaskedTextBox price;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.BindingSource bookDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookDataSetBindingSource1;
        private BookDataSet bookDataSet1;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 著者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値段DataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

