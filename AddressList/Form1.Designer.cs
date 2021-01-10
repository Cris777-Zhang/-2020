namespace AddressList
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我的同学");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("我的同事");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("我的家人");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系人分组GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加同级分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加下级分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改分组名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系人CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(524, 303);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(25, 113);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统YToolStripMenuItem,
            this.联系人分组GToolStripMenuItem,
            this.联系人CToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统YToolStripMenuItem
            // 
            this.系统YToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
            this.系统YToolStripMenuItem.Name = "系统YToolStripMenuItem";
            this.系统YToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.系统YToolStripMenuItem.Text = "系统（&Y）";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统（&E）";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 联系人分组GToolStripMenuItem
            // 
            this.联系人分组GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加同级分组ToolStripMenuItem,
            this.添加下级分组ToolStripMenuItem,
            this.修改分组名称ToolStripMenuItem,
            this.删除分组ToolStripMenuItem});
            this.联系人分组GToolStripMenuItem.Name = "联系人分组GToolStripMenuItem";
            this.联系人分组GToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.联系人分组GToolStripMenuItem.Text = "联系人分组（&G）";
            // 
            // 添加同级分组ToolStripMenuItem
            // 
            this.添加同级分组ToolStripMenuItem.Name = "添加同级分组ToolStripMenuItem";
            this.添加同级分组ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.添加同级分组ToolStripMenuItem.Text = "添加同级分组";
            this.添加同级分组ToolStripMenuItem.Click += new System.EventHandler(this.添加同级分组ToolStripMenuItem_Click);
            // 
            // 添加下级分组ToolStripMenuItem
            // 
            this.添加下级分组ToolStripMenuItem.Name = "添加下级分组ToolStripMenuItem";
            this.添加下级分组ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.添加下级分组ToolStripMenuItem.Text = "添加下级分组";
            this.添加下级分组ToolStripMenuItem.Click += new System.EventHandler(this.添加下级分组ToolStripMenuItem_Click);
            // 
            // 修改分组名称ToolStripMenuItem
            // 
            this.修改分组名称ToolStripMenuItem.Name = "修改分组名称ToolStripMenuItem";
            this.修改分组名称ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.修改分组名称ToolStripMenuItem.Text = "修改分组名称";
            this.修改分组名称ToolStripMenuItem.Click += new System.EventHandler(this.修改分组名称ToolStripMenuItem_Click);
            // 
            // 删除分组ToolStripMenuItem
            // 
            this.删除分组ToolStripMenuItem.Name = "删除分组ToolStripMenuItem";
            this.删除分组ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.删除分组ToolStripMenuItem.Text = "删除分组";
            this.删除分组ToolStripMenuItem.Click += new System.EventHandler(this.删除分组ToolStripMenuItem_Click);
            // 
            // 联系人CToolStripMenuItem
            // 
            this.联系人CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加联系人ToolStripMenuItem,
            this.删除联系人ToolStripMenuItem,
            this.读取联系人ToolStripMenuItem,
            this.查找联系人ToolStripMenuItem});
            this.联系人CToolStripMenuItem.Name = "联系人CToolStripMenuItem";
            this.联系人CToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.联系人CToolStripMenuItem.Text = "联系人（&C）";
            // 
            // 添加联系人ToolStripMenuItem
            // 
            this.添加联系人ToolStripMenuItem.Name = "添加联系人ToolStripMenuItem";
            this.添加联系人ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.添加联系人ToolStripMenuItem.Text = "添加联系人";
            this.添加联系人ToolStripMenuItem.Click += new System.EventHandler(this.添加联系人ToolStripMenuItem_Click);
            // 
            // 删除联系人ToolStripMenuItem
            // 
            this.删除联系人ToolStripMenuItem.Name = "删除联系人ToolStripMenuItem";
            this.删除联系人ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.删除联系人ToolStripMenuItem.Text = "删除联系人";
            this.删除联系人ToolStripMenuItem.Click += new System.EventHandler(this.删除联系人ToolStripMenuItem_Click);
            // 
            // 读取联系人ToolStripMenuItem
            // 
            this.读取联系人ToolStripMenuItem.Name = "读取联系人ToolStripMenuItem";
            this.读取联系人ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.读取联系人ToolStripMenuItem.Text = "读取联系人";
            this.读取联系人ToolStripMenuItem.Click += new System.EventHandler(this.读取联系人ToolStripMenuItem_Click);
            // 
            // 查找联系人ToolStripMenuItem
            // 
            this.查找联系人ToolStripMenuItem.Name = "查找联系人ToolStripMenuItem";
            this.查找联系人ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.查找联系人ToolStripMenuItem.Text = "查找联系人";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.关于AToolStripMenuItem.Text = "关于（&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1,
            this.tssl2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 17);
            // 
            // tssl2
            // 
            this.tssl2.Name = "tssl2";
            this.tssl2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton9,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton7,
            this.toolStripLabel1,
            this.tsbox1,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 24);
            this.toolStripButton1.Text = "添加同组";
            this.toolStripButton1.ToolTipText = "添加同组";
            this.toolStripButton1.Click += new System.EventHandler(this.添加同级分组ToolStripMenuItem_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(105, 24);
            this.toolStripButton9.Text = "添加下组";
            this.toolStripButton9.Click += new System.EventHandler(this.添加下级分组ToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 24);
            this.toolStripButton2.Text = "删除组";
            this.toolStripButton2.Click += new System.EventHandler(this.删除分组ToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(90, 24);
            this.toolStripButton3.Text = "修改组";
            this.toolStripButton3.Click += new System.EventHandler(this.修改分组名称ToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton4.Text = "新建";
            this.toolStripButton4.Click += new System.EventHandler(this.添加联系人ToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Purple;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton5.Text = "读取";
            this.toolStripButton5.Click += new System.EventHandler(this.读取联系人ToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton7.Text = "删除";
            this.toolStripButton7.Click += new System.EventHandler(this.删除联系人ToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "姓名：";
            // 
            // tsbox1
            // 
            this.tsbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsbox1.Name = "tsbox1";
            this.tsbox1.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(36, 24);
            this.toolStripButton8.Text = "搜索";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.treeView2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1060, 465);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 55);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1060, 490);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "节点0";
            treeNode1.Text = "我的同学";
            treeNode2.Name = "节点1";
            treeNode2.Text = "我的同事";
            treeNode3.Name = "节点2";
            treeNode3.Text = "我的家人";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView2.SelectedImageIndex = 1;
            this.treeView2.Size = new System.Drawing.Size(194, 465);
            this.treeView2.TabIndex = 6;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "人员.png");
            this.imageList1.Images.SetKeyName(1, "人员(1).png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 487);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 567);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统YToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系人分组GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系人CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsbox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 添加同级分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加下级分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改分组名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除联系人ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripStatusLabel tssl2;
        private System.Windows.Forms.ToolStripMenuItem 读取联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}

