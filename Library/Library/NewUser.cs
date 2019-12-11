﻿using System;
using System.Windows.Forms;

namespace Library
{
    public partial class NewUser : Form
    {
        Users UsersForm;

        public NewUser(Users users)
        {
            UsersForm = users;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null && textBoxSurname.Text != null && textBoxDepartment.Text != null && textBoxGroup.Text != null && textBoxAddress.Text != null && textBoxPhone.Text != null)
            {
                UsersForm.dataGridView1.Rows.Add(Convert.ToString(textBoxName.Text), Convert.ToString(textBoxSurname.Text), Convert.ToString(textBoxDepartment.Text), Convert.ToString(textBoxGroup.Text), Convert.ToString(textBoxAddress.Text), Convert.ToString(textBoxPhone.Text));
            }
        }
    }
}
