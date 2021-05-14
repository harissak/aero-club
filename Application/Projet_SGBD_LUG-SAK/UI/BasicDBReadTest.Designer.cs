
namespace UI
{
    partial class BasicDBReadTest
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
            this.TB_MBR = new System.Windows.Forms.TextBox();
            this.BUT_Member = new System.Windows.Forms.Button();
            this.DGV_MBR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MBR)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_MBR
            // 
            this.TB_MBR.Location = new System.Drawing.Point(12, 12);
            this.TB_MBR.Name = "TB_MBR";
            this.TB_MBR.Size = new System.Drawing.Size(188, 20);
            this.TB_MBR.TabIndex = 0;
            // 
            // BUT_Member
            // 
            this.BUT_Member.Location = new System.Drawing.Point(241, 8);
            this.BUT_Member.Name = "BUT_Member";
            this.BUT_Member.Size = new System.Drawing.Size(75, 23);
            this.BUT_Member.TabIndex = 1;
            this.BUT_Member.Text = "Load";
            this.BUT_Member.UseVisualStyleBackColor = true;
            this.BUT_Member.Click += new System.EventHandler(this.BUT_Member_Click);
            // 
            // DGV_MBR
            // 
            this.DGV_MBR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MBR.Location = new System.Drawing.Point(12, 38);
            this.DGV_MBR.Name = "DGV_MBR";
            this.DGV_MBR.Size = new System.Drawing.Size(776, 400);
            this.DGV_MBR.TabIndex = 2;
            // 
            // BasicDBReadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_MBR);
            this.Controls.Add(this.BUT_Member);
            this.Controls.Add(this.TB_MBR);
            this.Name = "BasicDBReadTest";
            this.Text = "BasicDBReadTest";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_MBR;
        private System.Windows.Forms.Button BUT_Member;
        private System.Windows.Forms.DataGridView DGV_MBR;
    }
}