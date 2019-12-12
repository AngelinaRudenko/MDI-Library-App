using System;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewBook NewBookForm = new NewBook(this);
            NewBookForm.Show();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            comboBoxSort.SelectedItem = "Название";
            BinaryDeserialization();
            TableSort(comboBoxSort.SelectedItem.ToString());
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinarySerialization();
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableSort(comboBoxSort.SelectedItem.ToString());
        }

        public void BinarySerialization()
        {
            BooksClass[] tableBooks = new BooksClass[dataGridView1.Rows.Count - 1];
            ReadGridToArray(tableBooks);    //fill the array with table values
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BooksInfo.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tableBooks);
                fs.Close();
            }
        }

        public void BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BooksInfo.txt", FileMode.OpenOrCreate))
            {
                BooksClass[] tableBooks = (BooksClass[])formatter.Deserialize(fs);
                if (tableBooks != null)
                {
                    foreach (BooksClass book in tableBooks)
                    {
                        dataGridView1.Rows.Add(book.caption, book.author, book.isbn, book.bbk, book.pblshngCompn, book.pblshYear, book.pages, book.giveDate, book.returnDate);
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
                dataGridView1.Rows.Add(book.caption, book.author, book.isbn, book.bbk, book.pblshngCompn, book.pblshYear, book.pages, book.giveDate, book.returnDate);
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
                array[i].giveDate = dataGridView1[7, i].Value.ToString();
                array[i].returnDate = dataGridView1[8, i].Value.ToString();
            }
            return array;
        }

        public void Search(string what)
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
            }
        }

        private void ClearColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Style.BackColor = Color.White;
                dataGridView1[1, i].Style.BackColor = Color.White;
                dataGridView1[2, i].Style.BackColor = Color.White;
                dataGridView1[3, i].Style.BackColor = Color.White;
                dataGridView1[4, i].Style.BackColor = Color.White;
                dataGridView1[5, i].Style.BackColor = Color.White;
                dataGridView1[7, i].Style.BackColor = Color.White;
                dataGridView1[8, i].Style.BackColor = Color.White;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search(textBoxSearch.Text.ToLower());
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearColor();
        }
    }
}
