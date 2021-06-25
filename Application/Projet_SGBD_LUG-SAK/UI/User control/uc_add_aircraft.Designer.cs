
namespace UI.User_control
{
    partial class uc_add_aircraft
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
            System.Windows.Forms.Label lb_add_app_class;
            this.tb_add_app_imma = new System.Windows.Forms.TextBox();
            this.lb_add_app_imma = new System.Windows.Forms.Label();
            this.cb_add_app_class = new System.Windows.Forms.ComboBox();
            this.tb_add_app_descr = new System.Windows.Forms.TextBox();
            this.lb_add_app_descr = new System.Windows.Forms.Label();
            this.bt_add_app = new System.Windows.Forms.Button();
            this.lb_add_app_classInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            lb_add_app_class = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_add_app_imma
            // 
            this.tb_add_app_imma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_add_app_imma.Location = new System.Drawing.Point(220, 4);
            this.tb_add_app_imma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_add_app_imma.Name = "tb_add_app_imma";
            this.tb_add_app_imma.Size = new System.Drawing.Size(132, 30);
            this.tb_add_app_imma.TabIndex = 0;
            // 
            // lb_add_app_imma
            // 
            this.lb_add_app_imma.AutoSize = true;
            this.lb_add_app_imma.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add_app_imma.Location = new System.Drawing.Point(2, 4);
            this.lb_add_app_imma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_add_app_imma.Name = "lb_add_app_imma";
            this.lb_add_app_imma.Size = new System.Drawing.Size(193, 28);
            this.lb_add_app_imma.TabIndex = 1;
            this.lb_add_app_imma.Text = "Immatriculation:";
            // 
            // cb_add_app_class
            // 
            this.cb_add_app_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_add_app_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_add_app_class.FormattingEnabled = true;
            this.cb_add_app_class.Location = new System.Drawing.Point(222, 92);
            this.cb_add_app_class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_add_app_class.Name = "cb_add_app_class";
            this.cb_add_app_class.Size = new System.Drawing.Size(202, 33);
            this.cb_add_app_class.TabIndex = 2;
            this.cb_add_app_class.SelectedIndexChanged += new System.EventHandler(this.cb_add_app_class_SelectedIndexChanged);
            // 
            // lb_add_app_class
            // 
            lb_add_app_class.AutoSize = true;
            lb_add_app_class.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_add_app_class.Location = new System.Drawing.Point(2, 93);
            lb_add_app_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_add_app_class.Name = "lb_add_app_class";
            lb_add_app_class.Size = new System.Drawing.Size(92, 28);
            lb_add_app_class.TabIndex = 3;
            lb_add_app_class.Text = "Classe:";
            // 
            // tb_add_app_descr
            // 
            this.tb_add_app_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_add_app_descr.Location = new System.Drawing.Point(222, 142);
            this.tb_add_app_descr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_add_app_descr.Multiline = true;
            this.tb_add_app_descr.Name = "tb_add_app_descr";
            this.tb_add_app_descr.Size = new System.Drawing.Size(250, 133);
            this.tb_add_app_descr.TabIndex = 4;
            // 
            // lb_add_app_descr
            // 
            this.lb_add_app_descr.AutoSize = true;
            this.lb_add_app_descr.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add_app_descr.Location = new System.Drawing.Point(4, 142);
            this.lb_add_app_descr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_add_app_descr.Name = "lb_add_app_descr";
            this.lb_add_app_descr.Size = new System.Drawing.Size(144, 28);
            this.lb_add_app_descr.TabIndex = 5;
            this.lb_add_app_descr.Text = "Description:";
            // 
            // bt_add_app
            // 
            this.bt_add_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_add_app.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add_app.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_app.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_add_app.Location = new System.Drawing.Point(51, 297);
            this.bt_add_app.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_app.Name = "bt_add_app";
            this.bt_add_app.Size = new System.Drawing.Size(157, 39);
            this.bt_add_app.TabIndex = 6;
            this.bt_add_app.Text = "Add new A/C";
            this.bt_add_app.UseVisualStyleBackColor = false;
            this.bt_add_app.Click += new System.EventHandler(this.bt_add_app_Click);
            // 
            // lb_add_app_classInfo
            // 
            this.lb_add_app_classInfo.AutoSize = true;
            this.lb_add_app_classInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add_app_classInfo.Location = new System.Drawing.Point(223, 56);
            this.lb_add_app_classInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_add_app_classInfo.Name = "lb_add_app_classInfo";
            this.lb_add_app_classInfo.Size = new System.Drawing.Size(0, 20);
            this.lb_add_app_classInfo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(250, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_add_aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_add_app_classInfo);
            this.Controls.Add(this.bt_add_app);
            this.Controls.Add(this.lb_add_app_descr);
            this.Controls.Add(this.tb_add_app_descr);
            this.Controls.Add(lb_add_app_class);
            this.Controls.Add(this.cb_add_app_class);
            this.Controls.Add(this.lb_add_app_imma);
            this.Controls.Add(this.tb_add_app_imma);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_add_aircraft";
            this.Size = new System.Drawing.Size(476, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_add_app_imma;
        private System.Windows.Forms.Label lb_add_app_imma;
        private System.Windows.Forms.ComboBox cb_add_app_class;
        private System.Windows.Forms.TextBox tb_add_app_descr;
        private System.Windows.Forms.Label lb_add_app_descr;
        private System.Windows.Forms.Button bt_add_app;
        private System.Windows.Forms.Label lb_add_app_classInfo;
        private System.Windows.Forms.Button button1;
    }
}
