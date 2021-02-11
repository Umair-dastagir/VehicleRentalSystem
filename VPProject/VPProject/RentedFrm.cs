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
    public partial class RenteFrm : Form
    {
        SqlConnection con = new SqlConnection();
        public RenteFrm()
        {
            InitializeComponent();
        }

        private void RenteFrm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_rented", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgRented.DataSource = dt;
        }

        private void btnRntdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
