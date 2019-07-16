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

    public partial class frmAddStu : Form
    {
        public frmAddStu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmLogin.Power == 0)
            {
                dataAccess DataAdd = new dataAccess();
                DataAdd.Datacon();
                string comStr = "insert into Studentinfo(Sid,Sname,Sex,Birthday,Class,Tel,Address) values ('" + txtSid.Text
                    + "', '" + txtSname.Text + "', '" + cboSex.Text + "', '" + txtBirthday.Text
                    + "', '" + txtClass.Text + "', '" + txtTel.Text + "', '" + txtAddress.Text + "')";
                if (DataAdd.DataCom(comStr))
                {
                    MessageBox.Show("学生添加成功！");
                }
                else
                {
                    MessageBox.Show("学生添加失败！");
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
