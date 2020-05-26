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
    public partial class LendBookForm : Form
    {
        public int ID;
        public LendBookForm()
        {
            InitializeComponent();
        }

        private void ShowStudents(string CommandText)
        {
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "Student"); // заполняем таблицу Student данными из базы данных 
            StudentDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные об издательствах в DataGrid на форме
            StudentDataGrid.Columns["ID"].Visible = false;    // ключевое поле ID не показываем
            StudentDataGrid.Columns["StudentName"].HeaderText = "П.I.Б"; // задаём Наменование столбца
            StudentDataGrid.Columns["StudentName"].Width = 200;  // ширина столбца    
            StudentDataGrid.Columns["StudentId"].HeaderText = "№ квитка"; // задаём Наменование столбца
            StudentDataGrid.Columns["StudentId"].Width = 80;  // ширина столбца              
        }

        private void LendBookForm_Load(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT * FROM Student ORDER BY StudentName";        //формируем строку запроса
            ShowStudents(CommandText);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT * FROM Student ";
            if (MaskTextBox.Text != "")
                CommandText += "WHERE StudentName LIKE '" + MaskTextBox.Text + "%' ";
            CommandText += "ORDER BY StudentName";        //формируем строку запроса
            ShowStudents(CommandText);
        }

        private void StudentDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = StudentDataGrid.CurrentRow.Index; // № по порядку в таблице представления
            ID = (int)StudentDataGrid[0, index].Value;  // получаем ID студента в выбранной строке
            StudentLabel.Text = Convert.ToString(StudentDataGrid[1, index].Value);
            IDLabel.Text = Convert.ToString(StudentDataGrid[2, index].Value);
        }

        private void LendBookButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
