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
    public partial class frmEditCou : Form
    {
        public frmEditCou()
        {
            InitializeComponent();
        }

        private void frmEditCou_Load(object sender, EventArgs e)
        {
            txtCid.Text = frmManageCou.Cid;
            string Cid = Convert.ToString(txtCid.Text);
            string comStr;
            dataAccess DataB = new dataAccess();
            DataB.Datacon();
            comStr = "select * from Courseinfo where Cid = '" + Cid + "'";
            DataSet cid = DataB.Data(comStr);
            txtCname.Text = Convert.ToString(cid.Tables[0].Rows[0][1]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (txtCid.Text != "" && txtCname.Text != "" && txtCredit.Text != "")
                {
                    dataAccess DataEdit = new dataAccess();
                    DataEdit.Datacon();
                    string comStr = "update Courseinfo set Cname = '" + txtCname.Text
                        + "',Credit = '" + txtCredit.Text + "' where  Cid = '" + txtCid.Text.Trim() + "'";
                    if (DataEdit.DataCom(comStr) == true)
                    {
                        MessageBox.Show("课程修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("课程修改失败！");
                    }
                }
        }

    }
}
