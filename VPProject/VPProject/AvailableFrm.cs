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
    public partial class AvailableFrm : Form
    {
        SqlConnection con = new SqlConnection();
        public AvailableFrm()
        {
            InitializeComponent();
        }

        public void Fetchdata()
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Make, Model, Color, Regno, Seatingcapacity, Amount, Availibility from [tbl_cars]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGavailable.DataSource = dt;
        }
        void Fetchdata2()
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_rented", con);
            DataTable dt = new DataTable("");
            da.Fill(dt);
            dgCarsRented.DataSource = dt;
        }



        private void btnDeletavailable_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExitavailable_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAddavailable_Click(object sender, EventArgs e)
        {
            new AddvehFrm().ShowDialog();
        }

        private void AvailableFrm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Make, Model, Color, Regno, Seatingcapacity, Amount, Availibility from [tbl_cars]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGavailable.DataSource = dt;
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_rented", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgCarsRented.DataSource = dt2;
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Fetchdata();
        }

        private void btnAddavailable_MouseHover(object sender, EventArgs e)
        {
            btnAddavailable.BackColor = Color.Red;
        }

        private void btnAddavailable_MouseLeave(object sender, EventArgs e)
        {
            btnAddavailable.BackColor = Color.Gray;
        }

        private void btnDeletavailable_MouseHover(object sender, EventArgs e)
        {
            btnDeletavailable.BackColor = Color.Red;

        }

        private void btnDeletavailable_MouseLeave(object sender, EventArgs e)
        {
            btnDeletavailable.BackColor = Color.Gray;
        }

        private void btnExitavailable_MouseHover(object sender, EventArgs e)
        {
            btnExitavailable.BackColor = Color.Red;
        }

        private void btnExitavailable_MouseLeave(object sender, EventArgs e)
        {
            btnExitavailable.BackColor = Color.Gray;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateAvail_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSeaGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? Has The Car Returned?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
                foreach (DataGridViewRow row in dgCarsRented.Rows)
                {
                    if (row.Selected == true)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbl_rented where ID = '" + id + "'", con);
                        SqlCommand cmdnew = new SqlCommand("Update tbl_cars set Availibility = 'Available' where Make = '" + txtCarsel.Text + "' ", con);
                        cmd.ExecuteNonQuery();
                        cmdnew.ExecuteNonQuery();
                        con.Close();
                        Fetchdata2();
                        MessageBox.Show("Vehicle Returned To The Compound And Database.");
                    }
                }
            }
        }

        private void btnDeletavailable_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? Delete The Selected Record Permanently?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DGavailable.Rows)
                {
                    if (row.Selected == true)
                    {
                        string id = row.Cells[0].Value.ToString();
                        con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from [tbl_cars] where Make ='" + id + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Fetchdata();
                    }

                }
            }
        }

        private void btnExitavailable_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateAvail_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGavailable.Rows)
            {
                if (row.Selected == true)
                {
                    string id = row.Cells[0].Value.ToString();
                    new FrmAvailibility(id).ShowDialog();
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGavailable.Rows)
            {
                if (row.Selected == true)
                {
                    string id = row.Cells[0].Value.ToString();
                    new UpdateFrm(id).ShowDialog();
                }
            }
        }

        private void btnAddavailable_Click_1(object sender, EventArgs e)
        {
            new AddvehFrm().ShowDialog();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Fetchdata();
        }

        private void dgCarsRented_SelectionChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            try
            {
                foreach (DataGridViewRow row in dgCarsRented.Rows)
                {
                    if (row.Selected == true)
                    {
                        int id1 = Convert.ToInt32(row.Cells[0].Value.ToString());
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("Select * from tbl_rented where ID = '" + id1 + "'", con);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        while (dr1.Read())
                        {
                            txtCarsel.Text = dr1["Car"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddavailable_MouseHover_1(object sender, EventArgs e)
        {
            btnAddavailable.BackColor = Color.Transparent;
        }

        private void btnAddavailable_MouseLeave_1(object sender, EventArgs e)
        {
            btnAddavailable.BackColor = Color.Gray;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Transparent;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Gray;
        }

        private void btnUpdateAvail_MouseHover(object sender, EventArgs e)
        {
            btnUpdateAvail.BackColor = Color.Transparent;
        }

        private void btnUpdateAvail_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateAvail.BackColor = Color.Gray;
        }

        private void btnDeletavailable_MouseHover_1(object sender, EventArgs e)
        {
            btnDeletavailable.BackColor = Color.Transparent;
        }

        private void btnDeletavailable_MouseLeave_1(object sender, EventArgs e)
        {
            btnDeletavailable.BackColor = Color.Gray;
        }

        private void btnExitavailable_MouseHover_1(object sender, EventArgs e)
        {
            btnExitavailable.BackColor = Color.Transparent;
        }

        private void btnExitavailable_MouseLeave_1(object sender, EventArgs e)
        {
            btnExitavailable.BackColor = Color.Gray;
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.Transparent;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.DarkGray;
        }
    }
}
