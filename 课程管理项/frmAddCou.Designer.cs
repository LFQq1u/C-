namespace WindowsFormsApplication1
{
    partial class frmAddCou
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
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lb1Credit = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lb1Cname = new System.Windows.Forms.Label();
            this.lb1Cid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCredit);
            this.gbxCourse.Controls.Add(this.lb1Credit);
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lb1Cname);
            this.gbxCourse.Controls.Add(this.lb1Cid);
            this.gbxCourse.Location = new System.Drawing.Point(12, 65);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(410, 145);
            this.gbxCourse.TabIndex = 0;
            this.gbxCourse.TabStop = false;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(279, 45);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 21);
            this.txtCredit.TabIndex = 2;
            // 
            // lb1Credit
            // 
            this.lb1Credit.AutoSize = true;
            this.lb1Credit.Location = new System.Drawing.Point(216, 48);
            this.lb1Credit.Name = "lb1Credit";
            this.lb1Credit.Size = new System.Drawing.Size(29, 12);
            this.lb1Credit.TabIndex = 4;
            this.lb1Credit.Text = "学分";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(90, 90);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(289, 21);
            this.txtCname.TabIndex = 3;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(90, 45);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lb1Cname
            // 
            this.lb1Cname.AutoSize = true;
            this.lb1Cname.Location = new System.Drawing.Point(31, 93);
            this.lb1Cname.Name = "lb1Cname";
            this.lb1Cname.Size = new System.Drawing.Size(53, 12);
            this.lb1Cname.TabIndex = 1;
            this.lb1Cname.Text = "课程名称";
            // 
            // lb1Cid
            // 
            this.lb1Cid.AutoSize = true;
            this.lb1Cid.Location = new System.Drawing.Point(31, 48);
            this.lb1Cid.Name = "lb1Cid";
            this.lb1Cid.Size = new System.Drawing.Size(53, 12);
            this.lb1Cid.TabIndex = 0;
            this.lb1Cid.Text = "课程编号";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmAddCou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程信息";
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lb1Cname;
        private System.Windows.Forms.Label lb1Cid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lb1Credit;
    }
}