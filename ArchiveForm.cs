using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryApp
{
    public partial class ArchiveForm : Form
    {
        public ArchiveForm()
        {
            InitializeComponent();
        }

        private void ShowLendingArchive(string CommandText)
        {
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "Lending"); // заполняем таблицу Books данными из базы данных 
            ArchiveDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            ArchiveDataGrid.Columns["BookName"].HeaderText = "Назва книги"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["BookName"].Width = 250;  // ширина столбца 
            ArchiveDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["AuthorName"].Width = 160;  // ширина столбца 
            ArchiveDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["PublishingName"].Width = 150;  // ширина столбца 
            ArchiveDataGrid.Columns["StudentName"].HeaderText = "ПIБ отримувача"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["StudentName"].Width = 150;  // ширина столбца  
            ArchiveDataGrid.Columns["LendingDate"].HeaderText = "Дата видачi"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["LendingDate"].Width = 100;  // ширина столбца 
            ArchiveDataGrid.Columns["Term"].HeaderText = "Срок видачi, днiв"; // задаём Наменование столбца
            ArchiveDataGrid.Columns["Term"].Width = 70;  // ширина столбца             
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.BookName,Author.AuthorName,Publishing.PublishingName,Student.StudentName,Lending.LendingDate,Lending.Term ";
            CommandText += "FROM Books,Author,Publishing,Student,Lending ";
            CommandText += "WHERE Student.ID=Lending.StudentID AND Books.ID=Lending.BookID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Author.ID=Books.AuthorId ";
            CommandText += "ORDER BY BookName";
            ShowLendingArchive(CommandText);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.BookName,Author.AuthorName,Publishing.PublishingName,Student.StudentName,Lending.LendingDate,Lending.Term ";
            CommandText += "FROM Books,Author,Publishing,Student,Lending ";
            CommandText += "WHERE Student.ID=Lending.StudentID AND Books.ID=Lending.BookID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Author.ID=Books.AuthorId ";
            if (FieldComboBox.SelectedIndex == 0) // Название
                CommandText += "AND Books.BookName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 1) // Автор
                CommandText += "AND Author.AuthorName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 2) // Дата выдачи
                CommandText += "AND Lending.LendingDate = " + MaskTextBox.Text + "' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 3) // Получатель
                CommandText += "AND Student.StudentName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 

            if (SortComboBox.SelectedIndex == 0) // Название
                CommandText += "ORDER BY BookName"; // подставляем фильтр 
            if (SortComboBox.SelectedIndex == 1) // Автор
                CommandText += "ORDER BY AuthorName"; // подставляем фильтр 
            if (SortComboBox.SelectedIndex == 2) // Дата выдачи
                CommandText += "ORDER BY LendingDate"; // подставляем фильтр 

            ShowLendingArchive(CommandText);
        }
    }
}
