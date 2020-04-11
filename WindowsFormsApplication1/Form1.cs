using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO.IsolatedStorage;
using AesEncrypt;
using Activation;
using System.Diagnostics;
using System.Data.SqlClient;
using FileEncrypt;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    { 
        public static string Dtime;
        private int count = 0;
        public int notifyTime = 0;
         
        public Form1()
        {
            InitializeComponent();
            
        }
        int dropHieght = 0;
        int a =0;
         
        private void button2_Click(object sender, EventArgs e)
        {
             
            Application.Exit();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (a == 1)
            {
                panIcon.Top = btntoday.Top;
                TodayPanel.Height = 0;
                btntoday.Image = Image.FromFile(@"Images\colapse.png");
                a = 0;
                pantodayicon.Visible = false;
            }
            else
            {
                dropHieght = 211;
                btntoday.Image = Image.FromFile(@"Images\1.png");
                panIcon.Top = btntoday.Top;
                panIcon.Visible = true;
                TodayPanel.Height = dropHieght;
                a = 1;
            } 
        }
        public delegate void OnAppStartEventHandler(object source, EventArgs args);

        public event OnAppStartEventHandler AppStarted;

        protected virtual void OnAppStarted()
        {
            if (AppStarted != null)
                {
                AppStarted(this , EventArgs.Empty);
                }
        }
        private  void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                timerTime.Start();
                TodayPanel.Height = dropHieght;
                pantodayicon.Visible = false;
                lbltime.Text = DateTime.Now.ToShortTimeString();
                new Thread(() =>
                {
                    //PREPARE THE DEBTORS LIST AT THE BACKGROUND
                    var ground = new GroundWorker(); 
                     var eventList=new EvenPayList();
                  AppStarted += ground.OnAppStarted;
                    AppStarted += eventList.OnAppStarted;
                 OnAppStarted();
                }).Start();
                lblLogin.Text = AdminLog.Admin;
                if (string.IsNullOrEmpty(AppActivation.isActivated())){
                    notifyTime = 15;
                    Notify();
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            catch (Exception Ex)
            {

            }


        }

         
        private void btnpay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            checkBtnToday();
            panIcon.Top = btnpay.Top;
            panIcon.Visible = true;

            //SET THE FORMS IN VIEW
            //payfees1.Visible = true;
            Payment Payment = new Payment();
            Payment.Show(); 
        }

        private  void btnadmin_Click(object sender, EventArgs e)
        {
            timer1.Start();
            checkBtnToday();
            panIcon.Top = btnadmin.Top;
            panIcon.Visible = true;
            AdminForm adm = new AdminForm();
            adm.Show();
            
            
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            checkBtnToday();
            panIcon.Top = btnstudent.Top;
            panIcon.Visible = true;

            //SET THE FORMS IN VIEW
            
            Update_Students us = new Update_Students();
            us.Show();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            timer1.Start();
            checkBtnToday();
            panIcon.Top = btnrecord.Top;
            panIcon.Visible = true;
            PayRecordsForm prf = new PayRecordsForm();
            prf.ShowDialog();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            timer1.Start();
            checkBtnToday();
            panIcon.Top = btnreport.Top;
            panIcon.Visible = true;
            ReportForm  paylog= new ReportForm(); 
            paylog.Show();
            
        }

        private void btnexpense_Click(object sender, EventArgs e)
        {
            checkBtnToday();
            ExpenseForm exp = new ExpenseForm();
            panIcon.Top = btnexpense.Top;
            panIcon.Visible = true;
            exp.ShowDialog();
             
        }
        public  void checkBtnToday()
        {
            if (a == 1)
            {
                panIcon.Top = btntoday.Top;
                TodayPanel.Height = 0;
                btntoday.Image = Image.FromFile(@"Images\colapse.png");
                a = 0;
                pantodayicon.Visible = false; 
                pantodayicon.Visible = false; 
            }
             
        }
        private void btnreciept_Click(object sender, EventArgs e)
        {
            checkBtnToday();
            panIcon.Top = btnreciept.Top;
            panIcon.Visible = true;
            var viewRecord = new Form9();
            viewRecord.Show();
             
        }
        //BACKGROUND CHANGER METHODS
        //private int imageNumber = 1;
        //private void LoadNextImage(){
        // if(imageNumber==2){
        //      imageNumber=1;
        //          }
        // this.BackgroundImage = @"BackImages\{0}.png";
        //       imageNumber++;
        //      }
        

        private void btntodayex_Click(object sender, EventArgs e)
        {
            pantodayicon.Top = btntodayex.Top;
            panIcon.Visible = false;
            pantodayicon.Visible = true; 
            TodayExpenses te = new TodayExpenses();
            te.Show();

        }

        private void btnpayrec_Click(object sender, EventArgs e)
        {
            
            pantodayicon.Top = btnpayrec.Top;
            panIcon.Visible = false;
            pantodayicon.Visible = true; 
            TodayPayRecords tpr = new TodayPayRecords();
            tpr.ShowDialog();
             
        }

        private void btnincome_Click(object sender, EventArgs e)
        {
            panIcon.Visible = false;
            pantodayicon.Top = btnincome.Top;
            pantodayicon.Visible = true;
            pantodayicon.Visible = true;
            Expenses exp = new Expenses();
            exp.getExpense();
            TodayIncome TI = new TodayIncome();
            TI.ShowDialog();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnaddStudents_Click(object sender, EventArgs e)
        {
            panIcon.Visible = false;
            AddStudentsForm stu = new AddStudentsForm();
            stu.ShowDialog(); 
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
        panIcon.Visible = false;
            SetSessionForm ses = new SetSessionForm();
            ses.ShowDialog();
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            controlSettings1.Visible = true;
            count = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        panIcon.Visible = false;
            setFeesForm setfees = new setFeesForm();
            setfees.ShowDialog();
             
        }

        private void timerTime_Tick(object sender, EventArgs e)
            {
            //check if the app has been activated
            if (notifyTime > 0)
                {
                timer1.Start();
                }
            //GCHANGE THE BACGROUND IMAGES
            //NOT IN USE NOW
            lbltime.Text = DateTime.Now.ToLongTimeString();
                lblDate.Text = DateTime.Today.Date.ToShortDateString();
                timerTime.Start();
                Dtime = lbltime.Text;
            lblLogin.Text = AdminLog.Admin;
                if (count > 0)
                {
                    count -= 1;
                    if (count == 0 )
                    {
                        controlSettings1.Visible = false;
                    activationPanel1.Visible = false;
                    }
                }

            }
         
        private void Notify()
        {

            notifyIcon1.BalloonTipText = "Application is not Activated";
            notifyIcon1.BalloonTipTitle = "Cash Desk";
            notifyIcon1.Icon = SystemIcons.Information; 
            notifyIcon1.ShowBalloonTip(10000);
            
        }
        //Activation
        #region
        /// <summary>
        /// CHECK THE ACTIVATION OF THE APPLICATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
            {
            //CHANGE BACKGROUND CODE GOES IN HERE LATER


            notifyTime -= 1;
            if (notifyTime <= 0)
            { 
                if(string.IsNullOrEmpty( AppActivation.isActivated()) && AppActivation.CheckLimit() != true)
                {
                    notifyTime = 35; 
                    Notify(); 
                }else if(string.IsNullOrEmpty(AppActivation.isActivated()) && AppActivation.CheckLimit() != false)//when the limit is reachee
                {
                    timer1.Stop();
                    var Activate = new DueActivationForm();
                    Activate.ShowDialog();
                }else if(string.IsNullOrEmpty(AppActivation.isActivated())==false && AppActivation.CheckLimit() != false){
                    //check Activation
                    using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                    {
                        try
                        {
                            using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("apps.txt", System.IO.FileMode.Open, isolatedStorageFile))
                            {
                                using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                                {
                                    var activation = sr.ReadLine();
                                    //if the there is an activation Key check if it is valid
                                    if ( AppActivation.isActivated() != activation )
                                    {
                                        timer1.Stop();
                                        var Activate = new DueActivationForm();
                                        Activate.ShowDialog();
                                    }
                                    else
                                    {
                                        timer1.Stop();
                                    }
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                }
                 
            } 
                }
        #endregion
        private void btnMore_Click(object sender, EventArgs e)
            {
            moreAbout1.Visible = true;
            }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminLog.AdminLogs(AdminLog.Admin, "Logout");
            Application.Exit(); 
        }

        private void btnMyFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/linus.learnuel");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            activationPanel1.Visible = true;
            count = 50;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSales_Click(object sender , EventArgs e)
            {
            checkBtnToday();
            var SalesRecord = new Sales_Record();
            panIcon.Top = btnSales.Top;
            panIcon.Visible = true;
            SalesRecord.Show();
            } 
        private void activationPanel1_Load(object sender , EventArgs e)
            {

            }

        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            try
            {

                ProcessStartInfo info = new ProcessStartInfo("BackFile.exe");
                info.UseShellExecute = true;
                info.Verb = "runas";
                Process.Start(info);
                new Thread(() => { AdminLog.AdminLogs(AdminLog.Admin, "Logout"); }).Start();
                Application.ExitThread(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
}
