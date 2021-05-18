
namespace UI
{
    partial class MembersForm
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
            this.panelMembersScreen = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.dgwShowMembers = new System.Windows.Forms.DataGridView();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMembersScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMembersScreen
            // 
            this.panelMembersScreen.Controls.Add(this.btnAddMember);
            this.panelMembersScreen.Controls.Add(this.btnSearch);
            this.panelMembersScreen.Controls.Add(this.tbMemberID);
            this.panelMembersScreen.Controls.Add(this.label1);
            this.panelMembersScreen.Controls.Add(this.tbMemberName);
            this.panelMembersScreen.Controls.Add(this.dgwShowMembers);
            this.panelMembersScreen.Controls.Add(this.lblMemberID);
            this.panelMembersScreen.Controls.Add(this.lblMemberName);
            this.panelMembersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMembersScreen.Location = new System.Drawing.Point(0, 0);
            this.panelMembersScreen.Name = "panelMembersScreen";
            this.panelMembersScreen.Size = new System.Drawing.Size(935, 758);
            this.panelMembersScreen.TabIndex = 0;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(536, 132);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(149, 32);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add new member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.addNewMember);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchMember);
            // 
            // tbMemberID
            // 
            this.tbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberID.Location = new System.Drawing.Point(184, 68);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(212, 26);
            this.tbMemberID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberName.Location = new System.Drawing.Point(184, 26);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(212, 26);
            this.tbMemberName.TabIndex = 9;
            // 
            // dgwShowMembers
            // 
            this.dgwShowMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowMembers.Location = new System.Drawing.Point(64, 184);
            this.dgwShowMembers.Name = "dgwShowMembers";
            this.dgwShowMembers.RowHeadersWidth = 51;
            this.dgwShowMembers.RowTemplate.Height = 24;
            this.dgwShowMembers.Size = new System.Drawing.Size(851, 559);
            this.dgwShowMembers.TabIndex = 6;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(27, 74);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(113, 20);
            this.lblMemberID.TabIndex = 8;
            this.lblMemberID.Text = "Member ID: ";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(27, 26);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(139, 20);
            this.lblMemberName.TabIndex = 7;
            this.lblMemberName.Text = "Member name: ";
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 758);
            this.Controls.Add(this.panelMembersScreen);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.panelMembersScreen.ResumeLayout(false);
            this.panelMembersScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMembersScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.DataGridView dgwShowMembers;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnAddMember;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}