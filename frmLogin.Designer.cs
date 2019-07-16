namespace WindowsFormsApplication1
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(247, 176);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 21);
            this.textId.TabIndex = 1;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(247, 234);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(100, 21);
            this.textPwd.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID.Location = new System.Drawing.Point(159, 176);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 12);
            this.ID.TabIndex = 3;
            this.ID.Text = "用户名";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwd.Location = new System.Drawing.Point(159, 234);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(29, 12);
            this.pwd.TabIndex = 4;
            this.pwd.Text = "密码";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.button1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生登录系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Button button2;
    }
}

