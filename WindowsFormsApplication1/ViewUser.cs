using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ViewUser : Form
        {
        public ViewUser()
            {
            InitializeComponent();
            }

        private void btclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void ViewUser_Load(object sender, EventArgs e)
            {
                view();
            }
        void view()
        {
            try
            {
                SqlConnection con = new DBConnection().getConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Admin", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridUsers.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    int n = dataGridUsers.Rows.Add();
                    dataGridUsers.Rows[n].Cells[0].Value = dr[1].ToString();
                    dataGridUsers.Rows[n].Cells[1].Value = dr[2].ToString();
                }
            }
            catch (Exception Ex)
            {

            }
        }
        }
    }
