using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    class RegularPay
    {
        private SqlConnection con = new DBConnection().getConnection();
            public void DisplayRegularPay(DataGridView view)
            {
            try
                {
                con.Open();
                SqlCommand query = new SqlCommand("sp_regular_pay_list " , con);// select *from RegularPayment 
                SqlDataAdapter display = new SqlDataAdapter(query);
               display.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dat[9]);

                    }
                con.Close();
                }
                catch(Exception){
                MessageBox.Show("there was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        public void SearchRegularPay(DataGridView view,DateTimePicker date,string term)
                {
                try
                    {
                   
                    con.Open();
                    if (string.IsNullOrEmpty(term))
                        {
                      var  query = "SELECT *FROM RegularPayment WHERE Date LIKE @dateto + '____%'";
                        SqlDataAdapter display = new SqlDataAdapter(query , con);
                        display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date.Value.Year.ToString(); 
                        DataTable data = new DataTable();
                        display.Fill(data);
                        view.Rows.Clear();
                        foreach (DataRow dat in data.Rows)
                        {
                            int n = view.Rows.Add();
                            view.Rows[n].Cells[0].Value = dat[1].ToString();
                            view.Rows[n].Cells[1].Value = dat[2].ToString();
                            view.Rows[n].Cells[2].Value = dat[3].ToString();
                            view.Rows[n].Cells[3].Value = dat[4].ToString();
                            view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                            view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                            view.Rows[n].Cells[6].Value = dat[7].ToString();
                            view.Rows[n].Cells[7].Value = dat[8].ToString();
                            view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                        con.Close();
                    }
                    else
                        {
                       var query = "SELECT *FROM RegularPayment WHERE Date LIKE @dateto + '____%' AND Term=@term";
                        SqlDataAdapter display = new SqlDataAdapter(query , con);
                        display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date.Value.Year.ToString();
                        display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;
                        DataTable data = new DataTable();
                        display.Fill(data);
                        view.Rows.Clear();
                        foreach (DataRow dat in data.Rows)
                        {
                            int n = view.Rows.Add();
                            view.Rows[n].Cells[0].Value = dat[1].ToString();
                            view.Rows[n].Cells[1].Value = dat[2].ToString();
                            view.Rows[n].Cells[2].Value = dat[3].ToString();
                            view.Rows[n].Cells[3].Value = dat[4].ToString();
                            view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                            view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                            view.Rows[n].Cells[6].Value = dat[7].ToString();
                            view.Rows[n].Cells[7].Value = dat[8].ToString();
                            view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                        con.Close();
                    } 
                   
                    }
                catch (Exception )
                    {
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        public void SearchRegularPay(DataGridView view, DateTimePicker date,DateTimePicker date2, string term)
            {
            try
                {
                
                con.Open();
                if (string.IsNullOrEmpty(term))
                    {
                 var   query = "SELECT *FROM RegularPayment WHERE Date BETWEEN @datefrom AND @dateto";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString(); 
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else
                    {
                  var  query = "SELECT *FROM RegularPayment WHERE Date BETWEEN @datefrom AND @dateto AND Term=@term";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                 
              
                }catch (Exception)
                {
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        public void SearchRegularPayWithDate(DataGridView view , DateTimePicker date , DateTimePicker date2 , string term,string search)
            {
            try
                {

                con.Open();
                if (string.IsNullOrEmpty(term))
                    {
                    var query = "SELECT *FROM RegularPayment WHERE Date BETWEEN @datefrom AND @dateto AND Fee_Name LIKE '%'+ @search +'%' OR"+
                        " Class LIKE '%'+ @search +'%' OR Paid_Amount LIKE '%'+ @search +'%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();
                    }
                else
                    {
                    var query = "SELECT *FROM RegularPayment WHERE Date BETWEEN @datefrom AND @dateto  AND Term=@term AND Fee_Name LIKE '%'+ @search +'%' OR" +
                        " Class LIKE '%'+ @search +'%' OR Paid_Amount LIKE '%'+ @search +'%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@datefrom" , SqlDbType.VarChar).Value = date.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@dateto" , SqlDbType.VarChar).Value = date2.Value.ToString();
                    display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search;
                    display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = term;
                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                        {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                        }
                    con.Close();
                    }


                }
            catch (Exception)
                {
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        public void SearchRegularPay(DataGridView view, string text)
            {
            try
            {
                string search = string.IsNullOrEmpty((text)) ? " " : text;
                con.Open();
                SqlCommand query = new SqlCommand("sp_regular_pay_all_search" , con);
                SqlDataAdapter display = new SqlDataAdapter(query);
                display.SelectCommand.CommandType = CommandType.StoredProcedure;
                display.SelectCommand.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                display.SelectCommand.Parameters["@search"].Value = search;
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                    {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                con.Close();
                }catch(Exception) {
                con.Close();
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        
        public void SearchAllRegularPay(DataGridView view , string text)
        {
            try
            {
                string search = string.IsNullOrEmpty((text)) ? " " : text;
                con.Open();
                var query = "SELECT * FROM RegularPayment WHERE Names LIKE '%'+ @Search +'%' OR  Fee_Name LIKE '%'+ @Search +'%' OR Class LIKE '%'+ @Search +'%' OR Paid_Amount LIKE '%'+ @Search +'%' OR Term LIKE '%'+ @Search +'%'";
                SqlDataAdapter display = new SqlDataAdapter(query,con); 
                display.SelectCommand.Parameters.Add(new SqlParameter("@Search" , SqlDbType.VarChar));
                display.SelectCommand.Parameters["@Search"].Value = search;
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }
        public void PastYearRegularPay(DataGridView view,DateTimePicker dateYear, string term,string classname)
        {
            try
            { 
                con.Open();
                var query = "SELECT *FROM RegularPayment WHERE Date LIKE @dateyear +'____%'  AND Term=@term AND Class LIKE '%'+ @classname +'%' ";
                SqlDataAdapter display = new SqlDataAdapter(query, con);
                display.SelectCommand.Parameters.AddWithValue("@dateyear", SqlDbType.VarChar).Value = dateYear.Value.Year.ToString(); 
                display.SelectCommand.Parameters.AddWithValue("@classname", SqlDbType.VarChar).Value = classname;
                display.SelectCommand.Parameters.AddWithValue("@term", SqlDbType.VarChar).Value = term;
                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}", dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}", dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}", dat[9]);

                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("There was error in the search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SearchRegularPay(DataGridView view,string text, TextBox feename)
        {
            try
            { 
                con.Open();
                if (string.IsNullOrEmpty(text))
                    {
                  var  query = " SELECT *FROM RegularPayment WHERE Fee_Name LIKE'%' + @feename + '%' OR Class=@feename";
                  SqlDataAdapter display = new SqlDataAdapter(query ,con); 
                  display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = text;

                  DataTable data = new DataTable();
                  display.Fill(data);
                  view.Rows.Clear();
                  foreach (DataRow dat in data.Rows)
                  {
                      int n = view.Rows.Add();
                      view.Rows[n].Cells[0].Value = dat[1].ToString();
                      view.Rows[n].Cells[1].Value = dat[2].ToString();
                      view.Rows[n].Cells[2].Value = dat[3].ToString();
                      view.Rows[n].Cells[3].Value = dat[4].ToString();
                      view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                      view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                      view.Rows[n].Cells[6].Value = dat[7].ToString();
                      view.Rows[n].Cells[7].Value = dat[8].ToString();
                      view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                  }
                  con.Close();
                    }
                else
                    {
                  var  query = "SELECT * FROM RegularPayment WHERE Term = @search AND Class = @feename"+
                            " OR Fee_Name = @feename";

                SqlDataAdapter display = new SqlDataAdapter(query,con);
                display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = text ;
                display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;

                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
                 }


                }
            catch (Exception) {
                con.Close();
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        public void SearchRegularPay(DataGridView view, string termname, TextBox feename, TextBox name)
        {
           
            try
            { 
                con.Open();
                if (string.IsNullOrEmpty(termname) && string.IsNullOrEmpty(feename.Text))
                    {
                  var  query = "SELECT *FROM RegularPayment WHERE Names LIKE'%' + @name + '%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con); 
                    display.SelectCommand.Parameters.AddWithValue("@name" , SqlDbType.VarChar).Value = name.Text;

                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    con.Close();
                    }
                else if (string.IsNullOrEmpty(termname))
                    {
                 var   query = "SELECT *FROM RegularPayment WHERE Fee_Name LIKE'%' + @feename + '%' AND Names LIKE'%' + @name + '%' ";
                    SqlDataAdapter display = new SqlDataAdapter(query , con); 
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                    display.SelectCommand.Parameters.AddWithValue("@name" , SqlDbType.VarChar).Value = name.Text;

                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    } 
                con.Close();
                }
                else
                    {
                   var query = "SELECT *FROM RegularPayment WHERE Fee_Name LIKE'%' + @feename + '%' AND Term =" +
                           " @termname  AND Names LIKE'%' + @name + '%'";
                    SqlDataAdapter display = new SqlDataAdapter(query , con);
                    display.SelectCommand.Parameters.AddWithValue("@termname" , SqlDbType.VarChar).Value = termname;
                    display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feename.Text;
                    display.SelectCommand.Parameters.AddWithValue("@name" , SqlDbType.VarChar).Value = name.Text;

                    DataTable data = new DataTable();
                    display.Fill(data);
                    view.Rows.Clear();
                    foreach (DataRow dat in data.Rows)
                    {
                        int n = view.Rows.Add();
                        view.Rows[n].Cells[0].Value = dat[1].ToString();
                        view.Rows[n].Cells[1].Value = dat[2].ToString();
                        view.Rows[n].Cells[2].Value = dat[3].ToString();
                        view.Rows[n].Cells[3].Value = dat[4].ToString();
                        view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                        view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                        view.Rows[n].Cells[6].Value = dat[7].ToString();
                        view.Rows[n].Cells[7].Value = dat[8].ToString();
                        view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                    }
                    }
                 
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        public void SearchRegularPay(DataGridView view,DateTimePicker date1, string term, TextBox feename,TextBox name)
        {
            try
               { 
              string  terms = string.IsNullOrEmpty(term) ? " " : term;
               string feenames = string.IsNullOrEmpty(feename.Text) ? " " : feename.Text;
               string names = string.IsNullOrEmpty(name.Text) ? " " : name.Text;
                con.Open();
                if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(feename.Text))
                    {
                    var query = " SELECT *FROM RegularPayment WHERE Names=@search";
                SqlDataAdapter display = new SqlDataAdapter(query ,con); 
                display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = names;

                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
                    }
                else if (string.IsNullOrEmpty(term))
                    {
                    var query =
                    "SELECT *FROM RegularPayment WHERE Date LIKE @paydate +'____%' AND Fee_Name=@feename OR Class=@feename AND Names=@search ";
                SqlDataAdapter display = new SqlDataAdapter(query,con );

                display.SelectCommand.Parameters.AddWithValue("@paydate", SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feenames;
                display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = names;

                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
                    }
                else if (string.IsNullOrEmpty(name.Text))
                    {
                        var query = "SELECT *FROM RegularPayment WHERE  Date LIKE @paydate + '____%' AND Term=@term " +
                                "  AND Class=@feename ";
                SqlDataAdapter display = new SqlDataAdapter(query ,con);
                display.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = terms;
                display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feenames; 

                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
                    }
                else if (string.IsNullOrEmpty(feename.Text))
                    {
                        var query = "SELECT *FROM RegularPayment WHERE Date LIKE @paydate + '____%'AND Term=@term " +
                                     " AND Names=@search";
                SqlDataAdapter display = new SqlDataAdapter(query ,con);
                display.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
                display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = terms; 
                display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = names;

                DataTable data = new DataTable();
                display.Fill(data);
                view.Rows.Clear();
                foreach (DataRow dat in data.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = dat[1].ToString();
                    view.Rows[n].Cells[1].Value = dat[2].ToString();
                    view.Rows[n].Cells[2].Value = dat[3].ToString();
                    view.Rows[n].Cells[3].Value = dat[4].ToString();
                    view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                    view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                    view.Rows[n].Cells[6].Value = dat[7].ToString();
                    view.Rows[n].Cells[7].Value = dat[8].ToString();
                    view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

                }
                con.Close();
                    }
                else
                    {
                        var query = "SELECT *FROM RegularPayment WHERE Date LIKE @paydate + '____%' AND Term=@term" +
                                 " AND Class =@feename AND Names=@search ";
              SqlDataAdapter display = new SqlDataAdapter(query,con);
              display.SelectCommand.Parameters.AddWithValue("@paydate" , SqlDbType.VarChar).Value = date1.Value.Year.ToString();
              display.SelectCommand.Parameters.AddWithValue("@term" , SqlDbType.VarChar).Value = terms;
              display.SelectCommand.Parameters.AddWithValue("@feename" , SqlDbType.VarChar).Value = feenames;
              display.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = names;

              DataTable data = new DataTable();
              display.Fill(data);
              view.Rows.Clear();
              foreach (DataRow dat in data.Rows)
              {
                  int n = view.Rows.Add();
                  view.Rows[n].Cells[0].Value = dat[1].ToString();
                  view.Rows[n].Cells[1].Value = dat[2].ToString();
                  view.Rows[n].Cells[2].Value = dat[3].ToString();
                  view.Rows[n].Cells[3].Value = dat[4].ToString();
                  view.Rows[n].Cells[4].Value = string.Format("{0:00.#0}" , dat[5]);
                  view.Rows[n].Cells[5].Value = string.Format("{0:00.#0}" , dat[6]);
                  view.Rows[n].Cells[6].Value = dat[7].ToString();
                  view.Rows[n].Cells[7].Value = dat[8].ToString();
                  view.Rows[n].Cells[8].Value = string.Format("{0:MM/dd/yyyy}" , dat[9]);

              }
              con.Close();
                } 
               
                }catch (Exception)
                {
                    con.Close();
                MessageBox.Show("There was error in the search" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
        }
        }
    }
