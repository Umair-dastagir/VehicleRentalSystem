using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VPProject
{
    public partial class FrmCars : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmCars()
        {
            InitializeComponent();
        }

        void Fetch()
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Make, Regno, Availibility from tbl_cars", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgVehicles.DataSource = dt;
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
            Fetch();   
        }


        private void btnExitCars_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgVehicles_SelectionChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            foreach(DataGridViewRow row in dgVehicles.Rows)
            {
                if (row.Selected == true)
                {
                    string id = row.Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from tbl_cars where Make = '" + id + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtCar.Text = dr["Image"].ToString();
                    }
                }
                con.Close();
                pictureBox1.ImageLocation = txtCar.Text;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Make, Regno from tbl_cars where Make like '"+txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgVehicles.DataSource = dt;
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgVehicles.Rows)
            {
                if (row.Selected == true)
                {
                    string car = row.Cells[0].Value.ToString();
                    string status = row.Cells[2].Value.ToString();
                    if(status == "Not Available")
                    {
                        MessageBox.Show("Selected Vehicle Not Available.", "We Are Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        new RentFrm(car).ShowDialog();
                    }
                    Fetch();

                }
            }
            
            
        }
    }
}
