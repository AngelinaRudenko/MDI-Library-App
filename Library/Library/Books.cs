using System;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        public Books(Users users)
        {
            if (users != null)
                users.booksForm = this;
            InitializeComponent();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            toolStripComboBoxSort.SelectedItem = "Название";
            BinaryDeserialization();
            TableSort(toolStripComboBoxSort.SelectedItem.ToString());
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinarySerialization();
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            NewBook NewBookForm = new NewBook(this);
            NewBookForm.Show();
            this.Enabled = false;
        }

        private void ToolStripComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableSort(toolStripComboBoxSort.SelectedItem.ToString());
        }

        private void ToolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Search(toolStripTextBoxSearch.Text.ToLower());
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            ClearColor();
        }

        private void ToolStripButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int a = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                NewBook NewBookForm = new NewBook(this);
                NewBookForm.Show();
                this.Enabled = false;
                NewBookForm.Text = "Редактировать книгу";
                NewBookForm.buttonAdd.Text = "Принять";
                NewBookForm.textBoxTitle.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxAuthor.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxISBN.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxBBK.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxPblshCmpn.Text = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxPblshYear.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                NewBookForm.textBoxPages.Text = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            }
        }

        private void BinarySerialization()
        {
            BooksClass[] tableBooks = new BooksClass[dataGridView1.Rows.Count - 1];
            ReadGridToArray(tableBooks);    //fill the array with table values
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BooksInfo.lib", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tableBooks);
                fs.Close();
            }
        }

        private void BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BooksInfo.lib", FileMode.OpenOrCreate))
            {
                BooksClass[] tableBooks = (BooksClass[])formatter.Deserialize(fs);
                if (tableBooks != null)
                {
                    foreach (BooksClass book in tableBooks)
                    {
                        dataGridView1.Rows.Add(book.caption, book.author, book.isbn, book.bbk, book.pblshngCompn, book.pblshYear, book.pages, book.giveDate, book.returnDate, book.whoTook);
                    }
                }
                fs.Close();
            }
        }

        public void TableSort(string byWhat)
        {
            BooksClass[] tableBooks = new BooksClass[dataGridView1.RowCount - 1];
            ReadGridToArray(tableBooks);    //fill the array with table values    
            switch (byWhat)
            {
                case "Название":
                    Array.Sort(tableBooks, (x, y) => x.caption.CompareTo(y.caption));
                    break;
                case "Автор":
                    Array.Sort(tableBooks, (x, y) => x.author.CompareTo(y.author));
                    break;
                case "Шифр ISBN":
                    Array.Sort(tableBooks, (x, y) => x.isbn.CompareTo(y.isbn));
                    break;
                case "ББК":
                    Array.Sort(tableBooks, (x, y) => x.bbk.CompareTo(y.bbk));
                    break;
                case "Издательство":
                    Array.Sort(tableBooks, (x, y) => x.pblshngCompn.CompareTo(y.pblshngCompn));
                    break;
                case "Год издания":
                    Array.Sort(tableBooks, (x, y) => x.pblshYear.CompareTo(y.pblshYear));
                    break;
                case "Дата выдачи":
                    Array.Sort(tableBooks, (x, y) => x.giveDate.CompareTo(y.giveDate));
                    break;
                case "Срок сдачи":
                    Array.Sort(tableBooks, (x, y) => x.returnDate.CompareTo(y.returnDate));
                    break;
            }
            dataGridView1.Rows.Clear();
            foreach (BooksClass book in tableBooks)
            {
                dataGridView1.Rows.Add(book.caption, book.author, book.isbn, book.bbk, book.pblshngCompn, book.pblshYear, book.pages, book.giveDate, book.returnDate, book.whoTook);
            }
        }

        private BooksClass[] ReadGridToArray(BooksClass[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new BooksClass();
                array[i].caption = dataGridView1[0, i].Value.ToString();
                array[i].author = dataGridView1[1, i].Value.ToString();
                array[i].isbn = dataGridView1[2, i].Value.ToString();
                array[i].bbk = dataGridView1[3, i].Value.ToString();
                array[i].pblshngCompn = dataGridView1[4, i].Value.ToString();
                array[i].pblshYear = dataGridView1[5, i].Value.ToString();
                array[i].pages = dataGridView1[6, i].Value.ToString();
                if (dataGridView1[7, i].Value != null)
                    array[i].giveDate = dataGridView1[7, i].Value.ToString();
                if (dataGridView1[8, i].Value != null)
                    array[i].returnDate = dataGridView1[8, i].Value.ToString();
                if (dataGridView1[9, i].Value != null)
                    array[i].whoTook = dataGridView1[9, i].Value.ToString();
            }
            return array;
        }

        private void Search(string what)
        {
            BooksClass[] array = new BooksClass[dataGridView1.RowCount - 1];
            ReadGridToArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].caption.ToLower().Contains(what))
                    dataGridView1[0, i].Style.BackColor = Color.Green;
                if (array[i].author.ToLower().Contains(what))
                    dataGridView1[1, i].Style.BackColor = Color.Green;
                if (array[i].isbn.ToLower().Contains(what))
                    dataGridView1[2, i].Style.BackColor = Color.Green;
                if (array[i].bbk.ToLower().Contains(what))
                    dataGridView1[3, i].Style.BackColor = Color.Green;
                if (array[i].pblshngCompn.ToLower().Contains(what))
                    dataGridView1[4, i].Style.BackColor = Color.Green;
                if (array[i].pblshYear.ToLower().Contains(what))
                    dataGridView1[5, i].Style.BackColor = Color.Green;
                if (array[i].giveDate.ToLower().Contains(what))
                    dataGridView1[7, i].Style.BackColor = Color.Green;
                if (array[i].returnDate.ToLower().Contains(what))
                    dataGridView1[8, i].Style.BackColor = Color.Green;
                if (array[i].whoTook.ToLower().Contains(what))
                    dataGridView1[9, i].Style.BackColor = Color.Green;
            }
        }

        private void ClearColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Style.BackColor = Color.White;
                }
            }
        }
    }
}
