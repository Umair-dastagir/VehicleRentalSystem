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
using System.IO;

namespace VPProject
{
    public partial class UpdateFrm : Form
    {
        SqlConnection con = new SqlConnection();
        string Fid;
        string path = "";
        public UpdateFrm(string id)
        {
            InitializeComponent();
            Fid = id;
        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [tbl_cars] where Make = '"+Fid+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMakeA.Text = dr["Make"].ToString();
                txtModelA.Text = dr["Model"].ToString();
                txtColorA.Text = dr["Color"].ToString();
                txtRegA.Text = dr["Regno"].ToString();
                txtScA.Text = dr["Seatingcapacity"].ToString();
                txtAddamountA.Text = dr["Amount"].ToString();
                comboBox1.Text = dr["Availibility"].ToString();
                txtImage.Text = dr["Image"].ToString();
            }
            con.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("Update tbl_cars Set Make = '" + txtMakeA.Text + "' , Model = '" + txtModelA.Text + "' , Color = '" + txtColorA.Text + "' , Regno = '" + txtRegA.Text + "' , Seatingcapacity = '" + txtScA.Text + "' , Amount = '" + txtAddamountA.Text + "' , Availibility = '" + comboBox1.Text + "' , Image = '"+txtImage.Text+"' where Make = '" + Fid + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been successfully updated");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCnclUp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(openFileDialog1.FileName);
                txtImage.Text = path;
            }
        }
    }
}
