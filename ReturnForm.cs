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
    public partial class ReturnForm : Form
    {
        public int ID;
        
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void ShowLendingBooks(string CommandText)
        {
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Books]"); // заполняем таблицу Books данными из базы данных 
            BooksDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            BooksDataGrid.Columns["ID"].Visible = false;    // ключевое поле ID не показываем
            BooksDataGrid.Columns["BookName"].HeaderText = "Назва книги"; // задаём Наменование столбца
            BooksDataGrid.Columns["BookName"].Width = 250;  // ширина столбца 
            BooksDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            BooksDataGrid.Columns["AuthorName"].Width = 160;  // ширина столбца 
            BooksDataGrid.Columns["BookYear"].HeaderText = "Рiк"; // задаём Наменование столбца
            BooksDataGrid.Columns["BookYear"].Width = 40;  // ширина столбца 
            BooksDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            BooksDataGrid.Columns["PublishingName"].Width = 160;  // ширина столбца 
            BooksDataGrid.Columns["Pages"].HeaderText = "Стр."; // задаём Наменование столбца
            BooksDataGrid.Columns["Pages"].Width = 40;  // ширина столбца        
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
            CommandText += "FROM Books,Author,Publishing ";
            CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Books.Available=false ";
            CommandText += "ORDER BY BookName";
            ShowLendingBooks(CommandText);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
            CommandText += "FROM Books,Author,Publishing ";
            CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Books.Available=false ";
            if (FieldComboBox.SelectedIndex == 0) // Название
                CommandText += "AND Books.BookName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 1) // Автор
                CommandText += "AND Author.AuthorName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 2) // Издательство
                CommandText += "AND Publishing.PublishingName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 3) // Год
                CommandText += "AND Books.BookYear=" + MaskTextBox.Text + " "; // подставляем фильтр 
            CommandText += "ORDER BY BookName";   //формируем строку запроса
            ShowLendingBooks(CommandText);
        }

        private void BooksDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = BooksDataGrid.CurrentRow.Index; // № по порядку в таблице представления
            ID = (int)BooksDataGrid[0, index].Value;  // получаем ID книги в выбранной строке
        }
    }
}
