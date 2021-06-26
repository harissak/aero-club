
namespace UI.User_control
{
    partial class uc_modify_aircraft
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_mod_app_descr = new System.Windows.Forms.Label();
            this.tb_mod_app_descr = new System.Windows.Forms.TextBox();
            this.lb_mod_app_class = new System.Windows.Forms.Label();
            this.cb_mod_app_class = new System.Windows.Forms.ComboBox();
            this.lb_mod_app_imma = new System.Windows.Forms.Label();
            this.tb_mod_app_imma = new System.Windows.Forms.TextBox();
            this.bt_mod_save = new System.Windows.Forms.Button();
            this.tb_mod_app_ID = new System.Windows.Forms.TextBox();
            this.lb_mod_app_id = new System.Windows.Forms.Label();
            this.bs_mod_app = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_mod_app)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mod_app_descr
            // 
            this.lb_mod_app_descr.AutoSize = true;
            this.lb_mod_app_descr.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mod_app_descr.Location = new System.Drawing.Point(4, 120);
            this.lb_mod_app_descr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mod_app_descr.Name = "lb_mod_app_descr";
            this.lb_mod_app_descr.Size = new System.Drawing.Size(144, 28);
            this.lb_mod_app_descr.TabIndex = 11;
            this.lb_mod_app_descr.Text = "Description:";
            // 
            // tb_mod_app_descr
            // 
            this.tb_mod_app_descr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_mod_app, "App_descr", true));
            this.tb_mod_app_descr.Location = new System.Drawing.Point(217, 125);
            this.tb_mod_app_descr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mod_app_descr.Multiline = true;
            this.tb_mod_app_descr.Name = "tb_mod_app_descr";
            this.tb_mod_app_descr.Size = new System.Drawing.Size(251, 126);
            this.tb_mod_app_descr.TabIndex = 10;
            // 
            // lb_mod_app_class
            // 
            this.lb_mod_app_class.AutoSize = true;
            this.lb_mod_app_class.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mod_app_class.Location = new System.Drawing.Point(5, 81);
            this.lb_mod_app_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mod_app_class.Name = "lb_mod_app_class";
            this.lb_mod_app_class.Size = new System.Drawing.Size(92, 28);
            this.lb_mod_app_class.TabIndex = 9;
            this.lb_mod_app_class.Text = "Classe:";
            // 
            // cb_mod_app_class
            // 
            this.cb_mod_app_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mod_app_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mod_app_class.FormattingEnabled = true;
            this.cb_mod_app_class.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_mod_app_class.Location = new System.Drawing.Point(217, 80);
            this.cb_mod_app_class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_mod_app_class.Name = "cb_mod_app_class";
            this.cb_mod_app_class.Size = new System.Drawing.Size(51, 33);
            this.cb_mod_app_class.TabIndex = 8;
            // 
            // lb_mod_app_imma
            // 
            this.lb_mod_app_imma.AutoSize = true;
            this.lb_mod_app_imma.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mod_app_imma.Location = new System.Drawing.Point(4, 43);
            this.lb_mod_app_imma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mod_app_imma.Name = "lb_mod_app_imma";
            this.lb_mod_app_imma.Size = new System.Drawing.Size(193, 28);
            this.lb_mod_app_imma.TabIndex = 7;
            this.lb_mod_app_imma.Text = "Immatriculation:";
            // 
            // tb_mod_app_imma
            // 
            this.tb_mod_app_imma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_mod_app, "App_imma", true));
            this.tb_mod_app_imma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mod_app_imma.Location = new System.Drawing.Point(217, 42);
            this.tb_mod_app_imma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mod_app_imma.Name = "tb_mod_app_imma";
            this.tb_mod_app_imma.Size = new System.Drawing.Size(132, 30);
            this.tb_mod_app_imma.TabIndex = 6;
            // 
            // bt_mod_save
            // 
            this.bt_mod_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_mod_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_mod_save.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mod_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_mod_save.Location = new System.Drawing.Point(114, 275);
            this.bt_mod_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_mod_save.Name = "bt_mod_save";
            this.bt_mod_save.Size = new System.Drawing.Size(225, 37);
            this.bt_mod_save.TabIndex = 12;
            this.bt_mod_save.Text = "Save modifications";
            this.bt_mod_save.UseVisualStyleBackColor = false;
            this.bt_mod_save.Click += new System.EventHandler(this.bt_mod_save_Click);
            // 
            // tb_mod_app_ID
            // 
            this.tb_mod_app_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_mod_app, "App_ID", true));
            this.tb_mod_app_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mod_app_ID.Location = new System.Drawing.Point(217, 4);
            this.tb_mod_app_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mod_app_ID.Name = "tb_mod_app_ID";
            this.tb_mod_app_ID.ReadOnly = true;
            this.tb_mod_app_ID.Size = new System.Drawing.Size(51, 30);
            this.tb_mod_app_ID.TabIndex = 13;
            // 
            // lb_mod_app_id
            // 
            this.lb_mod_app_id.AutoSize = true;
            this.lb_mod_app_id.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mod_app_id.Location = new System.Drawing.Point(5, 5);
            this.lb_mod_app_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mod_app_id.Name = "lb_mod_app_id";
            this.lb_mod_app_id.Size = new System.Drawing.Size(119, 28);
            this.lb_mod_app_id.TabIndex = 14;
            this.lb_mod_app_id.Text = "Mat. club:";
            // 
            // bs_mod_app
            // 
            this.bs_mod_app.DataSource = typeof(DTO.APP);
            // 
            // uc_modify_aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_mod_app_id);
            this.Controls.Add(this.tb_mod_app_ID);
            this.Controls.Add(this.bt_mod_save);
            this.Controls.Add(this.lb_mod_app_descr);
            this.Controls.Add(this.tb_mod_app_descr);
            this.Controls.Add(this.lb_mod_app_class);
            this.Controls.Add(this.cb_mod_app_class);
            this.Controls.Add(this.lb_mod_app_imma);
            this.Controls.Add(this.tb_mod_app_imma);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_modify_aircraft";
            this.Size = new System.Drawing.Size(474, 333);
            ((System.ComponentModel.ISupportInitialize)(this.bs_mod_app)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mod_app_descr;
        private System.Windows.Forms.TextBox tb_mod_app_descr;
        private System.Windows.Forms.Label lb_mod_app_class;
        private System.Windows.Forms.ComboBox cb_mod_app_class;
        private System.Windows.Forms.Label lb_mod_app_imma;
        private System.Windows.Forms.TextBox tb_mod_app_imma;
        private System.Windows.Forms.BindingSource bs_mod_app;
        private System.Windows.Forms.Button bt_mod_save;
        private System.Windows.Forms.TextBox tb_mod_app_ID;
        private System.Windows.Forms.Label lb_mod_app_id;
    }
}
