namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.Web = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toaDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themSuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themSuaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Web);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(12, 27);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(850, 585);
            this.tab.TabIndex = 0;
            // 
            // Web
            // 
            this.Web.Location = new System.Drawing.Point(4, 22);
            this.Web.Name = "Web";
            this.Web.Padding = new System.Windows.Forms.Padding(3);
            this.Web.Size = new System.Drawing.Size(842, 559);
            this.Web.TabIndex = 0;
            this.Web.Text = "tabPage1";
            this.Web.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toaDoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toaDoToolStripMenuItem
            // 
            this.toaDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiToolStripMenuItem,
            this.xiuToolStripMenuItem});
            this.toaDoToolStripMenuItem.Name = "toaDoToolStripMenuItem";
            this.toaDoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.toaDoToolStripMenuItem.Text = "Toa Do";
            // 
            // taiToolStripMenuItem
            // 
            this.taiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themSuaToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.taiToolStripMenuItem.Name = "taiToolStripMenuItem";
            this.taiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taiToolStripMenuItem.Text = "Tai";
            // 
            // xiuToolStripMenuItem
            // 
            this.xiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themSuaToolStripMenuItem1,
            this.xoaToolStripMenuItem1});
            this.xiuToolStripMenuItem.Name = "xiuToolStripMenuItem";
            this.xiuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xiuToolStripMenuItem.Text = "Xiu";
            // 
            // themSuaToolStripMenuItem
            // 
            this.themSuaToolStripMenuItem.Name = "themSuaToolStripMenuItem";
            this.themSuaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.themSuaToolStripMenuItem.Text = "Them/Sua";
            this.themSuaToolStripMenuItem.Click += new System.EventHandler(this.themSuaToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xoaToolStripMenuItem.Text = "Xoa";
            // 
            // themSuaToolStripMenuItem1
            // 
            this.themSuaToolStripMenuItem1.Name = "themSuaToolStripMenuItem1";
            this.themSuaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.themSuaToolStripMenuItem1.Text = "Them/Sua";
            // 
            // xoaToolStripMenuItem1
            // 
            this.xoaToolStripMenuItem1.Name = "xoaToolStripMenuItem1";
            this.xoaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xoaToolStripMenuItem1.Text = "Xoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 635);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Web;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toaDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themSuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themSuaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem1;
    }
}

