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
    public partial class AdminFrmNew : Form
    {
        SqlConnection con = new SqlConnection();
        public AdminFrmNew()
        {
            InitializeComponent();
        }

        private void AdminFrmNew_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [tbl_user] where Username = '" + TxtNaam.Text + "' and Password = '" + TxtCode.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Hello " + TxtNaam.Text + "!", "Welcome", MessageBoxButtons.OK ,MessageBoxIcon.None);
                string id = TxtNaam.Text;
                new FrmMainNew(id).ShowDialog();
                this.Hide();
                Close();
            }
            else if (TxtNaam.Text == "" || TxtCode.Text == "")
            {
                MessageBox.Show("Please fill the empty boxes.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("User Denied", "Sorry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                TxtNaam.Text = String.Empty;
                TxtCode.Text = String.Empty;
                TxtNaam.Focus();
            }

            con.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
