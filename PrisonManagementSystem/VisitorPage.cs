using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem
{
    public partial class VisitorPage : Form
    {
        public VisitorPage()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void VisitorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VisitorPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitorConfirmationPage visitorConfirmationPage = new VisitorConfirmationPage();
            visitorConfirmationPage.Show(); 
        }
    }
}
