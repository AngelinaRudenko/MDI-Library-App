using System;
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
                booksForm = new Books();
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
                usersForm = new Users();
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
    }
}
