
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
            this.BUT = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_MBR
            // 
            this.TB_MBR.Location = new System.Drawing.Point(12, 12);
            this.TB_MBR.Name = "TB_MBR";
            this.TB_MBR.Size = new System.Drawing.Size(188, 20);
            this.TB_MBR.TabIndex = 0;
            this.TB_MBR.TextChanged += new System.EventHandler(this.TB_MBR_TextChanged);
            // 
            // BUT
            // 
            this.BUT.Location = new System.Drawing.Point(241, 8);
            this.BUT.Name = "BUT";
            this.BUT.Size = new System.Drawing.Size(75, 23);
            this.BUT.TabIndex = 1;
            this.BUT.Text = "Load";
            this.BUT.UseVisualStyleBackColor = true;
            this.BUT.Click += new System.EventHandler(this.BUT_Member_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 38);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.Size = new System.Drawing.Size(776, 400);
            this.DGV.TabIndex = 2;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_MBR_CellContentClick);
            // 
            // BasicDBReadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.BUT);
            this.Controls.Add(this.TB_MBR);
            this.Name = "BasicDBReadTest";
            this.Text = "BasicDBReadTest";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_MBR;
        private System.Windows.Forms.Button BUT;
        private System.Windows.Forms.DataGridView DGV;
    }
}