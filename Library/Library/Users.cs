using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Library
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            BinaryDeserialization();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinarySerialization();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewUser NewUserForm = new NewUser(this);
            NewUserForm.Show();
        }

        public void BinarySerialization()
        {
            UsersClass[] tableUsers = new UsersClass[dataGridView1.Rows.Count - 1];
            for (int i = 0; i < tableUsers.Length; i++)
            {
                tableUsers[i] = new UsersClass();
                tableUsers[i].username = dataGridView1[0, i].Value.ToString();
                tableUsers[i].surname = dataGridView1[1, i].Value.ToString();
                tableUsers[i].department = dataGridView1[2, i].Value.ToString();
                tableUsers[i].group = dataGridView1[3, i].Value.ToString();
                tableUsers[i].address = dataGridView1[4, i].Value.ToString();
                tableUsers[i].phone = dataGridView1[5, i].Value.ToString();
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("UsersInfo.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tableUsers);
                fs.Close();
            }
        }

        public void BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("UsersInfo.txt", FileMode.OpenOrCreate))
            {
                UsersClass[] tableUsers = (UsersClass[])formatter.Deserialize(fs);
                if (tableUsers != null)
                {
                    foreach (UsersClass user in tableUsers)
                    {
                        dataGridView1.Rows.Add(user.username, user.surname, user.department, user.group, user.address, user.phone);
                    }
                }
                fs.Close();
            }
        }
    }
}
