
namespace UI.User_control
{
    partial class uc_add_new_reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_uc_res_aj_nom = new System.Windows.Forms.TextBox();
            this.cb_uc_res_aj_id = new System.Windows.Forms.ComboBox();
            this.cb_uc_res_aj_machine = new System.Windows.Forms.ComboBox();
            this.cb_uc_res_aj_heur_deb = new System.Windows.Forms.ComboBox();
            this.uc_btn_add_res = new System.Windows.Forms.Button();
            this.cb_uc_res_aj_heur_fin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_uc_add_res_prevu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_uc_res_aj_date = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Machine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heur deb:";
            // 
            // tb_uc_res_aj_nom
            // 
            this.tb_uc_res_aj_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uc_res_aj_nom.Location = new System.Drawing.Point(90, 37);
            this.tb_uc_res_aj_nom.Name = "tb_uc_res_aj_nom";
            this.tb_uc_res_aj_nom.Size = new System.Drawing.Size(219, 26);
            this.tb_uc_res_aj_nom.TabIndex = 7;
            // 
            // cb_uc_res_aj_id
            // 
            this.cb_uc_res_aj_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_id.FormattingEnabled = true;
            this.cb_uc_res_aj_id.Location = new System.Drawing.Point(90, 3);
            this.cb_uc_res_aj_id.Name = "cb_uc_res_aj_id";
            this.cb_uc_res_aj_id.Size = new System.Drawing.Size(122, 28);
            this.cb_uc_res_aj_id.TabIndex = 8;
            this.cb_uc_res_aj_id.SelectedIndexChanged += new System.EventHandler(this.MbrIDValueChanged);
            // 
            // cb_uc_res_aj_machine
            // 
            this.cb_uc_res_aj_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_machine.FormattingEnabled = true;
            this.cb_uc_res_aj_machine.Location = new System.Drawing.Point(91, 69);
            this.cb_uc_res_aj_machine.Name = "cb_uc_res_aj_machine";
            this.cb_uc_res_aj_machine.Size = new System.Drawing.Size(218, 28);
            this.cb_uc_res_aj_machine.TabIndex = 9;
            this.cb_uc_res_aj_machine.SelectedIndexChanged += new System.EventHandler(this.machine_SelectedIndexChanged);
            // 
            // cb_uc_res_aj_heur_deb
            // 
            this.cb_uc_res_aj_heur_deb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uc_res_aj_heur_deb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_heur_deb.FormattingEnabled = true;
            this.cb_uc_res_aj_heur_deb.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cb_uc_res_aj_heur_deb.Location = new System.Drawing.Point(91, 329);
            this.cb_uc_res_aj_heur_deb.Name = "cb_uc_res_aj_heur_deb";
            this.cb_uc_res_aj_heur_deb.Size = new System.Drawing.Size(121, 28);
            this.cb_uc_res_aj_heur_deb.TabIndex = 10;
            // 
            // uc_btn_add_res
            // 
            this.uc_btn_add_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_add_res.Location = new System.Drawing.Point(56, 467);
            this.uc_btn_add_res.Name = "uc_btn_add_res";
            this.uc_btn_add_res.Size = new System.Drawing.Size(189, 34);
            this.uc_btn_add_res.TabIndex = 12;
            this.uc_btn_add_res.Text = "Add new reservation";
            this.uc_btn_add_res.UseVisualStyleBackColor = true;
            this.uc_btn_add_res.Click += new System.EventHandler(this.uc_btn_add_res_Click);
            // 
            // cb_uc_res_aj_heur_fin
            // 
            this.cb_uc_res_aj_heur_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uc_res_aj_heur_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_heur_fin.FormattingEnabled = true;
            this.cb_uc_res_aj_heur_fin.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cb_uc_res_aj_heur_fin.Location = new System.Drawing.Point(91, 369);
            this.cb_uc_res_aj_heur_fin.Name = "cb_uc_res_aj_heur_fin";
            this.cb_uc_res_aj_heur_fin.Size = new System.Drawing.Size(121, 28);
            this.cb_uc_res_aj_heur_fin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Heur fin:";
            // 
            // cb_uc_add_res_prevu
            // 
            this.cb_uc_add_res_prevu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uc_add_res_prevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_add_res_prevu.FormattingEnabled = true;
            this.cb_uc_add_res_prevu.Items.AddRange(new object[] {
            "OUI",
            "NON"});
            this.cb_uc_add_res_prevu.Location = new System.Drawing.Point(91, 408);
            this.cb_uc_add_res_prevu.Name = "cb_uc_add_res_prevu";
            this.cb_uc_add_res_prevu.Size = new System.Drawing.Size(121, 28);
            this.cb_uc_add_res_prevu.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "Résér. est prevu:";
            // 
            // dt_uc_res_aj_date
            // 
            this.dt_uc_res_aj_date.Location = new System.Drawing.Point(87, 109);
            this.dt_uc_res_aj_date.Name = "dt_uc_res_aj_date";
            this.dt_uc_res_aj_date.TabIndex = 18;
            // 
            // uc_add_new_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dt_uc_res_aj_date);
            this.Controls.Add(this.cb_uc_add_res_prevu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_uc_res_aj_heur_fin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uc_btn_add_res);
            this.Controls.Add(this.cb_uc_res_aj_heur_deb);
            this.Controls.Add(this.cb_uc_res_aj_machine);
            this.Controls.Add(this.cb_uc_res_aj_id);
            this.Controls.Add(this.tb_uc_res_aj_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_add_new_reservation";
            this.Size = new System.Drawing.Size(334, 508);
            this.Load += new System.EventHandler(this.LoadMemberName);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_uc_res_aj_nom;
        private System.Windows.Forms.ComboBox cb_uc_res_aj_id;
        private System.Windows.Forms.ComboBox cb_uc_res_aj_machine;
        private System.Windows.Forms.ComboBox cb_uc_res_aj_heur_deb;
        private System.Windows.Forms.Button uc_btn_add_res;
        private System.Windows.Forms.ComboBox cb_uc_res_aj_heur_fin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_uc_add_res_prevu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar dt_uc_res_aj_date;
    }
}
