namespace WinProject
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشلیستکتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookListMenuItem,
            this.InsertBookMenuItem,
            this.UpdateBookMenuItem});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(124, 24);
            this.MenuItem.Text = "مدیریت کتاب ها";
            // 
            // BookListMenuItem
            // 
            this.BookListMenuItem.Name = "BookListMenuItem";
            this.BookListMenuItem.Size = new System.Drawing.Size(227, 26);
            this.BookListMenuItem.Text = "نمایش لیست کتاب ها";
            this.BookListMenuItem.Click += new System.EventHandler(this.BookListMenuItem_Click);
            // 
            // InsertBookMenuItem
            // 
            this.InsertBookMenuItem.Name = "InsertBookMenuItem";
            this.InsertBookMenuItem.Size = new System.Drawing.Size(227, 26);
            this.InsertBookMenuItem.Text = "افزودن کتاب";
            this.InsertBookMenuItem.Click += new System.EventHandler(this.InsertBookMenuItem_Click);
            // 
            // UpdateBookMenuItem
            // 
            this.UpdateBookMenuItem.Name = "UpdateBookMenuItem";
            this.UpdateBookMenuItem.Size = new System.Drawing.Size(227, 26);
            this.UpdateBookMenuItem.Text = "ویرایش کتاب";
            this.UpdateBookMenuItem.Click += new System.EventHandler(this.UpdateBookMenuItem_Click);
            // 
            // نمایشلیستکتابهاToolStripMenuItem
            // 
            this.نمایشلیستکتابهاToolStripMenuItem.Name = "نمایشلیستکتابهاToolStripMenuItem";
            this.نمایشلیستکتابهاToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinProject.Properties.Resources.bookph1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشلیستکتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertBookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateBookMenuItem;
    }
}