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
    public partial class CRUD : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKG3SI3\SQLEXPRESS;Initial Catalog=crud-one;Integrated Security=True");
        private int selectId = 0;

        public CRUD()
        {
            InitializeComponent();
            getData();
            conn.Open();
        }


        //Data

           private void getData()
            {
            string query = "SELECT * FROM Info";
            SqlCommand snd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(snd);
            DataTable dt = new DataTable();

            data.Fill(dt);
            dgView.DataSource = dt;

            }

        // Add info
        private void btnAdd_Click(object sender, EventArgs e)

        {
            string txt_Name = boxName.Text;
            string txt_Email = boxEmail.Text;
            string txt_newpass = boxPass.Text;

            string query = "INSERT INTO Info(Name,Email,Password) VALUES('" + txt_Name + "','" + txt_Email + "', + '"+txt_newpass+"' )";

            SqlCommand snd = new SqlCommand(query, conn);
                int result = snd.ExecuteNonQuery();

                if (result > 0)
                {
                    getData();
                boxName.Clear();
                boxEmail.Clear();
                boxPass.Clear();

            }
        }

        //click mouse datagridview

        private void dgv_mouse(object sender, DataGridViewCellMouseEventArgs e)
        {
            boxDel.Text = dgView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.selectId = Convert.ToInt32(dgView.Rows[e.RowIndex].Cells[0].Value.ToString());
         
        }

        //delete info

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Info WHERE id = " + this.selectId;
            SqlCommand snd = new SqlCommand(query, conn);
            int result = snd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show(" Deleted");
                getData();
                boxDel.Clear();    
            }
        }


        //info update

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txt_Name = boxName.Text;
            string txt_Email = boxEmail.Text;
            string txt_newpass = boxPass.Text;

            if (txt_Name.Length > 0 && txt_Email.Length > 0 )
            {
                string query = "UPDATE Info SET Name = '" + txt_Name + "', Email = '" + txt_Email + "'";
                if (txt_newpass.Length > 0)
                {
                    query += " , password ='" + txt_newpass + "'";
                }
                query += " WHERE id=" + this.selectId;

                SqlCommand sending = new SqlCommand(query, conn);
                int result = sending.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    MessageBox.Show("Updated");
                    getData();
                    boxName.Clear();
                    boxEmail.Clear();
                    boxPass.Clear();
                }
            }
        }


    }
}
