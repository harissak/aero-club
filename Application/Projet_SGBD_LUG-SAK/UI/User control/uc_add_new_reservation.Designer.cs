
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
            this.uc_res_ch_date = new System.Windows.Forms.MonthCalendar();
            this.uc_res_ch_id = new System.Windows.Forms.TextBox();
            this.uc_res_ch_nom = new System.Windows.Forms.ComboBox();
            this.uc_res_ch_machine = new System.Windows.Forms.ComboBox();
            this.uc_res_ch_heur = new System.Windows.Forms.ComboBox();
            this.uc_btn_add_res = new System.Windows.Forms.Button();
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
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heur:";
            // 
            // uc_res_ch_date
            // 
            this.uc_res_ch_date.Location = new System.Drawing.Point(91, 110);
            this.uc_res_ch_date.Name = "uc_res_ch_date";
            this.uc_res_ch_date.TabIndex = 6;
            // 
            // uc_res_ch_id
            // 
            this.uc_res_ch_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_id.Location = new System.Drawing.Point(91, 3);
            this.uc_res_ch_id.Name = "uc_res_ch_id";
            this.uc_res_ch_id.Size = new System.Drawing.Size(100, 26);
            this.uc_res_ch_id.TabIndex = 7;
            // 
            // uc_res_ch_nom
            // 
            this.uc_res_ch_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_nom.FormattingEnabled = true;
            this.uc_res_ch_nom.Location = new System.Drawing.Point(91, 33);
            this.uc_res_ch_nom.Name = "uc_res_ch_nom";
            this.uc_res_ch_nom.Size = new System.Drawing.Size(206, 28);
            this.uc_res_ch_nom.TabIndex = 8;
            // 
            // uc_res_ch_machine
            // 
            this.uc_res_ch_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_machine.FormattingEnabled = true;
            this.uc_res_ch_machine.Location = new System.Drawing.Point(91, 69);
            this.uc_res_ch_machine.Name = "uc_res_ch_machine";
            this.uc_res_ch_machine.Size = new System.Drawing.Size(206, 28);
            this.uc_res_ch_machine.TabIndex = 9;
            this.uc_res_ch_machine.SelectedIndexChanged += new System.EventHandler(this.uc_res_ch_machine_SelectedIndexChanged);
            // 
            // uc_res_ch_heur
            // 
            this.uc_res_ch_heur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_ch_heur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_ch_heur.FormattingEnabled = true;
            this.uc_res_ch_heur.Items.AddRange(new object[] {
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
            this.uc_res_ch_heur.Location = new System.Drawing.Point(91, 329);
            this.uc_res_ch_heur.Name = "uc_res_ch_heur";
            this.uc_res_ch_heur.Size = new System.Drawing.Size(121, 28);
            this.uc_res_ch_heur.TabIndex = 10;
            // 
            // uc_btn_add_res
            // 
            this.uc_btn_add_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_add_res.Location = new System.Drawing.Point(58, 384);
            this.uc_btn_add_res.Name = "uc_btn_add_res";
            this.uc_btn_add_res.Size = new System.Drawing.Size(189, 34);
            this.uc_btn_add_res.TabIndex = 12;
            this.uc_btn_add_res.Text = "Add new reservation";
            this.uc_btn_add_res.UseVisualStyleBackColor = true;
            // 
            // uc_add_new_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_btn_add_res);
            this.Controls.Add(this.uc_res_ch_heur);
            this.Controls.Add(this.uc_res_ch_machine);
            this.Controls.Add(this.uc_res_ch_nom);
            this.Controls.Add(this.uc_res_ch_id);
            this.Controls.Add(this.uc_res_ch_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_add_new_reservation";
            this.Size = new System.Drawing.Size(298, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar uc_res_ch_date;
        private System.Windows.Forms.TextBox uc_res_ch_id;
        private System.Windows.Forms.ComboBox uc_res_ch_nom;
        private System.Windows.Forms.ComboBox uc_res_ch_machine;
        private System.Windows.Forms.ComboBox uc_res_ch_heur;
        private System.Windows.Forms.Button uc_btn_add_res;
    }
}
