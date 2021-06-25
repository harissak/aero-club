
namespace UI.User_control
{
    partial class uc_licenses_mod
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
            this.tb_modif_Lic_num = new System.Windows.Forms.TextBox();
            this.lb_modif_lic_num = new System.Windows.Forms.Label();
            this.dtp_mod_lic_obt = new System.Windows.Forms.DateTimePicker();
            this.lb_modif_lic_obt = new System.Windows.Forms.Label();
            this.dtp_modif_lix_exp = new System.Windows.Forms.DateTimePicker();
            this.lb_modif_lic_exp = new System.Windows.Forms.Label();
            this.cb_modif_lic_active = new System.Windows.Forms.CheckBox();
            this.lb_modif_lic_active = new System.Windows.Forms.Label();
            this.tb_modif_lic_country = new System.Windows.Forms.TextBox();
            this.lb_modif_origin_country = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl1 = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl2 = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl3 = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl4 = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl5 = new System.Windows.Forms.Label();
            this.lb_modif_lic_cl6 = new System.Windows.Forms.Label();
            this.cb_modif_lic_cl1 = new System.Windows.Forms.CheckBox();
            this.cb_modif_lic_cl2 = new System.Windows.Forms.CheckBox();
            this.cb_modif_lic_cl3 = new System.Windows.Forms.CheckBox();
            this.cb_modif_lic_cl4 = new System.Windows.Forms.CheckBox();
            this.cb_modif_lic_cl5 = new System.Windows.Forms.CheckBox();
            this.cb_modif_lic_cl6 = new System.Windows.Forms.CheckBox();
            this.bt_modif_lic_save = new System.Windows.Forms.Button();
            this.tb_modif_lic_ID = new System.Windows.Forms.TextBox();
            this.lb_modif_lic_id = new System.Windows.Forms.Label();
            this.bs_modif_lic = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_modif_lic)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_modif_Lic_num
            // 
            this.tb_modif_Lic_num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_modif_lic, "Lic_num", true));
            this.tb_modif_Lic_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modif_Lic_num.Location = new System.Drawing.Point(217, 45);
            this.tb_modif_Lic_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_modif_Lic_num.Name = "tb_modif_Lic_num";
            this.tb_modif_Lic_num.Size = new System.Drawing.Size(144, 30);
            this.tb_modif_Lic_num.TabIndex = 0;
            // 
            // lb_modif_lic_num
            // 
            this.lb_modif_lic_num.AutoSize = true;
            this.lb_modif_lic_num.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modif_lic_num.Location = new System.Drawing.Point(4, 45);
            this.lb_modif_lic_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_num.Name = "lb_modif_lic_num";
            this.lb_modif_lic_num.Size = new System.Drawing.Size(196, 28);
            this.lb_modif_lic_num.TabIndex = 1;
            this.lb_modif_lic_num.Text = "License Number:";
            // 
            // dtp_mod_lic_obt
            // 
            this.dtp_mod_lic_obt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_modif_lic, "Lic_obt", true));
            this.dtp_mod_lic_obt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_mod_lic_obt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_mod_lic_obt.Location = new System.Drawing.Point(217, 93);
            this.dtp_mod_lic_obt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_mod_lic_obt.Name = "dtp_mod_lic_obt";
            this.dtp_mod_lic_obt.Size = new System.Drawing.Size(144, 30);
            this.dtp_mod_lic_obt.TabIndex = 2;
            // 
            // lb_modif_lic_obt
            // 
            this.lb_modif_lic_obt.AutoSize = true;
            this.lb_modif_lic_obt.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lb_modif_lic_obt.Location = new System.Drawing.Point(4, 93);
            this.lb_modif_lic_obt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_obt.Name = "lb_modif_lic_obt";
            this.lb_modif_lic_obt.Size = new System.Drawing.Size(181, 28);
            this.lb_modif_lic_obt.TabIndex = 3;
            this.lb_modif_lic_obt.Text = "Obtention date:";
            // 
            // dtp_modif_lix_exp
            // 
            this.dtp_modif_lix_exp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_modif_lic, "Lic_exp", true));
            this.dtp_modif_lix_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_modif_lix_exp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_modif_lix_exp.Location = new System.Drawing.Point(217, 128);
            this.dtp_modif_lix_exp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_modif_lix_exp.Name = "dtp_modif_lix_exp";
            this.dtp_modif_lix_exp.Size = new System.Drawing.Size(144, 30);
            this.dtp_modif_lix_exp.TabIndex = 4;
            // 
            // lb_modif_lic_exp
            // 
            this.lb_modif_lic_exp.AutoSize = true;
            this.lb_modif_lic_exp.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lb_modif_lic_exp.Location = new System.Drawing.Point(4, 128);
            this.lb_modif_lic_exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_exp.Name = "lb_modif_lic_exp";
            this.lb_modif_lic_exp.Size = new System.Drawing.Size(185, 28);
            this.lb_modif_lic_exp.TabIndex = 5;
            this.lb_modif_lic_exp.Text = "Expiration date:";
            // 
            // cb_modif_lic_active
            // 
            this.cb_modif_lic_active.AutoSize = true;
            this.cb_modif_lic_active.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_active", true));
            this.cb_modif_lic_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modif_lic_active.Location = new System.Drawing.Point(217, 181);
            this.cb_modif_lic_active.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_active.Name = "cb_modif_lic_active";
            this.cb_modif_lic_active.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_active.TabIndex = 6;
            this.cb_modif_lic_active.UseVisualStyleBackColor = true;
            // 
            // lb_modif_lic_active
            // 
            this.lb_modif_lic_active.AutoSize = true;
            this.lb_modif_lic_active.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lb_modif_lic_active.Location = new System.Drawing.Point(8, 181);
            this.lb_modif_lic_active.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_active.Name = "lb_modif_lic_active";
            this.lb_modif_lic_active.Size = new System.Drawing.Size(112, 28);
            this.lb_modif_lic_active.TabIndex = 7;
            this.lb_modif_lic_active.Text = "Is active:";
            // 
            // tb_modif_lic_country
            // 
            this.tb_modif_lic_country.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_modif_lic, "Lic_pays", true));
            this.tb_modif_lic_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modif_lic_country.Location = new System.Drawing.Point(217, 206);
            this.tb_modif_lic_country.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_modif_lic_country.Name = "tb_modif_lic_country";
            this.tb_modif_lic_country.Size = new System.Drawing.Size(144, 30);
            this.tb_modif_lic_country.TabIndex = 8;
            // 
            // lb_modif_origin_country
            // 
            this.lb_modif_origin_country.AutoSize = true;
            this.lb_modif_origin_country.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lb_modif_origin_country.Location = new System.Drawing.Point(8, 212);
            this.lb_modif_origin_country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_origin_country.Name = "lb_modif_origin_country";
            this.lb_modif_origin_country.Size = new System.Drawing.Size(175, 28);
            this.lb_modif_origin_country.TabIndex = 9;
            this.lb_modif_origin_country.Text = "Origin country:";
            // 
            // lb_modif_lic_cl1
            // 
            this.lb_modif_lic_cl1.AutoSize = true;
            this.lb_modif_lic_cl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl1.Location = new System.Drawing.Point(9, 285);
            this.lb_modif_lic_cl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl1.Name = "lb_modif_lic_cl1";
            this.lb_modif_lic_cl1.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl1.TabIndex = 10;
            this.lb_modif_lic_cl1.Text = "Class 1:";
            // 
            // lb_modif_lic_cl2
            // 
            this.lb_modif_lic_cl2.AutoSize = true;
            this.lb_modif_lic_cl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl2.Location = new System.Drawing.Point(9, 321);
            this.lb_modif_lic_cl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl2.Name = "lb_modif_lic_cl2";
            this.lb_modif_lic_cl2.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl2.TabIndex = 11;
            this.lb_modif_lic_cl2.Text = "Class 2:";
            // 
            // lb_modif_lic_cl3
            // 
            this.lb_modif_lic_cl3.AutoSize = true;
            this.lb_modif_lic_cl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl3.Location = new System.Drawing.Point(9, 356);
            this.lb_modif_lic_cl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl3.Name = "lb_modif_lic_cl3";
            this.lb_modif_lic_cl3.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl3.TabIndex = 12;
            this.lb_modif_lic_cl3.Text = "Class 3:";
            // 
            // lb_modif_lic_cl4
            // 
            this.lb_modif_lic_cl4.AutoSize = true;
            this.lb_modif_lic_cl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl4.Location = new System.Drawing.Point(9, 392);
            this.lb_modif_lic_cl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl4.Name = "lb_modif_lic_cl4";
            this.lb_modif_lic_cl4.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl4.TabIndex = 13;
            this.lb_modif_lic_cl4.Text = "Class 4:";
            // 
            // lb_modif_lic_cl5
            // 
            this.lb_modif_lic_cl5.AutoSize = true;
            this.lb_modif_lic_cl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl5.Location = new System.Drawing.Point(9, 428);
            this.lb_modif_lic_cl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl5.Name = "lb_modif_lic_cl5";
            this.lb_modif_lic_cl5.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl5.TabIndex = 14;
            this.lb_modif_lic_cl5.Text = "Class 5:";
            // 
            // lb_modif_lic_cl6
            // 
            this.lb_modif_lic_cl6.AutoSize = true;
            this.lb_modif_lic_cl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_modif_lic_cl6.Location = new System.Drawing.Point(9, 464);
            this.lb_modif_lic_cl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_cl6.Name = "lb_modif_lic_cl6";
            this.lb_modif_lic_cl6.Size = new System.Drawing.Size(75, 22);
            this.lb_modif_lic_cl6.TabIndex = 15;
            this.lb_modif_lic_cl6.Text = "Class 6:";
            // 
            // cb_modif_lic_cl1
            // 
            this.cb_modif_lic_cl1.AutoSize = true;
            this.cb_modif_lic_cl1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_cl1", true));
            this.cb_modif_lic_cl1.Location = new System.Drawing.Point(160, 289);
            this.cb_modif_lic_cl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl1.Name = "cb_modif_lic_cl1";
            this.cb_modif_lic_cl1.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl1.TabIndex = 16;
            this.cb_modif_lic_cl1.UseVisualStyleBackColor = true;
            // 
            // cb_modif_lic_cl2
            // 
            this.cb_modif_lic_cl2.AutoSize = true;
            this.cb_modif_lic_cl2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_cl2", true));
            this.cb_modif_lic_cl2.Location = new System.Drawing.Point(160, 324);
            this.cb_modif_lic_cl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl2.Name = "cb_modif_lic_cl2";
            this.cb_modif_lic_cl2.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl2.TabIndex = 17;
            this.cb_modif_lic_cl2.UseVisualStyleBackColor = true;
            // 
            // cb_modif_lic_cl3
            // 
            this.cb_modif_lic_cl3.AutoSize = true;
            this.cb_modif_lic_cl3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_cl3", true));
            this.cb_modif_lic_cl3.Location = new System.Drawing.Point(160, 360);
            this.cb_modif_lic_cl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl3.Name = "cb_modif_lic_cl3";
            this.cb_modif_lic_cl3.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl3.TabIndex = 18;
            this.cb_modif_lic_cl3.UseVisualStyleBackColor = true;
            // 
            // cb_modif_lic_cl4
            // 
            this.cb_modif_lic_cl4.AutoSize = true;
            this.cb_modif_lic_cl4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_cl4", true));
            this.cb_modif_lic_cl4.Location = new System.Drawing.Point(160, 396);
            this.cb_modif_lic_cl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl4.Name = "cb_modif_lic_cl4";
            this.cb_modif_lic_cl4.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl4.TabIndex = 19;
            this.cb_modif_lic_cl4.UseVisualStyleBackColor = true;
            // 
            // cb_modif_lic_cl5
            // 
            this.cb_modif_lic_cl5.AutoSize = true;
            this.cb_modif_lic_cl5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_modif_lic, "Lic_cl5", true));
            this.cb_modif_lic_cl5.Location = new System.Drawing.Point(160, 432);
            this.cb_modif_lic_cl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl5.Name = "cb_modif_lic_cl5";
            this.cb_modif_lic_cl5.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl5.TabIndex = 20;
            this.cb_modif_lic_cl5.UseVisualStyleBackColor = true;
            // 
            // cb_modif_lic_cl6
            // 
            this.cb_modif_lic_cl6.AutoSize = true;
            this.cb_modif_lic_cl6.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_modif_lic, "Lic_cl6", true));
            this.cb_modif_lic_cl6.Location = new System.Drawing.Point(160, 467);
            this.cb_modif_lic_cl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_modif_lic_cl6.Name = "cb_modif_lic_cl6";
            this.cb_modif_lic_cl6.Size = new System.Drawing.Size(18, 17);
            this.cb_modif_lic_cl6.TabIndex = 21;
            this.cb_modif_lic_cl6.UseVisualStyleBackColor = true;
            // 
            // bt_modif_lic_save
            // 
            this.bt_modif_lic_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_modif_lic_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_modif_lic_save.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modif_lic_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_modif_lic_save.Location = new System.Drawing.Point(119, 521);
            this.bt_modif_lic_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_modif_lic_save.Name = "bt_modif_lic_save";
            this.bt_modif_lic_save.Size = new System.Drawing.Size(132, 33);
            this.bt_modif_lic_save.TabIndex = 22;
            this.bt_modif_lic_save.Text = "Save modifications";
            this.bt_modif_lic_save.UseVisualStyleBackColor = false;
            this.bt_modif_lic_save.Click += new System.EventHandler(this.bt_modif_lic_save_Click);
            // 
            // tb_modif_lic_ID
            // 
            this.tb_modif_lic_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_modif_lic, "Lic_ID", true));
            this.tb_modif_lic_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modif_lic_ID.Location = new System.Drawing.Point(217, 0);
            this.tb_modif_lic_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_modif_lic_ID.Name = "tb_modif_lic_ID";
            this.tb_modif_lic_ID.ReadOnly = true;
            this.tb_modif_lic_ID.Size = new System.Drawing.Size(144, 30);
            this.tb_modif_lic_ID.TabIndex = 23;
            // 
            // lb_modif_lic_id
            // 
            this.lb_modif_lic_id.AutoSize = true;
            this.lb_modif_lic_id.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lb_modif_lic_id.Location = new System.Drawing.Point(4, 0);
            this.lb_modif_lic_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modif_lic_id.Name = "lb_modif_lic_id";
            this.lb_modif_lic_id.Size = new System.Drawing.Size(163, 28);
            this.lb_modif_lic_id.TabIndex = 24;
            this.lb_modif_lic_id.Text = "Mat. Lic Club:";
            // 
            // bs_modif_lic
            // 
            this.bs_modif_lic.DataSource = typeof(DTO.LIC);
            // 
            // uc_licenses_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_modif_lic_id);
            this.Controls.Add(this.tb_modif_lic_ID);
            this.Controls.Add(this.bt_modif_lic_save);
            this.Controls.Add(this.cb_modif_lic_cl6);
            this.Controls.Add(this.cb_modif_lic_cl5);
            this.Controls.Add(this.cb_modif_lic_cl4);
            this.Controls.Add(this.cb_modif_lic_cl3);
            this.Controls.Add(this.cb_modif_lic_cl2);
            this.Controls.Add(this.cb_modif_lic_cl1);
            this.Controls.Add(this.lb_modif_lic_cl6);
            this.Controls.Add(this.lb_modif_lic_cl5);
            this.Controls.Add(this.lb_modif_lic_cl4);
            this.Controls.Add(this.lb_modif_lic_cl3);
            this.Controls.Add(this.lb_modif_lic_cl2);
            this.Controls.Add(this.lb_modif_lic_cl1);
            this.Controls.Add(this.lb_modif_origin_country);
            this.Controls.Add(this.tb_modif_lic_country);
            this.Controls.Add(this.lb_modif_lic_active);
            this.Controls.Add(this.cb_modif_lic_active);
            this.Controls.Add(this.lb_modif_lic_exp);
            this.Controls.Add(this.dtp_modif_lix_exp);
            this.Controls.Add(this.lb_modif_lic_obt);
            this.Controls.Add(this.dtp_mod_lic_obt);
            this.Controls.Add(this.lb_modif_lic_num);
            this.Controls.Add(this.tb_modif_Lic_num);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_licenses_mod";
            this.Size = new System.Drawing.Size(399, 594);
            ((System.ComponentModel.ISupportInitialize)(this.bs_modif_lic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_modif_Lic_num;
        private System.Windows.Forms.Label lb_modif_lic_num;
        private System.Windows.Forms.DateTimePicker dtp_mod_lic_obt;
        private System.Windows.Forms.Label lb_modif_lic_obt;
        private System.Windows.Forms.DateTimePicker dtp_modif_lix_exp;
        private System.Windows.Forms.Label lb_modif_lic_exp;
        private System.Windows.Forms.CheckBox cb_modif_lic_active;
        private System.Windows.Forms.Label lb_modif_lic_active;
        private System.Windows.Forms.TextBox tb_modif_lic_country;
        private System.Windows.Forms.Label lb_modif_origin_country;
        private System.Windows.Forms.Label lb_modif_lic_cl1;
        private System.Windows.Forms.Label lb_modif_lic_cl2;
        private System.Windows.Forms.Label lb_modif_lic_cl3;
        private System.Windows.Forms.Label lb_modif_lic_cl4;
        private System.Windows.Forms.Label lb_modif_lic_cl5;
        private System.Windows.Forms.Label lb_modif_lic_cl6;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl1;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl2;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl3;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl4;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl5;
        private System.Windows.Forms.CheckBox cb_modif_lic_cl6;
        private System.Windows.Forms.Button bt_modif_lic_save;
        private System.Windows.Forms.TextBox tb_modif_lic_ID;
        private System.Windows.Forms.Label lb_modif_lic_id;
        private System.Windows.Forms.BindingSource bs_modif_lic;
    }
}
