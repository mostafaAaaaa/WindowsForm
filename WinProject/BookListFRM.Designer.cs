namespace WinProject
{
    partial class BookListFRM
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
            this.BooklistGv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BooklistGv)).BeginInit();
            this.SuspendLayout();
            // 
            // BooklistGv
            // 
            this.BooklistGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooklistGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooklistGv.Location = new System.Drawing.Point(0, 0);
            this.BooklistGv.Name = "BooklistGv";
            this.BooklistGv.RowHeadersWidth = 51;
            this.BooklistGv.RowTemplate.Height = 24;
            this.BooklistGv.Size = new System.Drawing.Size(800, 450);
            this.BooklistGv.TabIndex = 0;
            // 
            // BookListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BooklistGv);
            this.Name = "BookListFRM";
            this.Text = "BookListFRM";
            this.Load += new System.EventHandler(this.BookListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooklistGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooklistGv;
    }
}