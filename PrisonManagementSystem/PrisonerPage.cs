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
    public partial class PrisonerPage : Form
    {
        String Sql;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        public PrisonerPage()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString()); 
        }
        public void PopulateGridView(string sql = "select * from PrisonerTable;")
        {
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.PrisonerGridView.AutoGenerateColumns = false;
            this.PrisonerGridView.DataSource = this.Ds.Tables[0];
        }

        private void PrisonerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionPage selectionPage = new SelectionPage();
            selectionPage.Show();
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            //this.Dac = new DatabaseConfiguration();
            string sql = "select * from PrisonerTable;";
            this.PopulateGridView(sql);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Sql = "select * from PrisonerTable where prisonerid = '" + this.txt_search.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = this.PrisonerGridView.CurrentRow.Cells[0].Value.ToString();
            this.Sql = @"delete from PrisonerTable where prisonerid = '" + id + "';";
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(id + "Has Been Deleted");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateGridView();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into PrisonerTable 
            values ('" + this.txt_prisoner_id.Text + "' ,'" + this.txt_name.Text + "','" + this.dtp_dateofbirth.Text + "','" + this.txt_address.Text + "'," +
            "'"+ this.cmb_religion.Text + "','" + this.cmb_gender.Text + "','" + this.cmb_bloodGrp.Text + "','" + this.cmb_maritalstatus.Text + "','" + this.cmb_medicalcondition.Text + "'," +
            "'" + this.txt_emergencycontact.Text + "','" + this.txt_crimedetails.Text + "','" + this.dtp_entrancedate.Text + "','" + this.dtp_releasedate.Text + "');";
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("New Prisoner Added Properly");
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGridView();
        }

        private void PrisonerGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txt_prisoner_id.ReadOnly = true;
            this.txt_prisoner_id.Text = this.PrisonerGridView.CurrentRow.Cells["prisonerid"].Value.ToString();
            this.txt_name.Text = this.PrisonerGridView.CurrentRow.Cells["name"].Value.ToString();
            this.dtp_dateofbirth.Text = this.PrisonerGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
            this.txt_address.Text = this.PrisonerGridView.CurrentRow.Cells["address"].Value.ToString();
            this.cmb_religion.Text = this.PrisonerGridView.CurrentRow.Cells["religion"].Value.ToString();
            this.cmb_gender.Text = this.PrisonerGridView.CurrentRow.Cells["gender"].Value.ToString();
            this.cmb_bloodGrp.Text = this.PrisonerGridView.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.cmb_maritalstatus.Text = this.PrisonerGridView.CurrentRow.Cells["maritalstatus"].Value.ToString();
            this.cmb_medicalcondition.Text = this.PrisonerGridView.CurrentRow.Cells["medicalcondition"].Value.ToString();
            this.txt_emergencycontact.Text = this.PrisonerGridView.CurrentRow.Cells["emergencycontact"].Value.ToString();
            this.txt_crimedetails.Text = this.PrisonerGridView.CurrentRow.Cells["crimedetails"].Value.ToString();
            this.dtp_entrancedate.Text = this.PrisonerGridView.CurrentRow.Cells["entrancedate"].Value.ToString();
            this.dtp_releasedate.Text = this.PrisonerGridView.CurrentRow.Cells["releasedate"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Sql = @"update PrisonerTable
                         set name = '" + this.txt_name.Text + @"',
                         dateofbirth= '" + this.dtp_dateofbirth.Text + @"',
                         address = '" + this.txt_address.Text + @"',
                         religion = '" + this.cmb_religion.Text + @"',
                         gender = '" + this.cmb_gender.Text + @"',
                         bloodgroup = '" + this.cmb_bloodGrp.Text + @"',
                         maritalstatus = '" + this.cmb_maritalstatus.Text + @"',
                         medicalcondition = '" + this.cmb_medicalcondition.Text + @"',
                         emergencycontact = '" + this.txt_emergencycontact.Text + @"',
                         crimedetails = '" + this.txt_crimedetails.Text + @"',
                         entrancedate = '" + this.dtp_entrancedate.Text + @"',
                         releasedate = '" + this.dtp_releasedate.Text + @"'
                         where prisonerid = '" + this.txt_prisoner_id.Text + "';";

            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Prisoner's Data Updated");
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGridView();
            this.ClearAll();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txt_prisoner_id.Clear();
            this.txt_name.Clear();
            this.dtp_dateofbirth.Text = "";
            this.txt_address.Clear();
            this.cmb_religion.SelectedIndex = -1;
            this.cmb_gender.SelectedIndex = -1;
            this.cmb_bloodGrp.SelectedIndex = -1;
            this.cmb_maritalstatus.SelectedIndex = -1;
            this.cmb_medicalcondition.SelectedIndex = -1;
            this.txt_emergencycontact.Clear();
            this.txt_crimedetails.Clear();
            this.dtp_entrancedate.Text = "";
            this.dtp_releasedate.Text = "";
        }
    }
}
