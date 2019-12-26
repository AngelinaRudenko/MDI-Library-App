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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (buttonAdd.Text == "Добавить")
            {
                if (textBoxTitle.Text == string.Empty || textBoxAuthor.Text == string.Empty || textBoxISBN.Text == string.Empty || textBoxBBK.Text == string.Empty || textBoxPblshCmpn.Text == string.Empty || textBoxPblshYear.Text == string.Empty || textBoxPages.Text == string.Empty)
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    BooksForm.dataGridView1.Rows.Add(Convert.ToString(textBoxTitle.Text), Convert.ToString(textBoxAuthor.Text), Convert.ToString(textBoxISBN.Text), Convert.ToString(textBoxBBK.Text), Convert.ToString(textBoxPblshCmpn.Text), Convert.ToString(textBoxPblshYear.Text), Convert.ToString(textBoxPages.Text));
                    BooksForm.TableSort(BooksForm.toolStripComboBoxSort.SelectedItem.ToString());
                    this.Close();
                }
            }
            else
            {
                if (textBoxTitle.Text == string.Empty || textBoxAuthor.Text == string.Empty || textBoxISBN.Text == string.Empty || textBoxBBK.Text == string.Empty || textBoxPblshCmpn.Text == string.Empty || textBoxPblshYear.Text == string.Empty || textBoxPages.Text == string.Empty)
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    BooksForm.dataGridView1[0, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxTitle.Text;
                    BooksForm.dataGridView1[1, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxAuthor.Text;
                    BooksForm.dataGridView1[2, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxISBN.Text;
                    BooksForm.dataGridView1[3, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxBBK.Text;
                    BooksForm.dataGridView1[4, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxPblshCmpn.Text;
                    BooksForm.dataGridView1[5, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxPblshYear.Text;
                    BooksForm.dataGridView1[6, BooksForm.dataGridView1.CurrentCell.RowIndex].Value = textBoxPages.Text;
                    this.Close();
                }
            }
        }

        private void NewBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            BooksForm.Enabled = true;
        }
    }
}
