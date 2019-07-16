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
    public partial class frmEditStu : Form
    {
        public frmEditStu()
        {
            InitializeComponent();
        }

        private void frmEditStu_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmManageStu.Sid;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "")
            {
                txtSname.Text = frmManageStu.Sname;
            }
            if (cboSex.Text == "")
            {
                cboSex.Text = frmManageStu.Sex;
            }
            if (txtBirthday.Text == "")
            {
                txtBirthday.Text = frmManageStu.Birthday;
            }
            if (txtClass.Text == "")
            {
                txtClass.Text = frmManageStu.Class;
            }
            if (txtTel.Text == "")
            {
                txtTel.Text = frmManageStu.Tel;
            }
            if (txtAddress.Text == "")
            {
                txtAddress.Text = frmManageStu.Address;
            }
            
            if (txtSid.Text != "" && txtSname.Text != "" && cboSex.Text != "" 
                && txtBirthday.Text != "" && txtClass.Text != "" && txtTel.Text != "" 
                && txtAddress.Text != "")
            {
                dataAccess DataEdit = new dataAccess();
                DataEdit.Datacon();

                string comStr = "update Studentinfo set Sname = '" + txtSname.Text 
                    + "',Sex = '" + cboSex.Text + "', Birthday = '" + txtBirthday.Text 
                    + "', Class = '" + txtClass.Text + "', Tel = '" + txtTel.Text 
                    + "', Address = '" + txtAddress.Text 
                    +"'  where  Sid = '" + txtSid.Text.Trim() + "'";
                if (DataEdit.DataCom(comStr) == true)
                {                   
                    MessageBox.Show("学生修改成功！");
                }
                else
                {
                    MessageBox.Show("学生修改失败！");
                }
                
            }
        }

    }
}
