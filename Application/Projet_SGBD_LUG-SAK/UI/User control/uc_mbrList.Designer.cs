
namespace UI.User_control
{
    partial class uc_mbrList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMbrList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMbrList
            // 
            this.dgvMbrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMbrList.Location = new System.Drawing.Point(4, 132);
            this.dgvMbrList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMbrList.Name = "dgvMbrList";
            this.dgvMbrList.RowHeadersWidth = 51;
            this.dgvMbrList.RowTemplate.Height = 24;
            this.dgvMbrList.Size = new System.Drawing.Size(640, 458);
            this.dgvMbrList.TabIndex = 0;
            this.dgvMbrList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemCliked);
            this.dgvMbrList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMbrList_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(190, 98);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 26);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMemberID
            // 
            this.tbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberID.Location = new System.Drawing.Point(140, 46);
            this.tbMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(160, 23);
            this.tbMemberID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberName.Location = new System.Drawing.Point(140, 11);
            this.tbMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(160, 23);
            this.tbMemberName.TabIndex = 15;
            // 
            // uc_mbrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.dgvMbrList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_mbrList";
            this.Size = new System.Drawing.Size(646, 593);
            this.Load += new System.EventHandler(this.ucRech_mbr);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMbrList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMemberName;
    }
}
