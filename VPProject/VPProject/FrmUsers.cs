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
    public partial class FrmUsers : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmUsers()
        {
            InitializeComponent();
        }
        void fetchData()
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("select Username as 'Name', Phone from tbl_user", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgUsers.DataSource = dt;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new NewAdmin().ShowDialog();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void btnUsersExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-VOTPIG0L;Initial Catalog=DB_CARS;Integrated Security=True";
            foreach(DataGridViewRow row in dgUsers.Rows)
            {
                if(row.Selected == true)
                {
                    string name = row.Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from tbl_user where Username = '"+name+"'", con);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        txtPath.Text = dr2["Picture"].ToString();
                    }
                    con.Close();
                    PictureUser.ImageLocation = txtPath.Text;
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure? Delete User Permanently?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgUsers.Rows)
                {
                    if (row.Selected == true)
                    {
                        string id = row.Cells[0].Value.ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbl_user where Username = '" + id + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        fetchData();
                    }
                }
            }
           
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            fetchData();
        }
    }
}
