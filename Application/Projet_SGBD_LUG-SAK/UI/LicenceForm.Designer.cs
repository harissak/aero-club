
namespace UI
{
    partial class LicenceForm
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
            this.tab_settings_page2 = new System.Windows.Forms.TabPage();
            this.setting_uc_licenses_list = new UI.User_control.uc_licenses_list();
            this.uc_licenses_mod1 = new UI.User_control.uc_licenses_mod();
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.panelSettingsScreen.SuspendLayout();
            this.tab_settings_page2.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettingsScreen
            // 
            this.panelSettingsScreen.Controls.Add(this.tab_settings);
            this.panelSettingsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettingsScreen.Name = "panelSettingsScreen";
            this.panelSettingsScreen.Size = new System.Drawing.Size(1357, 847);
            this.panelSettingsScreen.TabIndex = 0;
            // 
            // tab_settings_page2
            // 
            this.tab_settings_page2.Controls.Add(this.uc_licenses_mod1);
            this.tab_settings_page2.Controls.Add(this.setting_uc_licenses_list);
            this.tab_settings_page2.Location = new System.Drawing.Point(4, 29);
            this.tab_settings_page2.Margin = new System.Windows.Forms.Padding(4);
            this.tab_settings_page2.Name = "tab_settings_page2";
            this.tab_settings_page2.Padding = new System.Windows.Forms.Padding(4);
            this.tab_settings_page2.Size = new System.Drawing.Size(1344, 799);
            this.tab_settings_page2.TabIndex = 1;
            this.tab_settings_page2.Text = "Flight Licenses Management";
            this.tab_settings_page2.UseVisualStyleBackColor = true;
            // 
            // setting_uc_licenses_list
            // 
            this.setting_uc_licenses_list.Location = new System.Drawing.Point(0, 9);
            this.setting_uc_licenses_list.Margin = new System.Windows.Forms.Padding(5);
            this.setting_uc_licenses_list.Name = "setting_uc_licenses_list";
            this.setting_uc_licenses_list.Size = new System.Drawing.Size(909, 737);
            this.setting_uc_licenses_list.TabIndex = 0;
            this.setting_uc_licenses_list.SelectLic += new UI.delSelectLIC(this.setting_uc_licenses_list_SelectLic);
            // 
            // uc_licenses_mod1
            // 
            this.uc_licenses_mod1.Location = new System.Drawing.Point(903, 48);
            this.uc_licenses_mod1.Margin = new System.Windows.Forms.Padding(5);
            this.uc_licenses_mod1.Name = "uc_licenses_mod1";
            this.uc_licenses_mod1.Size = new System.Drawing.Size(415, 698);
            this.uc_licenses_mod1.TabIndex = 1;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.tab_settings_page2);
            this.tab_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_settings.Location = new System.Drawing.Point(5, 0);
            this.tab_settings.Margin = new System.Windows.Forms.Padding(4);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(1352, 832);
            this.tab_settings.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 847);
            this.Controls.Add(this.panelSettingsScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panelSettingsScreen.ResumeLayout(false);
            this.tab_settings_page2.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettingsScreen;
        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tab_settings_page2;
        private User_control.uc_licenses_mod uc_licenses_mod1;
        private User_control.uc_licenses_list setting_uc_licenses_list;
    }
}