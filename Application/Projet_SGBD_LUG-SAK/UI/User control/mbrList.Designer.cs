
namespace UI.User_control
{
    partial class mbrList
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
            this.dgvMbrList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.dt_Ins_cot_val = new System.Windows.Forms.DateTimePicker();
            this.tb_Ins_TeleFixe = new System.Windows.Forms.TextBox();
            this.tb_Ins_GSM = new System.Windows.Forms.TextBox();
            this.tb_Ins_Password = new System.Windows.Forms.TextBox();
            this.tb_Ins_Mail = new System.Windows.Forms.TextBox();
            this.tb_Ins_Ville = new System.Windows.Forms.TextBox();
            this.tb_Ins_CP = new System.Windows.Forms.TextBox();
            this.tb_Ins_NbrBoite = new System.Windows.Forms.TextBox();
            this.tb_Ins_Adresse = new System.Windows.Forms.TextBox();
            this.dt_Ins_Naissance = new System.Windows.Forms.DateTimePicker();
            this.cb_Ins_Pilot = new System.Windows.Forms.ComboBox();
            this.cb_Ins_Admin = new System.Windows.Forms.ComboBox();
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
            this.addNewMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMbrList
            // 
            this.dgvMbrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMbrList.Location = new System.Drawing.Point(6, 163);
            this.dgvMbrList.Name = "dgvMbrList";
            this.dgvMbrList.RowHeadersWidth = 51;
            this.dgvMbrList.RowTemplate.Height = 24;
            this.dgvMbrList.Size = new System.Drawing.Size(854, 564);
            this.dgvMbrList.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(254, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMemberID
            // 
            this.tbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberID.Location = new System.Drawing.Point(186, 56);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(212, 26);
            this.tbMemberID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberName.Location = new System.Drawing.Point(186, 14);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(212, 26);
            this.tbMemberName.TabIndex = 15;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(29, 62);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(113, 20);
            this.lblMemberID.TabIndex = 14;
            this.lblMemberID.Text = "Member ID: ";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(29, 14);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(139, 20);
            this.lblMemberName.TabIndex = 13;
            this.lblMemberName.Text = "Member name: ";
            // 
            // dt_Ins_cot_val
            // 
            this.dt_Ins_cot_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ins_cot_val.Location = new System.Drawing.Point(1053, 588);
            this.dt_Ins_cot_val.Name = "dt_Ins_cot_val";
            this.dt_Ins_cot_val.Size = new System.Drawing.Size(296, 30);
            this.dt_Ins_cot_val.TabIndex = 64;
            // 
            // tb_Ins_TeleFixe
            // 
            this.tb_Ins_TeleFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_TeleFixe.Location = new System.Drawing.Point(1053, 474);
            this.tb_Ins_TeleFixe.Name = "tb_Ins_TeleFixe";
            this.tb_Ins_TeleFixe.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_TeleFixe.TabIndex = 63;
            // 
            // tb_Ins_GSM
            // 
            this.tb_Ins_GSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_GSM.Location = new System.Drawing.Point(1053, 438);
            this.tb_Ins_GSM.Name = "tb_Ins_GSM";
            this.tb_Ins_GSM.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_GSM.TabIndex = 62;
            // 
            // tb_Ins_Password
            // 
            this.tb_Ins_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Password.Location = new System.Drawing.Point(1053, 402);
            this.tb_Ins_Password.Name = "tb_Ins_Password";
            this.tb_Ins_Password.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Password.TabIndex = 61;
            // 
            // tb_Ins_Mail
            // 
            this.tb_Ins_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Mail.Location = new System.Drawing.Point(1053, 366);
            this.tb_Ins_Mail.Name = "tb_Ins_Mail";
            this.tb_Ins_Mail.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Mail.TabIndex = 60;
            // 
            // tb_Ins_Ville
            // 
            this.tb_Ins_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Ville.Location = new System.Drawing.Point(1053, 330);
            this.tb_Ins_Ville.Name = "tb_Ins_Ville";
            this.tb_Ins_Ville.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Ville.TabIndex = 59;
            // 
            // tb_Ins_CP
            // 
            this.tb_Ins_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_CP.Location = new System.Drawing.Point(1053, 292);
            this.tb_Ins_CP.Name = "tb_Ins_CP";
            this.tb_Ins_CP.Size = new System.Drawing.Size(138, 30);
            this.tb_Ins_CP.TabIndex = 58;
            // 
            // tb_Ins_NbrBoite
            // 
            this.tb_Ins_NbrBoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_NbrBoite.Location = new System.Drawing.Point(1053, 252);
            this.tb_Ins_NbrBoite.Name = "tb_Ins_NbrBoite";
            this.tb_Ins_NbrBoite.Size = new System.Drawing.Size(138, 30);
            this.tb_Ins_NbrBoite.TabIndex = 57;
            // 
            // tb_Ins_Adresse
            // 
            this.tb_Ins_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Adresse.Location = new System.Drawing.Point(1053, 211);
            this.tb_Ins_Adresse.Name = "tb_Ins_Adresse";
            this.tb_Ins_Adresse.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Adresse.TabIndex = 56;
            // 
            // dt_Ins_Naissance
            // 
            this.dt_Ins_Naissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ins_Naissance.Location = new System.Drawing.Point(1053, 171);
            this.dt_Ins_Naissance.Name = "dt_Ins_Naissance";
            this.dt_Ins_Naissance.Size = new System.Drawing.Size(296, 30);
            this.dt_Ins_Naissance.TabIndex = 55;
            // 
            // cb_Ins_Pilot
            // 
            this.cb_Ins_Pilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ins_Pilot.FormattingEnabled = true;
            this.cb_Ins_Pilot.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.cb_Ins_Pilot.Location = new System.Drawing.Point(1053, 510);
            this.cb_Ins_Pilot.Name = "cb_Ins_Pilot";
            this.cb_Ins_Pilot.Size = new System.Drawing.Size(121, 33);
            this.cb_Ins_Pilot.TabIndex = 54;
            // 
            // cb_Ins_Admin
            // 
            this.cb_Ins_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ins_Admin.FormattingEnabled = true;
            this.cb_Ins_Admin.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.cb_Ins_Admin.Location = new System.Drawing.Point(1053, 549);
            this.cb_Ins_Admin.Name = "cb_Ins_Admin";
            this.cb_Ins_Admin.Size = new System.Drawing.Size(121, 33);
            this.cb_Ins_Admin.TabIndex = 53;
            // 
            // cb_Ins_Sex
            // 
            this.cb_Ins_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ins_Sex.FormattingEnabled = true;
            this.cb_Ins_Sex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_Ins_Sex.Location = new System.Drawing.Point(1053, 132);
            this.cb_Ins_Sex.Name = "cb_Ins_Sex";
            this.cb_Ins_Sex.Size = new System.Drawing.Size(121, 33);
            this.cb_Ins_Sex.TabIndex = 52;
            // 
            // tb_Ins_Prénom
            // 
            this.tb_Ins_Prénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Prénom.Location = new System.Drawing.Point(1053, 93);
            this.tb_Ins_Prénom.Name = "tb_Ins_Prénom";
            this.tb_Ins_Prénom.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Prénom.TabIndex = 51;
            // 
            // tb_Ins_Nom
            // 
            this.tb_Ins_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_Nom.Location = new System.Drawing.Point(1053, 53);
            this.tb_Ins_Nom.Name = "tb_Ins_Nom";
            this.tb_Ins_Nom.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_Nom.TabIndex = 50;
            // 
            // tb_Ins_ID
            // 
            this.tb_Ins_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ins_ID.Location = new System.Drawing.Point(1053, 11);
            this.tb_Ins_ID.Name = "tb_Ins_ID";
            this.tb_Ins_ID.Size = new System.Drawing.Size(296, 30);
            this.tb_Ins_ID.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(889, 597);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Cotisation valide:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(892, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Est admin:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(892, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Est pilot:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(889, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Téléphone fixe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(889, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Adresse:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(889, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "CP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(889, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ville:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(889, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Prénom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(889, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(889, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Date de naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(889, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Numéro de boîte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(889, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "GSM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(889, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(892, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "ID:";
            // 
            // addNewMember
            // 
            this.addNewMember.Location = new System.Drawing.Point(1018, 647);
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(201, 33);
            this.addNewMember.TabIndex = 65;
            this.addNewMember.Text = "ADD NEW MEMBER";
            this.addNewMember.UseVisualStyleBackColor = true;
            this.addNewMember.Click += new System.EventHandler(this.addNewMember_Click);
            // 
            // mbrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.cb_Ins_Pilot);
            this.Controls.Add(this.cb_Ins_Admin);
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
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.dgvMbrList);
            this.Name = "mbrList";
            this.Size = new System.Drawing.Size(1368, 730);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMbrList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
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
        private System.Windows.Forms.ComboBox cb_Ins_Pilot;
        private System.Windows.Forms.ComboBox cb_Ins_Admin;
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
        private System.Windows.Forms.Button addNewMember;
    }
}
