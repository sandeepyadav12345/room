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


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int Id = 0;
        private void GridLoad() {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from userForm";
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }



                }
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into userForm(username,email) values(@username,@email)";
                    cmd.Parameters.AddWithValue("@username", textusername.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data send successfully");
                    textusername.Text = String.Empty;
                    textemail.Text = String.Empty;

                    GridLoad();


                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridLoad();

            
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string username = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string email = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Id= Convert.ToInt32(id1);
            textusername.Text = username;
            textemail.Text = email;
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            

            
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())

                {
                    
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE userForm SET username = @username, email = @email WHERE id = @id";
                    cmd.Parameters.AddWithValue("@username", textusername.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully");
                    textusername.Text = String.Empty;
                    textemail.Text = String.Empty;

                    GridLoad();


                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from userForm where username like @username or email like @email ";
                    
                    cmd.Parameters.AddWithValue("@username", "%"+textusername.Text+"%");
                   // cmd.Parameters.AddWithValue("@email", "%" + textemail.Text + "%");
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }



                }
            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from userForm where username like @username";

                    cmd.Parameters.AddWithValue("@username", "%" + textusername.Text + "%");
                    // cmd.Parameters.AddWithValue("@email", "%" + textemail.Text + "%");
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }



                }
            }

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from userForm where email like @email";

                    cmd.Parameters.AddWithValue("@email", "%" + textemail.Text + "%");
                    // cmd.Parameters.AddWithValue("@email", "%" + textemail.Text + "%");
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }



                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = SANDEEP-YADAV; Initial Catalog = Ims; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())

                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from userform WHERE id = @id";
                    
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully");
                    textusername.Text = String.Empty;
                    textemail.Text = String.Empty;

                    GridLoad();


                }
            }

        }
    }
}
