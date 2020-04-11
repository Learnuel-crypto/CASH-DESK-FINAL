using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ShowTallerImage;
using TallerInfor;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AllTallerPaymentForm : Form
    {
        DisplayTaller taller = new DisplayTaller();
        Taller tallerSearch = new Taller();
        SqlConnection con = new DBConnection().getConnection();
        private string names;
        private string feeName;
        private string Ddate;
        private string amount; 
        public AllTallerPaymentForm()
        {
            InitializeComponent();
            Taller.TallerPayments(dataGridTallerView);
        }

        private void AllTallerPaymentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridTallerView_Click(object sender, EventArgs e)
        {
            try
                {
                var ID = Convert.ToInt32(dataGridTallerView.SelectedRows[0].Cells[0].Value.ToString());
                DisplayImage(ID);
                DisplayTaller.tallerID = ID.ToString();
                names = dataGridTallerView.SelectedRows[0].Cells[1].Value.ToString();
                feeName = dataGridTallerView.SelectedRows[0].Cells[3].Value.ToString();
                amount = dataGridTallerView.SelectedRows[0].Cells[4].Value.ToString();
                Ddate = dataGridTallerView.SelectedRows[0].Cells[7].Value.ToString();
                }catch (Exception)
                {

                }
        }

        private void dataGridTallerView_DoubleClick(object sender, EventArgs e)
        {
            try
                {
                var ID = Convert.ToInt32(dataGridTallerView.SelectedRows[0].Cells[0].Value.ToString());
                DisplayTaller.tallerID = ID.ToString();
                names = dataGridTallerView.SelectedRows[0].Cells[1].Value.ToString();
                feeName = dataGridTallerView.SelectedRows[0].Cells[3].Value.ToString();
                amount = dataGridTallerView.SelectedRows[0].Cells[4].Value.ToString();
                Ddate = dataGridTallerView.SelectedRows[0].Cells[7].Value.ToString();
                var viewTaller = new ViewTallerForm(names , feeName , amount , Ddate);
                viewTaller.ShowDialog();
                }catch (Exception) { }
        }
        void DisplayImage(int id)
        {

            con.Open();
            var query="Select * from Taller  where ID =@telerid";
            SqlDataAdapter recsch = new SqlDataAdapter(query,con);
            recsch.SelectCommand.Parameters.AddWithValue("@telerid", SqlDbType.VarChar).Value = id;
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

        private void btnViewTaller_Click(object sender, EventArgs e)
        {
            var viewTaller = new ViewTallerForm(names, feeName, amount, Ddate);
            viewTaller.ShowDialog();
        }

        private void dataGridTallerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrintPayRecords_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecords(dataGridTallerView, MyPrinter.GetPrintTile());
            }
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            string Term = "";
            if (radioFirst.Checked == true)
                {
                Term = radioFirst.Text;
                }
            if (radioSecond.Checked == true)
                {
                Term = radioSecond.Text;
                }
            if (radioThird.Checked == true)
                {
                Term = radioThird.Text;
                }
            tallerSearch.TallerDateSearch(dataGridTallerView, dateTimeFrom, dateTimeTo,txtSearch.Text,Term);
        }

        private void radioFirst_Click(object sender, EventArgs e)
        {
            tallerSearch.TallerTermSearch(dataGridTallerView, radioFirst.Text);
        }

        private void radioSecond_Click(object sender, EventArgs e)
        {
            tallerSearch.TallerTermSearch(dataGridTallerView, radioSecond.Text);
        }

        private void radioThird_Click(object sender, EventArgs e)
        {
            tallerSearch.TallerTermSearch(dataGridTallerView, radioThird.Text);
        }

        private void radioAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            Taller.TallerPayments(dataGridTallerView);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            tallerSearch.TallerSearchAll (dataGridTallerView, txtSearch.Text);
            if (string.IsNullOrEmpty(txtSearch.Text))
                {
                Taller.TallerPayments(dataGridTallerView);
                }
        }
    }
}
