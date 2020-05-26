namespace libraryApp
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PagesTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.AuthorDataGrid = new System.Windows.Forms.DataGridView();
            this.PublishingDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorFilterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PublishingTextBox = new System.Windows.Forms.TextBox();
            this.PublishingFilterButton = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PublishingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishingDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Издательство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Автор";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(148, 264);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 31);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(376, 264);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 31);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(154, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(396, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // PagesTextBox
            // 
            this.PagesTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesTextBox.Location = new System.Drawing.Point(154, 158);
            this.PagesTextBox.Name = "PagesTextBox";
            this.PagesTextBox.Size = new System.Drawing.Size(89, 22);
            this.PagesTextBox.TabIndex = 8;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTextBox.Location = new System.Drawing.Point(154, 126);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(89, 22);
            this.YearTextBox.TabIndex = 9;
            // 
            // AuthorDataGrid
            // 
            this.AuthorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDataGrid.Location = new System.Drawing.Point(608, 96);
            this.AuthorDataGrid.Name = "AuthorDataGrid";
            this.AuthorDataGrid.Size = new System.Drawing.Size(220, 261);
            this.AuthorDataGrid.TabIndex = 10;
            this.AuthorDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorDataGrid_CellEnter);
            // 
            // PublishingDataGrid
            // 
            this.PublishingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublishingDataGrid.Location = new System.Drawing.Point(847, 96);
            this.PublishingDataGrid.Name = "PublishingDataGrid";
            this.PublishingDataGrid.Size = new System.Drawing.Size(220, 261);
            this.PublishingDataGrid.TabIndex = 11;
            this.PublishingDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PublishingDataGrid_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuthorTextBox);
            this.groupBox1.Controls.Add(this.AuthorFilterButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(608, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторы";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorTextBox.Location = new System.Drawing.Point(6, 21);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(210, 22);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // AuthorFilterButton
            // 
            this.AuthorFilterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorFilterButton.Location = new System.Drawing.Point(80, 49);
            this.AuthorFilterButton.Name = "AuthorFilterButton";
            this.AuthorFilterButton.Size = new System.Drawing.Size(75, 23);
            this.AuthorFilterButton.TabIndex = 0;
            this.AuthorFilterButton.Text = "Фильтр";
            this.AuthorFilterButton.UseVisualStyleBackColor = true;
            this.AuthorFilterButton.Click += new System.EventHandler(this.AuthorFilterButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PublishingTextBox);
            this.groupBox2.Controls.Add(this.PublishingFilterButton);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(847, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 85);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Издательства";
            // 
            // PublishingTextBox
            // 
            this.PublishingTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishingTextBox.Location = new System.Drawing.Point(6, 21);
            this.PublishingTextBox.Name = "PublishingTextBox";
            this.PublishingTextBox.Size = new System.Drawing.Size(208, 22);
            this.PublishingTextBox.TabIndex = 11;
            // 
            // PublishingFilterButton
            // 
            this.PublishingFilterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PublishingFilterButton.Location = new System.Drawing.Point(74, 49);
            this.PublishingFilterButton.Name = "PublishingFilterButton";
            this.PublishingFilterButton.Size = new System.Drawing.Size(75, 23);
            this.PublishingFilterButton.TabIndex = 1;
            this.PublishingFilterButton.Text = "Фильтр";
            this.PublishingFilterButton.UseVisualStyleBackColor = true;
            this.PublishingFilterButton.Click += new System.EventHandler(this.PublishingFilterButton_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AuthorLabel.Location = new System.Drawing.Point(151, 63);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 14);
            this.AuthorLabel.TabIndex = 14;
            this.AuthorLabel.Text = "label6";
            // 
            // PublishingLabel
            // 
            this.PublishingLabel.AutoSize = true;
            this.PublishingLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishingLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PublishingLabel.Location = new System.Drawing.Point(151, 96);
            this.PublishingLabel.Name = "PublishingLabel";
            this.PublishingLabel.Size = new System.Drawing.Size(43, 14);
            this.PublishingLabel.TabIndex = 15;
            this.PublishingLabel.Text = "label6";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 364);
            this.Controls.Add(this.PublishingLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PublishingDataGrid);
            this.Controls.Add(this.AuthorDataGrid);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.PagesTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление новой книги";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishingDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox PagesTextBox;
        public System.Windows.Forms.TextBox YearTextBox;
        public System.Windows.Forms.DataGridView AuthorDataGrid;
        public System.Windows.Forms.DataGridView PublishingDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Button AuthorFilterButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PublishingTextBox;
        private System.Windows.Forms.Button PublishingFilterButton;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PublishingLabel;
    }
}