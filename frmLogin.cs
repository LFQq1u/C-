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
    public partial class frmLogin : Form
    {
        private static int power;
        public static int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }
        //con 表
        //conStr 定义连接表的参数
        //com 对表操作的Command
        //comStr com的参数
        //da DataAdapter缩写 为DataAdapter参数
        //ds DataSet缩写 同上
        private void button1_Click(object sender, EventArgs e)
        {
            //定义用户名密码 trim 删除前后空白
            string userId = textId.Text.Trim();
            string Pwd = textPwd.Text.Trim();
            
            //链接数据库
            dataAccess DataA = new dataAccess();
            DataA.Datacon();

            string comStr = "select * from Userinfo where Userid = '" + userId + "' and Userpwd = '" + Pwd + "'";

            DataSet Login = DataA.Data(comStr);
            //ds集中第一个Tables，所有的行数 如果是对的择弹窗
            if (Login.Tables[0].Rows.Count == 1)
            { 
                if (Convert.ToString(Login.Tables[0].Rows[0][2]) == "教师")
                {
                    power = 0;
                }
                else
                {
                    power = 1;
                }
                frmMain fromM = new frmMain();
                fromM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}
