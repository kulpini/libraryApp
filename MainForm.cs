using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace libraryApp
{
    public partial class MainForm : Form
    {
        public AddValuesForm Authors;

        private string activeTable;  // имя активной таблицы
        static string pathToDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Library.mdb");
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ pathToDb;
        
        public MainForm()
        {
            InitializeComponent();
            Authors = new AddValuesForm();
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            Authors.ShowDialog();
        }

        private void GetAuthors()  // читаем таблицу "авторы"
        {
            string CommandText = "SELECT * FROM [Author] ORDER BY AuthorName";   //формируем строку запроса
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Author]"); // заполняем таблицу Author данными из базы данных 
            SecondaryDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные об авторах в DataGrid на форме
            SecondaryDataGrid.Columns["ID"].Visible = false;    // поле ID автора не показываем
            SecondaryDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["AuthorName"].Width = 200;  // ширина столбца 
        }

        private void GetPublishings()  // читаем таблицу "издательства"
        {
            string CommandText = "SELECT * FROM [Publishing] ORDER BY PublishingName";   //формируем строку запроса
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Publishing]"); // заполняем таблицу Publishing данными из базы данных 
            SecondaryDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные об издательствах в DataGrid на форме
            SecondaryDataGrid.Columns["ID"].Visible = false;    // поле ID издательства не показываем
            SecondaryDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["PublishingName"].Width = 200;  // ширина столбца 
        }

        private void GetStudents()  // читаем таблицу "студенты"
        {
            string CommandText = "SELECT * FROM [Student] ORDER BY StudentName";   //формируем строку запроса
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Student]"); // заполняем таблицу Student данными из базы данных 
            SecondaryDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SecondaryDataGrid.Columns["ID"].Visible = false;    // поле ID студента не показываем
            SecondaryDataGrid.Columns["StudentName"].HeaderText = "ПIБ студента"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["StudentName"].Width = 200;  // ширина столбца 
            SecondaryDataGrid.Columns["StudentID"].HeaderText = "№ студентського"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["StudentID"].Width = 130;  // ширина столбца 
        }

        private void GetBooks()  // читаем таблицу "книги"
        {
            string CommandText = "SELECT Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
            CommandText += "FROM Books,Author,Publishing ";
            CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
            CommandText += "ORDER BY BookName";   //формируем строку запроса
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Books]"); // заполняем таблицу Books данными из базы данных 
            SecondaryDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SecondaryDataGrid.Columns["BookName"].HeaderText = "Назва книги"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["BookName"].Width = 200;  // ширина столбца 
            SecondaryDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["AuthorName"].Width = 120;  // ширина столбца 
            SecondaryDataGrid.Columns["BookYear"].HeaderText = "Рiк"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["BookYear"].Width = 40;  // ширина столбца 
            SecondaryDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            SecondaryDataGrid.Columns["PublishingName"].Width = 120;  // ширина столбца 
            SecondaryDataGrid.Columns["Pages"].HeaderText = "Стр."; // задаём Наменование столбца
            SecondaryDataGrid.Columns["Pages"].Width = 40;  // ширина столбца
        }

        public void MyExecuteNonQuery(string CommandText)
        {
            OleDbConnection QueryConnection = new OleDbConnection(ConnectionString);   //создаём подключение
            QueryConnection.Open();    // открываем подключение
            OleDbCommand myCommand = QueryConnection.CreateCommand();   // создаём команду
            myCommand.CommandText = CommandText;    // текст команды
            myCommand.ExecuteNonQuery();        // выполняем команду
            QueryConnection.Close();        // закрываем соединение
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            GetAuthors();
            activeTable = "Author";
        }

        private void PublishingsButton_Click(object sender, EventArgs e)
        {
            GetPublishings();
            activeTable = "Publishing";
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            GetStudents();
            activeTable = "Student";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmForm DelForm = new ConfirmForm();
            if (DelForm.ShowDialog() == DialogResult.OK)
            {
                int index, index_old;
                string ID;
                index = SecondaryDataGrid.CurrentRow.Index; // № по порядку в таблице представления
                index_old = index;
                ID = Convert.ToString(SecondaryDataGrid[0, index].Value); // ID подаем в запрос как строку

                string CommandText = "DELETE FROM " + activeTable + " WHERE ID=" + ID;
                MyExecuteNonQuery(CommandText);
                switch (activeTable)
                {
                    case "Author":
                        GetAuthors();
                        break;
                    case "Publishing":
                        GetPublishings();
                        break;
                    case "Student":
                        GetStudents();
                        break;
                    case "Books":
                        GetBooks();
                        break;
                }
                if (index_old >= 0)
                {
                    SecondaryDataGrid.ClearSelection();
                    SecondaryDataGrid[0, index_old].Selected = true;
                }
            }
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            GetBooks();
            activeTable = "Books";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (activeTable == "Author")
            {
                AddValuesForm AddForm = new AddValuesForm();
                AddForm.Text = "Додання нового автора";
                AddForm.NameLabel.Text = "Автор книги";
                AddForm.ShowDialog();
                if (AddForm.DialogResult == DialogResult.OK)
                {
                    AddAuthor(AddForm.NameTextBox.Text);
                    GetAuthors();
                }
            }
            if (activeTable == "Publishing")
            {
                AddValuesForm AddForm = new AddValuesForm();
                AddForm.Text = "Додання нового видавництва";
                AddForm.NameLabel.Text = "Назва";
                AddForm.ShowDialog();
                if (AddForm.DialogResult == DialogResult.OK)
                {
                    AddPublishing(AddForm.NameTextBox.Text);
                    GetPublishings();
                }
            }
            if (activeTable == "Student")
            {
                AddStudentForm AddForm = new AddStudentForm();
                AddForm.ShowDialog();
                if (AddForm.DialogResult == DialogResult.OK)
                {
                    AddStudent(AddForm.NameTextBox.Text, AddForm.IDTextBox.Text);
                    GetStudents();
                }
            }
            if (activeTable == "Books")
            {
                AddBookForm AddForm = new AddBookForm();
                AddForm.ShowDialog();
                if (AddForm.DialogResult == DialogResult.OK)
                {
                    int row, idAuthor, idPublishing;
                    int year = int.Parse(AddForm.YearTextBox.Text);
                    int pages = int.Parse(AddForm.PagesTextBox.Text);
                    row = AddForm.AuthorDataGrid.CurrentCell.RowIndex; // взяли строку с AuthorDataGrid
                    idAuthor = (int)AddForm.AuthorDataGrid[0, row].Value;
                    row = AddForm.PublishingDataGrid.CurrentCell.RowIndex; // взяли строку с PublishingDataGrid
                    idPublishing = (int)AddForm.PublishingDataGrid[0, row].Value;
                    AddBook(AddForm.NameTextBox.Text, year, idAuthor, idPublishing, pages);
                    GetBooks();
                }
            }
        }

        private void AddAuthor(string authorName)
        {
            string CommandText;         //  вводим переменную для записи команды вставки
            CommandText = "INSERT INTO Author (AuthorName) VALUES ('" + authorName + "')";
            MyExecuteNonQuery(CommandText);
        }

        private void AddPublishing(string publishingName)
        {
            string CommandText;         //  вводим переменную для записи команды вставки
            CommandText = "INSERT INTO Publishing (PublishingName) VALUES ('" + publishingName + "')";
            MyExecuteNonQuery(CommandText);
        }

        private void AddStudent(string studentName,string studentID)
        {
            string CommandText;         //  вводим переменную для записи команды вставки
            CommandText = "INSERT INTO Student (StudentName,StudentID) VALUES ('" + studentName + "', '" + studentID + "')";
            MyExecuteNonQuery(CommandText);
        }

        private void AddBook(string bookName, int bookYear,int authorID, int publishingID, int pages)
        {
            string CommandText;         //  вводим переменную для записи команды вставки
            string year = Convert.ToString(bookYear);    // переводим переменную типа int в строку
            string author = Convert.ToString(authorID);  // переводим переменную типа int в строку
            string publishing = Convert.ToString(publishingID);     // переводим переменную типа int в строку
            string page = Convert.ToString(pages);      // переводим переменную типа int в строку
            CommandText = "INSERT INTO Books (BookName,BookYear,AuthorID,PublishingID,Pages) ";
            CommandText += "VALUES ('" + bookName + "'," + year + ","+ author + ","+ publishing + ","+ page + ")";
            MyExecuteNonQuery(CommandText);
        }

        private void ShowAvailableBooks(string CommandText)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Books]"); // заполняем таблицу Publishing данными из базы данных 
            BooksDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            BooksDataGrid.Columns["ID"].Visible = false;    // ключевое поле ID не показываем
            BooksDataGrid.Columns["BookName"].HeaderText = "Назва книги"; // задаём Наменование столбца
            BooksDataGrid.Columns["BookName"].Width = 200;  // ширина столбца 
            BooksDataGrid.Columns["AuthorName"].HeaderText = "Автор"; // задаём Наменование столбца
            BooksDataGrid.Columns["AuthorName"].Width = 120;  // ширина столбца 
            BooksDataGrid.Columns["BookYear"].HeaderText = "Рiк"; // задаём Наменование столбца
            BooksDataGrid.Columns["BookYear"].Width = 40;  // ширина столбца 
            BooksDataGrid.Columns["PublishingName"].HeaderText = "Видавництво"; // задаём Наменование столбца
            BooksDataGrid.Columns["PublishingName"].Width = 120;  // ширина столбца 
            BooksDataGrid.Columns["Pages"].HeaderText = "Стр."; // задаём Наменование столбца
            BooksDataGrid.Columns["Pages"].Width = 40;  // ширина столбца
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
            CommandText += "FROM Books,Author,Publishing ";
            CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Books.Available=true ";
            CommandText += "ORDER BY BookName";   //формируем строку запроса
            ShowAvailableBooks(CommandText);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string CommandText;
            CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
            CommandText += "FROM Books,Author,Publishing ";
            CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
            CommandText += "AND Books.Available=true ";
             if (FieldComboBox.SelectedIndex == 0) // Название
                CommandText += "AND Books.BookName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 1) // Автор
                CommandText += "AND Author.AuthorName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 2) // Издательство
                CommandText += "AND Publishing.PublishingName LIKE '" + MaskTextBox.Text + "%' "; // подставляем фильтр 
            if (FieldComboBox.SelectedIndex == 3) // Год
                CommandText += "AND Books.BookYear=" + MaskTextBox.Text + " "; // подставляем фильтр 
            CommandText += "ORDER BY BookName";   //формируем строку запроса
            ShowAvailableBooks(CommandText);
        }

        private void LendBook(int BookID, int StudentID, int Term)
        {
            string CommandText;         //  вводим переменную для записи команды 
            CommandText = "UPDATE Books SET Available=false WHERE ID="+Convert.ToString(BookID);
            MyExecuteNonQuery(CommandText);
            CommandText = "INSERT INTO Lending (BookID,StudentID,LendingDate,Term) ";
            CommandText += "VALUES ('" + Convert.ToString(BookID) + "','" + Convert.ToString(StudentID) + "','" + Convert.ToString(DateTime.Today) + "','" + Convert.ToString(Term) + "')";
            MyExecuteNonQuery(CommandText);
        }

        private void LendBookButton_Click(object sender, EventArgs e)
        {
            string CommandText;         //  вводим переменную для записи команды 
            int index = BooksDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
            int ID = (int)BooksDataGrid[0, index].Value;
            int term, studentID;
            LendBookForm LendForm = new LendBookForm();
            LendForm.BookLabel.Text = Convert.ToString(BooksDataGrid[1, index].Value);
            LendForm.AuthorLabel.Text = Convert.ToString(BooksDataGrid[2, index].Value);
            LendForm.PublishingLabel.Text = Convert.ToString(BooksDataGrid[4, index].Value);
            LendForm.YearLabel.Text = Convert.ToString(BooksDataGrid[3, index].Value);
            LendForm.ShowDialog();
            if (LendForm.DialogResult == DialogResult.OK)
            {
                term = Convert.ToInt32(LendForm.TermTextBox.Text);
                studentID = LendForm.ID;
                LendBook(ID, studentID,term);
                CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
                CommandText += "FROM Books,Author,Publishing ";
                CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
                CommandText += "AND Books.Available=true ";
                CommandText += "ORDER BY BookName";   //формируем строку запроса
                ShowAvailableBooks(CommandText);
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            string CommandText;         //  вводим переменную для записи команды 
            int ID;
            ReturnForm BookForm = new ReturnForm();
            BookForm.ShowDialog();
            if (BookForm.DialogResult == DialogResult.OK)
            {
                ID = BookForm.ID;
                CommandText = "UPDATE Books SET Available=true WHERE ID=" + Convert.ToString(ID);
                MyExecuteNonQuery(CommandText);
                CommandText = "SELECT Books.ID,Books.BookName,Author.AuthorName,Books.BookYear,Publishing.PublishingName,Books.Pages ";
                CommandText += "FROM Books,Author,Publishing ";
                CommandText += "WHERE Author.ID=Books.AuthorID AND Publishing.ID=Books.PublishingID ";
                CommandText += "AND Books.Available=true ";
                CommandText += "ORDER BY BookName";   //формируем строку запроса
                ShowAvailableBooks(CommandText);
            }
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm();
            archiveForm.ShowDialog();
        }
    }
}
