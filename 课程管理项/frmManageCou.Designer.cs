namespace WindowsFormsApplication1
{
    partial class frmManageCou
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lb1Cname = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lb1Cid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxSeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSeach
            // 
            this.gbxSeach.Controls.Add(this.btnEdit);
            this.gbxSeach.Controls.Add(this.btnDel);
            this.gbxSeach.Controls.Add(this.btnSeach);
            this.gbxSeach.Controls.Add(this.txtCname);
            this.gbxSeach.Controls.Add(this.lb1Cname);
            this.gbxSeach.Controls.Add(this.txtCid);
            this.gbxSeach.Controls.Add(this.lb1Cid);
            this.gbxSeach.ForeColor = System.Drawing.Color.Blue;
            this.gbxSeach.Location = new System.Drawing.Point(31, 36);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(370, 158);
            this.gbxSeach.TabIndex = 0;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "查询条件";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(266, 101);
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
            this.btnDel.Location = new System.Drawing.Point(151, 101);
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
            this.btnSeach.Location = new System.Drawing.Point(33, 101);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtCname
            // 
            this.txtCname.ForeColor = System.Drawing.Color.Black;
            this.txtCname.Location = new System.Drawing.Point(241, 41);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 21);
            this.txtCname.TabIndex = 3;
            // 
            // lb1Cname
            // 
            this.lb1Cname.AutoSize = true;
            this.lb1Cname.ForeColor = System.Drawing.Color.Black;
            this.lb1Cname.Location = new System.Drawing.Point(182, 44);
            this.lb1Cname.Name = "lb1Cname";
            this.lb1Cname.Size = new System.Drawing.Size(53, 12);
            this.lb1Cname.TabIndex = 2;
            this.lb1Cname.Text = "课程名称";
            // 
            // txtCid
            // 
            this.txtCid.ForeColor = System.Drawing.Color.Black;
            this.txtCid.Location = new System.Drawing.Point(67, 41);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 21);
            this.txtCid.TabIndex = 1;
            // 
            // lb1Cid
            // 
            this.lb1Cid.AutoSize = true;
            this.lb1Cid.ForeColor = System.Drawing.Color.Black;
            this.lb1Cid.Location = new System.Drawing.Point(8, 44);
            this.lb1Cid.Name = "lb1Cid";
            this.lb1Cid.Size = new System.Drawing.Size(53, 12);
            this.lb1Cid.TabIndex = 0;
            this.lb1Cid.Text = "课程编号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(31, 216);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(370, 150);
            this.dgvInfo.TabIndex = 1;
            // 
            // frmManageCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxSeach);
            this.Name = "frmManageCou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息管理";
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.Label lb1Cname;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lb1Cid;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}