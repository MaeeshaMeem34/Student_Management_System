using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            //Image image1 = Image.FromFile("../../Resources/username.png");
            //pictureBox1.Image = image1;

            


        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass", db.GetConnection);
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

       
    }
}
