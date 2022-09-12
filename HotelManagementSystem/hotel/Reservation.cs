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
    public partial class Reservation : Form
    {
        Database DB = new Database();
        public string id { get; set; }
        public string category { get; set; }
        public string desc { get; set; }
        public string price { get; set; }

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            getGuest();
            getRoom();
        }


        private void getGuest()
        {
            string sql = "SELECT * FROM customers";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            cmbGuest.DataSource = dt;
            cmbGuest.DisplayMember = "cus_name";
            cmbGuest.ValueMember = "cus_id";
        }

        private void getRoom()
        {
            string sql = "SELECT * FROM room WHERE room_status = 'Available'";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            cmbRoom.DataSource = dt;
            cmbRoom.DisplayMember = "room_category";
            cmbRoom.ValueMember = "room_id";
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbRoom.SelectedValue.ToString());
            createCart();
        }

        private void getRoomById(string id)
        {
            DB.Conn.Open();
            string sql = "SELECT * FROM room WHERE room_id = '"+id+"' ";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Reader = DB.Command.ExecuteReader();

            if (DB.Reader.Read() == true)
            {

               // MessageBox.Show(DB.Reader.GetString("room_description"));
               id =  DB.Reader.GetString("room_id");
               category = DB.Reader.GetString("room_category");
               desc = DB.Reader.GetString("room_description");
               price = DB.Reader.GetString("category_price");



                DB.Conn.Close();
            }
        }

        //the logic part
        private void createCart()
        {


            //call the random class
            Random rand = new Random();
            string reservationID = rand.Next(10, 100).ToString(); //generate random number
            string roomId = cmbRoom.SelectedValue.ToString(); // get the selected room roomID

            int num = 0;

            getRoomById(roomId);
            MessageBox.Show(desc);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridBooking);
            newRow.Cells[0].Value = id;
            newRow.Cells[1].Value = category;
            newRow.Cells[2].Value = desc;
            newRow.Cells[3].Value = price;
            dataGridBooking.Rows.Add(newRow);



        }
    }
}
