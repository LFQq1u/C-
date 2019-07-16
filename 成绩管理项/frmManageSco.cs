using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmManageSco : Form
    {
        public frmManageSco()
        {
            InitializeComponent();
        }

        private static string sid;
        public static string Sid
        {
            get
            {
                return sid;
            }
            set
            {
                sid = value;
            }
        }

        private static string cid;
        public static string Cid
        {
            get
            {
                return cid;
            }
            set
            {
                cid = value;
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

            dataAccess DataSelect = new dataAccess();
            DataSelect.Datacon();
            string condition = "";
            if (txtSid.Text.Trim() != "")
            {
                condition += "and Sid = '" + txtSid.Text.Trim() + "'";
            }
            if (txtCid.Text.Trim() != "")
            {
                condition += "and Cid = '" + txtCid.Text.Trim() + "'";
            }
            try
            {
                string comStr = "select Sid as 学号, Cid as 课程号,Score as 成绩 from Scoreinfo where 1=1 " + condition;
                DataSet ds = DataSelect.Data(comStr);
                dgvInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (frmLogin.Power == 0)
            {
                dataAccess DataDel = new dataAccess();
                DataDel.Datacon();
                string comStr = "delete from Scoreinfo where Sid = '" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
                DataDel.DataCom(comStr);
                MessageBox.Show("学生成绩删除成功！");
            }
            else
            {
                MessageBox.Show("权限不足！");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmLogin.Power == 0)
            {
                frmEditSco frmEdit = new frmEditSco();
                frmManageSco.Sid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
                frmManageSco.Cid = dgvInfo.CurrentRow.Cells[1].Value.ToString();
                frmEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("权限不足！");
            }
        }
    }
}
