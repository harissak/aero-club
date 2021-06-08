
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
            this.res_binding_source = new System.Windows.Forms.BindingSource(this.components);
            this.uc_res_change_machine = new System.Windows.Forms.ComboBox();
            this.uc_res_change_nom = new System.Windows.Forms.ComboBox();
            this.uc_res_ch_id = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_btn_res_modify
            // 
            this.uc_btn_res_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_modify.Location = new System.Drawing.Point(5, 559);
            this.uc_btn_res_modify.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_btn_res_modify.Name = "uc_btn_res_modify";
            this.uc_btn_res_modify.Size = new System.Drawing.Size(125, 32);
            this.uc_btn_res_modify.TabIndex = 23;
            this.uc_btn_res_modify.Text = "Modify";
            this.uc_btn_res_modify.UseVisualStyleBackColor = true;
            this.uc_btn_res_modify.Click += new System.EventHandler(this.Uc_btn_res_modify_Click);
            // 
            // res_binding_source
            // 
            this.res_binding_source.DataSource = typeof(DTO.RES);
            // 
            // uc_res_change_machine
            // 
            this.uc_res_change_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_machine.FormattingEnabled = true;
            this.uc_res_change_machine.Location = new System.Drawing.Point(142, 111);
            this.uc_res_change_machine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_res_change_machine.Name = "uc_res_change_machine";
            this.uc_res_change_machine.Size = new System.Drawing.Size(222, 28);
            this.uc_res_change_machine.TabIndex = 21;
            // 
            // uc_res_change_nom
            // 
            this.uc_res_change_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_nom.FormattingEnabled = true;
            this.uc_res_change_nom.Location = new System.Drawing.Point(142, 73);
            this.uc_res_change_nom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_res_change_nom.Name = "uc_res_change_nom";
            this.uc_res_change_nom.Size = new System.Drawing.Size(223, 28);
            this.uc_res_change_nom.TabIndex = 20;
            // 
            // uc_res_ch_id
            // 
            this.uc_res_ch_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_ID", true));
            this.uc_res_ch_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_id.Location = new System.Drawing.Point(236, 2);
            this.uc_res_ch_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_res_ch_id.Name = "uc_res_ch_id";
            this.uc_res_ch_id.Size = new System.Drawing.Size(129, 26);
            this.uc_res_ch_id.TabIndex = 19;
            // 
            // uc_res_change_date
            // 
            this.uc_res_change_date.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.res_binding_source, "Res_date", true));
            this.uc_res_change_date.Location = new System.Drawing.Point(125, 150);
            this.uc_res_change_date.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.uc_res_change_date.Name = "uc_res_change_date";
            this.uc_res_change_date.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Heure Debut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Machine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "RÉS - ID:";
            // 
            // uc_btn_res_delet
            // 
            this.uc_btn_res_delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_delet.Location = new System.Drawing.Point(199, 559);
            this.uc_btn_res_delet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_btn_res_delet.Name = "uc_btn_res_delet";
            this.uc_btn_res_delet.Size = new System.Drawing.Size(132, 32);
            this.uc_btn_res_delet.TabIndex = 24;
            this.uc_btn_res_delet.Text = "Delete";
            this.uc_btn_res_delet.UseVisualStyleBackColor = true;
            this.uc_btn_res_delet.Click += new System.EventHandler(this.uc_btn_res_delet_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 452);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 53);
            this.label8.TabIndex = 30;
            this.label8.Text = "Résér. est annulée:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 505);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 52);
            this.label7.TabIndex = 28;
            this.label7.Text = "Résér. est prevu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Heur fin:";
            // 
            // dtp_ch_hour_start
            // 
            this.dtp_ch_hour_start.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_deb", true));
            this.dtp_ch_hour_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ch_hour_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_ch_hour_start.Location = new System.Drawing.Point(196, 365);
            this.dtp_ch_hour_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_ch_hour_start.Name = "dtp_ch_hour_start";
            this.dtp_ch_hour_start.Size = new System.Drawing.Size(168, 26);
            this.dtp_ch_hour_start.TabIndex = 32;
            // 
            // dtp_ch_hour_fin
            // 
            this.dtp_ch_hour_fin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_fin", true));
            this.dtp_ch_hour_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ch_hour_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_ch_hour_fin.Location = new System.Drawing.Point(196, 401);
            this.dtp_ch_hour_fin.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_ch_hour_fin.Name = "dtp_ch_hour_fin";
            this.dtp_ch_hour_fin.Size = new System.Drawing.Size(168, 26);
            this.dtp_ch_hour_fin.TabIndex = 33;
            // 
            // uc_res_change_annul
            // 
            this.uc_res_change_annul.AutoSize = true;
            this.uc_res_change_annul.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.res_binding_source, "Res_est_annule", true));
            this.uc_res_change_annul.Location = new System.Drawing.Point(268, 452);
            this.uc_res_change_annul.Margin = new System.Windows.Forms.Padding(4);
            this.uc_res_change_annul.Name = "uc_res_change_annul";
            this.uc_res_change_annul.Size = new System.Drawing.Size(18, 17);
            this.uc_res_change_annul.TabIndex = 34;
            this.uc_res_change_annul.UseVisualStyleBackColor = true;
            // 
            // uc_res_change_prevu
            // 
            this.uc_res_change_prevu.AutoSize = true;
            this.uc_res_change_prevu.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.res_binding_source, "Res_est_prevenu", true));
            this.uc_res_change_prevu.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.res_binding_source, "Res_est_prevenu", true));
            this.uc_res_change_prevu.Location = new System.Drawing.Point(266, 505);
            this.uc_res_change_prevu.Margin = new System.Windows.Forms.Padding(4);
            this.uc_res_change_prevu.Name = "uc_res_change_prevu";
            this.uc_res_change_prevu.Size = new System.Drawing.Size(18, 17);
            this.uc_res_change_prevu.TabIndex = 35;
            this.uc_res_change_prevu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "MEMBER - ID:";
            // 
            // uc_ch_res_mbr_id
            // 
            this.uc_ch_res_mbr_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_ch_res_mbr_id.FormattingEnabled = true;
            this.uc_ch_res_mbr_id.Location = new System.Drawing.Point(236, 34);
            this.uc_ch_res_mbr_id.Margin = new System.Windows.Forms.Padding(4);
            this.uc_ch_res_mbr_id.Name = "uc_ch_res_mbr_id";
            this.uc_ch_res_mbr_id.Size = new System.Drawing.Size(129, 28);
            this.uc_ch_res_mbr_id.TabIndex = 38;
            // 
            // uc_md_del_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_ch_res_mbr_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uc_res_change_prevu);
            this.Controls.Add(this.uc_res_change_annul);
            this.Controls.Add(this.dtp_ch_hour_fin);
            this.Controls.Add(this.dtp_ch_hour_start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uc_btn_res_delet);
            this.Controls.Add(this.uc_btn_res_modify);
            this.Controls.Add(this.uc_res_change_machine);
            this.Controls.Add(this.uc_res_change_nom);
            this.Controls.Add(this.uc_res_ch_id);
            this.Controls.Add(this.uc_res_change_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_md_del_reservation";
            this.Size = new System.Drawing.Size(369, 616);
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).EndInit();
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
    }
}
