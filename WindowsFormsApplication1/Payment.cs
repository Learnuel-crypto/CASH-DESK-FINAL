using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using TallerInfor;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
    {
    public partial class Payment : Form
    {

        /// <summary>
        /// GLOBAL VARIABLS
        /// </summary>
        #region
         
        int studId;
        string Names;
        string status;
        double  FeeAmount = 0;
        int sessionId;
        int classId;
        double  payAmount;
        double  paidAmount;
        int feeid;
        double  Total;
        private string year;
        private string Feetype;
        private int printTime = 0;
        #endregion
        SqlConnection con = new DBConnection().getConnection();
        Taller taller = new Taller();
        int clicked = 0;
        public Payment()
        {
            InitializeComponent();
            Fees fs = new Fees();
        }
         
        private void btnclose_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                    //prepare the various list as per the payments made
                    var ground = new GroundWorker();
                PaymentMade += ground.OnAppStarted;
                OnPaymentMade();
            }).Start();
            this.Close();
        }

        private void radioDebt_CheckedChanged(object sender, EventArgs e)
        {
            panyear.Visible = true;

        }

        private void radioCurrent_CheckedChanged(object sender, EventArgs e)
        {
            panyear.Visible = false;
            txtdebtyear.Clear();
            txtFeeAmount.Clear();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dataAccess.setFeeName(combFeeName);
            string date = System.DateTime.Now.Month.ToString();
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void combTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// DISPLAY THE NAME OF STUDENT TYPED
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void txtname_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (clicked == 0)
                    {
                     
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    DataTable dt = new DataTable();
                    //MAKE CHANGES TO THE QUERY
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Names.Name_id, Names.First_Name,Names.Middle_Name, Names.Last_Name FROM Names  WHERE Names.First_Name LIKE '%" + txtname.Text.ToString() +
                                             "%'OR Middle_Name LIKE '%' +@search + '%' OR Last_Name LIKE '%' + @search + '%'" , con);
                    da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = txtname.Text;
                    da.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                        {
                        dataGridView1.Visible = true;
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                        }
                    }
                else
                    {
                    if (string.IsNullOrEmpty(txtname.Text))
                        {
                        dataGridView1.Visible = false;
                        }
                    con.Close();
                    }
                //con.Close();uncomment later
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        #endregion
        /// <summary>
        /// display the selected Name in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
                {
                clicked = 1;
                int nameid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var fname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var mname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                var lname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtname.Text = fname + " " + lname;

                dataGridView1.Visible = false;
                //GET THE ID OF THE SELECTED NAME
                DataTable dtc = new DataTable();
                SqlDataAdapter daid = new SqlDataAdapter("SELECT Students.Student_Id FROM Students WHERE Students.Name_id=@id " , con);
                daid.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = nameid;
                daid.Fill(dtc);
                foreach (DataRow dr in dtc.Rows)
                    {
                    var id = dr["Student_Id"].ToString();
                    studId = int.Parse(id);
                     
                    }
                }catch (Exception)
                {

                }
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
                {
                if (string.IsNullOrEmpty(txtClass.Text))
                    {
                    throw new Exception("Please SELECT A Class");
                    }
                if (string.IsNullOrEmpty(combFeeName.Text))
                    {
                    throw new Exception("Please SELECT Fee Name");
                    }
                if (string.IsNullOrEmpty(txtname.Text))
                    {
                    throw new Exception("Please SELECT a Name");
                    }
                if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                    throw new Exception("Please Enter Fee Amount");
                    }

                if (string.IsNullOrEmpty(combInstall.Text))
                { 
                        throw new Exception("Please Select Installment"); 
                }
                Fees fs = new Fees();
                var className = new GroundWorker();
                payAmount = double.Parse(string.Format("{0:00}" , txtAmount.Text));
                fs.setAmount(payAmount);
                payAmount = fs.getAmount(); 
                //GET THE CURRENT FEES BY ID
                var feeid = 0;
                FeeAmount = 0;
                paidAmount = 0;
              Names= className.ClassName(txtClass.Text.ToLower());
               // ClassName(txtClass.Text.ToLower());
                con.Open();
                //CHECK IF IS CURRENT FEE OR DEBT
                if (string.IsNullOrEmpty(combFeeName.Text)) { 
                    throw new Exception("Please SELECT Fee Name");
                }
                if (radioCurrent.Checked == true)
                {
                    Feetype = "Current";
                    year = DateTime.Today.Year.ToString();
                }
                else if (radioDebt.Checked == true)
                {
                    Feetype = "Debt";
                    year = txtdebtyear.Text;
                    //MAKE DEBT PAYMENT
                    var Fa = double.Parse(txtFeeAmount.Text);
                    fs.setAmount(Fa);
                    if (string.IsNullOrEmpty(txtFeeAmount.Text)) { 

                    }
                }
                else
                {
                    throw new Exception("Please Select Fee Type to pay");
                }
                if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    throw new Exception("Please enter The Amount");
                }
                //PAY WITH TALLER SECTION 
                //CONFIRM THE AMOUNT ENTERED
                if (CustomMsgBox.Show("Amount:\n" + txtAmount.Text, "Confirm Amount", "Yes", "No") == DialogResult.No)
                {
                    throw new Exception("Please Check the Amount"); 
                }
                //GET THE TALLER DETAILS
                if (checkTaller.Checked == true && string.IsNullOrEmpty( Taller.TallerID)==true)
                {
                    var tallerDetails = new TallerForm();
                    tallerDetails.ShowDialog();
                }
                if (Taller.TallerError == true)
                {
                    Taller.TallerError = false;
                    throw new Exception("Teller image was NOT uploaded");
                }
                //GET THE SESSION ID AND USE IT TO GET THE FEE AMOUNT
                DataTable dtfee = new DataTable();
                SqlDataAdapter dafee = new SqlDataAdapter("SELECT MAX(Session_Id) FROM Session", con);
                dafee.Fill(dtfee);
                foreach (DataRow drfe in dtfee.Rows)
                {
                    sessionId = Convert.ToInt32(drfe[0]);

                }
                Student st = new Student();
                st.setClass(txtClass.Text);//SET THE STUDENT CLASS
                SqlDataAdapter da = new SqlDataAdapter("SELECT Class_Id FROM Class WHERE Class.Student_Id IN(SELECT Students.Student_Id FROM Students" +
                                                       " WHERE Class.ClassName LIKE'%' + @pclass + '%' AND Class.Student_Id = @studid); ", con);
                da.SelectCommand.Parameters.AddWithValue("@pclass", SqlDbType.VarChar).Value = st.getpClass();
                da.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                DataTable dtclass = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(dtclass);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    //GET THE CLASS ID OF THE STUDENT 
                    foreach (DataRow drclassid in dtclass.Rows)
                    {
                        classId = Convert.ToInt32(drclassid["Class_Id"]);
                    }
                    con.Close();
                }

                else
                {
                    throw new Exception("Student was Not Found in Selected Class\nConfirm the Selected Class");
                     
                }
                //ON GETTING STUDENT ID, EXECUTION CONTINUES FROM HERE
                do
                {
                    con.Open();
                    //GET THE FEE AMOUNT TO BE PAID FOR 
                    DataTable dtpay = new DataTable();
                    SqlDataAdapter dapay = new SqlDataAdapter(" SELECT Amount FROM SetFees WHERE Section =@names AND Fee_Name LIKE'%' + @feename + '%' AND Session_Id =@sesid", con);
                    dapay.SelectCommand.Parameters.AddWithValue("@names", SqlDbType.VarChar).Value = Names;
                    dapay.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.Text;
                    dapay.SelectCommand.Parameters.AddWithValue("@sesid", SqlDbType.VarChar).Value = sessionId;
                        
                    DataSet ds2 = new DataSet();
                    dapay.Fill(dtpay);
                    dapay.Fill(ds2);
                    int check = ds2.Tables[0].Rows.Count;
                    //SEE IF NEW FEE HAS BEEN SET ELSE GET THE OLD FEE AMOUNT
                    if (check > 0)
                    {

                        foreach (DataRow drpay in dtpay.Rows)
                        {

                            var getAmount = Convert.ToInt32(drpay[0]);
                            FeeAmount =getAmount;
                        }
                    }
                    //WHEN THERE IS NOW NEW FEE SET FOR THE CURRENT ACADEMIC SESSION
                    else
                    {
                        sessionId -= 1; 
                    }
                    con.Close();
                } while (FeeAmount == 0 && sessionId >= 0);

                //IF SESSION_ID = 0 THEN TELL USER TO SET THE FEE AS IT IS NOT FOUND
                con.Close();
                #region
                ///SELECT WHICH PAYMENT TO BE MADE
                if (combTerm.SelectedItem.ToString() == "First" && radioCurrent.Checked == true)
                {
                    firstTerm();
                }
                else if (combTerm.SelectedItem.ToString() == "Second" && radioCurrent.Checked == true)
                {
                    secondTerm();
                }
                else if (combTerm.SelectedItem.ToString() == "Third" && radioCurrent.Checked == true)
                {
                    thirdTerm();
                }

                else if (combTerm.SelectedItem.ToString() == "First" && radioDebt.Checked == true)
                {
                    PayDebt();
                    firstTerm();
                }
                else if (combTerm.SelectedItem.ToString() == "Second" && radioDebt.Checked == true)
                {
                    PayDebt();
                    secondTerm();
                }
                else if (combTerm.SelectedItem.ToString() == "Third" && radioDebt.Checked == true)
                {
                    PayDebt();
                    thirdTerm();
                }
                else
                {
                    throw new Exception("Select Term to pay Fee for");
                }
                //start timer for reciept printing 
                printTime = 15;
                timerPrint.Start();

                }//ene of try block
            catch (ExceptionHandling Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            
        }
    
        #endregion
        public void PayDebt(){
             do
                    {
                    con.Open();
                    //GET THE FEE AMOUNT TO BE PAID FOR 
                    var pastAmount = Convert.ToInt32(txtFeeAmount.Text);
           SqlDataAdapter daDebtpay = new SqlDataAdapter("SELECT SetFees.Amount FROM SetFees WHERE Session_Id IN( SELECT Session_Id FROM Session WHERE "+
               "Start_Year=@startyear AND SetFees.Amount=@pamount AND SetFees.Fee_Name=@feename);", con);
           daDebtpay.SelectCommand.Parameters.AddWithValue("@startyear", SqlDbType.VarChar).Value = txtdebtyear.Text;
           daDebtpay.SelectCommand.Parameters.AddWithValue("@pamount", SqlDbType.VarChar).Value = pastAmount;
           daDebtpay.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.Text; 
            DataTable dtDebtpay = new DataTable();
                 DataSet dsDebt = new DataSet();
                    daDebtpay.Fill(dtDebtpay);
                    daDebtpay.Fill(dsDebt);
                    int check = dsDebt.Tables[0].Rows.Count;
                    if (check > 0)
                        {
                        foreach (DataRow drpay in dtDebtpay.Rows)
                            {
                            var getAmount = Convert.ToInt32(drpay[0]);
                            FeeAmount = getAmount;
                             
                            }
                        }
                    else
                        {
                       if( MessageBox.Show("Current Fees Amount not Set\nUse Previously Set Amount","Debt Payment",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes){
                       sessionId -= 1;
                           }
                        else{throw new Exception("Please Check the Selected Entries\nOr Set Fee for the Year Selected");}
                        }
                    con.Close();
                    } while (FeeAmount == 0 && sessionId >= 0);
            con.Close();
            }
        public void firstTerm()
            {
            try
                {
                con.Open();
                feeid = 0;
                var pdate = dateTimePicker1.Value.Date.Year;
                DataTable dtgetFee = new DataTable();
                //GET THE FEE ID OF THE INITAL PAYMENT 
                SqlDataAdapter daseach = new SqlDataAdapter("SELECT FirstTerm.Amount,FirstTerm.Fee_Id from FirstTerm where Fee_Id IN (SELECT Fee_Id FROM Fees WHERE Fees.Fee_Id= FirstTerm.Fee_Id "+
                "AND Student_Id=@studid AND  FirstTerm.Fee_Name =@feename AND Fees.Class_Id=@pclassid " +
                " AND FirstTerm.PayDate LIKE  @date + '%____');", con);

                daseach.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value =studId;
                daseach.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                daseach.SelectCommand.Parameters.AddWithValue("@pclassid", SqlDbType.VarChar).Value = classId;
                daseach.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = pdate.ToString() ;
                DataSet dtcheckFee = new DataSet();
                daseach.Fill(dtgetFee);
                daseach.Fill(dtcheckFee);
                int x = dtcheckFee.Tables[0].Rows.Count; 
                if (x > 0)
                    {

                    foreach (DataRow drfine in dtgetFee.Rows)
                        {

                        var getAmount = Convert.ToInt32(drfine[0]);
                        feeid = Convert.ToInt32(drfine[1]);
                        paidAmount = getAmount; 
                        }
                    if (paidAmount == 0 && payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                        con.Close();
                        FirstpayFee();

                        }
                    else if (paidAmount != 0 && paidAmount < FeeAmount)
                        {
                        if (paidAmount + payAmount == FeeAmount)
                            {
                            status = "Cleared";
                            //insert into tables
                            Total = paidAmount + payAmount;
                            con.Close();
                            UpdateFirstpaidFee();
                            }
                        else if (paidAmount + payAmount < FeeAmount)
                            {
                           Total = paidAmount + payAmount;
                            status = "Not Cleared";
                            con.Close();
                            UpdateFirstpaidFee();
                            }
                        else if (paidAmount + payAmount > FeeAmount)
                            {
                                con.Close();
                            throw new Exception("Check the Amount Entered\nTotal Payment Exceeds the Set Amount");
                            }

                        }
                    else
                        {
                            con.Close();
                        throw new Exception("Enter Actual Fee Amount to be Paid or Set New Fee\nSelected Fee is Cleared by Student");
                        }
                    }//close the first if statement

                else
                    {
                    if (payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                         
                        con.Close();
                        FirstpayFee();
                        }
                    else if (payAmount < FeeAmount)
                        {
                        
                        status = "Not Cleared";
                        con.Close();
                        FirstpayFee();
                        }
                    else
                        {
                            con.Close();
                        throw new Exception("Please check the SELECTED FEE TO PAY");
                        }  
                    con.Close();
                    }

                }//ene of try block
            catch (ExceptionHandling Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        //METHOD TO MAKE FEE PAYMENT THE FIRST TIME EACH FEE IS PAID
        public void FirstpayFee()
            {
            try
                {
                con.Open();
                double  Total = paidAmount + payAmount; 
                SqlCommand cmd = new SqlCommand("INSERT INTO Fees VALUES('" + classId + "','" + studId + "')", con);
                cmd.ExecuteNonQuery();
                DataTable dtc = new DataTable();
                SqlCommand cmd2 = new SqlCommand("SELECT  MAX(Fee_Id) FROM Fees ", con);
                SqlDataAdapter dacid = new SqlDataAdapter(cmd2);
                dacid.Fill(dtc);
                var clasid = 0;
                foreach (DataRow drc in dtc.Rows)
                    {
                    feeid = Convert.ToInt32(drc[0]); 
                    
                    }  
                SqlCommand cmdpay = new SqlCommand();
                cmdpay.Connection = con;
                cmdpay.Parameters.Clear();
                cmdpay.CommandType = CommandType.Text;
                cmdpay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@sesid", SqlDbType.VarChar));

                cmdpay.Parameters["@feeid"].Value = feeid;
                cmdpay.Parameters["@feename"].Value = combFeeName.SelectedItem;
                cmdpay.Parameters["@total"].Value = Total;
                cmdpay.Parameters["@status"].Value = status;
                cmdpay.Parameters["@date"].Value = dateTimePicker1.Value.Date.ToShortDateString();
                cmdpay.Parameters["@sesid"].Value = sessionId;
                cmdpay.CommandText = "INSERT INTO FirstTerm VALUES (@feeid,@feename,@total,@status,@date,@sesid ) ";
                cmdpay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid "+ combFeeName.SelectedItem.ToString();
                    dataAccess.Activities();
                    //CASH CLASS HERE
                    Cash ch = new Cash();//insert the records into the cash workwith table
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Succefully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }
            catch (SqlException Ex)
                {
                //delete inserted record if any error occurs
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                SqlCommand deletefee = new SqlCommand("DELETE Fees where Class_Id='" + classId + "' and Student_Id='" + studId + "'and Fee_Id='" + feeid + "'", con);
                deletefee.ExecuteNonQuery();
                deleteTaller.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                SqlCommand deletefee = new SqlCommand("DELETE Fees where Class_Id='" + classId + "' and Student_Id='" + studId + "' and Fee_Id='" + feeid + "'", con);
                deletefee.ExecuteNonQuery();
                deletefee.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public delegate void OnPaymentMadeEventHandler(object source, EventArgs args);

            public event OnPaymentMadeEventHandler PaymentMade;

            protected virtual void OnPaymentMade()
            {
            if (PaymentMade != null)
                {
                PaymentMade(this , EventArgs.Empty);
                }
            }
        //SFIRST TERM METHOD TO UPDATE ALREADY PAID FEES
        public void UpdateFirstpaidFee()
            {
            try
                {
                con.Open();
                var pdate = dateTimePicker1.Value.Date.ToShortDateString();
                double  Total = paidAmount + payAmount;
               var querysearch="SELECt Fees.Fee_Id from Fees where Fee_Id in(select FirstTerm.Fee_Id from FirstTerm where"+
                    " Fee_Id =@feeid AND Fee_Name=@feename AND FirstTerm.PayDate LIKE '%' + @date + '%');";
                  
                DataTable dtc = new DataTable(); 
                SqlDataAdapter dacid = new SqlDataAdapter(querysearch,con);
                dacid.SelectCommand.Parameters.AddWithValue("@feeid",SqlDbType.VarChar).Value=feeid;
                dacid.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                dacid.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = dataAccess.Sdate.ToString();
                dacid.Fill(dtc);
                
                foreach (DataRow drc in dtc.Rows)
                    {
                    feeid = Convert.ToInt32(drc[0]); 
                    
                    }
                SqlCommand cmdpay = new SqlCommand() ;         
                cmdpay.Connection = con;
                cmdpay.Parameters.Clear(); 
                cmdpay.CommandType = CommandType.Text;
                cmdpay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar)); 

                cmdpay.Parameters["@feeid"].Value = feeid;
                cmdpay.Parameters["@feename"].Value = combFeeName.SelectedItem;
                cmdpay.Parameters["@total"].Value = Total;
                cmdpay.Parameters["@status"].Value = status;
                cmdpay.CommandText = "UPDATE FirstTerm SET Amount =@total, Status=@status WHERE FirstTerm.Fee_Id IN(SELECT Fee_Id FROM " +
                                                   "Fees WHERE Fee_Id =@feeid AND FirstTerm.Fee_Name=@feename)";
                cmdpay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid "+combFeeName.SelectedItem;
                    dataAccess.Activities();
                    Fees fs = new Fees();
                    //CASH CLASS HERE
                    Cash ch = new Cash();//insert records into the workwith table
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID(); 
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }

            catch (SqlException Ex)
                {       
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public void secondTerm()
            {
            try
                {
                con.Open();
                feeid = 0;
                var pdate = dateTimePicker1.Value.Date.Year;
                DataTable dtgetFee = new DataTable();
                //GET THE FEE ID OF THE INITAL PAYMENT
                SqlDataAdapter daseach = new SqlDataAdapter("SELECT SecondTerm.Amount,SecondTerm.Fee_Id from SecondTerm WHERE Fee_Id IN (SELECT Fee_Id FROM Fees WHERE Fees.Fee_Id= SecondTerm.Fee_Id " +
                "AND Student_Id=@studid AND  SecondTerm.Fee_Name=@feename AND SecondTerm.PayDate LIKE @date + '%____' );", con);
                daseach.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                daseach.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                daseach.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = pdate.ToString();
                DataSet dtchectFee = new DataSet();
                daseach.Fill(dtgetFee);
                daseach.Fill(dtchectFee);
                int x = dtchectFee.Tables[0].Rows.Count; 
                if (x > 0)
                    {

                    foreach (DataRow drfine in dtgetFee.Rows)
                        {
                        //get the feeid and the amount the amount paid before
                        var getAmount = Convert.ToInt32(drfine[0]);
                        feeid = Convert.ToInt32(drfine[1]);
                        paidAmount = getAmount; 
                        }
                    if (paidAmount == 0 && payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                        con.Close();
                        SecondpayFee();

                        }
                    else if (paidAmount != 0 && paidAmount < FeeAmount)
                        {
                        if (paidAmount + payAmount == FeeAmount)
                            {
                            status = "Cleared";
                            //insert into tables
                            double  Total = paidAmount + payAmount;
                            con.Close();
                            UpdateSecondTermpaidFee();
                            }
                        else if (paidAmount + payAmount < FeeAmount)
                            {
                            double  Total = paidAmount + payAmount;
                            status = "Not Cleared";
                            con.Close();
                            UpdateSecondTermpaidFee();
                            }
                        else if (paidAmount + payAmount > FeeAmount)
                            {
                                con.Close();
                            throw new Exception("Check the Amount Entered\nTotal Payment Exceeds the Set Amount");
                            }

                        }
                    else
                        {
                            con.Close();
                        throw new Exception("Enter Actual Fee Amount to be Paid or Set New Fee\nSelected Fee is Cleared by Student");
                        }
                    }//close the first if statement

                else
                    {
                    if (payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                        Total = payAmount;
                        con.Close();
                        SecondpayFee();
                        }
                    else if (payAmount < FeeAmount)
                        {
                        Total = payAmount;
                        status = "Not Cleared";
                        con.Close();
                        SecondpayFee();
                        }
                    else
                        {
                            con.Close();
                        throw new Exception("Please check the SELECTED FEE TO PAY");
                        } 
                    con.Close();
                    }
               
            }//ene of try block
            catch (ExceptionHandling Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        //SECOND TERM CALL METHOD
        private void SecondpayFee()
            {
            try
                {
                con.Open();
                double  Total = paidAmount + payAmount;
                SqlCommand cmd = new SqlCommand("INSERT INTO Fees VALUES('" + classId + "','" + studId + "')", con);
                cmd.ExecuteNonQuery();
                DataTable dtc = new DataTable();
                SqlCommand cmd2 = new SqlCommand("SELECT  max(Fee_Id) FROM Fees ", con);
                SqlDataAdapter dacid = new SqlDataAdapter(cmd2);
                dacid.Fill(dtc);
                var clasid = 0;
                foreach (DataRow drc in dtc.Rows)
                    {
                    feeid = Convert.ToInt32(drc[0]);  
                    }
                var pdate = dateTimePicker1.Value.Date.ToShortDateString(); 
                SqlCommand cmdpay = new SqlCommand();
                cmdpay.Connection = con;
                cmdpay.Parameters.Clear();
                cmdpay.CommandType = CommandType.Text;
                cmdpay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@sesid", SqlDbType.VarChar));
                cmdpay.Parameters["@feeid"].Value = feeid;
                cmdpay.Parameters["@feename"].Value = combFeeName.SelectedItem;
                cmdpay.Parameters["@total"].Value = Total;
                cmdpay.Parameters["@status"].Value = status;
                cmdpay.Parameters["@date"].Value = pdate.ToString();
                cmdpay.Parameters["@sesid"].Value = sessionId;
                cmdpay.CommandText = "INSERT INTO SecondTerm VALUES (@feeid,@feename,@total,@status,@date ,@sesid ) ";
                cmdpay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid " + combFeeName.SelectedItem.ToString();
                    dataAccess.Activities();
                    //CASH CLASS HERE
                    Cash ch = new Cash();
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Succefully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }
            catch (SqlException Ex)
                {
                SqlCommand deletefee = new SqlCommand("DELETE Fees WHERE Class_Id='" + classId + "' and Student_Id='" + studId + "'and Fee_Id='" + feeid + "'", con);
                deletefee.ExecuteNonQuery();
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                deleteTaller.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                SqlCommand deletefee = new SqlCommand("DELETE Fees WHERE Class_Id='" + classId + "' and Student_Id='" + studId + "'and Fee_Id='" + feeid + "'", con);
                deletefee.ExecuteNonQuery();
                SqlCommand deleteTaller = new SqlCommand("Delete Taller WHERE ID=0", con);
                deleteTaller.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            con.Close();
            }
        //SECOND TERM METHOD TO UPDATE ALREADY PAID FEES
        public void UpdateSecondTermpaidFee()
            {
            try
                {
                con.Open();
                var pdate = dateTimePicker1.Value.Date.ToShortDateString();
                 Total = paidAmount + payAmount;
                var quer="SELECT Fees.Fee_Id FROM Fees WHERE Fee_Id IN(SELECT Fee_Id FROM "+"" +
                 "SecondTerm where Fee_Id =@feeid AND Fee_Name=@feename AND SecondTerm.PayDate like '%' + @date + '%');";
                     
                DataTable dtc = new DataTable(); 
                SqlDataAdapter dacid = new SqlDataAdapter(quer,con);
                dacid.SelectCommand.Parameters.AddWithValue("@feeid", SqlDbType.VarChar).Value = feeid;
                dacid.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                dacid.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = dataAccess.Sdate.ToString();
                dacid.Fill(dtc);
                
                foreach (DataRow drc in dtc.Rows)
                    {
                    feeid = Convert.ToInt32(drc[0]); 
                    
                    }

                     SqlCommand cmdpay = new SqlCommand()  ;
                    cmdpay.Connection = con;
                    cmdpay.Parameters.Clear();
                    cmdpay.CommandType = CommandType.Text;
                    cmdpay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar)); 
                    cmdpay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                    cmdpay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar)); 
                    cmdpay.Parameters["@feeid"].Value = feeid; 
                    cmdpay.Parameters["@total"].Value = Total;
                    cmdpay.Parameters["@status"].Value = status;
                    cmdpay.CommandText = "UPDATE SecondTerm SET Amount =@total,Status=@status WHERE SecondTerm.Fee_Id IN(SELECT Fee_Id FROM Fees WHERE Fee_Id =@feeid);";
                cmdpay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid "+combFeeName.SelectedItem.ToString();
                    dataAccess.Activities();
                    //CASH CLASS HERE
                    Cash ch = new Cash();
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }

            catch (SqlException Ex)
                {
                
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        //THIRD PAYMENT METHOD
        public void thirdTerm()
            {

            try
                {
                    var pdate = dateTimePicker1.Value.Date.Year.ToString();
                DataTable dtgetFee = new DataTable();
                SqlDataAdapter daseach = new SqlDataAdapter("SELECT ThirdTerm.Amount,ThirdTerm.Fee_Id from ThirdTerm where Fee_Id IN (SELECT Fee_Id FROM Fees WHERE Fees.Fee_Id= ThirdTerm.Fee_Id " +
                " AND Student_Id=@studid AND  ThirdTerm.Fee_Name=@feename AND ThirdTerm.PayDate LIKE  @date + '%____' );", con);
                daseach.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                daseach.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                daseach.SelectCommand.Parameters.AddWithValue("@date", SqlDbType.VarChar).Value = pdate;
                DataSet dtchectFee = new DataSet();
                daseach.Fill(dtgetFee);
                daseach.Fill(dtchectFee);
                int x = dtchectFee.Tables[0].Rows.Count;
                if (x > 0)
                {
                    foreach (DataRow drfine in dtgetFee.Rows)
                        {

                        var getAmount = Convert.ToInt32(drfine[0]);
                        feeid = Convert.ToInt32(drfine[1]);
                        paidAmount = getAmount; 
                        }
                    con.Close();
                    if (paidAmount == 0 && payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                        Total = paidAmount + payAmount;
                        ThirdpayFee();
                        }
                    else if (paidAmount != 0 && paidAmount < FeeAmount)
                        {
                        if (paidAmount + payAmount == FeeAmount)
                            {
                            status = "Cleared";
                            //insert into tables
                             Total = paidAmount + payAmount;
                            UpdateThirdTermpaidFee();
                            }
                        else if (paidAmount + payAmount < FeeAmount)
                            {
                            Total = paidAmount + payAmount;
                            status = "Not Cleared";
                            UpdateThirdTermpaidFee();
                            }
                        else if (paidAmount + payAmount > FeeAmount)
                            {
                            throw new Exception("Check the Amount Entered\nTotal Payment Exceeds the Set Amount");
                            }
                        }
                    else
                        {
                        throw new Exception("Enter Actual Fee Amount to be Paid or Set New Fee\n This Fee has been Cleared");
                        }
                    }//close the first if statement
                else
                    {
                    if (payAmount == FeeAmount)
                        {
                        status = "Cleared";
                        //insert into tables
                         Total = payAmount;
                        con.Close();
                        ThirdpayFee();
                        }
                    else if (payAmount < FeeAmount)
                        {
                         Total = payAmount;
                        status = "Not Cleared";
                        ThirdpayFee();
                        }
                    else
                        {
                        con.Close();
                        throw new Exception("Check the Amount Entered\nTotal Payment Exceeds the Set Amount"); 

                        }
                    }
                }//ene of try block
            catch (ExceptionHandling Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        //METHOD TO MAKE FEE PAYMENT THE FIRST TIME EACH FEE IS PAID
        private void ThirdpayFee()
            {
            con.Open();
            try
                {
                
                //INSERT THE CLASS ID AND STUDENT IDS INTO THE FEES TABLE
                SqlCommand cmd = new SqlCommand("INSERT INTO Fees VALUES('" + classId + "','" + studId + "')", con);
                cmd.ExecuteNonQuery();
                DataTable dtc = new DataTable();
                SqlCommand cmd2 = new SqlCommand("SELECT  MAX(Fee_Id) FROM Fees ", con);
                SqlDataAdapter dacid = new SqlDataAdapter(cmd2);
                dacid.Fill(dtc);
                var clasid = 0;
                foreach (DataRow drc in dtc.Rows)
                    {
                    //GET THE ID OF THE JUST INSERTED RECORD
                    feeid = Convert.ToInt32(drc[0]); 
                    }
                var pdate = dateTimePicker1.Value.Date.ToShortDateString(); 
                //INSER THE RECORDS INTO THE DATABASE
                SqlCommand cmdpay = new SqlCommand(); 
                cmdpay.Connection = con;
                cmdpay.Parameters.Clear();
                cmdpay.CommandType = CommandType.Text;
                cmdpay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar));
                cmdpay.Parameters.Add(new SqlParameter("@sesid", SqlDbType.VarChar));
                cmdpay.Parameters["@feeid"].Value = feeid;
                cmdpay.Parameters["@total"].Value = Total;
                cmdpay.Parameters["@feename"].Value = combFeeName.SelectedItem;
                cmdpay.Parameters["@status"].Value = status;
                cmdpay.Parameters["@date"].Value = pdate;
                cmdpay.Parameters["@sesid"].Value = sessionId;
                cmdpay.CommandText = "INSERT INTO ThirdTerm VALUES (@feeid ,@feename,@total,@status,@date ,@sesid) "; 
                cmdpay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid "+combFeeName.SelectedItem.ToString();
                    dataAccess.Activities();
                    //CASH CLASS HERE
                    Cash ch = new Cash();
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Succefully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }
            catch (SqlException Ex)
                {
                //ON ANY ERROR DURING INSERTION DELETE THE RECORDS INSERTED
                SqlCommand deletefee = new SqlCommand("DELETE Fees where Fee_Id='" + feeid + "' and Student_Id='" + studId + "' and Class_Id='" + classId + "'", con);
                deletefee.ExecuteNonQuery();
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                deleteTaller.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                //ON ANY ERROR DURING INSERTION DELETE THE RECORDS INSERTED
                SqlCommand deletefee = new SqlCommand("DELETE Fees WHERE Fee_Id='" + feeid + "' AND Student_Id='" + studId + "' and Class_Id='" + classId + "'", con);
                deletefee.ExecuteNonQuery();
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                deleteTaller.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        //THIRD TERM METHOD TO UPDATE ALREADY PAID FEES
        public void UpdateThirdTermpaidFee()
            {
            try
                { 
                con.Open();
                    Total = paidAmount + payAmount; 
                var search ="SELECT Fees.Fee_Id FROM Fees WHERE Fee_Id IN(SELECT Fee_Id FROM ThirdTerm WHERE Fee_Id =@feeid  AND Fee_Name=@feename);";
                     
                DataTable dtcUpdate = new DataTable(); 
                SqlDataAdapter daThirdTermFeeID = new SqlDataAdapter(search,con);
                daThirdTermFeeID.SelectCommand.Parameters.AddWithValue("@feeid", SqlDbType.VarChar).Value = feeid;
                daThirdTermFeeID.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
                    daThirdTermFeeID.Fill(dtcUpdate);
                
                foreach (DataRow drFeeID in dtcUpdate.Rows)
                    {
                    feeid = Convert.ToInt32(drFeeID["Fee_Id"]);
 
                    }
                SqlCommand cmdUpdatePay = new SqlCommand();
                cmdUpdatePay.Connection = con;
                cmdUpdatePay.Parameters.Clear();
                cmdUpdatePay.CommandType = CommandType.Text;
                cmdUpdatePay.Parameters.Add(new SqlParameter("@feeid", SqlDbType.VarChar));
                cmdUpdatePay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdUpdatePay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdUpdatePay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));
                cmdUpdatePay.Parameters["@feeid"].Value = feeid;
                cmdUpdatePay.Parameters["@total"].Value = Total;
                cmdUpdatePay.Parameters["@feename"].Value = combFeeName.SelectedItem;
                cmdUpdatePay.Parameters["@status"].Value = status;
                cmdUpdatePay.CommandText = "UPDATE  ThirdTerm  SET Amount=@total,Status=@status WHERE Fee_Id=@feeid  and Fee_Name=@feename ";
                cmdUpdatePay.ExecuteNonQuery();
                con.Close();
                    dataAccess.Description = "Paid "+combFeeName.SelectedItem;
                    dataAccess.Activities();
                    //CASH CLASS HERE
                    Cash ch = new Cash();
                    ch.insertCastPay(txtname, txtClass, combFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype, year);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                }

            catch (SqlException Ex)
                { 
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception Ex)
                {
                con.Close();
                MessageBox.Show(Ex.Message + "\nPayment Not Succeful", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        void ClearAll()
            {
            txtAmount.Text = "";
            radioDebt.Checked = false;
            radioCurrent.Checked = false;
            checkTaller.Checked = false;
            Taller.TallerID = null;
            clicked = 0;
            }
        /// <summary>
        /// /GET THE SECTION USING THE CLASS NAME
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region
        public string ClassName(string name)
            {
            //not in use
            //GET THE CLASS NAME ENTERED AND RETURN THE SECTION IT BELONGS
            if (string.IsNullOrEmpty(name))
                { 
                throw new Exception("Class not found");
                }

            else
                {  
               var subname = name.Substring(0 , 3).Trim().ToLower();
                if (subname.StartsWith("day"))
                    {
                    Names = "Daycare";
                    
                    }
                else if (subname.StartsWith("js"))
                    {
                    Names = "Junior"; 
                    }
                else if (subname.StartsWith("bas"))
                    {
                    Names = "Basic"; 
                    }

                else if (subname.StartsWith("ss"))
                    {
                    Names = "Senior";
                     
                    }
                else if (subname.StartsWith("pri"))
                    {
                   Names = "Primary";
                    
                    }
                else if (subname.StartsWith("nur"))
                {
                    Names = "Nursery";
                     
                }
                else if (subname.StartsWith("pre"))
                {
                    Names = "Prenursery";
                    
                }
                else if (subname.StartsWith("cre"))
                {
                    Names = "Creche"; 
                }
                }
            return Names;
            }
        #endregion
        private void txtdebtyear_Click(object sender, EventArgs e)
            {
            //LOAD THE YEAR FROM THE SESSION TABLE
            dataAccess.setSessionYear(listYear);
            listYear.Visible = true;
            }

        private void listYear_MouseLeave(object sender, EventArgs e)
            {
            //listYear.Visible = false;
            //listYear.Items.Clear();
            }

        private void listYear_Click(object sender, EventArgs e)
            {
            try
                {
                txtdebtyear.Text = listYear.SelectedItem.ToString();
                txtFeeAmount.Clear();
                listYear.Visible = false;
                listYear.Items.Clear();
                this.ActiveControl = txtdebtyear;
            }
            catch (NullReferenceException)
                {
                 
                }
            catch (Exception)
                {
          
                }
            }

        private void dataGridAmount_Click(object sender, EventArgs e)
            {
            try{

                var amount = Convert.ToInt32(dataGridAmount.SelectedRows[0].Cells[1].Value);
                txtFeeAmount.Text = amount.ToString();
                }catch (Exception)
                {

                }
            }
        /// <summary>
        /// Set the amount for the debt to be paid when the year is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void txtFeeAmount_Click(object sender, EventArgs e)
            {
            //get the fee for the selected fee
            SqlConnection con = new DBConnection().getConnection();
            con.Open();
            DataTable dtAmount = new DataTable();//I JUST MODIFIED THIS QUERY ON THE 31/12/2019
            SqlDataAdapter daAmount = new SqlDataAdapter("SELECT SetFees.Fee_Name, SetFees.Amount FROM SetFees WHERE Session_Id in" +
             "(SELECT Session_Id FROM Session WHERE Session.Start_Year=@startyear AND SetFees.Fee_Name =@feename)", con);
            daAmount.SelectCommand.Parameters.AddWithValue("@startyear", SqlDbType.VarChar).Value = txtdebtyear.Text;
            daAmount.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = combFeeName.SelectedItem;
            daAmount.Fill(dtAmount);
            dataGridView1.Rows.Clear();
            foreach (DataRow drA in dtAmount.Rows)
                {
                dataGridAmount.Visible = true;
                int n = dataGridAmount.Rows.Add();
                dataGridAmount.Rows[n].Cells[0].Value = drA[0];
                dataGridAmount.Rows[n].Cells[1].Value = string.Format("{0:00}", drA[1]);
                }
            con.Close();
            }
        #endregion
        private void dataGridAmount_MouseLeave(object sender, EventArgs e)
            {
            dataGridAmount.Visible = false;
            dataGridAmount.Rows.Clear();
            }

        private void txtClass_Click(object sender, EventArgs e)
            {
            dataAccess.setClassName(listClass);
            listClass.Visible = true;
            }

        private void listClass_Click(object sender, EventArgs e)
            {
            try{
            txtClass.Text = listClass.SelectedItem.ToString();
                listClass.Visible = false;
                listClass.Items.Clear();
            }
            catch(Exception){
                
                
                }
            }
  
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
            {
            if(char.IsNumber(e.KeyChar)){
                
                }
            else{
            e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void txtFeeAmount_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {

                }
            else
                {
                e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void txtdebtyear_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {

                }
            else
                {
                e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void combInstall_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {

                }
            else
                {
                e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void btnOtherPayments_Click(object sender, EventArgs e)
            {
            EventPayForm EventPay = new EventPayForm();
                EventPay.Show();
            }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            clicked = 0;
            dataGridView1.Visible = false; 
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (char.IsLetter(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Clear();
            txtAmount.Clear();
            txtname.Clear();
            txtFeeAmount.Clear();
            txtdebtyear.Clear();
             
        }
        /// <summary>
        /// Call the receipt method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ntmReceipt_Click(object sender, EventArgs e)
            {
                try
                {
                if (printTime > 0)
                    {
                    CashID();
                    ReceiptView RV = new ReceiptView();
                    RV.ShowDialog();
                    }
                else
                    {
                    throw new Exception("No receipt to print, please print from \"Records\"");
                    }
                }
                catch (Exception Ex)
                {

                MessageBox.Show(Ex.Message + "\nReceipt could Not be generated", "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        //get the ID of the just paid fee
        private int CashID()
        {
            try
            { 
                con.Open();
                SqlCommand receipt = new SqlCommand("SELECT MAX(ID) FROM Cash", con);
                SqlDataAdapter recDt = new SqlDataAdapter(receipt);
                DataTable dtrec = new DataTable();
                recDt.Fill(dtrec);
                foreach (DataRow dtR in dtrec.Rows)
                {
                    var cash = Convert.ToInt32(dtR[0]);
                    dataAccess.DcashId = cash;
                }
                con.Close();
                return dataAccess.DcashId;

            }
            catch (Exception)
            {
                throw new Exception("Operation Failed");
            }
            }
        
        private void Payment_Click(object sender, EventArgs e)
        {
            listClass.Visible = false;
            listClass.Items.Clear();
        }
         
        private void checkTaller_Click(object sender, EventArgs e)
        {
            if (checkTaller.Checked == false && Taller.TallerID !=null)
            {
                try
                {
                    //delete the last inserted record
                    con.Open();
                    SqlCommand deleteTaller = new SqlCommand("DELETE Taller WHERE ID=0", con);
                    deleteTaller.ExecuteNonQuery();
                    Taller.TallerID = null;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        private void timerPrint_Tick(object sender , EventArgs e)
            {
            printTime--;
            if (printTime == 0)
                {
                timerPrint.Stop();
                }
            }
        }
    }
