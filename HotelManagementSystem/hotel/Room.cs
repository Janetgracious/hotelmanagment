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
    public partial class Room : Form
    {
        Database DB = new Database();
        public Room()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateRoom();
            ReadData();
        }

        private void CreateRoom()
        {
            //validation
            if (cmbRoomCat.Text?.Length == 0 || txtPrice.Text?.Length == 0 || cmbRoomStatus.Text?.Length == 0)
            {
                MessageBox.Show("Fill in fields");
                return;
            }

            DB.Conn.Open();
            //Create
            string sql = "INSERT INTO room (room_category, room_description, category_price, room_status) VALUES ('" + cmbRoomCat.Text + "', '" + rtbDescription.Text + "', '" + txtPrice.Text + "', '"+cmbRoomStatus+"')";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();

            DB.Conn.Close(); //close connection
            MessageBox.Show("Submitted");

            cmbRoomStatus.Text = "";
            rtbDescription.Text = "";
            txtPrice.Text = "";
            cmbRoomCat.Text = "";
        }

        //read
        //retrieve all information on data table
        private void ReadData()
        {
            string sql = "SELECT * FROM room";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridRooms.DataSource = dt;

        }

        private void dataGridRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (dataGridRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = dataGridRooms.Rows[e.RowIndex].Cells[0].Value.ToString(); //assign the value of the ID of the selected datagrid to the ID textbox
                cmbRoomCat.Text = dataGridRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtbDescription.Text = dataGridRooms.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dataGridRooms.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbRoomStatus.Text = dataGridRooms.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void updateRoom()
        {
            DB.Conn.Open();

            string sql = "UPDATE  room SET room_category = '" + cmbRoomCat.Text + "', room_description = '" + rtbDescription.Text + "', category_price ='" + txtPrice.Text + "', room_status ='" + cmbRoomStatus.Text + "' WHERE room_id = '" + txtID.Text + "'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Updated");

            DB.Conn.Close();

            cmbRoomStatus.Text = "";
            rtbDescription.Text = "";
            txtPrice.Text = "";
            cmbRoomCat.Text = "";

            ReadData();
        }

        private void deleteRoom()
        {
            DB.Conn.Open();

            string sql = "DELETE FROM room WHERE room_id = '" + txtID.Text + "'";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();
            MessageBox.Show("Deleted");

            DB.Conn.Close();

            cmbRoomStatus.Text = "";
            rtbDescription.Text = "";
            txtPrice.Text = "";
            cmbRoomCat.Text = "";

            ReadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateRoom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRoom();
        }

        
    }
}
