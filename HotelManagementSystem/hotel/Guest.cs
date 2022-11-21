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
    public partial class Guest : Form
    {
        Database DB = new Database();
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateGuest();
            ReadData();
        }

        private void CreateGuest()
        {
            //validation
            if (txtName.Text == "" || txtAddress.Text == "" || txtTelephone.Text == "")
            {
                MessageBox.Show("Fill in fields");
                return;
            }

            DB.Conn.Open();
            //Create
            string sql = "INSERT INTO customers (cus_Name, cus_Address, cus_Telephone) VALUES ('" + txtName.Text+ "', '"+txtAddress.Text+ "', '"+txtTelephone.Text+"')";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();

            DB.Conn.Close(); //close connection

            MessageBox.Show("Submitted");

            txtName.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text = "";
        }

        //read
        //retrieve all information on data table
        private void ReadData()
        {
            string sql = "SELECT * FROM customers";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridGuest.DataSource = dt;

        }

        private void dataGridGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridGuest.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = dataGridGuest.Rows[e.RowIndex].Cells[0].Value.ToString(); //assign the value of the ID of the selected datagrid to the ID textbox
                txtName.Text = dataGridGuest.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridGuest.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelephone.Text = dataGridGuest.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void updateGuest()
        {
            DB.Conn.Open();

            string sql = "UPDATE  customers SET cus_Name = '" + txtName.Text + "', cus_Address = '" + txtAddress.Text + "', cus_Telephone ='" + txtTelephone.Text + "' WHERE cus_id = '" + txtID.Text + "'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Updated");

            DB.Conn.Close();

            txtName.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text = "";

            DB.Conn.Close(); //close connection

            ReadData();
        }

        private void deleteGuest()
        {
            DB.Conn.Open();

            string sql = "DELETE FROM customers WHERE cus_id = '" + txtID.Text + "'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Deleted");

            DB.Conn.Close();

            txtName.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text = "";

            DB.Conn.Close(); //close connection

            ReadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateGuest();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteGuest();
        }
    }
}
