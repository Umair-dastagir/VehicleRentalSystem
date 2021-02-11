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
    public partial class AddvehFrm : Form
    {
        string path = "";
        public AddvehFrm()
        {
            InitializeComponent();
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con2.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into [tbl_cars] values ('"+txtMake.Text+"', '"+txtModel.Text+"','"+txtColor.Text+"', '"+txtReg.Text+"','"+txtSc.Text+"' , '"+txtAddamount.Text+"' , '"+combAvailable.Text+"' , '"+path+"');", con2);
            cmd1.ExecuteNonQuery();
            con2.Close();
            MessageBox.Show("Vehicle Successfully Added");
            txtMake.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtColor.Text = String.Empty;
            txtReg.Text = String.Empty;
            txtSc.Text = String.Empty;
            txtAddamount.Text = String.Empty;
            combAvailable.Text = String.Empty;
            path = String.Empty;
            txtMake.Focus();
        }

        private void btnExitAddveh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetFullPath(openFileDialog1.FileName);
            }
        }
    }
}
