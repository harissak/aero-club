
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
            this.saveDeleteMember = new UI.User_control.uc_saveDelete();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.addNewMember = new UI.User_control.uc_addNewMember();
            this.mbrList = new UI.User_control.uc_mbrList();
            this.panelMembersScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMembersScreen
            // 
            this.panelMembersScreen.Controls.Add(this.saveDeleteMember);
            this.panelMembersScreen.Controls.Add(this.label1);
            this.panelMembersScreen.Controls.Add(this.lblMemberID);
            this.panelMembersScreen.Controls.Add(this.addNewMember);
            this.panelMembersScreen.Controls.Add(this.mbrList);
            this.panelMembersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMembersScreen.Location = new System.Drawing.Point(0, 0);
            this.panelMembersScreen.Name = "panelMembersScreen";
            this.panelMembersScreen.Size = new System.Drawing.Size(1354, 734);
            this.panelMembersScreen.TabIndex = 0;
            // 
            // saveDeleteMember
            // 
            this.saveDeleteMember.Location = new System.Drawing.Point(871, 12);
            this.saveDeleteMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveDeleteMember.Name = "saveDeleteMember";
            this.saveDeleteMember.Size = new System.Drawing.Size(471, 671);
            this.saveDeleteMember.TabIndex = 17;
            this.saveDeleteMember.refreshMbrList += new UI.delRefresh(this.refreshMembersList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member nom:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(43, 60);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(113, 20);
            this.lblMemberID.TabIndex = 15;
            this.lblMemberID.Text = "Member ID: ";
            // 
            // addNewMember
            // 
            this.addNewMember.Location = new System.Drawing.Point(875, 12);
            this.addNewMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(472, 675);
            this.addNewMember.TabIndex = 2;
            this.addNewMember.refreshMbrList += new UI.delRefresh(this.refreshMembersList);
            // 
            // mbrList
            // 
            this.mbrList.Location = new System.Drawing.Point(3, 1);
            this.mbrList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbrList.Name = "mbrList";
            this.mbrList.Size = new System.Drawing.Size(867, 730);
            this.mbrList.TabIndex = 1;
            this.mbrList.SelectMbr += new UI.delSelect(this.recherce_Mbr);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.panelMembersScreen);
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersForm";
            this.panelMembersScreen.ResumeLayout(false);
            this.panelMembersScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMembersScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrprenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrsexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbradrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnumboiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrcpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrfixtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrgsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrcotvalideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mbrestpilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mbrestadmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrpasswDataGridViewTextBoxColumn;
        private User_control.uc_mbrList mbrList;
        private User_control.uc_addNewMember addNewMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberID;
        private User_control.uc_saveDelete saveDeleteMember;
    }
}