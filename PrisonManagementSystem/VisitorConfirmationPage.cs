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
    public partial class VisitorConfirmationPage : Form
    {
        public VisitorConfirmationPage()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void VisitorConfirmationPage_Load(object sender, EventArgs e)
        {
           
        }

        private void VisitorConfirmationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
