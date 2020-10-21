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

        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            checkDb(textBoxUsername.Text, textBoxPassword.Text);
       }

        public bool checkDb(string name, string pass)
        {
            DatabaseConnection db = new DatabaseConnection();


            if (name == "" || pass == "")
            {
                throw new NullReferenceException("Field cannot be empty");
            }


            string sql = "SELECT * FROM user WHERE username='" + name.Trim() + "' AND password='" + pass.Trim() + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.GetConnection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.DialogResult = DialogResult.OK;

                return true;
            }

        }




    }
}
