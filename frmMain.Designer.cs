namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStuManage = new System.Windows.Forms.ToolStripButton();
            this.btnCouManage = new System.Windows.Forms.ToolStripButton();
            this.btnScoManage = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理TToolStripMenuItem,
            this.课程信息管理CToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息管理TToolStripMenuItem
            // 
            this.学生信息管理TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息查询ToolStripMenuItem,
            this.学生信息修改ToolStripMenuItem,
            this.学生信息添加ToolStripMenuItem,
            this.学生信息删除ToolStripMenuItem});
            this.学生信息管理TToolStripMenuItem.Name = "学生信息管理TToolStripMenuItem";
            this.学生信息管理TToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.学生信息管理TToolStripMenuItem.Text = "学生信息管理（T）";
            this.学生信息管理TToolStripMenuItem.Click += new System.EventHandler(this.学生信息管理TToolStripMenuItem_Click);
            // 
            // 学生信息查询ToolStripMenuItem
            // 
            this.学生信息查询ToolStripMenuItem.Name = "学生信息查询ToolStripMenuItem";
            this.学生信息查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息查询ToolStripMenuItem.Text = "学生信息查询";
            this.学生信息查询ToolStripMenuItem.Click += new System.EventHandler(this.学生信息查询ToolStripMenuItem_Click);
            // 
            // 学生信息修改ToolStripMenuItem
            // 
            this.学生信息修改ToolStripMenuItem.Name = "学生信息修改ToolStripMenuItem";
            this.学生信息修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息修改ToolStripMenuItem.Text = "学生信息修改";
            this.学生信息修改ToolStripMenuItem.Click += new System.EventHandler(this.学生信息修改ToolStripMenuItem_Click);
            // 
            // 学生信息添加ToolStripMenuItem
            // 
            this.学生信息添加ToolStripMenuItem.Name = "学生信息添加ToolStripMenuItem";
            this.学生信息添加ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息添加ToolStripMenuItem.Text = "学生信息添加";
            this.学生信息添加ToolStripMenuItem.Click += new System.EventHandler(this.学生信息添加ToolStripMenuItem_Click);
            // 
            // 学生信息删除ToolStripMenuItem
            // 
            this.学生信息删除ToolStripMenuItem.Name = "学生信息删除ToolStripMenuItem";
            this.学生信息删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息删除ToolStripMenuItem.Text = "学生信息删除";
            this.学生信息删除ToolStripMenuItem.Click += new System.EventHandler(this.学生信息删除ToolStripMenuItem_Click);
            // 
            // 课程信息管理CToolStripMenuItem
            // 
            this.课程信息管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程信息查询ToolStripMenuItem,
            this.课程信息添加ToolStripMenuItem,
            this.课程信息修改ToolStripMenuItem,
            this.课程信息删除ToolStripMenuItem});
            this.课程信息管理CToolStripMenuItem.Name = "课程信息管理CToolStripMenuItem";
            this.课程信息管理CToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.课程信息管理CToolStripMenuItem.Text = "课程信息管理（C）";
            // 
            // 课程信息查询ToolStripMenuItem
            // 
            this.课程信息查询ToolStripMenuItem.Name = "课程信息查询ToolStripMenuItem";
            this.课程信息查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.课程信息查询ToolStripMenuItem.Text = "课程信息查询";
            this.课程信息查询ToolStripMenuItem.Click += new System.EventHandler(this.课程信息查询ToolStripMenuItem_Click);
            // 
            // 课程信息添加ToolStripMenuItem
            // 
            this.课程信息添加ToolStripMenuItem.Name = "课程信息添加ToolStripMenuItem";
            this.课程信息添加ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.课程信息添加ToolStripMenuItem.Text = "课程信息添加";
            this.课程信息添加ToolStripMenuItem.Click += new System.EventHandler(this.课程信息添加ToolStripMenuItem_Click);
            // 
            // 课程信息修改ToolStripMenuItem
            // 
            this.课程信息修改ToolStripMenuItem.Name = "课程信息修改ToolStripMenuItem";
            this.课程信息修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.课程信息修改ToolStripMenuItem.Text = "课程信息修改";
            this.课程信息修改ToolStripMenuItem.Click += new System.EventHandler(this.课程信息修改ToolStripMenuItem_Click);
            // 
            // 课程信息删除ToolStripMenuItem
            // 
            this.课程信息删除ToolStripMenuItem.Name = "课程信息删除ToolStripMenuItem";
            this.课程信息删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课程信息删除ToolStripMenuItem.Text = "课程信息删除";
            this.课程信息删除ToolStripMenuItem.Click += new System.EventHandler(this.课程信息删除ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.成绩修改ToolStripMenuItem,
            this.成绩添加ToolStripMenuItem,
            this.成绩删除ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理（R）";
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 成绩修改ToolStripMenuItem
            // 
            this.成绩修改ToolStripMenuItem.Name = "成绩修改ToolStripMenuItem";
            this.成绩修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.成绩修改ToolStripMenuItem.Text = "成绩修改";
            this.成绩修改ToolStripMenuItem.Click += new System.EventHandler(this.成绩修改ToolStripMenuItem_Click);
            // 
            // 成绩添加ToolStripMenuItem
            // 
            this.成绩添加ToolStripMenuItem.Name = "成绩添加ToolStripMenuItem";
            this.成绩添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.成绩添加ToolStripMenuItem.Text = "成绩添加";
            this.成绩添加ToolStripMenuItem.Click += new System.EventHandler(this.成绩添加ToolStripMenuItem_Click);
            // 
            // 成绩删除ToolStripMenuItem
            // 
            this.成绩删除ToolStripMenuItem.Name = "成绩删除ToolStripMenuItem";
            this.成绩删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.成绩删除ToolStripMenuItem.Text = "成绩删除";
            this.成绩删除ToolStripMenuItem.Click += new System.EventHandler(this.成绩删除ToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本ToolStripMenuItem});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.关于AToolStripMenuItem.Text = "关于（A）";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.版本ToolStripMenuItem.Text = "版本";
            this.版本ToolStripMenuItem.Click += new System.EventHandler(this.版本ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStuManage,
            this.btnCouManage,
            this.btnScoManage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStuManage
            // 
            this.btnStuManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStuManage.Image = ((System.Drawing.Image)(resources.GetObject("btnStuManage.Image")));
            this.btnStuManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(23, 22);
            this.btnStuManage.Text = "学生信息查询";
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // btnCouManage
            // 
            this.btnCouManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCouManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCouManage.Image")));
            this.btnCouManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCouManage.Name = "btnCouManage";
            this.btnCouManage.Size = new System.Drawing.Size(23, 22);
            this.btnCouManage.Text = "课程信息查询";
            this.btnCouManage.Click += new System.EventHandler(this.btnCouManage_Click);
            // 
            // btnScoManage
            // 
            this.btnScoManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScoManage.Image = ((System.Drawing.Image)(resources.GetObject("btnScoManage.Image")));
            this.btnScoManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScoManage.Name = "btnScoManage";
            this.btnScoManage.Size = new System.Drawing.Size(23, 22);
            this.btnScoManage.Text = "成绩信息查询";
            this.btnScoManage.Click += new System.EventHandler(this.btnScoManage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(164, 17);
            this.toolStripStatusLabel1.Text = "欢迎登陆学生成绩管理系统！";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(179, 17);
            this.toolStripStatusLabel3.Text = "制作人 郭旭辉 学号 170224109";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStuManage;
        private System.Windows.Forms.ToolStripButton btnCouManage;
        private System.Windows.Forms.ToolStripButton btnScoManage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}