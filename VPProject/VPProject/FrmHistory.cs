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
    public partial class FrmHistory : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmHistory()
        {
            InitializeComponent();
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Name, Cnic, Number, Address, Car, Registration as 'Plate', Bookingdate as 'Booking' , Returndate as 'Return' from tbl_clients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgHistory.DataSource = dt;

        }

        private void btnExHistory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select Name, Cnic, Number, Address, Car, Registration as 'Plate', Bookingdate as 'Booking' , Returndate as 'Return' from tbl_clients where Name like '" + txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgHistory.DataSource = dt;
        }
    }
}
