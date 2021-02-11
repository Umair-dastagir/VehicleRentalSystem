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
    public partial class FrmMainNew : Form
    {
        SqlConnection con = new SqlConnection();
        string Fid;
        public FrmMainNew(string id)
        {
            InitializeComponent();
            Fid = id;
        }

        private void btnCh_Click(object sender, EventArgs e)
        {
            new FrmHistory().ShowDialog();
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            new AvailableFrm().ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            new RentFrm(null).ShowDialog();
        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            new AddvehFrm().ShowDialog();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            new FrmUsers().ShowDialog();
        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            new FrmCars().ShowDialog();
        }

        private void btnViewRented_Click(object sender, EventArgs e)
        {
            new RenteFrm().ShowDialog();
        }

        private void btnExitMainfrm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
            new AdminFrmNew().ShowDialog();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCh_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCh_MouseLeave(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Make, Model, Color, Regno, Seatingcapacity, Amount, Availibility from [tbl_cars]", con);
            DataTable dt = new DataTable("DT");
            da.Fill(dt);
            dgAllCars.DataSource = dt;
        }

        private void FrmMainNew_Load(object sender, EventArgs e)
        {
            labelName.Text = Fid;
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_user where Username = '"+Fid+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PictureDisplay.ImageLocation = dr["Picture"].ToString();
            }
            con.Close();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new AdminFrmNew().ShowDialog();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFacebook_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/PETcars");
        }

        private void btnTwitter_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/platinum_et");
        }

        private void btnInsta_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/platinumet_official/");
        }
    }
}
