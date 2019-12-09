using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void УправлениеКнигамиToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void УправлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
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
