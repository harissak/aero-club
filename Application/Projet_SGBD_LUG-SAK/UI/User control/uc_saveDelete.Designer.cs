
namespace UI.User_control
{
    partial class uc_saveDelete
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
            this.modify = new System.Windows.Forms.Button();
            this.deleteMember = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(3, 3);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(112, 33);
            this.modify.TabIndex = 0;
            this.modify.Text = "MODIFY";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // deleteMember
            // 
            this.deleteMember.Location = new System.Drawing.Point(156, 3);
            this.deleteMember.Name = "deleteMember";
            this.deleteMember.Size = new System.Drawing.Size(112, 33);
            this.deleteMember.TabIndex = 1;
            this.deleteMember.Text = "DELETE";
            this.deleteMember.UseVisualStyleBackColor = true;
            this.deleteMember.Click += new System.EventHandler(this.deleteMember_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(293, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 33);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // uc_saveDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deleteMember);
            this.Controls.Add(this.modify);
            this.Name = "uc_saveDelete";
            this.Size = new System.Drawing.Size(418, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button deleteMember;
        private System.Windows.Forms.Button cancel;
    }
}
