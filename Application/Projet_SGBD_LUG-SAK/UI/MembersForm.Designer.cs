
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
            this.mbrList1 = new UI.User_control.mbrList();
            this.mbrList2 = new UI.User_control.mbrList();
            this.saveDelete1 = new UI.User_control.saveDelete();
            this.panelMembersScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMembersScreen
            // 
            this.panelMembersScreen.Controls.Add(this.saveDelete1);
            this.panelMembersScreen.Controls.Add(this.mbrList2);
            this.panelMembersScreen.Controls.Add(this.mbrList1);
            this.panelMembersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMembersScreen.Location = new System.Drawing.Point(0, 0);
            this.panelMembersScreen.Name = "panelMembersScreen";
            this.panelMembersScreen.Size = new System.Drawing.Size(1379, 758);
            this.panelMembersScreen.TabIndex = 0;
            // 
            // mbrList1
            // 
            this.mbrList1.Location = new System.Drawing.Point(0, 0);
            this.mbrList1.Name = "mbrList1";
            this.mbrList1.Size = new System.Drawing.Size(1368, 730);
            this.mbrList1.TabIndex = 0;
            // 
            // mbrList2
            // 
            this.mbrList2.Location = new System.Drawing.Point(8, 8);
            this.mbrList2.Name = "mbrList2";
            this.mbrList2.Size = new System.Drawing.Size(1368, 730);
            this.mbrList2.TabIndex = 1;
            // 
            // saveDelete1
            // 
            this.saveDelete1.Location = new System.Drawing.Point(1007, 676);
            this.saveDelete1.Name = "saveDelete1";
            this.saveDelete1.Size = new System.Drawing.Size(275, 42);
            this.saveDelete1.TabIndex = 1;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 758);
            this.Controls.Add(this.panelMembersScreen);
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersForm";
            this.panelMembersScreen.ResumeLayout(false);
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
        private User_control.saveDelete saveDelete1;
        private User_control.mbrList mbrList2;
        private User_control.mbrList mbrList1;
    }
}