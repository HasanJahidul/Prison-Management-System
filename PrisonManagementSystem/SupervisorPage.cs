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
    public partial class SupervisorPage : Form
    {
        //String Sql;
        private string Sql { get; set; }
        private string SqlLogin { get; set; }
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        //private DataTable DA { get; set; }
        public SupervisorPage()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            //string sql = "select * from SupervisorTable;";
            this.PopulateGridView();
            this.GenerateSupervisorID();
            //MessageBox.Show(this.Dac.Tables[0].Rows[0][1].ToString());       
        }

        public void PopulateGridView(string sql = "select * from SupervisorTable;")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.SupervisorPageGridView.AutoGenerateColumns = false;
            this.SupervisorPageGridView.DataSource = this.Ds.Tables[0];
        }


        private void SupervisorPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_supervisorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            //this.Dac = new DatabaseConfiguration();
            string sql = "select * from SupervisorTable;";
            this.PopulateGridView(sql);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Sql = "select * from SupervisorTable where id = '" + this.txt_search.Text + "';";
            this.PopulateGridView(Sql);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = this.SupervisorPageGridView.CurrentRow.Cells[0].Value.ToString();
            this.Sql = @"delete from SupervisorTable where id = '" + id + "';"+
                "delete from LoginTable where id = '" + id + "';";
            int count = this.Dc.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(id +" Has Been Deleted");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateGridView();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into SupervisorTable 
            values ('"+this.txt_id.Text+"' ,'"+this.txt_name.Text+"','"+this.txt_pass.Text+"','"+this.dtp_dateofbirth.Text+"'," +
            "'"+this.cmb_gender.Text+"','"+this.cmb_bloodGrp.Text+"','"+this.txt_PreAddress.Text+"','"+this.txt_ParAddress.Text+"'," +
            "'"+this.txt_mobileno.Text+"','"+this.txt_nidno.Text+"','"+this.txt_passportno.Text+ "');" +
            "insert into LoginTable values('" + this.txt_id.Text + "' ,'" + this.txt_name.Text + "','" + this.txt_pass.Text + "', 'Supervisor');";
            /*this.SqlLogin = @"insert into LoginTable 
            values ('" + this.txt_id.Text + "','" + this.txt_pass.Text + "');";*/
            int count = this.Dc.ExecuteUpdateQuery(this.Sql);
            //int count2 = this.Dc.ExecuteUpdateQuery(this.SqlLogin);

            if (count == 2)
            {
                MessageBox.Show("New Supervisor Added Properly");
                
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGridView();
        }

        private void SupervisorPageGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txt_id.ReadOnly = true;
            this.txt_id.Text = this.SupervisorPageGridView.CurrentRow.Cells["id"].Value.ToString();
            this.txt_name.Text = this.SupervisorPageGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txt_pass.Text = this.SupervisorPageGridView.CurrentRow.Cells["password"].Value.ToString();
            this.dtp_dateofbirth.Text = this.SupervisorPageGridView.CurrentRow.Cells["dateofbirth"].Value.ToString();
            this.cmb_gender.Text = this.SupervisorPageGridView.CurrentRow.Cells[4].Value.ToString();
            this.cmb_bloodGrp.Text = this.SupervisorPageGridView.CurrentRow.Cells[5].Value.ToString();
            this.txt_PreAddress.Text = this.SupervisorPageGridView.CurrentRow.Cells["presentaddress"].Value.ToString();
            this.txt_ParAddress.Text = this.SupervisorPageGridView.CurrentRow.Cells["parmanentaddress"].Value.ToString();
            this.txt_mobileno.Text = this.SupervisorPageGridView.CurrentRow.Cells["mobileno"].Value.ToString();
            this.txt_nidno.Text = this.SupervisorPageGridView.CurrentRow.Cells["nidno"].Value.ToString();
            this.txt_passportno.Text = this.SupervisorPageGridView.CurrentRow.Cells["passportno"].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Sql = @"update SupervisorTable
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

            int count = this.Dc.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Supervisor's Data Updated");
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
            this.GenerateSupervisorID();
        }
        private void GenerateSupervisorID()
        {
            this.Sql = "select * from SupervisorTable order by id desc;";
            DataTable dt = this.Dc.ExecuteQueryTable(this.Sql);
            string id = dt.Rows[0]["id"].ToString();
            string[] st = id.Split('-');
            int tempID = Convert.ToInt32(st[1]);
            string newId ="SV-"+(++tempID).ToString("d2");
            this.txt_id.Text = newId;
        }
    }
}
