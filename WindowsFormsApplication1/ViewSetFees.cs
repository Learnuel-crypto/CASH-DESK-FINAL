using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class ViewSetFees
    {
        private SqlConnection con = new DBConnection().getConnection();
            public void DisplaySetFees(DataGridView view)
            {
                con.Open();
                SqlCommand query = new SqlCommand("SELECT *FROM SetFees ORDER BY Set_Id DESC", con);
                SqlDataAdapter display = new SqlDataAdapter(query);
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[2].ToString();
                    view.Rows[n].Cells[1].Value = dat[3].ToString();
                    view.Rows[n].Cells[2].Value = string.Format("{0:00.#0}", dat[4]);
                    view.Rows[n].Cells[3].Value = dat[5].ToString();
                    view.Rows[n].Cells[4].Value =string.Format("{0:MM/dd/yyyy}" ,dat[6]);
                     

                }

            }
        }
    }
