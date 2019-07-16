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
    public partial class frmManageStu : Form
    {
        public frmManageStu()
        {
            InitializeComponent();
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
            if (txtSname.Text.Trim() != "")
            {
                condition += "and Sname LIKE  '%"+ txtSname.Text.Trim() + "%'";
            }
            if (cboSex.Text != "")
            {
                condition += "and Sex = '" + cboSex.Text + "'";
            }
            if (txtClass.Text.Trim() != "")
            {
                condition += "and Class = '" + txtClass.Text.Trim() + "'";
            }
            try
            {
                string comStr = "select Sid as 学号, Sname as 姓名, Sex as 性别, Birthday as 生日, Class as 班级, Tel as 电话, Address as 家庭住址 from Studentinfo where 1=1 " + condition;
                DataSet ds = DataSelect.Data(comStr);
                dgvInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private static string sname;
        public static string Sname
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }

        private static string sex;
        public static string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        private static string birthday;
        public static string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        private static string class1;
        public static string Class
        {
            get
            {
                return class1;
            }
            set
            {
                class1 = value;
            }
        }

        private static string tel;
        public static string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }

        private static string address;
        public static string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        //点击修改以后跳转到学生修改页面
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInfo.CurrentRow != null)
            {
                if (frmLogin.Power == 0)
                {
                    frmEditStu frmEdit = new frmEditStu();
                    frmManageStu.Sid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
                    frmManageStu.Sname = dgvInfo.CurrentRow.Cells[1].Value.ToString();
                    frmManageStu.Sex = dgvInfo.CurrentRow.Cells[2].Value.ToString();
                    frmManageStu.Birthday = dgvInfo.CurrentRow.Cells[3].Value.ToString();
                    frmManageStu.Class = dgvInfo.CurrentRow.Cells[4].Value.ToString();
                    frmManageStu.Tel = dgvInfo.CurrentRow.Cells[5].Value.ToString();
                    frmManageStu.Address = dgvInfo.CurrentRow.Cells[6].Value.ToString();
                    frmEdit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("权限不足");
                }
            }
            else
            {
                MessageBox.Show("请查询并选择你要修改的学生信息");
            }
        }

        private void frmManageStu_Load(object sender, EventArgs e)
        {

        }

        //点击删除以后删除该学生信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvInfo.CurrentRow != null)
            {
                if (frmLogin.Power == 0)
                {
                    dataAccess DataDel = new dataAccess();
                    DataDel.Datacon();
                    string comStr = "delete from Studentinfo where Sid = '" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
                    if (DataDel.DataCom(comStr) == true)
                    {
                        MessageBox.Show("学生删除成功！");
                    }
                    else
                    {
                        MessageBox.Show("学生删除失败！");
                    }
                }
                else
                {
                    MessageBox.Show("权限不足！");
                }
            }
            else
            {
                MessageBox.Show("请查询并选择你要删除的学生信息！");
            }
        }
        
    }
}
