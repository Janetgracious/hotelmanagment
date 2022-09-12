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
    public partial class Report : Form
    {
        Database DB = new Database();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        //calc the total
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;

            for (int i = 0; i < dataGridReport.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridReport.Rows[i].Cells[1].Value);
            }

            //this format the numbers to make it easier to read
            txtTotal.Text = String.Format("₵ {0:n}", sum);
        }

        private void rdMonthly_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "SELECT res_number, total, created_at FROM bill WHERE MONTH(created_at) = MONTH(NOW()) ORDER BY created_at DESC";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridReport.DataSource = dt;

            calcTotalAmount(); //calc total
        }

        private void rdDialy_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "SELECT res_number, total, created_at FROM bill WHERE date(created_at) = curdate() ORDER BY created_at DESC";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridReport.DataSource = dt;

            calcTotalAmount(); //calc total

        }

        private void rdWeekly_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "SELECT res_number, total, created_at FROM bill WHERE WEEK(created_at) = WEEK(NOW()) ORDER BY created_at DESC";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridReport.DataSource = dt;

            calcTotalAmount(); //calc total
        }

        private void rdAnnual_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "SELECT res_number, total, created_at FROM bill WHERE YEAR(created_at) = year(curdate()) ORDER BY created_at DESC";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, DB.Conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
            dataGridReport.DataSource = dt;

            calcTotalAmount(); //calc total
        }
    }
}
