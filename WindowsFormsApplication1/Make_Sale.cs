using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Make_Sale : Form
        {
        setSales setsales = new setSales();
        CreditSales creditor = new CreditSales();
        int qty = 0;
        double  price = 0;
        double percent = 0;
        int success = 0; 
        private string NameID = null;
        public Make_Sale()
            {
            InitializeComponent();
            ItemSales.DispayItems(dataGridItmes ,"");
            ItemSales.DispayStudentNames(dataGridStudentNames , "");
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            this.Close();
            }

        private void radioBtnYes_Click(object sender , EventArgs e)
            {
            
            lblPercent.Visible = true;
            lblpercentSign.Visible = true;
            txtPercent.Visible = true;
            txtTotal.Text = "0";
            }

        private void radioBtnNo_Click(object sender , EventArgs e)
            {
            
            txtPercent.Text="0";
            lblPercent.Visible = false;
            lblpercentSign.Visible = false;
            txtPercent.Visible = false;
            txtTotal.Text = txtAmount.Text;
             
            }
 
        private void txtItemName_Click(object sender , EventArgs e)
            {
            txtItemName.Clear();
            setsales.ItemID=0;
            txtItemName.ReadOnly = false;
            ItemSales.DispayItems(dataGridItmes,txtItemName.Text);
            dataGridItmes.Visible = true;
            }

        private void checkCredit_Click(object sender , EventArgs e)
            {
            if (checkCredit.Checked == true)
                {
                picArrow.Visible = true;
                panCredite.Visible = true;
                this.ActiveControl = txtFirstname;
                }
            else
                {
                picArrow.Visible = false;
                panCredite.Visible = false;
                txtFirstname.Clear();
                txtLastname.Clear();
                txtContact.Clear();
                }
            }

        private void txtTotal_Click(object sender , EventArgs e)
            {
            //TODO
            //PERFORM THE OPERATION
            }

        private void txtquantity_TextChanged(object sender , EventArgs e)
            {
            //TODO CALCUATION
            if (!string.IsNullOrEmpty(txtquantity.Text) && !string.IsNullOrEmpty(txtSelingPrice.Text))
                {
                qty = Int32.Parse(txtquantity.Text);
                price = double.Parse(txtSelingPrice.Text);
                double  cost = qty * price;
                txtAmount.Text = cost.ToString();
                }
           
            if (radioBtnYes.Checked == true)
                {
                CalculateTotal();
                }

            if (string.IsNullOrEmpty(txtquantity.Text) && !string.IsNullOrEmpty(txtSelingPrice.Text))
                {
                qty = 0;
                price = double.Parse(txtSelingPrice.Text);
                double  cost = qty * price;
                txtAmount.Text = cost.ToString();
                }
            }

        private void txtquantity_KeyPress(object sender , KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {
                }
            else
                {
                e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
 
        private void dataGridItmes_Click(object sender , EventArgs e)
            {
            try
                {
                txtItemName.ReadOnly = true;
                setsales.ItemID = Int32.Parse(dataGridItmes.SelectedRows[0].Cells[0].Value.ToString());
                txtSelectedItemName.Text = dataGridItmes.SelectedRows[0].Cells[1].Value.ToString();
                this.ActiveControl = txtquantity;
                txtSelingPrice.Text = ItemSales.setSellinPrice(setsales.getItemID()).ToString();
                txtquantity.Text = "0";
                }
            catch (Exception)
                {

                }
            }

        private void txtItemName_TextChanged(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtItemName.Text)) {
                    ItemSales.DispayItems(dataGridItmes , txtItemName.Text);
                    }
                else{
                 
                ItemSales.DispayItems(dataGridItmes , txtItemName.Text);
                }
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        void CalculateTotal()
            {
            try
                { 
                double total = 0;
                double  amount = double.Parse(txtAmount.Text);
                total = amount - (amount * percent / 100);
                txtTotal.Text = total.ToString();
                }catch (Exception)
                {

                }
            }
        private void txtPercent_TextChanged(object sender , EventArgs e)
            {
            try
                {
                string pattern = @"(^[a-zA-Z@!#$%^&*()~]+)$";
                Match match = Regex.Match(txtPercent.Text , pattern);
                if (match.Success)
                    {
                    throw new Exception("Percent contain invalid character");
                    }
                if (!string.IsNullOrEmpty(txtPercent.Text))
                    { 
                    if(txtPercent.Text.StartsWith("0") && txtPercent.Text.Length >2 && txtPercent.Text.Contains(".") == false)
                        {
                        throw new Exception("Discount percent is not a valid digit ");
                        }
                    percent = Convert.ToDouble(txtPercent.Text);
                    
                    if (percent > 0)
                        {
                        CalculateTotal();
                        }
                    }
                else
                    {
                    txtTotal.Text = txtAmount.Text;
                    }
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Percent Digit Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnSubmit_Click(object sender , EventArgs e)
            {
            try
                {
                if (checkCredit.Checked == true)
                    {
                    //operation
                    creditor.SetFirstname(txtFirstname.Text);
                    creditor.SetLasttname(txtLastname.Text);
                    if (string.IsNullOrEmpty(txtContact.Text))
                        {
                        if (MessageBox.Show("Creditor's Contact is empty\ncontinue ?" , "Contact Error" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                            creditor.SetContact("");
                            }
                        else
                            {
                            throw new Exception("Please provide contact infor and continue");
                            }
                        }
                    else
                        {
                        if (txtContact.Text.Length < 11 || txtContact.Text.Length > 11)
                            {
                            throw new Exception("Creditor's Contact has Invalid length of digits");
                            }
                        creditor.SetContact(txtContact.Text);
                        }
                    setsales.SetQuantity(txtquantity.Text);
                    setsales.SetSellinPrice(txtSelingPrice.Text);
                    if (setsales.getItemID() <= 0)
                        {
                        throw new Exception("Item Not found, Select and item");
                        }
                    if(!radioBtnNo.Checked && !radioBtnYes.Checked)
                        {
                        throw new Exception("Select Yes or No for discount");
                        }
                    if(string.IsNullOrEmpty(txtTotal.Text)| txtTotal.Text == "0")
                        {
                        throw new Exception("Total cost not provided Renter Quantity");
                        }
                var qtyAvailable = 0;
                var qtySold = 0;
                 qtyAvailable = ItemSales.checkItemQuantity(setsales.getItemID());
                qtySold = ItemSales.checkItemQuantitySold(setsales.getItemID());
                if (qtyAvailable <=qtySold )
                    {
                        txtquantity.Text = "0";
                        throw new Exception("Item Selected is not available in Stock\nsales could not complete");
                    }
                if(qtyAvailable < qtySold+ setsales.GetQuantity())
                    {
                       
                    throw new Exception("Quantity entered is greater than available Stock\nsales could not complete");
                    }
                if(checkAddstudentName.Checked==true && NameID == null)
                    {
                    throw new Exception("Student name is NOT Selected");
                    }
                var discount = txtPercent.Text;
                    var NewQty = qtyAvailable - (qtySold+ setsales.GetQuantity());
                    ItemSales.makeSale(setsales.getItemID() , NewQty , setsales.GetQuantity().ToString() , txtAmount.Text , txtTotal.Text , dateTimeAdded , discount , 1,NameID);
                    Clear();
                    success = 10;
                    Infortimer.Start();
                    }
                else
                    {
                    //TO INSERT 
                    setsales.SetQuantity(txtquantity.Text);
                    setsales.SetSellinPrice(txtSelingPrice.Text);
                    var qtyAvail = 0;
                    var qtySold = 0;
                    if (setsales.getItemID() <= 0)
                        {
                        throw new Exception("Item Not found, Select and item");
                        }
                    qtyAvail = ItemSales.checkItemQuantity(setsales.getItemID());
                    qtySold = ItemSales.checkItemQuantitySold(setsales.getItemID());
                    if (qtyAvail <= qtySold)
                        {
                        txtquantity.Text = "0";
                        throw new Exception("Selected item is not available in Stock\nsales could not complete");
                        }
                    if (qtyAvail <  qtySold + setsales.GetQuantity())
                        {
                        throw new Exception("Selected item Quantity is greater than available Stock\nsales could not complete");
                        }
                if (checkAddstudentName.Checked == true && NameID == null)
                    {
                    throw new Exception("Student name is NOT Selected");
                    }
                    if (string.IsNullOrEmpty(txtTotal.Text) | txtTotal.Text == "0")
                        {
                        throw new Exception("Total cost not provided Renter Quantity");
                        }
                    var discount = txtPercent.Text ;
                    var NewQty = qtyAvail - (qtySold + setsales.GetQuantity());
                    ItemSales.makeSale(setsales.getItemID() , NewQty , setsales.GetQuantity().ToString() , txtAmount.Text , txtTotal.Text, dateTimeAdded , discount , 0,NameID);
                    Clear();
                    success = 10;
                    Infortimer.Start();
                    }
            }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Sales Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
    }
        void Clear()
            {
            NameID = null;
            txtSelectedItemName.Clear();
            txtSelingPrice.Clear();
            txtAmount.Clear();
            txtquantity.Clear();
            txtContact.Clear();
            txtFirstname.Clear();
            txtLastname.Clear(); 

            radioBtnNo.Checked = false;
            radioBtnYes.Checked = false;
            checkCredit.Checked = false;
            checkAddstudentName.Checked = false;

            lblStudentName.Visible = false;
            txtStudentName.Clear();
            txtStudentName.Visible = false;
            panCredite.Visible = false;

            lblPercent.Visible = false;
            lblpercentSign.Visible = false;
            txtPercent.Visible = false; 
            txtPercent.Text = "0";

            picArrow.Visible = false;
            txtTotal.Clear();

            btnSubmit2.Visible = false;
            btnSubmit.Visible = true;
            btnClear.Visible = true;
            btnClear2.Visible = false;

            }
        private void Infortimer_Tick(object sender , EventArgs e)
            {
            if (success > 0)
                {
                lblinfor.Visible = true;
                success--;
                }
            else
                {
                lblinfor.Visible = false;
                Infortimer.Stop();
                }
            }

       
        private void checkAddstudentName_Click(object sender , EventArgs e)
            {
            if (checkAddstudentName.Checked == true)
                {
                panItemsList.Visible = false;
                panStudents.Visible = true;
                }
            else
                {
                panStudents.Visible = false;
                panItemsList.Visible = true;
                lblStudentName.Visible = false;
                txtStudentName.Visible = false;
                btnClear2.Visible = false;
                btnSubmit2.Visible = false;
                btnClear.Visible = true;
                btnSubmit.Visible = true;
                txtStudentName.Clear();
                NameID = null;
                }
            }

        private void dataGridStudentNames_Click(object sender , EventArgs e)
            {
            try {
                NameID = dataGridStudentNames.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentName.Text = dataGridStudentNames.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridStudentNames.SelectedRows[0].Cells[2].Value.ToString();
                btnSubmit.Visible = false;
                btnClear.Visible = false;
                lblStudentName.Visible = true;
                txtStudentName.Visible = true;
                panStudents.Visible = false;
                panItemsList.Visible = true;
                btnClear2.Visible = true;
                btnSubmit2.Visible = true; 
                }
            catch (Exception) { }
                }

        private void txtSearchStudent_TextChanged(object sender , EventArgs e)
            {
            try {
                if (string.IsNullOrEmpty(txtSearchStudent.Text))
                    {
                    ItemSales.DispayStudentNames(dataGridStudentNames , txtSearchStudent.Text);
                    }
                else
                    {
                    
                    ItemSales.DispayStudentNames(dataGridStudentNames , txtSearchStudent.Text);
                    }
                    }catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Student Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void txtStudentName_Click(object sender , EventArgs e)
            {
            panItemsList.Visible = false;
            panStudents.Visible = true;
            }

        private void txtSearchStudent_Click(object sender , EventArgs e)
            {
            txtSearchStudent.Clear();
            }

        private void txtContact_KeyPress(object sender , KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {
                }
            else
                {
                e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }

        private void btnClear_Click(object sender , EventArgs e)
            {
            Clear();
            }

        private void btnClear2_Click(object sender , EventArgs e)
            {
            Clear();
                     }

        private void btnSubmit2_Click(object sender , EventArgs e)
            {
            try
                {
                if (checkCredit.Checked == true)
                    {
                    //operation
                    creditor.SetFirstname(txtFirstname.Text);
                    creditor.SetLasttname(txtLastname.Text);
                    if(string.IsNullOrEmpty(txtContact.Text))
                        {
                        if(MessageBox.Show("Creditor's Contact is empty\ncontinue ?","Contact Error" , MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                            creditor.SetContact("");
                            }
                        else
                            {
                            throw new Exception("Please provide contact infor and continue");
                            }
                        }
                    else
                        {
                        if (txtContact.Text.Length < 11 || txtContact.Text.Length > 11)
                            {
                            throw new Exception("Creditor's Contact has Invalid length of digits");
                            }
                        creditor.SetContact(txtContact.Text);
                        }
                    
                    setsales.SetQuantity(txtquantity.Text);
                    setsales.SetSellinPrice(txtSelingPrice.Text);
                    if (setsales.getItemID() <= 0)
                        {
                        throw new Exception("Item Not found, Select and item");
                        }
                    var qtyAvailable = 0;
                    var qtySold = 0;
                    qtyAvailable = ItemSales.checkItemQuantity(setsales.getItemID());
                    qtySold = ItemSales.checkItemQuantitySold(setsales.getItemID());
                    if (qtyAvailable <= qtySold)
                        {
                        throw new Exception("Item Selected is not available in Stock\nsales could not completed");
                        }
                    if (qtyAvailable < qtySold + setsales.GetQuantity())
                        {
                        throw new Exception("Quantity entered is greater than available Stock\nsales could not completed");
                        }
                    if (checkAddstudentName.Checked == true && NameID == null)
                        {
                        throw new Exception("Student name is NOT Selected");
                        }
                    if (string.IsNullOrEmpty(txtTotal.Text) | txtTotal.Text == "0")
                        {
                        throw new Exception("Total cost not provided Renter Quantity");
                        }
                    var discount = txtPercent.Text;
                    var NewQty = qtyAvailable -(qtySold+ setsales.GetQuantity());
                    ItemSales.makeSale(setsales.getItemID() , NewQty , setsales.GetQuantity().ToString() , txtAmount.Text , txtTotal.Text , dateTimeAdded , discount , 1 , NameID);
                    Clear();
                    success = 10;
                    Infortimer.Start();
                    }
                else
                    {
                    //TO INSERT 
                    setsales.SetQuantity(txtquantity.Text);
                    setsales.SetSellinPrice(txtSelingPrice.Text);
                    var qtyAvail = 0;
                    var qtySold = 0;
                    if (setsales.getItemID() <= 0)
                        {
                        throw new Exception("Item Not found, Select and item");
                        }
                    qtyAvail = ItemSales.checkItemQuantity(setsales.getItemID());
                    qtySold = ItemSales.checkItemQuantitySold(setsales.getItemID());
                    if (qtyAvail <= qtySold)
                        {
                        throw new Exception("Selected item is not available in Stock\nsales could not completed");
                        }
                    if (qtyAvail < qtySold + setsales.GetQuantity())
                        {
                        throw new Exception("Selected item Quantity is greater than available Stock\nsales could not completed");
                        }
                    if (checkAddstudentName.Checked == true && NameID == null)
                        {
                        throw new Exception("Student name is NOT Selected");
                        }
                    if (string.IsNullOrEmpty(txtTotal.Text) | txtTotal.Text == "0")
                        {
                        throw new Exception("Total cost not provided Renter Quantity");
                        }
                    var discount = txtPercent.Text ;
                    var NewQty = qtyAvail -(qtySold+ setsales.GetQuantity());
                    ItemSales.makeSale(setsales.getItemID() , NewQty , setsales.GetQuantity().ToString() , txtAmount.Text , txtTotal.Text , dateTimeAdded , discount , 0 , NameID);
                    Clear();
                    success = 10;
                    Infortimer.Start();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Sales Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }

            }

        private void txtFirstname_TextChanged(object sender , EventArgs e)
            {
            
                if (!string.IsNullOrEmpty(txtFirstname.Text))
                    {
                Check(txtFirstname.Text,label8.Text);
                    }
               
            }
        void Check( string check,string show)
            {
            string pattern = @"([a-zA-Z. ]+)";
            Match match = Regex.Match(check , pattern);
            try
                {
                 
                if (!match.Success)
                    {
                    throw new Exception(show+ " should contain only alphabets.");
                    }
                else if (txtFirstname.Text.Length > 30)
                    {
                    throw new Exception(show + " length of characters is exceeded, reduce.");
                    }

                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Input Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
        private void txtLastname_TextChanged(object sender , EventArgs e)
            {
             
                if (!string.IsNullOrEmpty(txtLastname.Text))
                    {
                Check(txtLastname.Text, label9.Text);
                } 
            }

        private void txtContact_TextChanged(object sender , EventArgs e)
            {
            string pattern = @"^(\d+)$";
            Match match = Regex.Match(txtContact.Text , pattern);
            try
                {
                if (!string.IsNullOrEmpty(txtContact.Text))
                    {
                    if (!match.Success)
                        {
                        throw new Exception("Creditor's Contact should contain only Digits");
                        }
                    }
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Input Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                }
 
        }
        }
