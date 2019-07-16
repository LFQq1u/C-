namespace WindowsFormsApplication1
{
    partial class frmManageStu
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
            this.gbxSeach = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lb1Class = new System.Windows.Forms.Label();
            this.lb1Sname = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.lb1Sex = new System.Windows.Forms.Label();
            this.lb1Sid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxSeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSeach
            // 
            this.gbxSeach.Controls.Add(this.cboSex);
            this.gbxSeach.Controls.Add(this.txtClass);
            this.gbxSeach.Controls.Add(this.txtSname);
            this.gbxSeach.Controls.Add(this.lb1Class);
            this.gbxSeach.Controls.Add(this.lb1Sname);
            this.gbxSeach.Controls.Add(this.txtSid);
            this.gbxSeach.Controls.Add(this.btnEdit);
            this.gbxSeach.Controls.Add(this.btnDel);
            this.gbxSeach.Controls.Add(this.btnSeach);
            this.gbxSeach.Controls.Add(this.lb1Sex);
            this.gbxSeach.Controls.Add(this.lb1Sid);
            this.gbxSeach.ForeColor = System.Drawing.Color.Blue;
            this.gbxSeach.Location = new System.Drawing.Point(43, 43);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(345, 143);
            this.gbxSeach.TabIndex = 0;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "查询条件";
            // 
            // cboSex
            // 
            this.cboSex.ForeColor = System.Drawing.Color.Black;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(80, 64);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 11;
            // 
            // txtClass
            // 
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(235, 64);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 10;
            // 
            // txtSname
            // 
            this.txtSname.ForeColor = System.Drawing.Color.Black;
            this.txtSname.Location = new System.Drawing.Point(235, 31);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 9;
            // 
            // lb1Class
            // 
            this.lb1Class.AutoSize = true;
            this.lb1Class.ForeColor = System.Drawing.Color.Black;
            this.lb1Class.Location = new System.Drawing.Point(189, 65);
            this.lb1Class.Name = "lb1Class";
            this.lb1Class.Size = new System.Drawing.Size(29, 12);
            this.lb1Class.TabIndex = 8;
            this.lb1Class.Text = "班级";
            // 
            // lb1Sname
            // 
            this.lb1Sname.AutoSize = true;
            this.lb1Sname.ForeColor = System.Drawing.Color.Black;
            this.lb1Sname.Location = new System.Drawing.Point(187, 31);
            this.lb1Sname.Name = "lb1Sname";
            this.lb1Sname.Size = new System.Drawing.Size(29, 12);
            this.lb1Sname.TabIndex = 7;
            this.lb1Sname.Text = "姓名";
            // 
            // txtSid
            // 
            this.txtSid.ForeColor = System.Drawing.Color.Black;
            this.txtSid.Location = new System.Drawing.Point(80, 31);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(246, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(141, 102);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.ForeColor = System.Drawing.Color.Black;
            this.btnSeach.Location = new System.Drawing.Point(36, 102);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 2;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // lb1Sex
            // 
            this.lb1Sex.AutoSize = true;
            this.lb1Sex.ForeColor = System.Drawing.Color.Black;
            this.lb1Sex.Location = new System.Drawing.Point(34, 65);
            this.lb1Sex.Name = "lb1Sex";
            this.lb1Sex.Size = new System.Drawing.Size(29, 12);
            this.lb1Sex.TabIndex = 1;
            this.lb1Sex.Text = "性别";
            // 
            // lb1Sid
            // 
            this.lb1Sid.AutoSize = true;
            this.lb1Sid.ForeColor = System.Drawing.Color.Black;
            this.lb1Sid.Location = new System.Drawing.Point(32, 31);
            this.lb1Sid.Name = "lb1Sid";
            this.lb1Sid.Size = new System.Drawing.Size(29, 12);
            this.lb1Sid.TabIndex = 0;
            this.lb1Sid.Text = "学号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvInfo.Location = new System.Drawing.Point(43, 219);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(345, 150);
            this.dgvInfo.TabIndex = 1;
            // 
            // frmManageStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxSeach);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "frmManageStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.frmManageStu_Load);
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lb1Class;
        private System.Windows.Forms.Label lb1Sname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label lb1Sex;
        private System.Windows.Forms.Label lb1Sid;
        private System.Windows.Forms.DataGridView dgvInfo;

    }
}