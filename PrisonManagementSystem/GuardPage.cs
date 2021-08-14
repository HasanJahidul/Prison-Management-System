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
    public partial class GuardPage : Form
    {
        String Sql;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        public GuardPage()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString());     
        }
        public void PopulateGridView(string sql = "select * from GuardsTable;")
        {
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.GuardPageGridView.AutoGenerateColumns = false;
            this.GuardPageGridView.DataSource = this.Ds.Tables[0];
        }

        private void GuardPage_Load(object sender, EventArgs e)
        {

        }

        private void GuardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_guardPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionPage selectionPage = new SelectionPage();
            selectionPage.Show();
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            //this.Dac = new DatabaseConfiguration();
            string sql = "select * from GuardsTable;";
            this.PopulateGridView(sql);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Sql = "select * from GuardsTable where id = '" + this.txt_search.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = this.GuardPageGridView.CurrentRow.Cells[0].Value.ToString();
            this.Sql = @"delete from GuardsTable where id = '" + id + "';";
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
            this.Sql = @"insert into GuardsTable 
            values ('" + this.txt_id.Text + "' ,'" + this.txt_name.Text + "','" + this.txt_pass.Text + "','" + this.dtp_dateofbirth.Text + "'," +
            "'" + this.cmb_gender.Text + "','" + this.cmb_bloodGrp.Text + "','" + this.txt_PreAddress.Text + "','" + this.txt_ParAddress.Text + "'," +
            "'" + this.txt_mobileno.Text + "','" + this.txt_nidno.Text + "','" + this.txt_passportno.Text + "');";
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("New Guard Added Properly");
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGridView();
        }

        private void GuardPageGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txt_id.ReadOnly = true;
            this.txt_id.Text = this.GuardPageGridView.CurrentRow.Cells["id"].Value.ToString();
            this.txt_name.Text = this.GuardPageGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txt_pass.Text = this.GuardPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.dtp_dateofbirth.Text = this.GuardPageGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
            this.cmb_gender.Text = this.GuardPageGridView.CurrentRow.Cells["gender"].Value.ToString();
            this.cmb_bloodGrp.Text = this.GuardPageGridView.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txt_PreAddress.Text = this.GuardPageGridView.CurrentRow.Cells["presentaddress"].Value.ToString();
            this.txt_ParAddress.Text = this.GuardPageGridView.CurrentRow.Cells["parmanentaddress"].Value.ToString();
            this.txt_mobileno.Text = this.GuardPageGridView.CurrentRow.Cells["mobileno"].Value.ToString();
            this.txt_nidno.Text = this.GuardPageGridView.CurrentRow.Cells["nidno"].Value.ToString();
            this.txt_passportno.Text = this.GuardPageGridView.CurrentRow.Cells["passportno"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Sql = @"update GuardsTable
                         set name = '" + this.txt_name.Text + @"',
                         password = '" + this.txt_pass.Text + @"',
                         dateofbirth= '" + this.dtp_dateofbirth.Text + @"',
                         gender = '" + this.cmb_gender.Text + @"',
                         bloodgroup = '" + this.cmb_bloodGrp.Text + @"',
                         presentaddress = '" + this.txt_PreAddress.Text + @"',
                         parmanentaddress = '" + this.txt_ParAddress.Text + @"',
                         mobileno = '" + this.txt_mobileno.Text + @"',
                         nidno = '" + this.txt_nidno.Text + @"',
                         passportno = '" + this.txt_passportno.Text + @"'
                         where id = '" + this.txt_id.Text + "';";

            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Guards's Data Updated");
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
            this.txt_id.Clear();
            this.txt_name.Clear();
            this.txt_pass.Clear();
            this.txt_conPass.Clear();
            this.dtp_dateofbirth.Text = "";
            this.cmb_gender.SelectedIndex = -1;
            this.cmb_bloodGrp.SelectedIndex = -1;
            this.txt_PreAddress.Clear();
            this.txt_ParAddress.Clear();
            this.txt_mobileno.Clear();
            this.txt_nidno.Clear();
            this.txt_passportno.Clear();
        }
    }
}
