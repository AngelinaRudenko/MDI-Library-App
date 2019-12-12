using System;
using System.Windows.Forms;

namespace Library
{
    public partial class NewBook : Form
    {
        Books BooksForm;

        public NewBook(Books books)
        {
            InitializeComponent();
            BooksForm = books;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BooksForm.dataGridView1.Rows.Add(Convert.ToString(textBoxName.Text), Convert.ToString(textBoxSurname.Text), Convert.ToString(textBoxDepartment.Text), Convert.ToString(textBoxGroup.Text), Convert.ToString(textBoxAddress.Text), Convert.ToString(textBoxPhone.Text), Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToString(textBox3.Text));
            BooksForm.TableSort(BooksForm.comboBoxSort.SelectedItem.ToString());
        }
    }
}
