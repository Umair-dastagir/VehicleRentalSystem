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
    public partial class FrmAvailibility : Form
    {
        SqlConnection con = new SqlConnection();
        string Fid;
        public FrmAvailibility(string id)
        {
          InitializeComponent();
            Fid = id;
        }

        private void FrmAvailibility_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_cars where Make = '"+Fid+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Text = dr["Availibility"].ToString();
            }
            con.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbl_cars set Availibility = '"+comboBox1.Text+"' where Make ='"+Fid+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Status Updated.");
            Close();
        }

        private void btnCnclAv_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
