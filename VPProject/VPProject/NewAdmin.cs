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
    public partial class NewAdmin : Form
    {
        SqlConnection con = new SqlConnection();
        string path = "";

        public NewAdmin()
        {
            InitializeComponent();
        }


        private void btnAddadmin_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();

            if (txtUadmin.Text == "" || txtPadmin.Text == "" || txtPconfirm.Text == "")
            {
                MessageBox.Show("Fill all of the fields.");
            }

            else if (txtPadmin.Text == txtPconfirm.Text)
            {
                SqlCommand cmd = new SqlCommand("Insert into [tbl_user] values ('" + txtUadmin.Text + "', '" + txtPadmin.Text + "' , '"+txtPhone.Text+"' , '"+path+"');", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Successfully Added");
                txtUadmin.Text = String.Empty;
                txtPadmin.Text = String.Empty;
                txtPconfirm.Text = String.Empty;
                txtPhone.Text = String.Empty;
                path = String.Empty;
                txtUadmin.Focus();
            }
           
            else
            {
                MessageBox.Show("Passwords doesn't match");
            }
            con.Close();
           
        }

        private void btnExitAddadmin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(openFileDialog1.FileName);
            }
        }
    }
}
