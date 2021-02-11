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
    public partial class AdminFrm : Form
    {
        SqlConnection con = new SqlConnection();
        public AdminFrm()
        {
            InitializeComponent();
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from [tbl_clients];",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgAdmin.DataSource = dt;
        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            new AddvehFrm().ShowDialog();
            
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            new RenteFrm().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new NewAdmin().ShowDialog();

        }

        private void btnExitadmin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAvVehadmin_Click(object sender, EventArgs e)
        {
            new AvailableFrm().ShowDialog();
        }
    }
}
