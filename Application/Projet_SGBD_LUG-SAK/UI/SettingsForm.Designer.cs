﻿
namespace UI
{
    partial class SettingsForm
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
            this.panelSettingsScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSettingsScreen
            // 
            this.panelSettingsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsScreen.Name = "panelSettingsScreen";
            this.panelSettingsScreen.Size = new System.Drawing.Size(1000, 563);
            this.panelSettingsScreen.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSettingsScreen);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettingsScreen;
    }
}