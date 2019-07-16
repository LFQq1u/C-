namespace WindowsFormsApplication1
{
    partial class frmEditSco
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.lb1Cname = new System.Windows.Forms.Label();
            this.lb1Sname = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lb1Score = new System.Windows.Forms.Label();
            this.lb1Cid = new System.Windows.Forms.Label();
            this.lb1Sid = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 313);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtSname);
            this.gbxCourse.Controls.Add(this.lb1Cname);
            this.gbxCourse.Controls.Add(this.lb1Sname);
            this.gbxCourse.Controls.Add(this.txtScore);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.txtSid);
            this.gbxCourse.Controls.Add(this.lb1Score);
            this.gbxCourse.Controls.Add(this.lb1Cid);
            this.gbxCourse.Controls.Add(this.lb1Sid);
            this.gbxCourse.Location = new System.Drawing.Point(43, 77);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(349, 187);
            this.gbxCourse.TabIndex = 3;
            this.gbxCourse.TabStop = false;
            // 
            // lb1Cname
            // 
            this.lb1Cname.AutoSize = true;
            this.lb1Cname.Location = new System.Drawing.Point(182, 92);
            this.lb1Cname.Name = "lb1Cname";
            this.lb1Cname.Size = new System.Drawing.Size(53, 12);
            this.lb1Cname.TabIndex = 8;
            this.lb1Cname.Text = "课程名称";
            // 
            // lb1Sname
            // 
            this.lb1Sname.AutoSize = true;
            this.lb1Sname.Location = new System.Drawing.Point(181, 52);
            this.lb1Sname.Name = "lb1Sname";
            this.lb1Sname.Size = new System.Drawing.Size(29, 12);
            this.lb1Sname.TabIndex = 6;
            this.lb1Sname.Text = "姓名";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(77, 126);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 5;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(75, 89);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 4;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(75, 49);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 21);
            this.txtSid.TabIndex = 3;
            // 
            // lb1Score
            // 
            this.lb1Score.AutoSize = true;
            this.lb1Score.Location = new System.Drawing.Point(16, 129);
            this.lb1Score.Name = "lb1Score";
            this.lb1Score.Size = new System.Drawing.Size(29, 12);
            this.lb1Score.TabIndex = 2;
            this.lb1Score.Text = "成绩";
            // 
            // lb1Cid
            // 
            this.lb1Cid.AutoSize = true;
            this.lb1Cid.Location = new System.Drawing.Point(16, 92);
            this.lb1Cid.Name = "lb1Cid";
            this.lb1Cid.Size = new System.Drawing.Size(53, 12);
            this.lb1Cid.TabIndex = 1;
            this.lb1Cid.Text = "课程编号";
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
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(243, 49);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 9;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(243, 89);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 10;
            // 
            // frmEditSco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmEditSco";
            this.Text = "学生成绩修改";
            this.Load += new System.EventHandler(this.frmEditSco_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.Label lb1Cname;
        private System.Windows.Forms.Label lb1Sname;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lb1Score;
        private System.Windows.Forms.Label lb1Cid;
        private System.Windows.Forms.Label lb1Sid;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtSname;
    }
}