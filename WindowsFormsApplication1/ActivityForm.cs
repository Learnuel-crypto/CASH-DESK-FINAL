using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class ActivityForm : Form
    {
        private string[] strArray = new string[4];
        public ActivityForm()
        {
            InitializeComponent();
        }
        public delegate void OnAppStartedEventHandler(object source, EventArgs args);
        public event OnAppStartedEventHandler AppStarted;

        protected virtual void OnAppStarted()
        {
            if (AppStarted != null)
            {
                AppStarted(this, EventArgs.Empty);
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            //ADD ASYNCHRONOUS METHOD HERE
            getData();

        }
        private void getData()
        {

            SqlConnection con = new DBConnection().getConnection();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Activity ORDER BY Date,Time DESC", con);
            da.Fill(dts);
            dataGridActivity.Rows.Clear();
            foreach (DataRow dr in dts.Rows)
            {
                var n = dataGridActivity.Rows.Add();
                dataGridActivity.Rows[n].Cells[0].Value = dr[0];
                dataGridActivity.Rows[n].Cells[1].Value = dr[1];
                dataGridActivity.Rows[n].Cells[2].Value = dr[2];
                dataGridActivity.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyy}", dr[3]);

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //SEARCH FOR ACTIVITY
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT  *FROM Activity WHERE Description LIKE '%'+ @search + '%' OR Time LIKE '%'+ @search +" +
                       " '%' OR Date LIKE '%'+ @search + '%' ORDER BY Date,Time DESC", con);
                da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = txtSearch.Text;
                da.Fill(dts);
                dataGridActivity.Rows.Clear();
                foreach (DataRow dr in dts.Rows)
                {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridActivity.Rows.Add();
                    dataGridActivity.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridActivity.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridActivity.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridActivity.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyy}", dr[3]);
                }

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataAccess.displaysActivity(dataGridActivity);
                }
            }
            catch (Exception)
            {
                con.Close();
            }
        }

        private void btnTodayActivity_Click(object sender, EventArgs e)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {

                con.Open();
                DataTable dtToday = new DataTable();
                SqlDataAdapter daToday =
                    new SqlDataAdapter(
                        "SELECT  *FROM Activity WHERE Date=@today ORDER BY Date,Time DESC", con);
                daToday.SelectCommand.Parameters.AddWithValue("@today", SqlDbType.VarChar).Value = DateTime.Now.Date.ToString("MM/dd/yyyy");
                daToday.Fill(dtToday);
                dataGridActivity.Rows.Clear();
                foreach (DataRow drToday in dtToday.Rows)
                {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridActivity.Rows.Add();
                    dataGridActivity.Rows[n].Cells[0].Value = drToday[0].ToString();
                    dataGridActivity.Rows[n].Cells[1].Value = drToday[1].ToString();
                    dataGridActivity.Rows[n].Cells[2].Value = drToday[2].ToString();
                    dataGridActivity.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyy}", drToday[3]);
                }
            }
            catch (Exception Ex)
            {
                con.Close();
               MessageBox.Show("there was error in the search","search error");
            }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dataAccess.displaysActivity(dataGridActivity);
        }

        private void btnDeleteActivities_Click(object sender, EventArgs e)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                if (MessageBox.Show("Are you Sure you want to Delete all activity records ?", "Cash Desk", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE Activity", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    dataAccess.Description = AdminLog.Admin + " Deleted Activity Records";
                    dataAccess.Activities();
                    getData();
                    MessageBox.Show("Records Deleted Successfully", "Cash Desk", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message, "Cash Desk", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.ShowDialog();
            if (MyPrinter.Print)
            {
                MyPrinter.PrintRecordsPortrate(dataGridActivity, MyPrinter.GetPrintTile());
            }
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new DBConnection().getConnection();
            try
            {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT  *FROM Activity WHERE Date=@date ORDER BY Date,Time DESC", con);
                da.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = dateTimeFrom.Value.ToString("MM/dd/yyyy");
                da.Fill(dts);
                dataGridActivity.Rows.Clear();
                foreach (DataRow dr in dts.Rows)
                {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridActivity.Rows.Add();
                    dataGridActivity.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridActivity.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridActivity.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridActivity.Rows[n].Cells[3].Value = string.Format("{0:MM/dd/yyy}", dr[3]);
                }
            }
            catch (Exception)
            {
                con.Close();
            }
        }
    }
        }
        
