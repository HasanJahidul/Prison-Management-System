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
    public partial class SelectionPage : Form
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void SelectionPage_Load(object sender, EventArgs e)
        {

        }

        private void SelectionPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_prisoner_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrisonerPage prisonerPage = new PrisonerPage();
            prisonerPage.Show();
        }

        private void btn_guard_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardPage guardPage = new GuardPage();
            guardPage.Show();
        }




    }
}
