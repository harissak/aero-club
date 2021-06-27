
namespace UI.User_control
{
    partial class uc_reservations
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
            this.tb_uc_recherch_res_id = new System.Windows.Forms.TextBox();
            this.bt_uc_res_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_running_reserv = new System.Windows.Forms.DataGridView();
            this.Res_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reshrdebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reshrfinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resestannuleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.resestprevenuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bs_reservation_list = new System.Windows.Forms.BindingSource(this.components);
            this.cb_uc_rechercher_aeronef = new System.Windows.Forms.ComboBox();
            this.bt_reload_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_running_reserv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_reservation_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_uc_recherch_res_id
            // 
            this.tb_uc_recherch_res_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uc_recherch_res_id.Location = new System.Drawing.Point(219, 16);
            this.tb_uc_recherch_res_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_uc_recherch_res_id.Name = "tb_uc_recherch_res_id";
            this.tb_uc_recherch_res_id.Size = new System.Drawing.Size(96, 26);
            this.tb_uc_recherch_res_id.TabIndex = 1;
            // 
            // bt_uc_res_search
            // 
            this.bt_uc_res_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_uc_res_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_uc_res_search.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_uc_res_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_uc_res_search.Location = new System.Drawing.Point(512, 30);
            this.bt_uc_res_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_uc_res_search.Name = "bt_uc_res_search";
            this.bt_uc_res_search.Size = new System.Drawing.Size(109, 31);
            this.bt_uc_res_search.TabIndex = 3;
            this.bt_uc_res_search.Text = "SEARCH";
            this.bt_uc_res_search.UseVisualStyleBackColor = false;
            this.bt_uc_res_search.Click += new System.EventHandler(this.bt_uc_res_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "AÉRONEF:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUMÉRO DE RÉSÉRVATION:";
            // 
            // dgv_running_reserv
            // 
            this.dgv_running_reserv.AutoGenerateColumns = false;
            this.dgv_running_reserv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_running_reserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_running_reserv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Res_ID,
            this.resdateDataGridViewTextBoxColumn,
            this.reshrdebDataGridViewTextBoxColumn,
            this.reshrfinDataGridViewTextBoxColumn,
            this.mbr_id,
            this.app_id,
            this.resestannuleDataGridViewCheckBoxColumn,
            this.resestprevenuDataGridViewCheckBoxColumn});
            this.dgv_running_reserv.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dgv_running_reserv.DataSource = this.bs_reservation_list;
            this.dgv_running_reserv.Location = new System.Drawing.Point(3, 100);
            this.dgv_running_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_running_reserv.Name = "dgv_running_reserv";
            this.dgv_running_reserv.RowHeadersWidth = 51;
            this.dgv_running_reserv.RowTemplate.Height = 24;
            this.dgv_running_reserv.Size = new System.Drawing.Size(808, 433);
            this.dgv_running_reserv.TabIndex = 6;
            this.dgv_running_reserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reservation_clicked);
            this.dgv_running_reserv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_running_reserv_CellContentClick);
            // 
            // Res_ID
            // 
            this.Res_ID.DataPropertyName = "Res_ID";
            this.Res_ID.HeaderText = "Réservation ID";
            this.Res_ID.MinimumWidth = 6;
            this.Res_ID.Name = "Res_ID";
            this.Res_ID.ReadOnly = true;
            this.Res_ID.Width = 125;
            // 
            // resdateDataGridViewTextBoxColumn
            // 
            this.resdateDataGridViewTextBoxColumn.DataPropertyName = "Res_date";
            this.resdateDataGridViewTextBoxColumn.HeaderText = "Date de réservation";
            this.resdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resdateDataGridViewTextBoxColumn.Name = "resdateDataGridViewTextBoxColumn";
            this.resdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.resdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reshrdebDataGridViewTextBoxColumn
            // 
            this.reshrdebDataGridViewTextBoxColumn.DataPropertyName = "Res_hr_deb";
            this.reshrdebDataGridViewTextBoxColumn.HeaderText = "Heur début de RÉS";
            this.reshrdebDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reshrdebDataGridViewTextBoxColumn.Name = "reshrdebDataGridViewTextBoxColumn";
            this.reshrdebDataGridViewTextBoxColumn.ReadOnly = true;
            this.reshrdebDataGridViewTextBoxColumn.Width = 125;
            // 
            // reshrfinDataGridViewTextBoxColumn
            // 
            this.reshrfinDataGridViewTextBoxColumn.DataPropertyName = "Res_hr_fin";
            this.reshrfinDataGridViewTextBoxColumn.HeaderText = "Heur fin de RÉS";
            this.reshrfinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reshrfinDataGridViewTextBoxColumn.Name = "reshrfinDataGridViewTextBoxColumn";
            this.reshrfinDataGridViewTextBoxColumn.ReadOnly = true;
            this.reshrfinDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbr_id
            // 
            this.mbr_id.DataPropertyName = "Res_FK_Mbr_ID";
            this.mbr_id.HeaderText = "Member ID";
            this.mbr_id.MinimumWidth = 6;
            this.mbr_id.Name = "mbr_id";
            this.mbr_id.Width = 125;
            // 
            // app_id
            // 
            this.app_id.DataPropertyName = "Res_FK_App_ID";
            this.app_id.HeaderText = "APP ID";
            this.app_id.MinimumWidth = 6;
            this.app_id.Name = "app_id";
            this.app_id.Width = 125;
            // 
            // resestannuleDataGridViewCheckBoxColumn
            // 
            this.resestannuleDataGridViewCheckBoxColumn.DataPropertyName = "Res_est_annule";
            this.resestannuleDataGridViewCheckBoxColumn.HeaderText = "RÉS est annulée";
            this.resestannuleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.resestannuleDataGridViewCheckBoxColumn.Name = "resestannuleDataGridViewCheckBoxColumn";
            this.resestannuleDataGridViewCheckBoxColumn.Visible = false;
            this.resestannuleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // resestprevenuDataGridViewCheckBoxColumn
            // 
            this.resestprevenuDataGridViewCheckBoxColumn.DataPropertyName = "Res_est_prevenu";
            this.resestprevenuDataGridViewCheckBoxColumn.HeaderText = "RÉS est prevenu";
            this.resestprevenuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.resestprevenuDataGridViewCheckBoxColumn.Name = "resestprevenuDataGridViewCheckBoxColumn";
            this.resestprevenuDataGridViewCheckBoxColumn.Visible = false;
            this.resestprevenuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bs_reservation_list
            // 
            this.bs_reservation_list.DataSource = typeof(DTO.RES);
            // 
            // cb_uc_rechercher_aeronef
            // 
            this.cb_uc_rechercher_aeronef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uc_rechercher_aeronef.FormattingEnabled = true;
            this.cb_uc_rechercher_aeronef.Location = new System.Drawing.Point(219, 58);
            this.cb_uc_rechercher_aeronef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_uc_rechercher_aeronef.Name = "cb_uc_rechercher_aeronef";
            this.cb_uc_rechercher_aeronef.Size = new System.Drawing.Size(204, 28);
            this.cb_uc_rechercher_aeronef.TabIndex = 7;
            // 
            // bt_reload_all
            // 
            this.bt_reload_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_reload_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reload_all.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reload_all.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_reload_all.Location = new System.Drawing.Point(675, 30);
            this.bt_reload_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_reload_all.Name = "bt_reload_all";
            this.bt_reload_all.Size = new System.Drawing.Size(109, 31);
            this.bt_reload_all.TabIndex = 8;
            this.bt_reload_all.Text = "Reload All";
            this.bt_reload_all.UseVisualStyleBackColor = false;
            this.bt_reload_all.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_reload_all);
            this.Controls.Add(this.cb_uc_rechercher_aeronef);
            this.Controls.Add(this.dgv_running_reserv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_uc_res_search);
            this.Controls.Add(this.tb_uc_recherch_res_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_reservations";
            this.Size = new System.Drawing.Size(818, 587);
            this.Load += new System.EventHandler(this.LoadAllReservation);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_running_reserv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_reservation_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_uc_recherch_res_id;
        private System.Windows.Forms.Button bt_uc_res_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_running_reserv;
        private System.Windows.Forms.BindingSource bs_reservation_list;
        private System.Windows.Forms.ComboBox cb_uc_rechercher_aeronef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Res_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reshrdebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reshrfinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn app_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resestannuleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resestprevenuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button bt_reload_all;
    }
}
