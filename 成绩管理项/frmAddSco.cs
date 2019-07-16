using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class frmAddSco : Form
    {
        public frmAddSco()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmLogin.Power == 0)
            {
                dataAccess DataAdd = new dataAccess();
                DataAdd.Datacon();
                string comStr = "insert into Scoreinfo values ('" + txtSid.Text + "', '" + txtCid.Text + "', '" + txtScore.Text + "')";
                if (DataAdd.DataCom(comStr))
                {
                    MessageBox.Show("成绩添加成功！");
                }
            }
            else
            {
                MessageBox.Show("权限不足！");
            }
        }

        private void frmAddSco_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("provider = microsoft.jet.OleDb.4.0;Data Source = " + Application.StartupPath.ToString() + "//student.mdb;");
            con.Open();
            OleDbCommand comSname = new OleDbCommand("select Sname from Studentinfo", con);
            OleDbDataReader readSname = comSname.ExecuteReader();
            while (readSname.Read())
            {
                cboSname.Items.Add(readSname[0].ToString());
            }
            
            OleDbCommand comCname = new OleDbCommand("select Cname from Courseinfo", con);
            OleDbDataReader readCname = comCname.ExecuteReader();
            while (readCname.Read())
            {
                cboCname.Items.Add(readCname[0].ToString());
            }
            con.Close();

        }


        private void cboSname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Sname = Convert.ToString(cboSname.SelectedItem);
            dataAccess DataA = new dataAccess();
            DataA.Datacon();
            string comStr = "select * from Studentinfo where Sname = '" + Sname + "'";
            DataSet name = DataA.Data(comStr);
            txtSid.Text = Convert.ToString(name.Tables[0].Rows[0][0]);
        }

        private void cboCname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cname = Convert.ToString(cboCname.SelectedItem);
            dataAccess DataA = new dataAccess();
            DataA.Datacon();
            string comStr = "select * from Courseinfo where Cname = '" + Cname + "'";
            DataSet name = DataA.Data(comStr);
            txtCid.Text = Convert.ToString(name.Tables[0].Rows[0][0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbxCourse_Enter(object sender, EventArgs e)
        {

        }
    }
}
