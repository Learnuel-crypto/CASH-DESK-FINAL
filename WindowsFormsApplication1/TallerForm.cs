using System;
using System.Windows.Forms;
using System.Drawing;
using TallerInfor;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using ShowTallerImage;


namespace WindowsFormsApplication1
{
    public partial class TallerForm : Form
    {
        Taller taller = new Taller();
        SqlConnection con = new DBConnection().getConnection();
        public TallerForm()
        {
            InitializeComponent();

        }

        private void txtTallerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Have NOT Uploaded the Teller Image\nContiune Exit", "Teller Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Taller.TallerError = true;
                Taller.TallerID = "";
                this.Close();
            }
        }

        private void btnloadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTallerNumber.Text))
                {
                    this.ActiveControl = txtTallerNumber;
                    throw new Exception("Enter Teller Number");
                }
                taller.setTallerId(txtTallerNumber.Text, pictureTaller, lblTallerPath);
                LoadTaller();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Teller Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Have NOT Uploaded the Teller Image\nContiune Exit", "Teller Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Taller.TallerError = true;
                Taller.TallerID = "";
                this.Close();
            }
        }
        void LoadTaller()
        { 
            try
            { 
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "@C://Pictures";
                fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png";
                fileDialog.FilterIndex = 1;
                fileDialog.Title = "Select Teller Image";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureTaller.Image = Image.FromFile(fileDialog.FileName);
                    //Tallerimage.ImageLocation = fileDialog.FileName;
                    lblTallerPath.Text = fileDialog.FileName; 
                }
              
            }

            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Teller Image");
            }
        }
        void SaveTaller()
        {
            try
            {

                if (CustomMsgBox.Show("Teller No:\n" + txtTallerNumber.Text, "Confirm Details", "Yes", "No") == DialogResult.Yes)
                {
                    
                    //Save the taller image
                    SqlCommand cmd = new SqlCommand();
                    MemoryStream ms = new MemoryStream();
                    pictureTaller.Image.Save(ms, pictureTaller.Image.RawFormat);
                    byte[] a = ms.GetBuffer();
                    ms.Close();
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Taller", a);
                    cmd.CommandText = "INSERT INTO Taller(ID,Taller_Id,Taller) VALUES(0,'" +Taller.TallerID + "',@Taller)";
                    con.Open();
                    cmd.ExecuteNonQuery();
                   con.Close();
                     
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nOperation Failed", "Teller Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try { 
            if (pictureTaller.Image == null)
            {
                throw new Exception("Upload Teller Image");
            }
            
            SaveTaller();
                Taller.TallerError = false;
                con.Open();
            this.Close();
        }
        catch(Exception Ex){
                MessageBox.Show(Ex.Message, "Teller Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = txtTallerNumber;
            }
        }

        private void TallerForm_Load(object sender, EventArgs e)
        {
            con.Close();
        }
    }
    }

