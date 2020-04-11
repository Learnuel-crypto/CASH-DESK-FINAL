using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    {
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ViewRecords.FirstTerm(dataGridRecords);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ViewRecords.FirstTerm(dataGridRecords);
            ViewRecords.ThirdTerm(dataGridThird);
            ViewRecords.SecondTerm(dataGridSecond);
            ViewRecords.Events(dataGridEvents);
            ViewRecords.Students(dataGridStudents);
            ViewRecords.SessionSet(dataGridSession);
        }

        private void dataGridSecond_Click(object sender, EventArgs e)
        {
            ViewRecords.SecondTerm(dataGridSecond);
        }

        private void dataGridThird_Click(object sender, EventArgs e)
        {
            ViewRecords.ThirdTerm(dataGridThird);
        }
    }
}
