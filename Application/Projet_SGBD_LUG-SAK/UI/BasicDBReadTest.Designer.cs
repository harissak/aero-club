
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
            this.TB_MBR.Location = new System.Drawing.Point(16, 15);
            this.TB_MBR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_MBR.Name = "TB_MBR";
            this.TB_MBR.Size = new System.Drawing.Size(249, 22);
            this.TB_MBR.TabIndex = 0;
            this.TB_MBR.TextChanged += new System.EventHandler(this.TB_MBR_TextChanged);
            // 
            // BUT_Member
            // 
            this.BUT_Member.Location = new System.Drawing.Point(321, 10);
            this.BUT_Member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BUT_Member.Name = "BUT_Member";
            this.BUT_Member.Size = new System.Drawing.Size(100, 28);
            this.BUT_Member.TabIndex = 1;
            this.BUT_Member.Text = "Load";
            this.BUT_Member.UseVisualStyleBackColor = true;
            this.BUT_Member.Click += new System.EventHandler(this.BUT_Member_Click);
            // 
            // DGV_MBR
            // 
            this.DGV_MBR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MBR.Location = new System.Drawing.Point(16, 47);
            this.DGV_MBR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_MBR.Name = "DGV_MBR";
            this.DGV_MBR.RowHeadersWidth = 51;
            this.DGV_MBR.Size = new System.Drawing.Size(1035, 492);
            this.DGV_MBR.TabIndex = 2;
            // 
            // BasicDBReadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DGV_MBR);
            this.Controls.Add(this.BUT_Member);
            this.Controls.Add(this.TB_MBR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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