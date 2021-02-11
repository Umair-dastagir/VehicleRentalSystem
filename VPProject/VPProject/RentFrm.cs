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
    public partial class RentFrm : Form
    {
        SqlConnection con = new SqlConnection();
        string Fid;

        public RentFrm(string car)
        {
            InitializeComponent();
            Fillcombo();
            Fid = car;
        }

        void Fillcombo()
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand("select * from [tbl_cars] ;", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd1.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["Make"].ToString();
                    comboVeh.Items.Add(sName);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RentFrm_Load(object sender, EventArgs e)
        {
            txtFrom.Text = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
            txtTo.Text = dateTimePicker2.Value.Date.ToString("yyyy/MM/dd");
            comboVeh.Text = Fid;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtAddress.Text == "" || txtAmount.Text == "")
                {
                    MessageBox.Show("Error");
                }
                con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
                con.Open();

                string gender = "";
                if (radMale.Checked == true)
                {
                    gender = "Male";

                }
                else if (radFemale.Checked == true)
                {
                    gender = "Female";
                }
                if (txtStatus.Text == "Available")
                {
                    SqlCommand cmd = new SqlCommand("Insert into [tbl_clients] values('" + txtName.Text + "', '" + txtCnic.Text + "', '" + gender + "','" + txtNumber.Text + "', '" + txtAddress.Text + "', '" + comboVeh.Text + "', '" + txtRegistration.Text + "' , '" + txtFrom.Text + "' , '" + txtTo.Text + "');", con);
                    SqlCommand cmd2 = new SqlCommand("Update tbl_cars set Availibility = 'Not Available' where Make = '" + comboVeh.Text + "'", con);
                    SqlCommand cmd3 = new SqlCommand("Insert into tbl_rented values('" + comboVeh.Text + "', '" + txtRegistration.Text + "' , '" + txtName.Text + "' , '" + txtCnic.Text + "' , '" + txtNumber.Text + "' , '" + txtFrom.Text + "' , '" + txtTo.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thank You For Booking With P.E.T :)" , "Booking Successful");
                    txtName.Text = String.Empty;
                    txtCnic.Text = String.Empty;
                    txtNumber.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    radMale.Checked = false;
                    comboVeh.Text = String.Empty;
                    txtAmount.Text = String.Empty;
                    txtRegistration.Text = String.Empty;
                    txtStatus.Text = String.Empty;
                    txtFrom.Text = String.Empty;
                    txtTo.Text = String.Empty;
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnExitBook_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboVeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlCommand cmd1 = new SqlCommand("select * from [tbl_cars] where Make = '" + comboVeh.Text + "' ;", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd1.ExecuteReader();

                while (myReader.Read())
                {
                    txtAmount.Text = myReader["Amount"].ToString();
                    txtStatus.Text = myReader["Availibility"].ToString();
                    txtRegistration.Text = myReader["Regno"].ToString();
                    if (txtStatus.Text == "Not Available")
                    {
                        MessageBox.Show("This vehicle is not available", "We beg your pardon.");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
            
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = dateTimePicker2.Value.Date.ToString("yyyy/MM/dd");
        }
    }
}
