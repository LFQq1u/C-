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
    public partial class frmEditSco : Form
    {
        public frmEditSco()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCid.Text != "" && txtSid.Text != "" && txtScore.Text != "")
            {
                dataAccess DataEdit = new dataAccess();
                DataEdit.Datacon();
                string comStr = "update Scoreinfo set Score = '" + txtScore.Text
                        + "' where  Cid = '" + txtCid.Text.Trim() + "' and Sid = '" + txtSid.Text.Trim() + "'";
                if (DataEdit.DataCom(comStr) == true)
                {
                    MessageBox.Show("成绩修改成功！");
                }
                else
                {
                    MessageBox.Show("成绩修改失败！");
                }
            }
        }

        private void frmEditSco_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmManageSco.Sid;
            string Sid = Convert.ToString(txtSid.Text);
            string comStr;
            dataAccess DataA = new dataAccess();
            DataA.Datacon();
            comStr = "select * from Studentinfo where Sid = '" + Sid + "'";
            DataSet sid = DataA.Data(comStr);
            txtSname.Text = Convert.ToString(sid.Tables[0].Rows[0][1]);

            txtCid.Text = frmManageSco.Cid;
            string Cid = Convert.ToString(txtCid.Text);
            dataAccess DataB = new dataAccess();
            DataB.Datacon();
            comStr = "select * from Courseinfo where Cid = '" + Cid + "'";
            DataSet cid = DataB.Data(comStr);
            txtCname.Text = Convert.ToString(cid.Tables[0].Rows[0][1]);
        }
    }
}
