using System;
using System.Windows.Forms;
using ShowTallerImage;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
 

namespace WindowsFormsApplication1
{
    public partial class ViewTallerForm : Form
    {
        DisplayTaller display = new DisplayTaller();
        SqlConnection con = new DBConnection().getConnection();
        public ViewTallerForm(string  names, string feename, string amount, string date)
        { 
            InitializeComponent();
            txtFirstName.Text = names.ToUpper();
            txtFeeName.Text = feename;
            txtAmount.Text = amount;
            txtDate.Text = date;
            DisplayImage();// display the taller image

        }

        private void ViewTallerForm_Load(object sender, EventArgs e)
        { 
        }

        void DisplayImage()
        {
            
            con.Open();
            var query="SELECT * FROM Taller  WHERE ID =@tellerid";
            SqlDataAdapter recsch = new SqlDataAdapter(query ,con);
            recsch.SelectCommand.Parameters.AddWithValue("@tellerid", SqlDbType.VarChar).Value = DisplayTaller.tallerID;
            DataTable dtSch = new DataTable();
            DataSet ds = new DataSet();
            recsch.Fill(dtSch);
            recsch.Fill(ds);
            int x = dtSch.Rows.Count;

            if (x <= 0)
            { 
            }
            else
            {
                //GET THE TALLER IMAGE
                byte[] pic = (byte[])ds.Tables[0].Rows[0]["Taller"];
                MemoryStream ms = new MemoryStream(pic);
                pictureTaller.Image = Image.FromStream(ms);
                foreach (DataRow drs in dtSch.Rows)
                { 
                    txtTallerNum.Text = drs[2].ToString();
                }

            }
            con.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender , EventArgs e)
            {

            }
        }
}
