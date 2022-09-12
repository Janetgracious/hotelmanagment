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

namespace HotelManagementSystem.hotel
{
    public partial class Employee : Form
    {
        Database DB = new Database();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            ReadData();
        }

        private void CreateEmployee()
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtPassword.Text == "" || dateDOB.Text == "" || txtUsername.Text == "" || txtTelephone.Text == "" )
            {
                MessageBox.Show("Fill in fields");
                return;
            }

            DB.Conn.Open();
            //DB.Command.CommandText = "SELECT * FROM employees WHERE username = '"+ txtUsername.Text + "' AND password = '"+txtpassword.Text+"'";
            //DB.Command.CommandType = CommandType.Text;
            //DB.Reader = DB.Command.ExecuteReader();

            //Create
            string sql = "INSERT INTO employees (emp_Name, emp_DOB, emp_Address, emp_Telephone, username, password) VALUES ('"+txtUsername.Text+ "', '"+dateDOB.Text+ "', '"+txtAddress.Text+ "', '"+txtTelephone.Text+ "', '"+txtUsername.Text+ "', '"+txtPassword.Text+"')";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Submitted");

            txtName.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtTelephone.Text = "";
            txtUsername.Text = "";
            dateDOB.Text = "";    
        }
        //read
        //retrieve all information on data table
        private void ReadData()
        {
            string sql = "SELECT * FROM employees";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridEmployee.DataSource = dt;

        }

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (dataGridEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = dataGridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString(); //assign the value of the ID of the selected datagrid to the ID textbox
                txtName.Text = dataGridEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                //dateDOB.Value = dataGridEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dataGridEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelephone.Text = dataGridEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUsername.Text = dataGridEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPassword.Text = dataGridEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void updateEmployee()
        {
            DB.Conn.Open();

            string sql = "UPDATE  employees SET emp_Name = '"+txtName.Text+ "', emp_Address = '"+txtAddress.Text+ "', emp_DOB ='"+dateDOB.Text+ "', emp_Telephone ='"+txtTelephone.Text+ "', username = '"+txtUsername.Text+ "', password = '"+txtPassword.Text+ "' WHERE emp_id = '"+txtID.Text+"'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Updated");

            DB.Conn.Close();

            txtName.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtTelephone.Text = "";
            txtUsername.Text = "";
            dateDOB.Text = "";

            ReadData();
        }

        private void deleteEmployee()
        {
            DB.Conn.Open();

            string sql = "DELETE FROM employees WHERE emp_id = '"+txtID.Text+"'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Deleted");

            DB.Conn.Close();

            txtName.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtTelephone.Text = "";
            txtUsername.Text = "";
            dateDOB.Text = "";

            ReadData();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteEmployee();
        }
    }
}
