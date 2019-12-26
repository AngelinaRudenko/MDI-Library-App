using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Books booksForm;
        private void BooksAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (booksForm == null)
            {
                booksForm = new Books(usersForm);
                booksForm.MdiParent = this;
                booksForm.FormClosed += BooksForm_FormClosed;
                booksForm.Show();
                LayoutMdi(MdiLayout.TileVertical);
            }
            else
                booksForm.Activate();
        }

        private void BooksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            booksForm = null;
            //throw new NotImplementedException();
        }

        Users usersForm;
        private void UsersAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersForm == null)
            {
                usersForm = new Users(booksForm);
                usersForm.MdiParent = this;
                usersForm.FormClosed += UsersForm_FormClosed;
                usersForm.Show();
                LayoutMdi(MdiLayout.TileVertical);
            }
            else
                usersForm.Activate();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            usersForm = null;
            //throw new NotImplementedException();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void DebtsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDebts();
        }

        private void ShowDebts()
        {
            if (booksForm != null)
            {
                for (int i = 0; i < booksForm.dataGridView1.RowCount - 1; i++)
                {
                    if (booksForm.dataGridView1[8, i].Value.ToString() != "-" && Convert.ToDateTime(booksForm.dataGridView1[8, i].Value) < DateTime.Now)
                    {
                        for (int j = 0; j < booksForm.dataGridView1.ColumnCount; j++)
                        {
                            booksForm.dataGridView1[j, i].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void DebtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDebtors();
        }

        private void ShowDebtors()
        {
            if (booksForm != null && usersForm != null)
            {
                for (int i = 0; i < booksForm.dataGridView1.RowCount - 1; i++)
                {
                    if (booksForm.dataGridView1[8, i].Value.ToString() != "-" && Convert.ToDateTime(booksForm.dataGridView1[8, i].Value) < DateTime.Now)
                    {
                        for (int j = 0; j < usersForm.dataGridView1.RowCount - 1; j++)
                        {
                            if (booksForm.dataGridView1[9, i].Value.ToString() == usersForm.dataGridView1[0, j].Value.ToString() + " " + usersForm.dataGridView1[1, j].Value.ToString())
                            {
                                for (int k = 0; k < usersForm.dataGridView1.ColumnCount; k++)
                                {
                                    usersForm.dataGridView1[k, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
