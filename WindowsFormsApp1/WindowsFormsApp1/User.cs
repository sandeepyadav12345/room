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

namespace WindowsFormsApp1
{
    public partial class User : User
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into userForm(username,email) values(@username,@email)";
                    cmd.Parameters.AddWithValue("@username", textUsername.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data send successfully");
                    textUsername.Text = String.Empty;
                    textEmail.Text = String.Empty;


                }
            }
        }

        private void gusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from users";
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                
                    

                }
            }
        }
    }
}
