using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TallerInfor;

namespace WindowsFormsApplication1
{
    public partial class EventPayForm : Form
    {
         
        private  int studId;
        private string Feetype;
        private double payAmount =0;
        private double  paidAmount=0;
        private double  FeeAmount = 0;
        private int feeid = 0;
        private string status;
        private string term;
        private double  Total = 0;
        private int eventClassId = 0;
        int clicked = 0;
        private int printTime = 0;
        SqlConnection con = new DBConnection().getConnection();
        Taller taller = new Taller();
        public EventPayForm()
        {
            InitializeComponent();
            
        }

        private void btnclose_Click(object sender, EventArgs e)
            {
                new Thread(() =>
                {
                    var eventPay = new EvenPayList();
                    PaymentMade += eventPay.OnAppStarted;
                    OnPaymentMade();
                }).Start();
            this.Close();
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

        private void txtname_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (clicked != 1)
                    {
                     
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Name_id, Names.First_Name,Names.Middle_Name, Names.Last_Name FROM Names "+
                        " WHERE Names.First_Name like '%' + @name +'%' OR Middle_Name LIKE '%' + @name+ '%' OR Last_Name LIKE '%' + @name + '%' ORDER BY Names.First_Name ASC" , con);
                    da.SelectCommand.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = txtname.Text;
                   
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
                    con.Close();
                    }
                else
                    {
                    if (string.IsNullOrEmpty(txtname.Text))
                        {
                        dataGridView1.Visible = false;
                        }
                    con.Close();
                    }
                 
                }catch(Exception ex)
                {
                    con.Close();
                MessageBox.Show(ex.Message , "Search error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                }
                
        private void dataGridView1_Click(object sender, EventArgs e)
            {
            try
                {
                clicked = 1;
                var nameid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var fname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var mname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                var lname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtname.Text = fname + " " + mname + " " + lname;

                dataGridView1.Visible = false;
                //GET THE ID OF THE SELECTED NAME
                DataTable dtc = new DataTable();
                SqlDataAdapter daid = new SqlDataAdapter("SELECT Students.Student_Id FROM Students WHERE Students.Name_Id =" + nameid + "" , con);

                daid.Fill(dtc);
                foreach (DataRow dr in dtc.Rows)
                    {
                    var id = dr["Student_Id"];
                    studId = Convert.ToInt32(id);
                    }
                }catch (Exception)
                {

                }
            }

        private void EventPayForm_Load(object sender, EventArgs e)
            {
            
                EventPayment.setEventName(combEventName);
            }

        private void combFeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventPayment.setEventFeeName(combEventName, txtFeeName);
            EventPayment.setEventClassName(listClass, txtFeeName);
            }

        private void txtClass_TextChanged(object sender, EventArgs e)
            {

            }

        private void txtClass_Click(object sender, EventArgs e)
            {
            
                listClass.Visible = true;
                EventPayment.setEventClassName(listClass, txtFeeName);
            }

        private void listClass_MouseLeave(object sender, EventArgs e)
        {
            //listClass.Visible = false;
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtClass.Text = listClass.SelectedItem.ToString();
                listClass.Visible = false;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
            {
                try
                {

                if (string.IsNullOrEmpty(combEventName.Text))
                    {
                    throw new Exception("Please SELECT Fee Name");
                    }
                if (string.IsNullOrEmpty(txtname.Text))
                    {
                    throw new Exception("Please SELECT a Name");
                    }
                if (string.IsNullOrEmpty(txtClass.Text))
                    {
                    throw new Exception("Please SELECT A Class");
                    }
                if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                    throw new Exception("Please Enter Fee Amount");
                    }
                    Fees fs = new Fees();
                    payAmount = double.Parse(string.Format("{0:00}", txtAmount.Text));
                    fs.setAmount(payAmount);
                    payAmount = fs.getAmount(); 


                //CHECK IF IS CURRENT FEE OR DEBT
                if (string.IsNullOrEmpty(combEventName.Text))
                    {
                    throw new Exception("Please SELECT Fee Name");
                    }
                if (string.IsNullOrEmpty(combTerm.Text))
                    {
                    throw new Exception("Select Term");
                    }
                    if (radioCurrent.Checked == true)
                    {
                        Feetype = "Current";
                    }
                    else if (radioDebt.Checked == true)
                    {
                        Feetype = "Debt";
                        //MAKE DEBT PAYMENT
                    }
                    else
                    {
                        throw new Exception("Please Select Fee Type to pay");
                    }

                    if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                        throw new Exception("Please enter The Amount");
                    }
                    

                //ON GETTING STUDENT ID, EXECUTION CONTINUES FROM HER
                con.Open();
                    //GET THE FEE AMOUNT TO BE PAID FOR
                    //MessageBox.Show(Name + "\nStudent" + studId.ToString() + "\n sesId" + sessionId.ToString());
                    DataTable dtpay = new DataTable();
                    SqlDataAdapter dapay = new SqlDataAdapter(
                        " SELECT Amount FROM Events WHERE Name =@event AND Fee_Name =@feename AND Event_Id =@eventid", con);
                    dapay.SelectCommand.Parameters.AddWithValue("@event", SqlDbType.VarChar).Value = combEventName.SelectedItem;
                    dapay.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = txtFeeName.Text;
                    dapay.SelectCommand.Parameters.AddWithValue("@eventid", SqlDbType.VarChar).Value = EventPayment.EventId;
                    DataSet dsId = new DataSet();
                    dapay.Fill(dtpay);
                    dapay.Fill(dsId);
                    int check = dsId.Tables[0].Rows.Count;
                    if (check > 0)
                    {
                        foreach (DataRow drpay in dtpay.Rows)
                        {

                            var getAmount = Convert.ToInt32(drpay[0]);
                            FeeAmount = getAmount; 
                        }
                    }
                    else
                    {

                        MessageBox.Show("Fees amount not Set");
                    }
                     
                    con.Close();
                //MessageBox.Show(studId.ToString(),"Student Id");
                //GET STUDENT ID OF THE PAYER
                DataTable dtGetId = new DataTable();
                    SqlDataAdapter daGetId = new SqlDataAdapter("SELECT ClassName FROM Class WHERE Student_Id =@studid and ClassName=@class", con);
                    daGetId.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                    daGetId.SelectCommand.Parameters.AddWithValue("@class",SqlDbType.VarChar).Value =txtClass.Text.ToUpper();
                     DataSet dsGetId = new DataSet();
                    daGetId.Fill(dtGetId);
                    daGetId.Fill(dsGetId);
                    int checkId = dsGetId.Tables[0].Rows.Count;
                    if (checkId > 0)
                    {
                    //CONFIRM AMOUNT
                    if (CustomMsgBox.Show("Amount:\n" + txtAmount.Text, "Confirm Amount", "Yes", "No") == DialogResult.No)
                    {
                        throw new Exception("Please Check the Amount");
                    }
                    //GET THE TALLER DETAILS
                    if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == true)
                    {
                        var tallerDetails = new TallerForm();
                        tallerDetails.ShowDialog();
                    }
                    if (Taller.TallerError == true)
                    {
                        Taller.TallerError = false;
                        throw new Exception("Teller Image was NOT Uploaded");//on error with the taller upload stop the program
                    }
                    payEventFees(); 
                    }
                    else
                    {
 
                        if (MessageBox.Show("Student Does not belong to the selected Class\nPromote Student?",
                                "Payment Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //CALL PROMOTION METHOD
                            MessageBox.Show("Go To Students Section and \nPromote Student to new Class", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        //else
                        //{
                        //    throw new Exception("Student Not found in Event Class");
                        //}
                    }
                printTime = 15;
                timerPrint.Start();
                } //ene of try block
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

            }
        public  void payEventFees()
            {
            try
                {
                con.Open();

                 DataTable dtgetFee = new DataTable();
                //GET THE FEE ID OF THE INITAL PAYMENT
                SqlDataAdapter daseach = new SqlDataAdapter("SELECT  EventPay.Term, EventPay.Amount, EventPay.Status from EventPay WHERE Id IN (SELECT Id FROM EventClass WHERE EventClass.Id= EventPay.Id "+
                "AND EventPay.Student_Id=@studid AND  EventPay.Fee_Name=@feename AND EventPay.Term=@term );", con);
                daseach.SelectCommand.Parameters.AddWithValue("@studid", SqlDbType.VarChar).Value = studId;
                daseach.SelectCommand.Parameters.AddWithValue("@feename", SqlDbType.VarChar).Value = txtFeeName.Text;
                daseach.SelectCommand.Parameters.AddWithValue("@term", SqlDbType.VarChar).Value = combTerm.SelectedItem;
                DataSet dtchectFee = new DataSet();
                daseach.Fill(dtgetFee);
                daseach.Fill(dtchectFee);
                int x = dtchectFee.Tables[0].Rows.Count; 
                if (x > 0)
                    {

                    foreach (DataRow drfine in dtgetFee.Rows)
                    {
                        term = drfine[0].ToString();
                        var getAmount = Convert.ToInt32(drfine[1]);
                            status = drfine[2].ToString();
                        paidAmount = getAmount; 
                        }
                    if (status == "Cleared" && paidAmount == FeeAmount && combTerm.SelectedItem.ToString()==term)
                        {
                         
                        //THROW A MESSAGE BOX BEFORE PAYING AGAIN
                            if (MessageBox.Show("Student HAS Cleared this Fee \nMake a New Payment?",
                                    "Payment Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                con.Close();
                                insertPaymentDetail();
                            }
                            else 
                            {

                            }
                            con.Close();
                         

                        }
                    else if (status != "Cleared" && paidAmount <= FeeAmount && combTerm.SelectedItem.ToString() != term)
                    {
                        if (MessageBox.Show("Student Has Not Cleared this Fee For previous Term \nMake a New Payment?",
                                "Payment Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            con.Close();
                            insertPaymentDetail();
                        }
                        
                    }
                    
                    else if (paidAmount != 0 && paidAmount < FeeAmount)
                        {
                        if (paidAmount + payAmount == FeeAmount)
                            {
                            status = "Cleared";
                            //insert into tables
                            Total = paidAmount + payAmount;
                            con.Close();
                                UpdatePayment();
                            }
                        else if (paidAmount + payAmount < FeeAmount)
                            {
                            Total = paidAmount + payAmount;
                            status = "Not Cleared";
                            con.Close();
                                UpdatePayment();
                            }
                        else if (paidAmount + payAmount > FeeAmount)
                            {
                            throw new Exception("Check the Amount Entered\nTotal Payment Exceeds the Set Fee");
                            }

                        }
                    else
                        {
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
                         insertPaymentDetail();
           
                        }
                    else if (payAmount < FeeAmount)
                        {
                        
                        status = "Not Cleared";
                        con.Close();
                        insertPaymentDetail();
                        }
                    else
                        {
                        throw new Exception("Please check the SELECTED Fee To Pay and The Amount Entered");
                        }
                     
                    con.Close();
                    }

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


            }

        private void insertPaymentDetail()
        {
            try
            {
              con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Event_Id" , EventPayment.EventId);
                cmd.Parameters.AddWithValue("@Name" , combEventName.SelectedItem);
                cmd.Parameters.AddWithValue("@Class" , txtClass.Text);
                cmd.CommandText="SELECt EventClass.Id from EventClass where Event_Id in(select Event_Id from Events where" +
                                                " Event_Id = @Event_Id AND Events.Name=@Name AND EventClass.Class=@Class);"; 
                cmd.ExecuteNonQuery();
                DataTable dtc = new DataTable();
                SqlDataAdapter dacid = new SqlDataAdapter(cmd);
                dacid.Fill(dtc);
                foreach (DataRow drc in dtc.Rows)
                {
                    eventClassId = Convert.ToInt32(drc[0]); 
                }

              
                Total = paidAmount + payAmount;
                SqlCommand cmdPay = new SqlCommand();
                cmdPay.Connection = con;
                cmdPay.Parameters.Clear();
                cmdPay.Parameters.AddWithValue("@Id" , eventClassId);
                cmdPay.Parameters.AddWithValue("@Student_Id" , studId);
                cmdPay.Parameters.AddWithValue("@Fee_Name" , txtFeeName.Text);
                cmdPay.Parameters.AddWithValue("@Term" , combTerm.SelectedItem);
                cmdPay.Parameters.AddWithValue("@Amount" , txtAmount.Text);
                cmdPay.Parameters.AddWithValue("@Status" , status);
                cmdPay.Parameters.AddWithValue("@Date" , dateTimePicker1.Value.Date.ToShortDateString());
                cmdPay.CommandText= "INSERT INTO EventPay(Id,Student_Id,Fee_Name,Term,Amount,Status,Date) VALUES(@Id,@Student_Id,@Fee_Name,@Term,@Amount,@Status,@Date )";
                cmdPay.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Paid " + txtFeeName.Text;
                dataAccess.Activities();
                //CASH CLASS HERE
                Cash ch = new Cash();
                ch.insertEventPay(txtname, txtClass, txtFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            catch (Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message+"\nAn Error Occured","Insertion Error");
            }


        }
        void ClearAll()
            {
            txtAmount.Clear();
            checkTaller.Checked = false;
            radioCurrent.Checked = false;
            radioDebt.Checked = false;
            Taller.TallerID = null;
            clicked = 0;
            }
        private void UpdatePayment()
        {
        try
            {
            con.Open();
                Total = paidAmount + payAmount;
             
                //CODE THE UPDATE QUERY LATER
                SqlCommand cmdUpdatepay = new SqlCommand();
                cmdUpdatepay.Connection = con;
                cmdUpdatepay.Parameters.Clear();
                cmdUpdatepay.CommandType = CommandType.Text;
                cmdUpdatepay.Parameters.Add(new SqlParameter("@total", SqlDbType.VarChar));
                cmdUpdatepay.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar));
                cmdUpdatepay.Parameters.Add(new SqlParameter("@studid", SqlDbType.VarChar));
                cmdUpdatepay.Parameters.Add(new SqlParameter("@class", SqlDbType.VarChar));
                cmdUpdatepay.Parameters.Add(new SqlParameter("@feename", SqlDbType.VarChar));
                cmdUpdatepay.Parameters.Add(new SqlParameter("@term", SqlDbType.VarChar));

                cmdUpdatepay.Parameters["@total"].Value = Total;
                cmdUpdatepay.Parameters["@status"].Value = status;
                cmdUpdatepay.Parameters["@studid"].Value = studId;
                cmdUpdatepay.Parameters["@class"].Value = txtClass.Text;
                cmdUpdatepay.Parameters["@feename"].Value = txtFeeName.Text;
                cmdUpdatepay.Parameters["@term"].Value = combTerm.SelectedItem; 
            cmdUpdatepay.CommandText="UPDATE Eventpay SET Amount=@total, Status=@status WHERE Id IN(SELECT Id FROM EventClass WHERE" +
                                                         " EventClass.Id = Eventpay.Id AND EventPay.Student_Id=@studid AND EventPay.Fee_Name=@feename" +
                                                         "' AND EventClass.Class=@class " +
                                                         "AND EventPay.Term=@term);";
            cmdUpdatepay.ExecuteNonQuery();                                       
            con.Close();
            dataAccess.Description = "Paid "+txtFeeName.Text;
            dataAccess.Activities();
            Cash chpay = new Cash();
            chpay.insertEventPay(txtname, txtClass, txtFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype);
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
        #region
        /// <summary>
        /// ADD THIS FEATURE IN NEW VERSIONS
        /// </summary>
        private void debtPayment()
            {
            try
                {
                con.Open();
                Total = paidAmount + payAmount;
                //THIS SECTION IS NOT IN USE FOR NOW
                
                //CODE THE UPDATE QUERY LATER
                //SqlCommand cmdDebtepay = new SqlCommand(, con);
                //cmdDebtepay.ExecuteNonQuery();
                con.Close();
                dataAccess.Description = "Paid debt for " + txtFeeName.Text;
                dataAccess.Activities();
                Cash chpay = new Cash();
                chpay.insertEventPay(txtname, txtClass, txtFeeName, combTerm, txtAmount, dateTimePicker1, combInstall, Feetype);
                Cash.paid = true;
                if (checkTaller.Checked == true && string.IsNullOrEmpty(Taller.TallerID) == false)
                {
                    var ID = CashID();
                    taller.UpdateTaller(ID);
                }
                MessageBox.Show("Fee Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                new Thread(() =>
                    {
                        var eventPay = new EvenPayList();
                        PaymentMade += eventPay.OnAppStarted;
                        OnPaymentMade();
                    }).Start();
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
        #endregion
        private void txtFeeName_TextChanged(object sender, EventArgs e)
        {
            txtClass.Text = "";
        }

        private void btnReceipt_Click(object sender, EventArgs e)
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
                    throw new Exception("No receipt to print, print from \"Records\"");
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message + "\nReceipt Could Not Be Generated", "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        //get the just made payment ID
        private int CashID()
        {
            try
            {
                con.Open();
                SqlCommand receipt = new SqlCommand("SELECT max(ID) FROM Cash", con);
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
        private void radioDebt_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void txtname_Click(object sender, EventArgs e)
        {
            clicked = 0;
            txtname.Clear();
            dataGridView1.Visible = false;
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
            {
            
            }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char) Keys.Back;
                }
            } 
        private void checkTaller_Click(object sender, EventArgs e)
        {
            if (checkTaller.Checked == false && Taller.TallerID !=null)
            {
                //delete the last inserted record
                con.Open();
                SqlCommand deleteTaller = new SqlCommand("Delete Taller where ID=0", con);
                deleteTaller.ExecuteNonQuery();
                Taller.TallerID = null;
                con.Close();
            }
        }


        //END MAIN OF METHOD
    }
        }