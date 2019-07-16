namespace WindowsFormsApplication1
{
    partial class frmManageSco
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxSeach = new System.Windows.Forms.GroupBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lb1Class = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lb1Sname = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lb1Cid = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lb1Sid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.gbxSeach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(32, 221);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(370, 150);
            this.dgvInfo.TabIndex = 3;
            // 
            // gbxSeach
            // 
            this.gbxSeach.Controls.Add(this.txtClass);
            this.gbxSeach.Controls.Add(this.lb1Class);
            this.gbxSeach.Controls.Add(this.txtSname);
            this.gbxSeach.Controls.Add(this.lb1Sname);
            this.gbxSeach.Controls.Add(this.btnEdit);
            this.gbxSeach.Controls.Add(this.btnDel);
            this.gbxSeach.Controls.Add(this.btnSeach);
            this.gbxSeach.Controls.Add(this.txtCid);
            this.gbxSeach.Controls.Add(this.lb1Cid);
            this.gbxSeach.Controls.Add(this.txtSid);
            this.gbxSeach.Controls.Add(this.lb1Sid);
            this.gbxSeach.ForeColor = System.Drawing.Color.Blue;
            this.gbxSeach.Location = new System.Drawing.Point(32, 41);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(370, 158);
            this.gbxSeach.TabIndex = 2;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "查询条件";
            // 
            // txtClass
            // 
            this.txtClass.ForeColor = System.Drawing.Color.Black;
            this.txtClass.Location = new System.Drawing.Point(241, 88);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 4;
            // 
            // lb1Class
            // 
            this.lb1Class.AutoSize = true;
            this.lb1Class.ForeColor = System.Drawing.Color.Black;
            this.lb1Class.Location = new System.Drawing.Point(184, 96);
            this.lb1Class.Name = "lb1Class";
            this.lb1Class.Size = new System.Drawing.Size(29, 12);
            this.lb1Class.TabIndex = 9;
            this.lb1Class.Text = "班级";
            // 
            // txtSname
            // 
            this.txtSname.ForeColor = System.Drawing.Color.Black;
            this.txtSname.Location = new System.Drawing.Point(67, 88);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 3;
            // 
            // lb1Sname
            // 
            this.lb1Sname.AutoSize = true;
            this.lb1Sname.ForeColor = System.Drawing.Color.Black;
            this.lb1Sname.Location = new System.Drawing.Point(8, 96);
            this.lb1Sname.Name = "lb1Sname";
            this.lb1Sname.Size = new System.Drawing.Size(29, 12);
            this.lb1Sname.TabIndex = 7;
            this.lb1Sname.Text = "姓名";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(266, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(149, 129);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.ForeColor = System.Drawing.Color.Black;
            this.btnSeach.Location = new System.Drawing.Point(30, 129);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtCid
            // 
            this.txtCid.ForeColor = System.Drawing.Color.Black;
            this.txtCid.Location = new System.Drawing.Point(241, 41);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lb1Cid
            // 
            this.lb1Cid.AutoSize = true;
            this.lb1Cid.ForeColor = System.Drawing.Color.Black;
            this.lb1Cid.Location = new System.Drawing.Point(182, 44);
            this.lb1Cid.Name = "lb1Cid";
            this.lb1Cid.Size = new System.Drawing.Size(53, 12);
            this.lb1Cid.TabIndex = 2;
            this.lb1Cid.Text = "课程编号";
            // 
            // txtSid
            // 
            this.txtSid.ForeColor = System.Drawing.Color.Black;
            this.txtSid.Location = new System.Drawing.Point(67, 41);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 1;
            // 
            // lb1Sid
            // 
            this.lb1Sid.AutoSize = true;
            this.lb1Sid.ForeColor = System.Drawing.Color.Black;
            this.lb1Sid.Location = new System.Drawing.Point(8, 44);
            this.lb1Sid.Name = "lb1Sid";
            this.lb1Sid.Size = new System.Drawing.Size(29, 12);
            this.lb1Sid.TabIndex = 0;
            this.lb1Sid.Text = "学号";
            // 
            // frmManageSco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxSeach);
            this.Name = "frmManageSco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lb1Cid;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lb1Sid;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lb1Class;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lb1Sname;
    }
}