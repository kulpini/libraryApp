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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void GetAuthors(string CommandText)  // читаем таблицу "авторы"
        {
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Author]"); // заполняем таблицу Author данными из базы данных 
            AuthorDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные об авторах в DataGrid на форме
            AuthorDataGrid.Columns["ID"].Visible = false;    // поле ID автора не показываем
            AuthorDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            AuthorDataGrid.Columns["AuthorName"].Width = 200;  // ширина столбца 
        }

        private void GetPublishings(string CommandText)  // читаем таблицу "издательства"
        {
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Publishing]"); // заполняем таблицу Publishing данными из базы данных 
            PublishingDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные об издательствах в DataGrid на форме
            PublishingDataGrid.Columns["ID"].Visible = false;    // поле ID издательства не показываем
            PublishingDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            PublishingDataGrid.Columns["PublishingName"].Width = 200;  // ширина столбца 
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT * FROM Author ORDER BY AuthorName";   //формируем строку запроса
            GetAuthors(CommandText);
            CommandText = "SELECT * FROM Publishing ORDER BY PublishingName";   //формируем строку запроса
            GetPublishings(CommandText);
            AuthorLabel.Text = "";
            PublishingLabel.Text = "";
        }

        private void AuthorDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            string ID;
            index = AuthorDataGrid.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(AuthorDataGrid[0, index].Value);  // получаем ID автора в выбранной строке
            AuthorLabel.Text = Convert.ToString(AuthorDataGrid[1, index].Value);
        }

        private void PublishingDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            string ID;
            index = PublishingDataGrid.CurrentRow.Index; // № по порядку в таблице представления
            ID = Convert.ToString(PublishingDataGrid[0, index].Value);  // получаем ID автора в выбранной строке
            PublishingLabel.Text = Convert.ToString(PublishingDataGrid[1, index].Value);
        }

        private void AuthorFilterButton_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM Author ";
            if (AuthorTextBox.Text!="")
                CommandText += "WHERE AuthorName LIKE '" + AuthorTextBox.Text + "%' ";
            CommandText += "ORDER BY AuthorName";
            GetAuthors(CommandText);
        }

        private void PublishingFilterButton_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM Publishing ";
            if (PublishingTextBox.Text != "")
                CommandText += "WHERE PublishingName LIKE '" + PublishingTextBox.Text + "%' ";
            CommandText += "ORDER BY PublishingName";
            GetPublishings(CommandText);
        }
    }
}
