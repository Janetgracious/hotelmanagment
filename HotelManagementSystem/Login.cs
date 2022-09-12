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

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        Database DB = new Database();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            Loginp();
        }

        private void Loginp()
        {

            try
            {
                if (txtUsername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Fill all field");
                    return;
                }

                DB.Conn.Open();
                //DB.Command.CommandText = "SELECT * FROM employees WHERE username = '"+ txtUsername.Text + "' AND password = '"+txtpassword.Text+"'";
                //DB.Command.CommandType = CommandType.Text;
                //DB.Reader = DB.Command.ExecuteReader();

                string sql = "SELECT * FROM employees WHERE username = '" + txtUsername.Text + "' AND password = '" + txtpassword.Text + "'";
                DB.Command = new MySqlCommand(sql, DB.Conn);
                DB.Reader = DB.Command.ExecuteReader();

                if (DB.Reader.Read() == true)
                {
                    // MessageBox.Show(DB.Reader.GetString("password"));

                    this.Hide();

                    DashBoard users = new DashBoard();
                    users.Show();

                    DB.Conn.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password or Username");
                }

            }finally
            {
                DB.Conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
