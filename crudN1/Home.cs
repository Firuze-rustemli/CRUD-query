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

namespace crudN1
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKG3SI3\SQLEXPRESS;Initial Catalog=crud-one;Integrated Security=True");

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = boxUser.Text;
            string password = boxUserPass.Text;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT FROM Admin WHERE username='" + username + "' AND password='" + password + "' ";

                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader dtReader = cmd.ExecuteReader();

                if (dtReader.HasRows)
                {
                    while (dtReader.Read())
                    {
                        Form home_form = new Form();
                        this.Hide();
                        home_form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("There is no data like this");
                }
            }
        }
    }
}
