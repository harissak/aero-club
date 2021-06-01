
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
            this.components = new System.ComponentModel.Container();
            this.modify = new System.Windows.Forms.Button();
            this.deleteMember = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dt_mdf_cot_val = new System.Windows.Forms.DateTimePicker();
            this.bsMember = new System.Windows.Forms.BindingSource(this.components);
            this.tb_mdf_TeleFixe = new System.Windows.Forms.TextBox();
            this.tb_mdf_GSM = new System.Windows.Forms.TextBox();
            this.tb_mdf_Password = new System.Windows.Forms.TextBox();
            this.tb_mdf_Mail = new System.Windows.Forms.TextBox();
            this.tb_mdf_Ville = new System.Windows.Forms.TextBox();
            this.tb_mdf_CP = new System.Windows.Forms.TextBox();
            this.tb_mdf_NbrBoite = new System.Windows.Forms.TextBox();
            this.tb_mdf_Adresse = new System.Windows.Forms.TextBox();
            this.dt_mdf_Naissance = new System.Windows.Forms.DateTimePicker();
            this.cb_mdf_Sex = new System.Windows.Forms.ComboBox();
            this.tb_mdf_Prénom = new System.Windows.Forms.TextBox();
            this.tb_mdf_Nom = new System.Windows.Forms.TextBox();
            this.tb_mdf_ID = new System.Windows.Forms.TextBox();
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
            this.cb_mdf_is_pilote = new System.Windows.Forms.CheckBox();
            this.cb_mdf_is_admin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsMember)).BeginInit();
            this.SuspendLayout();
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(22, 514);
            this.modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(84, 27);
            this.modify.TabIndex = 0;
            this.modify.Text = "MODIFY";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // deleteMember
            // 
            this.deleteMember.Location = new System.Drawing.Point(118, 514);
            this.deleteMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteMember.Name = "deleteMember";
            this.deleteMember.Size = new System.Drawing.Size(84, 27);
            this.deleteMember.TabIndex = 1;
            this.deleteMember.Text = "DELETE";
            this.deleteMember.UseVisualStyleBackColor = true;
            this.deleteMember.Click += new System.EventHandler(this.deleteMember_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(218, 514);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(84, 27);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dt_mdf_cot_val
            // 
            this.dt_mdf_cot_val.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_cot_valide", true));
            this.dt_mdf_cot_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_mdf_cot_val.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_mdf_cot_val.Location = new System.Drawing.Point(126, 471);
            this.dt_mdf_cot_val.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_mdf_cot_val.Name = "dt_mdf_cot_val";
            this.dt_mdf_cot_val.Size = new System.Drawing.Size(104, 26);
            this.dt_mdf_cot_val.TabIndex = 130;
            // 
            // bsMember
            // 
            this.bsMember.DataSource = typeof(DTO.MBR);
            this.bsMember.CurrentChanged += new System.EventHandler(this.bsMember_CurrentChanged);
            // 
            // tb_mdf_TeleFixe
            // 
            this.tb_mdf_TeleFixe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_fix_tel", true));
            this.tb_mdf_TeleFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_TeleFixe.Location = new System.Drawing.Point(126, 379);
            this.tb_mdf_TeleFixe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_TeleFixe.Name = "tb_mdf_TeleFixe";
            this.tb_mdf_TeleFixe.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_TeleFixe.TabIndex = 129;
            this.tb_mdf_TeleFixe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_GSM
            // 
            this.tb_mdf_GSM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_gsm", true));
            this.tb_mdf_GSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_GSM.Location = new System.Drawing.Point(126, 349);
            this.tb_mdf_GSM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_GSM.Name = "tb_mdf_GSM";
            this.tb_mdf_GSM.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_GSM.TabIndex = 128;
            this.tb_mdf_GSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_Password
            // 
            this.tb_mdf_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_passw", true));
            this.tb_mdf_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Password.Location = new System.Drawing.Point(126, 320);
            this.tb_mdf_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Password.Name = "tb_mdf_Password";
            this.tb_mdf_Password.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Password.TabIndex = 127;
            this.tb_mdf_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_Mail
            // 
            this.tb_mdf_Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_mail", true));
            this.tb_mdf_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Mail.Location = new System.Drawing.Point(126, 291);
            this.tb_mdf_Mail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Mail.Name = "tb_mdf_Mail";
            this.tb_mdf_Mail.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Mail.TabIndex = 126;
            this.tb_mdf_Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_Ville
            // 
            this.tb_mdf_Ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_loc", true));
            this.tb_mdf_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Ville.Location = new System.Drawing.Point(126, 262);
            this.tb_mdf_Ville.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Ville.Name = "tb_mdf_Ville";
            this.tb_mdf_Ville.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Ville.TabIndex = 125;
            this.tb_mdf_Ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_CP
            // 
            this.tb_mdf_CP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_cp", true));
            this.tb_mdf_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_CP.Location = new System.Drawing.Point(126, 231);
            this.tb_mdf_CP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_CP.Name = "tb_mdf_CP";
            this.tb_mdf_CP.Size = new System.Drawing.Size(104, 26);
            this.tb_mdf_CP.TabIndex = 124;
            this.tb_mdf_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_NbrBoite
            // 
            this.tb_mdf_NbrBoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_num_boite", true));
            this.tb_mdf_NbrBoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_NbrBoite.Location = new System.Drawing.Point(126, 198);
            this.tb_mdf_NbrBoite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_NbrBoite.Name = "tb_mdf_NbrBoite";
            this.tb_mdf_NbrBoite.Size = new System.Drawing.Size(104, 26);
            this.tb_mdf_NbrBoite.TabIndex = 123;
            this.tb_mdf_NbrBoite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_Adresse
            // 
            this.tb_mdf_Adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_adrs", true));
            this.tb_mdf_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Adresse.Location = new System.Drawing.Point(126, 165);
            this.tb_mdf_Adresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Adresse.Name = "tb_mdf_Adresse";
            this.tb_mdf_Adresse.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Adresse.TabIndex = 122;
            this.tb_mdf_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dt_mdf_Naissance
            // 
            this.dt_mdf_Naissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_naiss", true));
            this.dt_mdf_Naissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_mdf_Naissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_mdf_Naissance.Location = new System.Drawing.Point(126, 132);
            this.dt_mdf_Naissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_mdf_Naissance.Name = "dt_mdf_Naissance";
            this.dt_mdf_Naissance.Size = new System.Drawing.Size(104, 26);
            this.dt_mdf_Naissance.TabIndex = 121;
            // 
            // cb_mdf_Sex
            // 
            this.cb_mdf_Sex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_sexe", true));
            this.cb_mdf_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mdf_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mdf_Sex.FormattingEnabled = true;
            this.cb_mdf_Sex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_mdf_Sex.Location = new System.Drawing.Point(126, 101);
            this.cb_mdf_Sex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_mdf_Sex.Name = "cb_mdf_Sex";
            this.cb_mdf_Sex.Size = new System.Drawing.Size(104, 28);
            this.cb_mdf_Sex.TabIndex = 118;
            // 
            // tb_mdf_Prénom
            // 
            this.tb_mdf_Prénom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_prenom", true));
            this.tb_mdf_Prénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Prénom.Location = new System.Drawing.Point(126, 69);
            this.tb_mdf_Prénom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Prénom.Name = "tb_mdf_Prénom";
            this.tb_mdf_Prénom.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Prénom.TabIndex = 117;
            this.tb_mdf_Prénom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_Nom
            // 
            this.tb_mdf_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_nom", true));
            this.tb_mdf_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_Nom.Location = new System.Drawing.Point(126, 37);
            this.tb_mdf_Nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_Nom.Name = "tb_mdf_Nom";
            this.tb_mdf_Nom.Size = new System.Drawing.Size(223, 26);
            this.tb_mdf_Nom.TabIndex = 116;
            this.tb_mdf_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mdf_ID
            // 
            this.tb_mdf_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMember, "Mbr_ID", true));
            this.tb_mdf_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mdf_ID.Location = new System.Drawing.Point(126, 2);
            this.tb_mdf_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mdf_ID.Name = "tb_mdf_ID";
            this.tb_mdf_ID.ReadOnly = true;
            this.tb_mdf_ID.Size = new System.Drawing.Size(104, 26);
            this.tb_mdf_ID.TabIndex = 115;
            this.tb_mdf_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 479);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 114;
            this.label16.Text = "Cotisation valide:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 445);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 113;
            this.label15.Text = "Est admin:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 414);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 112;
            this.label14.Text = "Est pilote:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 384);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 111;
            this.label13.Text = "Téléphone fixe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 110;
            this.label12.Text = "Adresse:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 109;
            this.label11.Text = "CP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 108;
            this.label10.Text = "Ville:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Prénom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Sexe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Date de naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Numéro de boîte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "GSM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 8);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 99;
            this.label17.Text = "ID:";
            // 
            // cb_mdf_is_pilote
            // 
            this.cb_mdf_is_pilote.AutoSize = true;
            this.cb_mdf_is_pilote.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMember, "Mbr_est_pil", true));
            this.cb_mdf_is_pilote.Location = new System.Drawing.Point(126, 417);
            this.cb_mdf_is_pilote.Name = "cb_mdf_is_pilote";
            this.cb_mdf_is_pilote.Size = new System.Drawing.Size(15, 14);
            this.cb_mdf_is_pilote.TabIndex = 131;
            this.cb_mdf_is_pilote.UseVisualStyleBackColor = true;
            // 
            // cb_mdf_is_admin
            // 
            this.cb_mdf_is_admin.AutoSize = true;
            this.cb_mdf_is_admin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMember, "Mbr_est_adm", true));
            this.cb_mdf_is_admin.Location = new System.Drawing.Point(126, 445);
            this.cb_mdf_is_admin.Name = "cb_mdf_is_admin";
            this.cb_mdf_is_admin.Size = new System.Drawing.Size(15, 14);
            this.cb_mdf_is_admin.TabIndex = 132;
            this.cb_mdf_is_admin.UseVisualStyleBackColor = true;
            // 
            // uc_saveDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_mdf_is_admin);
            this.Controls.Add(this.cb_mdf_is_pilote);
            this.Controls.Add(this.dt_mdf_cot_val);
            this.Controls.Add(this.tb_mdf_TeleFixe);
            this.Controls.Add(this.tb_mdf_GSM);
            this.Controls.Add(this.tb_mdf_Password);
            this.Controls.Add(this.tb_mdf_Mail);
            this.Controls.Add(this.tb_mdf_Ville);
            this.Controls.Add(this.tb_mdf_CP);
            this.Controls.Add(this.tb_mdf_NbrBoite);
            this.Controls.Add(this.tb_mdf_Adresse);
            this.Controls.Add(this.dt_mdf_Naissance);
            this.Controls.Add(this.cb_mdf_Sex);
            this.Controls.Add(this.tb_mdf_Prénom);
            this.Controls.Add(this.tb_mdf_Nom);
            this.Controls.Add(this.tb_mdf_ID);
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
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deleteMember);
            this.Controls.Add(this.modify);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_saveDelete";
            this.Size = new System.Drawing.Size(353, 545);
            ((System.ComponentModel.ISupportInitialize)(this.bsMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button deleteMember;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker dt_mdf_cot_val;
        private System.Windows.Forms.TextBox tb_mdf_TeleFixe;
        private System.Windows.Forms.TextBox tb_mdf_GSM;
        private System.Windows.Forms.TextBox tb_mdf_Password;
        private System.Windows.Forms.TextBox tb_mdf_Mail;
        private System.Windows.Forms.TextBox tb_mdf_Ville;
        private System.Windows.Forms.TextBox tb_mdf_CP;
        private System.Windows.Forms.TextBox tb_mdf_NbrBoite;
        private System.Windows.Forms.TextBox tb_mdf_Adresse;
        private System.Windows.Forms.DateTimePicker dt_mdf_Naissance;
        private System.Windows.Forms.ComboBox cb_mdf_Sex;
        private System.Windows.Forms.TextBox tb_mdf_Prénom;
        private System.Windows.Forms.TextBox tb_mdf_Nom;
        private System.Windows.Forms.TextBox tb_mdf_ID;
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
        private System.Windows.Forms.BindingSource bsMember;
        private System.Windows.Forms.CheckBox cb_mdf_is_pilote;
        private System.Windows.Forms.CheckBox cb_mdf_is_admin;
    }
}
