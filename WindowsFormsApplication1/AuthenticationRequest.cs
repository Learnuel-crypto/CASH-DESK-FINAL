using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class AuthenticationRequest : UserControl
    {
         
        public AuthenticationRequest()
            {
            InitializeComponent();
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            txtPassword.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
            {
                 
            }
        
        }
    }
