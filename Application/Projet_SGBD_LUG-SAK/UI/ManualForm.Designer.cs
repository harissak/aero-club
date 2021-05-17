
namespace UI
{
    partial class ManualForm
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
            this.panelManualScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelManualScreen
            // 
            this.panelManualScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManualScreen.Location = new System.Drawing.Point(0, 0);
            this.panelManualScreen.Name = "panelManualScreen";
            this.panelManualScreen.Size = new System.Drawing.Size(1000, 563);
            this.panelManualScreen.TabIndex = 0;
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelManualScreen);
            this.Name = "ManualForm";
            this.Text = "ManualForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManualScreen;
    }
}