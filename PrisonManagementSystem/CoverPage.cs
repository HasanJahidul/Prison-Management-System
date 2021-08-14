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
    public partial class CoverPage : Form
    {
        public CoverPage()
        {
            InitializeComponent();
            panel_articel.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.BackgroundImage = Properties.Resources.CoverPage;
        }

        private void CoverPage_Load(object sender, EventArgs e)
        {

        }

        private void coverPageNextBtn(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void CoverPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
