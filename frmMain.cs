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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu fms = new frmManageStu();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 学生信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStu fas = new frmAddStu();
            fas.MdiParent = this;
            fas.Show();
        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu fms = new frmManageStu();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSco fms = new frmManageSco();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 成绩添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSco fas = new frmAddSco();
            fas.MdiParent = this;
            fas.Show();
        }

        private void 成绩修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSco fms = new frmManageSco();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCou fmc = new frmManageCou();
            fmc.MdiParent = this;
            fmc.Show();
        }

        private void 课程信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCou fac = new frmAddCou();
            fac.MdiParent = this;
            fac.Show();
        }

        private void 课程信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCou fmc = new frmManageCou();
            fmc.MdiParent = this;
            fmc.Show();
        }

        private void btnStuManage_Click(object sender, EventArgs e)
        {
            frmManageStu fms = new frmManageStu();
            fms.MdiParent = this;
            fms.Show();
        }

        private void btnCouManage_Click(object sender, EventArgs e)
        {
            frmManageCou fmc = new frmManageCou();
            fmc.MdiParent = this;
            fmc.Show();
        }

        private void btnScoManage_Click(object sender, EventArgs e)
        {
            frmManageSco fms = new frmManageSco();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu fms = new frmManageStu();
            fms.MdiParent = this;
            fms.Show();

        }

        private void 课程信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCou fmc = new frmManageCou();
            fmc.MdiParent = this;
            fmc.Show();
        }

        private void 成绩删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSco fms = new frmManageSco();
            fms.MdiParent = this;
            fms.Show();
        }

        private void 学生信息管理TToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; 
            //获取当前的日期；
            string strDate = dt.ToLongDateString().ToString();
            // 获取当前的时间；
            string strTime = dt.ToLongTimeString().ToString();
            // 用控件显示出来；
            toolStripStatusLabel2.Text = "当前时间：" + strDate + "  " + strTime;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("郭旭辉 170224109");
        }



    }
}
