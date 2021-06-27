
namespace UI.User_control
{
    partial class uc_md_del_reservation
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
            this.uc_btn_res_modify = new System.Windows.Forms.Button();
            this.uc_res_change_machine = new System.Windows.Forms.ComboBox();
            this.uc_res_change_nom = new System.Windows.Forms.ComboBox();
            this.uc_res_ch_id = new System.Windows.Forms.TextBox();
            this.res_binding_source = new System.Windows.Forms.BindingSource(this.components);
            this.uc_res_change_date = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_btn_res_delet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ch_hour_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_ch_hour_fin = new System.Windows.Forms.DateTimePicker();
            this.uc_res_change_annul = new System.Windows.Forms.CheckBox();
            this.uc_res_change_prevu = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uc_ch_res_mbr_id = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_btn_res_modify
            // 
            this.uc_btn_res_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uc_btn_res_modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uc_btn_res_modify.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_modify.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uc_btn_res_modify.Location = new System.Drawing.Point(253, 518);
            this.uc_btn_res_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_btn_res_modify.Name = "uc_btn_res_modify";
            this.uc_btn_res_modify.Size = new System.Drawing.Size(106, 32);
            this.uc_btn_res_modify.TabIndex = 23;
            this.uc_btn_res_modify.Text = "Modify";
            this.uc_btn_res_modify.UseVisualStyleBackColor = false;
            this.uc_btn_res_modify.Click += new System.EventHandler(this.Uc_btn_res_modify_Click);
            // 
            // uc_res_change_machine
            // 
            this.uc_res_change_machine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_change_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_machine.FormattingEnabled = true;
            this.uc_res_change_machine.Location = new System.Drawing.Point(174, 140);
            this.uc_res_change_machine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_res_change_machine.Name = "uc_res_change_machine";
            this.uc_res_change_machine.Size = new System.Drawing.Size(188, 28);
            this.uc_res_change_machine.TabIndex = 21;
            // 
            // uc_res_change_nom
            // 
            this.uc_res_change_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_nom.FormattingEnabled = true;
            this.uc_res_change_nom.Location = new System.Drawing.Point(531, 17);
            this.uc_res_change_nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_res_change_nom.Name = "uc_res_change_nom";
            this.uc_res_change_nom.Size = new System.Drawing.Size(175, 28);
            this.uc_res_change_nom.TabIndex = 20;
            // 
            // uc_res_ch_id
            // 
            this.uc_res_ch_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_ID", true));
            this.uc_res_ch_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_id.Location = new System.Drawing.Point(174, 20);
            this.uc_res_ch_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_res_ch_id.Name = "uc_res_ch_id";
            this.uc_res_ch_id.ReadOnly = true;
            this.uc_res_ch_id.Size = new System.Drawing.Size(98, 26);
            this.uc_res_ch_id.TabIndex = 19;
            // 
            // res_binding_source
            // 
            this.res_binding_source.DataSource = typeof(DTO.RES);
            // 
            // uc_res_change_date
            // 
            this.uc_res_change_date.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.res_binding_source, "Res_date", true));
            this.uc_res_change_date.Location = new System.Drawing.Point(174, 197);
            this.uc_res_change_date.Name = "uc_res_change_date";
            this.uc_res_change_date.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Heure Debut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Machine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Résérvation ID:";
            // 
            // uc_btn_res_delet
            // 
            this.uc_btn_res_delet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uc_btn_res_delet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uc_btn_res_delet.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_delet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uc_btn_res_delet.Location = new System.Drawing.Point(410, 518);
            this.uc_btn_res_delet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_btn_res_delet.Name = "uc_btn_res_delet";
            this.uc_btn_res_delet.Size = new System.Drawing.Size(109, 32);
            this.uc_btn_res_delet.TabIndex = 24;
            this.uc_btn_res_delet.Text = "Delete";
            this.uc_btn_res_delet.UseVisualStyleBackColor = false;
            this.uc_btn_res_delet.Click += new System.EventHandler(this.uc_btn_res_delet_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Résérvation est annulée:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 42);
            this.label7.TabIndex = 28;
            this.label7.Text = "Résérvation est prevu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Heur fin:";
            // 
            // dtp_ch_hour_start
            // 
            this.dtp_ch_hour_start.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_deb", true));
            this.dtp_ch_hour_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ch_hour_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_ch_hour_start.Location = new System.Drawing.Point(562, 33);
            this.dtp_ch_hour_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ch_hour_start.Name = "dtp_ch_hour_start";
            this.dtp_ch_hour_start.Size = new System.Drawing.Size(127, 26);
            this.dtp_ch_hour_start.TabIndex = 32;
            // 
            // dtp_ch_hour_fin
            // 
            this.dtp_ch_hour_fin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_fin", true));
            this.dtp_ch_hour_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ch_hour_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_ch_hour_fin.Location = new System.Drawing.Point(562, 67);
            this.dtp_ch_hour_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ch_hour_fin.Name = "dtp_ch_hour_fin";
            this.dtp_ch_hour_fin.Size = new System.Drawing.Size(127, 26);
            this.dtp_ch_hour_fin.TabIndex = 33;
            // 
            // uc_res_change_annul
            // 
            this.uc_res_change_annul.AutoSize = true;
            this.uc_res_change_annul.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.res_binding_source, "Res_est_annule", true));
            this.uc_res_change_annul.Location = new System.Drawing.Point(286, 439);
            this.uc_res_change_annul.Name = "uc_res_change_annul";
            this.uc_res_change_annul.Size = new System.Drawing.Size(15, 14);
            this.uc_res_change_annul.TabIndex = 34;
            this.uc_res_change_annul.UseVisualStyleBackColor = true;
            // 
            // uc_res_change_prevu
            // 
            this.uc_res_change_prevu.AutoSize = true;
            this.uc_res_change_prevu.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.res_binding_source, "Res_est_prevenu", true));
            this.uc_res_change_prevu.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.res_binding_source, "Res_est_prevenu", true));
            this.uc_res_change_prevu.Location = new System.Drawing.Point(640, 439);
            this.uc_res_change_prevu.Name = "uc_res_change_prevu";
            this.uc_res_change_prevu.Size = new System.Drawing.Size(15, 14);
            this.uc_res_change_prevu.TabIndex = 35;
            this.uc_res_change_prevu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Member ID:";
            // 
            // uc_ch_res_mbr_id
            // 
            this.uc_ch_res_mbr_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_ch_res_mbr_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_ch_res_mbr_id.FormattingEnabled = true;
            this.uc_ch_res_mbr_id.Location = new System.Drawing.Point(172, 17);
            this.uc_ch_res_mbr_id.Name = "uc_ch_res_mbr_id";
            this.uc_ch_res_mbr_id.Size = new System.Drawing.Size(98, 28);
            this.uc_ch_res_mbr_id.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uc_res_ch_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(722, 55);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résérvation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uc_ch_res_mbr_id);
            this.groupBox2.Controls.Add(this.uc_res_change_nom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(724, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal information";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(724, 53);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Machine";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtp_ch_hour_start);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dtp_ch_hour_fin);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(0, 181);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(724, 215);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date and time";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(2, 401);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(723, 81);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extra informations";
            // 
            // uc_md_del_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_res_change_prevu);
            this.Controls.Add(this.uc_res_change_annul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uc_btn_res_delet);
            this.Controls.Add(this.uc_btn_res_modify);
            this.Controls.Add(this.uc_res_change_machine);
            this.Controls.Add(this.uc_res_change_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_md_del_reservation";
            this.Size = new System.Drawing.Size(770, 576);
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uc_btn_res_modify;
        private System.Windows.Forms.ComboBox uc_res_change_machine;
        private System.Windows.Forms.ComboBox uc_res_change_nom;
        private System.Windows.Forms.TextBox uc_res_ch_id;
        private System.Windows.Forms.MonthCalendar uc_res_change_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uc_btn_res_delet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource res_binding_source;
        private System.Windows.Forms.DateTimePicker dtp_ch_hour_start;
        private System.Windows.Forms.DateTimePicker dtp_ch_hour_fin;
        private System.Windows.Forms.CheckBox uc_res_change_annul;
        private System.Windows.Forms.CheckBox uc_res_change_prevu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox uc_ch_res_mbr_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
