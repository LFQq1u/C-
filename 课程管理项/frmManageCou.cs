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
    public partial class frmManageCou : Form
    {
        public frmManageCou()
        {
            InitializeComponent();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            dataAccess DataSelect = new dataAccess();
            DataSelect.Datacon();
            string condition = "";
            if (txtCid.Text.Trim() != "")
            {
                condition += "and Cid = '" + txtCid.Text.Trim() + "'";
            }
            if (txtCname.Text.Trim() != "")
            {
                condition += "and Cname = '" + txtCname.Text.Trim() + "'";
            }
            try
            {
                string comStr = "select Cid as 课程编号, Cname as 课程名, Credit as 学分 from Courseinfo where 1=1 " + condition;
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
                string comStr = "delete from Courseinfo where Cid = '" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
                if (DataDel.DataCom(comStr))
                {
                    MessageBox.Show("科目删除成功！");
                }
            }
            else
            {
                MessageBox.Show("权限不足！");
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInfo.CurrentRow != null)
            {
                if (frmLogin.Power == 0)
                {
                    frmEditCou frmEdit = new frmEditCou();
                    frmManageCou.Cid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
                    frmEdit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("权限不足！");
                }
            }
            else
            {
                MessageBox.Show("请查询并选择你要修改的课程！");
            }
        }
    }
}
