namespace WindowsFormsApplication1
{
    partial class frmAddStu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lb1Tel = new System.Windows.Forms.Label();
            this.lb1Birthday = new System.Windows.Forms.Label();
            this.lb1Sname = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lb1Address = new System.Windows.Forms.Label();
            this.lb1Class = new System.Windows.Forms.Label();
            this.lb1Sex = new System.Windows.Forms.Label();
            this.lb1Sid = new System.Windows.Forms.Label();
            this.gbxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.txtTel);
            this.gbxStudent.Controls.Add(this.txtBirthday);
            this.gbxStudent.Controls.Add(this.txtSname);
            this.gbxStudent.Controls.Add(this.cboSex);
            this.gbxStudent.Controls.Add(this.lb1Tel);
            this.gbxStudent.Controls.Add(this.lb1Birthday);
            this.gbxStudent.Controls.Add(this.lb1Sname);
            this.gbxStudent.Controls.Add(this.txtAddress);
            this.gbxStudent.Controls.Add(this.txtClass);
            this.gbxStudent.Controls.Add(this.txtSid);
            this.gbxStudent.Controls.Add(this.lb1Address);
            this.gbxStudent.Controls.Add(this.lb1Class);
            this.gbxStudent.Controls.Add(this.lb1Sex);
            this.gbxStudent.Controls.Add(this.lb1Sid);
            this.gbxStudent.Location = new System.Drawing.Point(43, 43);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(342, 235);
            this.gbxStudent.TabIndex = 3;
            this.gbxStudent.TabStop = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(229, 130);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 5;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(229, 92);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(100, 21);
            this.txtBirthday.TabIndex = 3;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(229, 52);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 1;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(63, 92);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 2;
            // 
            // lb1Tel
            // 
            this.lb1Tel.AutoSize = true;
            this.lb1Tel.Location = new System.Drawing.Point(170, 131);
            this.lb1Tel.Name = "lb1Tel";
            this.lb1Tel.Size = new System.Drawing.Size(29, 12);
            this.lb1Tel.TabIndex = 9;
            this.lb1Tel.Text = "电话";
            // 
            // lb1Birthday
            // 
            this.lb1Birthday.AutoSize = true;
            this.lb1Birthday.Location = new System.Drawing.Point(170, 92);
            this.lb1Birthday.Name = "lb1Birthday";
            this.lb1Birthday.Size = new System.Drawing.Size(29, 12);
            this.lb1Birthday.TabIndex = 8;
            this.lb1Birthday.Text = "生日";
            // 
            // lb1Sname
            // 
            this.lb1Sname.AutoSize = true;
            this.lb1Sname.Location = new System.Drawing.Point(170, 52);
            this.lb1Sname.Name = "lb1Sname";
            this.lb1Sname.Size = new System.Drawing.Size(29, 12);
            this.lb1Sname.TabIndex = 7;
            this.lb1Sname.Text = "姓名";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(64, 131);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 4;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(63, 52);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 0;
            // 
            // lb1Address
            // 
            this.lb1Address.AutoSize = true;
            this.lb1Address.Location = new System.Drawing.Point(16, 181);
            this.lb1Address.Name = "lb1Address";
            this.lb1Address.Size = new System.Drawing.Size(53, 12);
            this.lb1Address.TabIndex = 3;
            this.lb1Address.Text = "家庭住址";
            // 
            // lb1Class
            // 
            this.lb1Class.AutoSize = true;
            this.lb1Class.Location = new System.Drawing.Point(16, 131);
            this.lb1Class.Name = "lb1Class";
            this.lb1Class.Size = new System.Drawing.Size(29, 12);
            this.lb1Class.TabIndex = 2;
            this.lb1Class.Text = "班级";
            // 
            // lb1Sex
            // 
            this.lb1Sex.AutoSize = true;
            this.lb1Sex.Location = new System.Drawing.Point(16, 92);
            this.lb1Sex.Name = "lb1Sex";
            this.lb1Sex.Size = new System.Drawing.Size(29, 12);
            this.lb1Sex.TabIndex = 1;
            this.lb1Sex.Text = "性别";
            // 
            // lb1Sid
            // 
            this.lb1Sid.AutoSize = true;
            this.lb1Sid.Location = new System.Drawing.Point(16, 52);
            this.lb1Sid.Name = "lb1Sid";
            this.lb1Sid.Size = new System.Drawing.Size(29, 12);
            this.lb1Sid.TabIndex = 0;
            this.lb1Sid.Text = "学号";
            // 
            // frmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxStudent);
            this.Name = "frmAddStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息添加";
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lb1Tel;
        private System.Windows.Forms.Label lb1Birthday;
        private System.Windows.Forms.Label lb1Sname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lb1Address;
        private System.Windows.Forms.Label lb1Class;
        private System.Windows.Forms.Label lb1Sex;
        private System.Windows.Forms.Label lb1Sid;
    }
}