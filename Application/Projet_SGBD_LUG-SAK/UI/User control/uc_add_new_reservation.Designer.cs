
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
            this.uc_btn_add_res = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_uc_res_aj_date = new System.Windows.Forms.MonthCalendar();
            this.dtp_hour_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_hour_end = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Machine:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heur deb:";
            // 
            // tb_uc_res_aj_nom
            // 
            this.tb_uc_res_aj_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uc_res_aj_nom.Location = new System.Drawing.Point(589, 4);
            this.tb_uc_res_aj_nom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_uc_res_aj_nom.Name = "tb_uc_res_aj_nom";
            this.tb_uc_res_aj_nom.Size = new System.Drawing.Size(235, 30);
            this.tb_uc_res_aj_nom.TabIndex = 7;
            // 
            // cb_uc_res_aj_id
            // 
            this.cb_uc_res_aj_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_id.FormattingEnabled = true;
            this.cb_uc_res_aj_id.Location = new System.Drawing.Point(155, 4);
            this.cb_uc_res_aj_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_uc_res_aj_id.Name = "cb_uc_res_aj_id";
            this.cb_uc_res_aj_id.Size = new System.Drawing.Size(119, 33);
            this.cb_uc_res_aj_id.TabIndex = 8;
            this.cb_uc_res_aj_id.SelectedIndexChanged += new System.EventHandler(this.MbrIDValueChanged);
            // 
            // cb_uc_res_aj_machine
            // 
            this.cb_uc_res_aj_machine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uc_res_aj_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_res_aj_machine.FormattingEnabled = true;
            this.cb_uc_res_aj_machine.Location = new System.Drawing.Point(155, 69);
            this.cb_uc_res_aj_machine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_uc_res_aj_machine.Name = "cb_uc_res_aj_machine";
            this.cb_uc_res_aj_machine.Size = new System.Drawing.Size(252, 33);
            this.cb_uc_res_aj_machine.TabIndex = 9;
            this.cb_uc_res_aj_machine.SelectedIndexChanged += new System.EventHandler(this.machine_SelectedIndexChanged);
            // 
            // uc_btn_add_res
            // 
            this.uc_btn_add_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uc_btn_add_res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uc_btn_add_res.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_add_res.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uc_btn_add_res.Location = new System.Drawing.Point(372, 487);
            this.uc_btn_add_res.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uc_btn_add_res.Name = "uc_btn_add_res";
            this.uc_btn_add_res.Size = new System.Drawing.Size(255, 51);
            this.uc_btn_add_res.TabIndex = 12;
            this.uc_btn_add_res.Text = "Add new reservation";
            this.uc_btn_add_res.UseVisualStyleBackColor = false;
            this.uc_btn_add_res.Click += new System.EventHandler(this.uc_btn_add_res_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Heur fin:";
            // 
            // dt_uc_res_aj_date
            // 
            this.dt_uc_res_aj_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_uc_res_aj_date.Location = new System.Drawing.Point(155, 170);
            this.dt_uc_res_aj_date.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.dt_uc_res_aj_date.Name = "dt_uc_res_aj_date";
            this.dt_uc_res_aj_date.TabIndex = 18;
            // 
            // dtp_hour_start
            // 
            this.dtp_hour_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hour_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hour_start.Location = new System.Drawing.Point(659, 171);
            this.dtp_hour_start.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtp_hour_start.Name = "dtp_hour_start";
            this.dtp_hour_start.ShowUpDown = true;
            this.dtp_hour_start.Size = new System.Drawing.Size(135, 30);
            this.dtp_hour_start.TabIndex = 19;
            this.dtp_hour_start.ValueChanged += new System.EventHandler(this.dtp_hour_start_ValueChanged);
            // 
            // dtp_hour_end
            // 
            this.dtp_hour_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hour_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hour_end.Location = new System.Drawing.Point(659, 218);
            this.dtp_hour_end.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtp_hour_end.Name = "dtp_hour_end";
            this.dtp_hour_end.ShowUpDown = true;
            this.dtp_hour_end.Size = new System.Drawing.Size(135, 30);
            this.dtp_hour_end.TabIndex = 20;
            // 
            // uc_add_new_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_hour_end);
            this.Controls.Add(this.dtp_hour_start);
            this.Controls.Add(this.dt_uc_res_aj_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uc_btn_add_res);
            this.Controls.Add(this.cb_uc_res_aj_machine);
            this.Controls.Add(this.cb_uc_res_aj_id);
            this.Controls.Add(this.tb_uc_res_aj_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_add_new_reservation";
            this.Size = new System.Drawing.Size(926, 653);
            this.Load += new System.EventHandler(this.LoadPilotOnly);
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
        private System.Windows.Forms.Button uc_btn_add_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar dt_uc_res_aj_date;
        private System.Windows.Forms.DateTimePicker dtp_hour_start;
        private System.Windows.Forms.DateTimePicker dtp_hour_end;
    }
}
