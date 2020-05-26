namespace libraryApp
{
    partial class LendBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BookLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PublishingLabel = new System.Windows.Forms.Label();
            this.LendBookButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.YearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книга:";
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BookLabel.Location = new System.Drawing.Point(139, 41);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(43, 14);
            this.BookLabel.TabIndex = 1;
            this.BookLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Видавництво:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AuthorLabel.Location = new System.Drawing.Point(139, 61);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 14);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Назва:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Автор:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Рiк видання:";
            // 
            // PublishingLabel
            // 
            this.PublishingLabel.AutoSize = true;
            this.PublishingLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PublishingLabel.Location = new System.Drawing.Point(139, 84);
            this.PublishingLabel.Name = "PublishingLabel";
            this.PublishingLabel.Size = new System.Drawing.Size(43, 14);
            this.PublishingLabel.TabIndex = 7;
            this.PublishingLabel.Text = "label8";
            // 
            // LendBookButton
            // 
            this.LendBookButton.Location = new System.Drawing.Point(97, 430);
            this.LendBookButton.Name = "LendBookButton";
            this.LendBookButton.Size = new System.Drawing.Size(120, 30);
            this.LendBookButton.TabIndex = 8;
            this.LendBookButton.Text = "Видати";
            this.LendBookButton.UseVisualStyleBackColor = true;
            this.LendBookButton.Click += new System.EventHandler(this.LendBookButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(371, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 30);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Вiдмiна";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.YearLabel.Location = new System.Drawing.Point(139, 108);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(43, 14);
            this.YearLabel.TabIndex = 10;
            this.YearLabel.Text = "label9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(51, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Читач:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "ПIБ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Термiн видачi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "№ квитка:";
            // 
            // TermTextBox
            // 
            this.TermTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermTextBox.Location = new System.Drawing.Point(142, 310);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(75, 27);
            this.TermTextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "днiв";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IDLabel.Location = new System.Drawing.Point(139, 222);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(135, 14);
            this.IDLabel.TabIndex = 17;
            this.IDLabel.Text = "виберiть студента...";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentLabel.Location = new System.Drawing.Point(139, 197);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(135, 14);
            this.StudentLabel.TabIndex = 18;
            this.StudentLabel.Text = "виберiть студента...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindButton);
            this.groupBox1.Controls.Add(this.MaskTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(638, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенти";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(117, 56);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(120, 30);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Знайти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskTextBox.Location = new System.Drawing.Point(51, 18);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(285, 27);
            this.MaskTextBox.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "ПIБ:";
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(638, 118);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.Size = new System.Drawing.Size(342, 346);
            this.StudentDataGrid.TabIndex = 20;
            this.StudentDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellEnter);
            // 
            // LendBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 485);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TermTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LendBookButton);
            this.Controls.Add(this.PublishingLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LendBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Видача книги читачу";
            this.Load += new System.EventHandler(this.LendBookForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label PublishingLabel;
        private System.Windows.Forms.Button LendBookButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView StudentDataGrid;
    }
}