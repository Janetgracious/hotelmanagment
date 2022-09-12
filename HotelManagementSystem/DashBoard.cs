using HotelManagementSystem.hotel;
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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //instance of the employee class
            Employee hms = new Employee()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Guest hms = new Guest()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category hms = new Category()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            Room hms = new Room()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reservation hms = new Reservation()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report hms = new Report()
            {
                //set the properties to false
                TopLevel = false,
                //set the border of the form to none
                FormBorderStyle = FormBorderStyle.None,
                //fill the workplace with the forms
                Dock = DockStyle.Fill
            };
            //add instance variable to the panel
            workPlacePanel.Controls.Add(hms);
            workPlacePanel.Tag = hms;
            //bring the forms to the workplacepanel when the button is clicked
            hms.BringToFront();
            //display the forms
            hms.Show();
        }
    }
}
