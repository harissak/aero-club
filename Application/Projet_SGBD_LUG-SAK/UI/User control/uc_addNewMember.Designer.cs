
namespace UI.User_control
{
    partial class uc_addNewMember
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
            this.components = new System.ComponentModel.Container();
            this.addNewMember = new System.Windows.Forms.Button();
            this.dt_Ins_cot_val = new System.Windows.Forms.DateTimePicker();
            this.bs_new_member = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Ins_TeleFixe = new System.Windows.Forms.TextBox();
            this.tb_Ins_GSM = new System.Windows.Forms.TextBox();
            this.tb_Ins_Password = new System.Windows.Forms.TextBox();
            this.tb_Ins_Mail = new System.Windows.Forms.TextBox();
            this.tb_Ins_Ville = new System.Windows.Forms.TextBox();
            this.tb_Ins_CP = new System.Windows.Forms.TextBox();
            this.tb_Ins_NbrBoite = new System.Windows.Forms.TextBox();
            this.tb_Ins_Adresse = new System.Windows.Forms.TextBox();
            this.dt_Ins_Naissance = new System.Windows.Forms.DateTimePicker();
            this.cb_Ins_Sex = new System.Windows.Forms.ComboBox();
            this.tb_Ins_Prénom = new System.Windows.Forms.TextBox();
            this.tb_Ins_Nom = new System.Windows.Forms.TextBox();
            this.tb_Ins_ID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_Ins_is_pilot = new System.Windows.Forms.CheckBox();
            this.cb_Ins_is_admin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_new_member)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewMember
            // 
            this.addNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewMember.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMember.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewMember.Location = new System.Drawing.Point(130, 635);
            this.addNewMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(209, 37);
            this.addNewMember.TabIndex = 98;
            this.addNewMember.Text = "Add new member";
            this.addNewMember.UseVisualStyleBackColor = false;
            this.addNewMember.Click += new System.EventHandler(this.addNewMember_Click);
            // 
            // dt_Ins_cot_val
            // 
            this.dt_Ins_cot_val.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_cot_valide", true));
            this.dt_Ins_cot_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ins_cot_val.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ins_cot_val.Location = new System.Drawing.Point(165, 580);
            this.dt_Ins_cot_val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Ins_cot_val.Name = "dt_Ins_cot_val";
            this.dt_Ins_cot_val.Size = new System.Drawing.Size(137, 30);
            this.dt_Ins_cot_val.TabIndex = 97;
            // 
            // bs_new_member
            // 
            this.bs_new_member.DataSource = typeof(DTO.MBR);
            // 
            // tb_Ins_TeleFixe
            // 
            this.tb_Ins_TeleFixe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_fix_tel", true));
            this.tb_Ins_TeleFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_TeleFixe.Location = new System.Drawing.Point(165, 466);
            this.tb_Ins_TeleFixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_TeleFixe.Name = "tb_Ins_TeleFixe";
            this.tb_Ins_TeleFixe.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_TeleFixe.TabIndex = 96;
            this.tb_Ins_TeleFixe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_GSM
            // 
            this.tb_Ins_GSM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_gsm", true));
            this.tb_Ins_GSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_GSM.Location = new System.Drawing.Point(165, 430);
            this.tb_Ins_GSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_GSM.Name = "tb_Ins_GSM";
            this.tb_Ins_GSM.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_GSM.TabIndex = 95;
            this.tb_Ins_GSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_Password
            // 
            this.tb_Ins_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_passw", true));
            this.tb_Ins_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Password.Location = new System.Drawing.Point(165, 394);
            this.tb_Ins_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Password.Name = "tb_Ins_Password";
            this.tb_Ins_Password.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Password.TabIndex = 94;
            this.tb_Ins_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_Mail
            // 
            this.tb_Ins_Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_mail", true));
            this.tb_Ins_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Mail.Location = new System.Drawing.Point(165, 358);
            this.tb_Ins_Mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Mail.Name = "tb_Ins_Mail";
            this.tb_Ins_Mail.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Mail.TabIndex = 93;
            this.tb_Ins_Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_Ville
            // 
            this.tb_Ins_Ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_loc", true));
            this.tb_Ins_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Ville.Location = new System.Drawing.Point(165, 322);
            this.tb_Ins_Ville.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Ville.Name = "tb_Ins_Ville";
            this.tb_Ins_Ville.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Ville.TabIndex = 92;
            this.tb_Ins_Ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_CP
            // 
            this.tb_Ins_CP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_cp", true));
            this.tb_Ins_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_CP.Location = new System.Drawing.Point(165, 284);
            this.tb_Ins_CP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_CP.Name = "tb_Ins_CP";
            this.tb_Ins_CP.Size = new System.Drawing.Size(200, 30);
            this.tb_Ins_CP.TabIndex = 91;
            this.tb_Ins_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_NbrBoite
            // 
            this.tb_Ins_NbrBoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_num_boite", true));
            this.tb_Ins_NbrBoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_NbrBoite.Location = new System.Drawing.Point(165, 244);
            this.tb_Ins_NbrBoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_NbrBoite.Name = "tb_Ins_NbrBoite";
            this.tb_Ins_NbrBoite.Size = new System.Drawing.Size(137, 30);
            this.tb_Ins_NbrBoite.TabIndex = 90;
            this.tb_Ins_NbrBoite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_Adresse
            // 
            this.tb_Ins_Adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_adrs", true));
            this.tb_Ins_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Adresse.Location = new System.Drawing.Point(165, 203);
            this.tb_Ins_Adresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Adresse.Name = "tb_Ins_Adresse";
            this.tb_Ins_Adresse.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Adresse.TabIndex = 89;
            this.tb_Ins_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dt_Ins_Naissance
            // 
            this.dt_Ins_Naissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_naiss", true));
            this.dt_Ins_Naissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ins_Naissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Ins_Naissance.Location = new System.Drawing.Point(165, 162);
            this.dt_Ins_Naissance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Ins_Naissance.Name = "dt_Ins_Naissance";
            this.dt_Ins_Naissance.Size = new System.Drawing.Size(137, 30);
            this.dt_Ins_Naissance.TabIndex = 88;
            // 
            // cb_Ins_Sex
            // 
            this.cb_Ins_Sex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_sexe", true));
            this.cb_Ins_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ins_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ins_Sex.FormattingEnabled = true;
            this.cb_Ins_Sex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_Ins_Sex.Location = new System.Drawing.Point(165, 124);
            this.cb_Ins_Sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Ins_Sex.Name = "cb_Ins_Sex";
            this.cb_Ins_Sex.Size = new System.Drawing.Size(137, 33);
            this.cb_Ins_Sex.TabIndex = 85;
            // 
            // tb_Ins_Prénom
            // 
            this.tb_Ins_Prénom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_prenom", true));
            this.tb_Ins_Prénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Prénom.Location = new System.Drawing.Point(165, 85);
            this.tb_Ins_Prénom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Prénom.Name = "tb_Ins_Prénom";
            this.tb_Ins_Prénom.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Prénom.TabIndex = 84;
            this.tb_Ins_Prénom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_Nom
            // 
            this.tb_Ins_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_new_member, "Mbr_nom", true));
            this.tb_Ins_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Nom.Location = new System.Drawing.Point(165, 46);
            this.tb_Ins_Nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_Nom.Name = "tb_Ins_Nom";
            this.tb_Ins_Nom.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Nom.TabIndex = 83;
            this.tb_Ins_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ins_ID
            // 
            this.tb_Ins_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_ID.Location = new System.Drawing.Point(165, 2);
            this.tb_Ins_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ins_ID.Name = "tb_Ins_ID";
            this.tb_Ins_ID.ReadOnly = true;
            this.tb_Ins_ID.Size = new System.Drawing.Size(137, 30);
            this.tb_Ins_ID.TabIndex = 82;
            this.tb_Ins_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 590);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 81;
            this.label16.Text = "Cotisation valide:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 80;
            this.label15.Text = "Est admin:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 510);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 79;
            this.label14.Text = "Est pilote:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 78;
            this.label13.Text = "Téléphone fixe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 77;
            this.label12.Text = "Adresse:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "CP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "Ville:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Prénom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Sexe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Date de naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Numéro de boîte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "GSM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 20);
            this.label17.TabIndex = 66;
            this.label17.Text = "ID:";
            // 
            // cb_Ins_is_pilot
            // 
            this.cb_Ins_is_pilot.AutoSize = true;
            this.cb_Ins_is_pilot.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_new_member, "Mbr_est_pil", true));
            this.cb_Ins_is_pilot.Location = new System.Drawing.Point(165, 512);
            this.cb_Ins_is_pilot.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Ins_is_pilot.Name = "cb_Ins_is_pilot";
            this.cb_Ins_is_pilot.Size = new System.Drawing.Size(18, 17);
            this.cb_Ins_is_pilot.TabIndex = 99;
            this.cb_Ins_is_pilot.UseVisualStyleBackColor = true;
            // 
            // cb_Ins_is_admin
            // 
            this.cb_Ins_is_admin.AutoSize = true;
            this.cb_Ins_is_admin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_new_member, "Mbr_est_adm", true));
            this.cb_Ins_is_admin.Location = new System.Drawing.Point(165, 548);
            this.cb_Ins_is_admin.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Ins_is_admin.Name = "cb_Ins_is_admin";
            this.cb_Ins_is_admin.Size = new System.Drawing.Size(18, 17);
            this.cb_Ins_is_admin.TabIndex = 100;
            this.cb_Ins_is_admin.UseVisualStyleBackColor = true;
            // 
            // uc_addNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_Ins_is_admin);
            this.Controls.Add(this.cb_Ins_is_pilot);
            this.Controls.Add(this.addNewMember);
            this.Controls.Add(this.dt_Ins_cot_val);
            this.Controls.Add(this.tb_Ins_TeleFixe);
            this.Controls.Add(this.tb_Ins_GSM);
            this.Controls.Add(this.tb_Ins_Password);
            this.Controls.Add(this.tb_Ins_Mail);
            this.Controls.Add(this.tb_Ins_Ville);
            this.Controls.Add(this.tb_Ins_CP);
            this.Controls.Add(this.tb_Ins_NbrBoite);
            this.Controls.Add(this.tb_Ins_Adresse);
            this.Controls.Add(this.dt_Ins_Naissance);
            this.Controls.Add(this.cb_Ins_Sex);
            this.Controls.Add(this.tb_Ins_Prénom);
            this.Controls.Add(this.tb_Ins_Nom);
            this.Controls.Add(this.tb_Ins_ID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_addNewMember";
            this.Size = new System.Drawing.Size(465, 674);
            ((System.ComponentModel.ISupportInitialize)(this.bs_new_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewMember;
        private System.Windows.Forms.DateTimePicker dt_Ins_cot_val;
        private System.Windows.Forms.TextBox tb_Ins_TeleFixe;
        private System.Windows.Forms.TextBox tb_Ins_GSM;
        private System.Windows.Forms.TextBox tb_Ins_Password;
        private System.Windows.Forms.TextBox tb_Ins_Mail;
        private System.Windows.Forms.TextBox tb_Ins_Ville;
        private System.Windows.Forms.TextBox tb_Ins_CP;
        private System.Windows.Forms.TextBox tb_Ins_NbrBoite;
        private System.Windows.Forms.TextBox tb_Ins_Adresse;
        private System.Windows.Forms.DateTimePicker dt_Ins_Naissance;
        private System.Windows.Forms.ComboBox cb_Ins_Sex;
        private System.Windows.Forms.TextBox tb_Ins_Prénom;
        private System.Windows.Forms.TextBox tb_Ins_Nom;
        private System.Windows.Forms.TextBox tb_Ins_ID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cb_Ins_is_pilot;
        private System.Windows.Forms.CheckBox cb_Ins_is_admin;
        private System.Windows.Forms.BindingSource bs_new_member;
    }
}
