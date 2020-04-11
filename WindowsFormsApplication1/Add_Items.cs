using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WindowsFormsApplication1
    {
    public partial class Add_Items : Form
        {
        int infor = 0;
        int qty = 0;
        int price = 0;
        int selection = 0;
        int oldQty = 0;
        setSales set = new setSales();
        public Add_Items()
            {
            InitializeComponent();
            setSales.Items(dataGridItmes);
            }

        private void txtItemName_Click(object sender , EventArgs e)
            {
            txtItemName.Clear();
            }

        private void txtSeachBox_Click(object sender , EventArgs e)
            {
            if (lblClick.Visible == true)
                {
                lblClick.Visible = false;
                setSales.Items(dataGridItmes);
                }
            txtSeachBox.Clear();
            }

        private void btnClose_Click(object sender , EventArgs e)
            {
            this.Close();
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

        private void txtSellingPrice_KeyPress(object sender , KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {
                }
            else
                {
                e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }

        private void txtAmount_KeyPress(object sender , KeyPressEventArgs e)
            {
            if (char.IsNumber(e.KeyChar))
                {
                }
            else
                {
                e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
        void Clear()
            {
            set.ItemID=0;
            txtAmount.Text="0";
            txtItemName.Clear();
            txtquantity.Text="0";
            txtSellingPrice.Text="0";
            dateTimeAdded.Text =DateTime.Today.ToString("MM/dd/yyy");
            selection = 0;
            oldQty = 0;
            }
        private string showAmount(int qty=0, int price=0)
            {
            var amount = qty * price;
            return amount.ToString();
            }
        private void btnaddnew_Click(object sender , EventArgs e)
            {
            Clear();
            }

        private void btnSave_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtItemName.Text))
                    {
                    throw new Exception("item name is empty");
                    }
                

                set.SetItemName(txtItemName.Text);
                set.SetSellinPrice(txtSellingPrice.Text);
                set.SetQuantity(txtquantity.Text);
                set.RecordSaleItems(set.GetItemName() , set.GetQuantity() , set.GetSellingPrice().ToString() , txtAmount.Text , dateTimeAdded);
                infor = 10;
                Infortimer.Start();
                Clear();
               btnRefresh.ForeColor=Color.Blue;
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Save Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void txtquantity_TextChanged(object sender , EventArgs e)
            {
            if (!string.IsNullOrEmpty(txtquantity.Text) && !string.IsNullOrEmpty(txtSellingPrice.Text) && selection==0)
                {
                qty = Int32.Parse(txtquantity.Text);
                price = Int32.Parse(txtSellingPrice.Text);
                var cost = qty * price;
                txtAmount.Text = cost.ToString();
                }
             
            }

        private void txtSellingPrice_TextChanged(object sender , EventArgs e)
            {
            if (!string.IsNullOrEmpty(txtquantity.Text) && !string.IsNullOrEmpty(txtSellingPrice.Text) && selection == 0)
                {
                qty = Int32.Parse(txtquantity.Text);
                price = Int32.Parse(txtSellingPrice.Text);
                var cost = qty * price;
                txtAmount.Text = cost.ToString();
                }
            
            }

        private void txtquantity_Click(object sender , EventArgs e)
            {
            txtquantity.Clear();
            selection = 0;
            }

        private void Infortimer_Tick(object sender , EventArgs e)
            {
            if (infor > 0)
                {
                lblinfor.Visible = true;
                infor--;
                }
            else
                {
                lblinfor.Visible = false;
                Infortimer.Stop();
                }
            }

        
        private void btnUpdate_Click(object sender , EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtItemName.Text))
                    {
                    throw new Exception("Item name Can't be empty");
                    }
                set.SetSellinPrice(txtSellingPrice.Text);
                set.SetQuantity(txtquantity.Text);
                var amount = Int32.Parse(txtAmount.Text);
                if (set.getItemID() == 0)
                    {
                    throw new Exception("No record is selected, Select a record and try again");
                    }
                //MODIFY THE COHER
                var newQty = oldQty + set.GetQuantity();
                set.UpdateSaleItems(set.getItemID() , txtItemName.Text , newQty, set.GetSellingPrice().ToString() , amount.ToString() , dateTimeAdded);
                Clear();
                infor = 10;
                Infortimer.Start();
                btnRefresh.ForeColor = Color.Blue;

                }
            catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Operation failed" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void btnDelete_Click(object sender , EventArgs e)
            {
            try
                {
                if (set.getItemID() == 0)
                    {
                    throw new Exception("No record is selected, Select a record and try again");
                    }
                else if(MessageBox.Show("This will delete all sales record for selected item\nDo you want to continue ?","Confim Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                    {
                    set.Delete(set.getItemID());
                    Clear();
                    infor = 10;
                    Infortimer.Start();
                    btnRefresh.ForeColor = Color.Blue;

                    dataAccess.Description = "Deleted " + txtItemName.Text;
                    dataAccess.Activities();
                    }
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Operation failed" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void checkTotalAmount_Click(object sender , EventArgs e)
            {
            if (checkTotalAmount.Checked == true)
                {
                lblTotal.Text = string.Format("{0:00.#0}" , setSales.Total);
                lblTotal.Visible = true;
                }
            else { lblTotal.Visible = false; }
            }

        private void txtSeachBox_TextChanged(object sender , EventArgs e)
            {
            try
                {
                 
                if (string.IsNullOrEmpty(txtSeachBox.Text))
                    {
                    setSales.Items(dataGridItmes);
                    }
                else
                    {
                     
                    setSales.SearchItems(dataGridItmes , txtSeachBox.Text);
                    }
                lblTotal.Text = string.Format("{0:00.#0}" , setSales.Total);
                }
            catch(ExceptionHandling ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        private void dateTimeFrom_ValueChanged(object sender , EventArgs e)
            {
            setSales.SearchItems(dataGridItmes , dateTimeFrom);
            lblClick.Visible = true;
            }

        private void lblClick_Click(object sender , EventArgs e)
            {
            lblClick.Visible = false;
            setSales.Items(dataGridItmes);
            }

        private void dataGridItmes_Click_1(object sender , EventArgs e)
            {
            try
                {
                    selection = 1;
                set.ItemID = Int32.Parse(dataGridItmes.SelectedRows[0].Cells[0].Value.ToString());
                txtItemName.Text = dataGridItmes.SelectedRows[0].Cells[1].Value.ToString();
                txtquantity.Text = dataGridItmes.SelectedRows[0].Cells[2].Value.ToString();
                oldQty = Int32.Parse(dataGridItmes.SelectedRows[0].Cells[2].Value.ToString());
                txtSellingPrice.Text = dataGridItmes.SelectedRows[0].Cells[3].Value.ToString();
                txtAmount.Text = string.Format("{0:00.}" , dataGridItmes.SelectedRows[0].Cells[4].Value);
                dateTimeAdded.Text = dataGridItmes.SelectedRows[0].Cells[5].Value.ToString();
                }
            catch (Exception)
                {

                }
            }

        private void txtSellingPrice_Click(object sender , EventArgs e)
            {
            txtSellingPrice.Clear();
            selection = 0;
            }

        private void btnPrint_Click(object sender , EventArgs e)
            {
                var printDialog = new PrintDialog();
                printDialog.ShowDialog();
                if (MyPrinter.Print)
                {
                    MyPrinter.PrintRecordsPortrate(dataGridItmes, MyPrinter.GetPrintTile());
                }
            }

       
        private void btnHowtoUpdate_Click(object sender , EventArgs e)
            {
            how_to_Update_items1.Visible = true;
            }

        private void btnRefresh_Click(object sender , EventArgs e)
        {
            selection = 0;
                setSales.Items(dataGridItmes);
            }

        private void btnStock_Click(object sender , EventArgs e)
            {
            var stock = new SalesStock();
            stock.ShowDialog();
            }
        }
    }
