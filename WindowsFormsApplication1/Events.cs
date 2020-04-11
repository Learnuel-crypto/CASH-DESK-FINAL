using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
    {
    public partial class EventsForm : Form
        {
        SqlConnection con = new DBConnection().getConnection();
        public EventsForm()
            {
            InitializeComponent();
            displays();
            }
         
        private void Events_Load(object sender, EventArgs e)
            {
            dataAccess.setClassName(combClass);
            }
        void displays()
            {
            try
                {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select  *from Events", con);
                da.Fill(dts);
                dataGridEvents.Rows.Clear();
                foreach (DataRow dr in dts.Rows)
                    {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridEvents.Rows.Add();
                    dataGridEvents.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridEvents.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridEvents.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridEvents.Rows[n].Cells[3].Value = string.Format("{0:00.00}", dr[3]);
                    dataGridEvents.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" ,dr[4]);

                    }
                con.Close();
                }
            catch (Exception)
                {

                }
            }

        void Searchdisplays(TextBox search)
        {
            try
            {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Events WHERE Fee_Name LIKE'%' + @search + '%'OR Name LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%'", con);
                da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
                da.Fill(dts);
                dataGridEvents.Rows.Clear();
                foreach (DataRow dr in dts.Rows)
                {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridEvents.Rows.Add();
                    dataGridEvents.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridEvents.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridEvents.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridEvents.Rows[n].Cells[3].Value = string.Format("{0:00.00}", dr[3]);
                    dataGridEvents.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}", dr[4]);

                }
                con.Close();
            }
            catch (Exception)
            {

            }
        }
        void Search(TextBox search)
            {
            try
                {
                con.Open();
                DataTable dts = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Events WHERE Fee_Name = @search OR Name =@search  OR Amount = @search " , con);
                da.SelectCommand.Parameters.AddWithValue("@search" , SqlDbType.VarChar).Value = search.Text;
                da.Fill(dts);
                dataGridEvents.Rows.Clear();
                foreach (DataRow dr in dts.Rows)
                    {
                    //DISPLAY THE RECORDS IN THE GRID VIEW CONTROL AS THEY ARE SEARCH IN THE DATABASE
                    int n = dataGridEvents.Rows.Add();
                    dataGridEvents.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridEvents.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridEvents.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridEvents.Rows[n].Cells[3].Value = string.Format("{0:00.00}" , dr[3]);
                    dataGridEvents.Rows[n].Cells[4].Value = string.Format("{0:MM/dd/yyyy}" , dr[4]);

                    }
                con.Close();
                }
            catch (Exception)
                {

                }
            }
            void setEventClass(ListBox text)
            {
                try
                    {
                    //SET THE YEAR OF THE SCHOOL SESSION THE LIST BOX CONTROL
                    SqlConnection con = new DBConnection().getConnection();
                    con.Open();
                    text.Items.Clear();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Id,Class FROM EventClass WHERE Event_Id='" + dataAccess.eventId + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                        {
                        // text.Items.Add((dr[0].ToString()));
                        text.Items.Add((dr[1].ToString()));
                        }
                    con.Close();
                    }
                catch (Exception) { }
                }
            
        private void btnaddnew_Click(object sender, EventArgs e)
            {
            dataAccess.clearNames(txtEventName, txtEventFeeName, txtEventAmount, txtEventID);
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            listEventClass.Items.Clear();
            txtEventClassId.Clear();
             
            }

        private void btnCreate_Click(object sender, EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtEventName.Text))
                    throw new Exception("Enter Event Name");
                if (string.IsNullOrEmpty(txtEventFeeName.Text))
                    throw new Exception("Enter the Event Fee Name");
                if (string.IsNullOrEmpty(txtEventAmount.Text))
                    throw new Exception("Please Enter Event Amount");
                
                dataAccess.insertEvent(txtEventName.Text, txtEventFeeName.Text, txtEventAmount.Text , dateTimePicker1.Value.ToShortDateString());
                dataAccess.clearNames(txtEventName , txtEventFeeName , txtEventAmount , txtEventID);
                displays();
                }
            catch(Exception Ex){
            con.Close();
            MessageBox.Show(Ex.Message, "Error occured",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        private void txtEventAmount_KeyPress(object sender, KeyPressEventArgs e)
            {
            if(char.IsNumber(e.KeyChar)){
                }
            else{
            e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void listEventClass_Click(object sender, EventArgs e)
            {
            try{
            txtEdithClass.Text = listEventClass.SelectedItem.ToString();

            txtEventClassId.Text = listEventClass.SelectedItem.ToString();
                }
            catch(Exception ){
                
                }
            }

        private void txtEventName_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsLetter(e.KeyChar)||(e.KeyChar == ' '))
                {
                }
            else{
            e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void txtEventFeeName_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsLetter(e.KeyChar)|| (e.KeyChar ==' '))
                {
                }
            else
                {
                e.Handled = e.KeyChar != (char) Keys.Back;
                }
            }

        private void dataGridEvents_Click(object sender, EventArgs e)
            {
            try
                {
                //DISPLAY THE GRID VIEW ROW SELECTED IN THE TEXBOXES
                txtEventID.Text = dataGridEvents.SelectedRows[0].Cells[0].Value.ToString();
                dataAccess.eventId = Convert.ToInt32(txtEventID.Text);
                txtEventName.Text = dataGridEvents.SelectedRows[0].Cells[1].Value.ToString();
                txtEventFeeName.Text = dataGridEvents.SelectedRows[0].Cells[2].Value.ToString();
                var amount = dataGridEvents.SelectedRows[0].Cells[3].Value.ToString();
                txtEventAmount.Text = string.Format("{0:00}" , amount.ToString());
                dateTimePicker1.Text = dataGridEvents.SelectedRows[0].Cells[4].Value.ToString();
              setEventClass(listEventClass);
                }catch (Exception) { }
            }

        private void btnClassView_Click(object sender, EventArgs e)
            {
            try
            { 
                
                if (listEventClass.Items.Contains(combClass.SelectedItem))
                    throw new Exception("Class is Already Added to this Event");
                con.Open();
                if (string.IsNullOrEmpty(txtEventID.Text))
                    {
                    throw new Exception("Select Event to Add Class");
                    }
                else if(string.IsNullOrEmpty(combClass.Text)){
                throw new Exception("Enter Class Name to Add to Event ");
                    }
                else
                    {
                    SqlCommand cmd = new SqlCommand("INSERT INTO EventClass VALUES(@eventid,@class,@date)", con);
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@eventid" , SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@class" , SqlDbType.VarChar)); 
                    cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                    cmd.Parameters["@eventid"].Value = dataAccess.eventId;
                    cmd.Parameters["@class"].Value = combClass.SelectedItem;
                    cmd.Parameters["@date"].Value = dateTimePicker1.Value;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataAccess.Description = "Added Class to An Event";
                    dataAccess.Activities();
                    setEventClass(listEventClass); 
                    combClass.SelectedItem = "";
                     
                    }
                }
            catch(Exception Ex){
            con.Close();
            MessageBox.Show(Ex.Message, "Add Class Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void btnUpdateClass_Click(object sender, EventArgs e)
            {
            try{
            if(listEventClass.Items.Contains(txtEdithClass.Text))
            throw new Exception("Class Already Exist for this Event");
            if(string.IsNullOrEmpty(txtEdithClass.Text))
             throw new Exception("Select Class To Update");
                
            con.Open();
            
            SqlCommand sqlupdate = new SqlCommand();
            sqlupdate.Connection = con;
            sqlupdate.CommandType = CommandType.Text;
            sqlupdate.Parameters.Clear();
            sqlupdate.Parameters.Add(new SqlParameter("@newclass", SqlDbType.VarChar));
            sqlupdate.Parameters.Add(new SqlParameter("@eventclassid" , SqlDbType.VarChar));
            sqlupdate.Parameters.Add(new SqlParameter("@eventid" , SqlDbType.VarChar));
            sqlupdate.Parameters["@newclass"].Value = txtEdithClass.Text;
            sqlupdate.Parameters["@eventclassid"].Value = txtEventClassId.Text;
            sqlupdate.Parameters["@eventid"].Value = txtEventID.Text;
            sqlupdate.CommandText= "UPDATE EventClass SET Class=@newclass WHERE Class=@eventclassid AND Event_Id=@eventid";
                sqlupdate.ExecuteNonQuery();
            con.Close();
                dataAccess.Description="Updated Event Class";
                dataAccess.Activities();
                txtEventClassId.Text = "";
               setEventClass(listEventClass);
            
                }
            catch(Exception Ex){
            con.Close();
                 MessageBox.Show(Ex.Message, "Update Class Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void btnDelete_Click(object sender, EventArgs e)
            {

            try{
             
            if(string.IsNullOrEmpty(txtEdithClass.Text))
             throw new Exception("Select A Class to Delete");
                
            con.Open();
            
            SqlCommand sqldelete = new SqlCommand();
            sqldelete.CommandType = CommandType.Text;
            sqldelete.Parameters.Clear();
            sqldelete.Parameters.Add(new SqlParameter("@newclass" , SqlDbType.VarChar));
            sqldelete.Parameters.Add(new SqlParameter("@eventclassid" , SqlDbType.VarChar));
            sqldelete.Parameters.Add(new SqlParameter("@eventid" , SqlDbType.VarChar));
            sqldelete.Parameters["@newclass"].Value = txtEdithClass.Text;
            sqldelete.Parameters["@eventclassid"].Value = txtEventClassId.Text;
            sqldelete.Parameters["@eventid"].Value = dataAccess.eventId;
            sqldelete.CommandText= "DELETE EventClass WHERE Class=@newclass AND  Class=@eventclassid AND Event_Id=@eventid";
            sqldelete.ExecuteNonQuery();
            con.Close();
                dataAccess.Description="Deleted A Class From Event";
                dataAccess.Activities();
                txtEventClassId.Clear();
                txtEdithClass.Clear();
               setEventClass(listEventClass); 
                }
            catch(Exception Ex){
                 MessageBox.Show(Ex.Message, "Delete Class Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 con.Close();
                }
            }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
            {try{
            if (string.IsNullOrEmpty(txtEventName.Text))
                throw new Exception("Enter Event Name Or Select Event");
            if (string.IsNullOrEmpty(txtEventFeeName.Text))
                throw new Exception("Enter the Event Fee Name Or Select Event");
            if (string.IsNullOrEmpty(txtEventAmount.Text))
                throw new Exception("Please Enter Event Amount Or Select Event");

            //UPDATE NAMES IN THE NAMES TABLE
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@name" , SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@feename" , SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@amount" , SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@date" , SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@eventid" , SqlDbType.VarChar));
                cmd.Parameters["@name"].Value = txtEventName.Text;
            cmd.Parameters["@feename"].Value = txtEventFeeName.Text;
            cmd.Parameters["@date"].Value = dateTimePicker1.Value.ToShortDateString();
            cmd.Parameters["@amount"].Value = txtEventAmount.Text;
                cmd.Parameters["@eventid"].Value = dataAccess.eventId;
            cmd.CommandText = "UPDATE Events SET Name =@name ,Fee_Name = @feename, Amount =@amount, Date =@date WHERE Event_Id=@eventid ";
                cmd.ExecuteNonQuery();
            con.Close();
            dataAccess.Description = "Updated Event Details";
            dataAccess.Activities();
            displays();
            dataAccess.clearNames(txtEventName , txtEventFeeName , txtEventAmount , txtEventID);
            dateTimePicker1.Visible = true;
            lblDate.Visible = true;
            
                }
            catch(Exception Ex){
            con.Close();
            MessageBox.Show(Ex.Message +"\nDetails Update Failed", "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        private void btndel_Click(object sender, EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtEventID.Text))
                    throw new Exception("Select an Event to Delete");
                if (MessageBox.Show("Delete Selected Event", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    con.Open();
                    SqlCommand cmdDel = new SqlCommand();
                    cmdDel.Connection = con;
                    cmdDel.CommandType = CommandType.Text;
                    cmdDel.Parameters.Clear();
                    cmdDel.Parameters.Add(new SqlParameter("@eventid" , SqlDbType.VarChar));
                    cmdDel.Parameters["@eventid"].Value = dataAccess.eventId;
                    cmdDel.CommandText =
                        "DELETE EventClass WHERE Event_Id =@eventid; DELETE Events WHERE Event_Id =@eventid";
                    cmdDel.ExecuteNonQuery();
                    con.Close();
                    displays();
                   setEventClass(listEventClass);
                    dataAccess.Description = "Delete an Event";
                    dataAccess.Activities();
                    dataAccess.clearNames(txtEventName, txtEventFeeName, txtEventAmount , txtEventID);
                    MessageBox.Show("Event Deleted Successfully", "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    }
                else { }
                }
            catch(Exception Ex){
            con.Close();
            MessageBox.Show(Ex.Message+"\nEvent Delete Failed", "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void button4_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
            {
            try
                {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                    displays();
                    }
                else
                    {
                    
                    Searchdisplays(txtSearch);
                    }
                }catch (Exception ex)
                {
                MessageBox.Show(ex.Message , "Search Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertFormat.ExportDataTableToPdf(dataGridEvents, "Other Fees List", "Other Fees List");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                displays();
            }
            else
            {
                Search(txtSearch);
            }
        }
            }
             
            }