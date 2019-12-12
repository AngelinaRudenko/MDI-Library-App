using System;
using System.IO;
using System.Drawing;
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
            comboBoxSort.SelectedItem = "Имя";
            BinaryDeserialization();
            TableSort(comboBoxSort.SelectedItem.ToString());
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

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableSort(comboBoxSort.SelectedItem.ToString());
        }

        public void BinarySerialization()
        {
            UsersClass[] tableUsers = new UsersClass[dataGridView1.Rows.Count - 1];
            ReadGridToArray(tableUsers);    //fill the array with table values
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

        public void TableSort(string byWhat)
        {
            UsersClass[] tableUsers = new UsersClass[dataGridView1.RowCount - 1];
            ReadGridToArray(tableUsers);    //fill the array with table values    
            switch (byWhat)
            {
                case "Имя":
                    Array.Sort(tableUsers, (x, y) => x.username.CompareTo(y.username));
                    break;
                case "Фамилия":
                    Array.Sort(tableUsers, (x, y) => x.surname.CompareTo(y.surname));
                    break;
                case "Отделение":
                    Array.Sort(tableUsers, (x, y) => x.department.CompareTo(y.department));
                    break;
                case "Группа":
                    Array.Sort(tableUsers, (x, y) => x.group.CompareTo(y.group));
                    break;
            }
            dataGridView1.Rows.Clear();
            foreach (UsersClass user in tableUsers)
            {
                dataGridView1.Rows.Add(user.username, user.surname, user.department, user.group, user.address, user.phone);
            }
        }

        private UsersClass[] ReadGridToArray(UsersClass[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new UsersClass();
                array[i].username = dataGridView1[0, i].Value.ToString();
                array[i].surname = dataGridView1[1, i].Value.ToString();
                array[i].department = dataGridView1[2, i].Value.ToString();
                array[i].group = dataGridView1[3, i].Value.ToString();
                array[i].address = dataGridView1[4, i].Value.ToString();
                array[i].phone = dataGridView1[5, i].Value.ToString();
            }
            return array;
        }

        public void Search(string what)
        {
            UsersClass[] array = new UsersClass[dataGridView1.RowCount - 1];
            ReadGridToArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].username.ToLower().Contains(what))
                    dataGridView1[0, i].Style.BackColor = Color.Green;
                if (array[i].surname.ToLower().Contains(what))
                    dataGridView1[1, i].Style.BackColor = Color.Green;
                if (array[i].department.ToLower().Contains(what))
                    dataGridView1[2, i].Style.BackColor = Color.Green;
                if (array[i].group.ToLower().Contains(what))
                    dataGridView1[3, i].Style.BackColor = Color.Green;
                if (array[i].address.ToLower().Contains(what))
                    dataGridView1[4, i].Style.BackColor = Color.Green;
                if (array[i].phone.ToLower().Contains(what))
                    dataGridView1[5, i].Style.BackColor = Color.Green;
            }
        }

        private void ClearColor()
        {
            for (int i = 0; i<dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Style.BackColor = Color.White;
                dataGridView1[1, i].Style.BackColor = Color.White;
                dataGridView1[2, i].Style.BackColor = Color.White;
                dataGridView1[3, i].Style.BackColor = Color.White;
                dataGridView1[4, i].Style.BackColor = Color.White;
                dataGridView1[5, i].Style.BackColor = Color.White;
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
