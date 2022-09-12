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
        public string roomID { get; set; }
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
            generateReservationID();
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
        

        //delete from cart
        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeCell();   
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
               roomID =  DB.Reader.GetString("room_id");
               category = DB.Reader.GetString("room_category");
               desc = DB.Reader.GetString("room_description");
               price = DB.Reader.GetString("category_price");



                DB.Conn.Close();
            }
        }

        //generate reservation id
        private void generateReservationID()
        {
            //call the random class
            Random rand = new Random();
            txtID.Text = rand.Next(1000, 10000).ToString(); //generate random number
        }

        //the logic part
        private void createCart()
        {
            
            string roomId = cmbRoom.SelectedValue.ToString(); // get the selected room roomID

            int num = 0;

            getRoomById(roomId); //call this method to query the database to retrieve the select room data

            //add each selected room data to the cart
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridBooking);
            newRow.Cells[0].Value = roomID;
            newRow.Cells[1].Value = category;
            newRow.Cells[2].Value = desc;
            newRow.Cells[3].Value = price;
            dataGridBooking.Rows.Add(newRow);

            calcTotalAmount();

        }

        //remove from the cart
        private void removeCell()
        {
            try
            {
                //check if the row of an item in the cart is selcted
                if (dataGridBooking.SelectedRows.Count > 0)
                {
                    //loop through the cart
                    foreach (DataGridViewRow row in dataGridBooking.Rows)
                    {
                        //if the selected row is true
                        if (row.Selected == true)
                        {
                            //substract the price from the Total textbox
                            txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(row.Cells["category_price"].Value)).ToString();

                            //remove item from the cart
                            dataGridBooking.Rows.RemoveAt(row.Index);
                            dataGridBooking.Refresh();
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Remove: Something went wrong");
            }

        }


        //calculate for total
        private void calcTotalAmount()
        {
            //calculate the datagridview price
            double sum = 0;


            for (int i = 0; i < dataGridBooking.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridBooking.Rows[i].Cells[3].Value);
            }

            //set the value to the total textbox
            txtTotal.Text = sum.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbRoom.SelectedValue.ToString());
            createCart();
        }

        //insert into bill
        private void insertBillDB()
        {

            if (txtTotal.Text == "")
            {
                MessageBox.Show("Select a Room");

                return;
            }

            DB.Conn.Open();

            //Create
            string sql = "INSERT INTO bill (res_number, total) VALUES ('" + txtID.Text + "', '" + txtTotal.Text + "')";
            DB.Command = new MySqlCommand(sql, DB.Conn);
            DB.Command.ExecuteNonQuery();

            //display success message
            MessageBox.Show("completed");

        }

        //insert into reservations
        private void insertReservations()
        {
            string custId = cmbGuest.SelectedValue.ToString(); //get the customer id

            foreach (DataGridViewRow row in dataGridBooking.Rows)
            {
                string roomID = Convert.ToString(row.Cells["room_id"].Value);

                DB.Conn.Open();

                //Create
                string sql = "INSERT INTO reservations (res_number, res_arrival, res_departure, cus_id, room_id) VALUES ('" + txtID.Text + "', '" + dTpArrival.Text + "', '" + dTpDeparture.Text + "', '" + custId + "', '" + roomID + "')";
                DB.Command = new MySqlCommand(sql, DB.Conn);
                DB.Command.ExecuteNonQuery();
                DB.Conn.Close();

            }
        }

        //clear the cart
        //CLEAR CART
        private void clearDataGridTable()
        {
            dataGridBooking.DataSource = null;
            dataGridBooking.Rows.Clear();

        }


        private void fireTheBook()
        {
            if (dataGridBooking.Rows.Count == 0 || dataGridBooking == null)
            {
                MessageBox.Show("Select a room");

                return;
            }

            if (txtTotal.Text == "0" || txtTotal.Text == "")
            {
                MessageBox.Show("Subtotal is 0");
                return;
            }




            DialogResult confirm = MessageBox.Show("Do you want to make reservation? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                //insert into reservation in the db
                insertReservations();

                //insert the bill  in the db
                insertBillDB();

                //clear the cart
                clearDataGridTable();

                generateReservationID(); //generate new code


            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            fireTheBook();
        }
    }
}
