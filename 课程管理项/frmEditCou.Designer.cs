namespace WindowsFormsApplication1
{
    partial class frmEditCou
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
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lb1Credit = new System.Windows.Forms.Label();
            this.lb1Cname = new System.Windows.Forms.Label();
            this.lb1Cid = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCredit);
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lb1Credit);
            this.gbxCourse.Controls.Add(this.lb1Cname);
            this.gbxCourse.Controls.Add(this.lb1Cid);
            this.gbxCourse.Location = new System.Drawing.Point(60, 98);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(316, 148);
            this.gbxCourse.TabIndex = 0;
            this.gbxCourse.TabStop = false;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(151, 99);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 21);
            this.txtCredit.TabIndex = 5;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(151, 68);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 4;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(151, 34);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 3;
            // 
            // lb1Credit
            // 
            this.lb1Credit.AutoSize = true;
            this.lb1Credit.Location = new System.Drawing.Point(50, 99);
            this.lb1Credit.Name = "lb1Credit";
            this.lb1Credit.Size = new System.Drawing.Size(29, 12);
            this.lb1Credit.TabIndex = 2;
            this.lb1Credit.Text = "学分";
            // 
            // lb1Cname
            // 
            this.lb1Cname.AutoSize = true;
            this.lb1Cname.Location = new System.Drawing.Point(50, 68);
            this.lb1Cname.Name = "lb1Cname";
            this.lb1Cname.Size = new System.Drawing.Size(41, 12);
            this.lb1Cname.TabIndex = 1;
            this.lb1Cname.Text = "课程名";
            // 
            // lb1Cid
            // 
            this.lb1Cid.AutoSize = true;
            this.lb1Cid.Location = new System.Drawing.Point(50, 34);
            this.lb1Cid.Name = "lb1Cid";
            this.lb1Cid.Size = new System.Drawing.Size(53, 12);
            this.lb1Cid.TabIndex = 0;
            this.lb1Cid.Text = "课程编号";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEditCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbxCourse);
            this.Name = "frmEditCou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改课程";
            this.Load += new System.EventHandler(this.frmEditCou_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lb1Credit;
        private System.Windows.Forms.Label lb1Cname;
        private System.Windows.Forms.Label lb1Cid;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}