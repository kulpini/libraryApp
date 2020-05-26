namespace libraryApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BooksButton = new System.Windows.Forms.Button();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.PublishingsButton = new System.Windows.Forms.Button();
            this.AuthorsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.LendBookButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FieldComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SecondaryDataGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BooksDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryDataGrid)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 113);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(617, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 111);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BooksButton);
            this.groupBox3.Controls.Add(this.StudentsButton);
            this.groupBox3.Controls.Add(this.PublishingsButton);
            this.groupBox3.Controls.Add(this.AuthorsButton);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(46, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перегляд";
            // 
            // BooksButton
            // 
            this.BooksButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BooksButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BooksButton.Location = new System.Drawing.Point(19, 19);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(120, 30);
            this.BooksButton.TabIndex = 10;
            this.BooksButton.Text = "Книги";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // StudentsButton
            // 
            this.StudentsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentsButton.Location = new System.Drawing.Point(168, 55);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(120, 30);
            this.StudentsButton.TabIndex = 9;
            this.StudentsButton.Text = "Студенти";
            this.StudentsButton.UseVisualStyleBackColor = true;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // PublishingsButton
            // 
            this.PublishingsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PublishingsButton.Location = new System.Drawing.Point(168, 19);
            this.PublishingsButton.Name = "PublishingsButton";
            this.PublishingsButton.Size = new System.Drawing.Size(120, 30);
            this.PublishingsButton.TabIndex = 8;
            this.PublishingsButton.Text = "Видавництва";
            this.PublishingsButton.UseVisualStyleBackColor = true;
            this.PublishingsButton.Click += new System.EventHandler(this.PublishingsButton_Click);
            // 
            // AuthorsButton
            // 
            this.AuthorsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorsButton.Location = new System.Drawing.Point(19, 56);
            this.AuthorsButton.Name = "AuthorsButton";
            this.AuthorsButton.Size = new System.Drawing.Size(120, 30);
            this.AuthorsButton.TabIndex = 7;
            this.AuthorsButton.Text = "Автори";
            this.AuthorsButton.UseVisualStyleBackColor = true;
            this.AuthorsButton.Click += new System.EventHandler(this.AuthorsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(359, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Керування";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(30, 53);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(30, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 30);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавити...";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ArchiveButton);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 111);
            this.panel2.TabIndex = 1;
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArchiveButton.Location = new System.Drawing.Point(485, 30);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 52);
            this.ArchiveButton.TabIndex = 3;
            this.ArchiveButton.Text = "Архiв видачi";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ReturnBookButton);
            this.groupBox4.Controls.Add(this.LendBookButton);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(277, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Видача книг";
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnBookButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ReturnBookButton.Location = new System.Drawing.Point(18, 60);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(150, 30);
            this.ReturnBookButton.TabIndex = 7;
            this.ReturnBookButton.Text = "Повернути книгу";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // LendBookButton
            // 
            this.LendBookButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LendBookButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LendBookButton.Location = new System.Drawing.Point(18, 19);
            this.LendBookButton.Name = "LendBookButton";
            this.LendBookButton.Size = new System.Drawing.Size(150, 30);
            this.LendBookButton.TabIndex = 6;
            this.LendBookButton.Text = "Видати книгу";
            this.LendBookButton.UseVisualStyleBackColor = true;
            this.LendBookButton.Click += new System.EventHandler(this.LendBookButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaskTextBox);
            this.groupBox1.Controls.Add(this.FilterButton);
            this.groupBox1.Controls.Add(this.FieldComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фiльтр";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(73, 43);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(152, 20);
            this.MaskTextBox.TabIndex = 7;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilterButton.Location = new System.Drawing.Point(62, 69);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(120, 30);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Фiльтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FieldComboBox
            // 
            this.FieldComboBox.FormattingEnabled = true;
            this.FieldComboBox.Items.AddRange(new object[] {
            "Назва",
            "Автор",
            "Видавництво",
            "Рiк"});
            this.FieldComboBox.Location = new System.Drawing.Point(73, 16);
            this.FieldComboBox.Name = "FieldComboBox";
            this.FieldComboBox.Size = new System.Drawing.Size(152, 21);
            this.FieldComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1180, 545);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SecondaryDataGrid);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(618, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(562, 545);
            this.panel6.TabIndex = 1;
            // 
            // SecondaryDataGrid
            // 
            this.SecondaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondaryDataGrid.Location = new System.Drawing.Point(9, 6);
            this.SecondaryDataGrid.Name = "SecondaryDataGrid";
            this.SecondaryDataGrid.Size = new System.Drawing.Size(540, 527);
            this.SecondaryDataGrid.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BooksDataGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 545);
            this.panel5.TabIndex = 0;
            // 
            // BooksDataGrid
            // 
            this.BooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGrid.Location = new System.Drawing.Point(12, 6);
            this.BooksDataGrid.Name = "BooksDataGrid";
            this.BooksDataGrid.Size = new System.Drawing.Size(574, 527);
            this.BooksDataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библiотечний облiк";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryDataGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button LendBookButton;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox FieldComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthorsButton;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button PublishingsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView SecondaryDataGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView BooksDataGrid;
        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button ArchiveButton;
    }
}

