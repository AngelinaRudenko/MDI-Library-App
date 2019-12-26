using System;
using System.Windows.Forms;

namespace Library
{
    public partial class NewUser : Form
    {
        Users UsersForm;
        Books booksForm;
        Boolean flag;
        public NewUser(Users users, Books booksForm, bool flag)
        {
            UsersForm = users;
            this.booksForm = booksForm;
            this.flag = flag;
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (flag != true)
            {
                if (IsGridEmpty() || textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty || textBoxDepartment.Text == string.Empty || textBoxGroup.Text == string.Empty || textBoxAddress.Text == string.Empty || textBoxPhone.Text == string.Empty)
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    UsersForm.dataGridView1.Rows.Add(Convert.ToString(textBoxName.Text), Convert.ToString(textBoxSurname.Text), Convert.ToString(textBoxDepartment.Text), Convert.ToString(textBoxGroup.Text), Convert.ToString(textBoxAddress.Text), Convert.ToString(textBoxPhone.Text));
                    UsersForm.TableSort(UsersForm.toolStripComboBoxSort.SelectedItem.ToString());
                    SaveDatesAndBooksUsers();
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                if (IsGridEmpty() || textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty || textBoxDepartment.Text == string.Empty || textBoxGroup.Text == string.Empty || textBoxAddress.Text == string.Empty || textBoxPhone.Text == string.Empty)
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    UsersForm.dataGridView1.Rows[UsersForm.dataGridView1.CurrentCell.RowIndex].SetValues(textBoxName.Text, textBoxSurname.Text, textBoxDepartment.Text, textBoxGroup.Text, textBoxAddress.Text, textBoxPhone.Text);
                    SaveDatesAndBooksUsers();
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsersForm.Enabled = true;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < booksForm.dataGridView1.RowCount - 1; i++)
            {
                if (booksForm.dataGridView1[9, i].Value.ToString() == "-")
                {
                    comboBoxBooks.Items.Add(booksForm.dataGridView1[0, i].Value.ToString());
                }
            }
            if (flag) ShowTakenBooks();

            comboBoxBooks.SelectedItem = comboBoxBooks.Items[0];
        }

        private void ButtonTakeBook_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.Items.Count > 0)
            {
                dataGridView1.Rows.Add(comboBoxBooks.SelectedItem.ToString(), DateTime.Now.ToShortDateString(), DateTime.Now.AddMonths(1).ToShortDateString());
                comboBoxBooks.Items.Remove(comboBoxBooks.SelectedItem);
                if (comboBoxBooks.Items.Count != 0)
                    comboBoxBooks.SelectedItem = comboBoxBooks.Items[0];
            }
        }

        private bool IsGridEmpty()
        {
            for (int i = 0; i<dataGridView1.RowCount-1;i++)
            {
                for(int j = 0; j<dataGridView1.ColumnCount;j++)
                {
                    if (dataGridView1[j, i].Value.ToString() == "")
                        return true;
                }
            }
            return false;
        }

        private void SaveDatesAndBooksUsers()
        {
            string selectedUser = UsersForm.dataGridView1[0, UsersForm.dataGridView1.CurrentCell.RowIndex].Value.ToString() + " " + UsersForm.dataGridView1[1, UsersForm.dataGridView1.CurrentCell.RowIndex].Value.ToString();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (booksForm != null)
                {
                    for (int j = 0; j < booksForm.dataGridView1.RowCount - 1; j++)
                    {
                        if (booksForm.dataGridView1[0, j].Value.ToString() == dataGridView1[0, i].Value.ToString())
                        {
                            booksForm.dataGridView1[7, j].Value = dataGridView1[1, i].Value.ToString();
                            booksForm.dataGridView1[8, j].Value = dataGridView1[2, i].Value.ToString();
                            booksForm.dataGridView1[9, j].Value = selectedUser;
                            break;
                        }
                    }
                }
            }
        }

        private void ShowTakenBooks()
        {
            string selectedUser = UsersForm.dataGridView1[0, UsersForm.dataGridView1.CurrentCell.RowIndex].Value.ToString() + " " + UsersForm.dataGridView1[1, UsersForm.dataGridView1.CurrentCell.RowIndex].Value.ToString();
            for (int i = 0; i < booksForm.dataGridView1.RowCount - 1; i++)
            {
                if (booksForm.dataGridView1[9, i].Value.ToString() == selectedUser)
                {
                    dataGridView1.Rows.Add(booksForm.dataGridView1[0, i].Value.ToString(), booksForm.dataGridView1[7, i].Value.ToString(), booksForm.dataGridView1[8, i].Value.ToString());
                }
            }
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.RowIndex != dataGridView1.RowCount)
                {
                    for (int i = 0; i < booksForm.dataGridView1.RowCount - 1; i++)
                    {
                        if (booksForm.dataGridView1[0, i].Value == dataGridView1[0, dataGridView1.CurrentRow.Index].Value)
                        {
                            booksForm.dataGridView1[7, i].Value = "-";
                            booksForm.dataGridView1[8, i].Value = "-";
                            booksForm.dataGridView1[9, i].Value = "-";
                        }
                    }
                    int a = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
                }
            }
            catch { }
        }
    }
}
