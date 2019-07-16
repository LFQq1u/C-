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
    public partial class frmAddCou : Form
    {
        public frmAddCou()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmLogin.Power == 0)
            {
                dataAccess DataAdd = new dataAccess();
                DataAdd.Datacon();
                string comStr = "insert into Courseinfo values ('" + txtCid.Text + "', '" + txtCname.Text + "', '" + txtCredit.Text + "')";
                if (DataAdd.DataCom(comStr))
                {
                    MessageBox.Show("课程添加成功！");
                }
            }
            else
            {
                MessageBox.Show("权限不足！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
