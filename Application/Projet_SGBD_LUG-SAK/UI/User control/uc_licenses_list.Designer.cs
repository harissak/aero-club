
namespace UI.User_control
{
    partial class uc_licenses_list
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
            this.dgv_licenses = new System.Windows.Forms.DataGridView();
            this.bs_licenses = new System.Windows.Forms.BindingSource(this.components);
            this.bt_search_mat = new System.Windows.Forms.Button();
            this.lb_mat_club = new System.Windows.Forms.Label();
            this.tb_search_mat = new System.Windows.Forms.TextBox();
            this.bt_search_name = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_search_name = new System.Windows.Forms.TextBox();
            this.lICFKMBRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licobtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licpaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liccl1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.liccl2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.liccl3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.liccl4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.liccl5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.liccl6DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_reloiad_dgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_licenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_licenses
            // 
            this.dgv_licenses.AutoGenerateColumns = false;
            this.dgv_licenses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_licenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_licenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lICFKMBRIDDataGridViewTextBoxColumn,
            this.licIDDataGridViewTextBoxColumn,
            this.licnumDataGridViewTextBoxColumn,
            this.licobtDataGridViewTextBoxColumn,
            this.licexpDataGridViewTextBoxColumn,
            this.licactiveDataGridViewCheckBoxColumn,
            this.licpaysDataGridViewTextBoxColumn,
            this.liccl1DataGridViewCheckBoxColumn,
            this.liccl2DataGridViewCheckBoxColumn,
            this.liccl3DataGridViewCheckBoxColumn,
            this.liccl4DataGridViewCheckBoxColumn,
            this.liccl5DataGridViewCheckBoxColumn,
            this.liccl6DataGridViewCheckBoxColumn});
            this.dgv_licenses.DataSource = this.bs_licenses;
            this.dgv_licenses.Location = new System.Drawing.Point(3, 97);
            this.dgv_licenses.Name = "dgv_licenses";
            this.dgv_licenses.RowHeadersWidth = 51;
            this.dgv_licenses.Size = new System.Drawing.Size(442, 373);
            this.dgv_licenses.TabIndex = 0;
            this.dgv_licenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licenses_CellClick);
            // 
            // bs_licenses
            // 
            this.bs_licenses.DataSource = typeof(DTO.LIC);
            // 
            // bt_search_mat
            // 
            this.bt_search_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_search_mat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_search_mat.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search_mat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search_mat.Location = new System.Drawing.Point(280, 39);
            this.bt_search_mat.Name = "bt_search_mat";
            this.bt_search_mat.Size = new System.Drawing.Size(146, 23);
            this.bt_search_mat.TabIndex = 12;
            this.bt_search_mat.Text = "Search by Mat. Owner";
            this.bt_search_mat.UseVisualStyleBackColor = false;
            this.bt_search_mat.Click += new System.EventHandler(this.bt_search_mat_Click);
            // 
            // lb_mat_club
            // 
            this.lb_mat_club.AutoSize = true;
            this.lb_mat_club.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mat_club.Location = new System.Drawing.Point(7, 37);
            this.lb_mat_club.Name = "lb_mat_club";
            this.lb_mat_club.Size = new System.Drawing.Size(102, 19);
            this.lb_mat_club.TabIndex = 11;
            this.lb_mat_club.Text = "Mat. Owner:";
            // 
            // tb_search_mat
            // 
            this.tb_search_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_mat.Location = new System.Drawing.Point(123, 41);
            this.tb_search_mat.Name = "tb_search_mat";
            this.tb_search_mat.Size = new System.Drawing.Size(131, 26);
            this.tb_search_mat.TabIndex = 10;
            // 
            // bt_search_name
            // 
            this.bt_search_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_search_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_search_name.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search_name.Location = new System.Drawing.Point(280, 9);
            this.bt_search_name.Name = "bt_search_name";
            this.bt_search_name.Size = new System.Drawing.Size(146, 23);
            this.bt_search_name.TabIndex = 9;
            this.bt_search_name.Text = "Search by name";
            this.bt_search_name.UseVisualStyleBackColor = false;
            this.bt_search_name.Click += new System.EventHandler(this.bt_search_name_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(7, 7);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(110, 19);
            this.lb_name.TabIndex = 8;
            this.lb_name.Text = "Name owner:";
            // 
            // tb_search_name
            // 
            this.tb_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_name.Location = new System.Drawing.Point(123, 9);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(131, 26);
            this.tb_search_name.TabIndex = 7;
            // 
            // lICFKMBRIDDataGridViewTextBoxColumn
            // 
            this.lICFKMBRIDDataGridViewTextBoxColumn.DataPropertyName = "LIC_FK_MBR_ID";
            this.lICFKMBRIDDataGridViewTextBoxColumn.HeaderText = "Member Mat. Club";
            this.lICFKMBRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lICFKMBRIDDataGridViewTextBoxColumn.Name = "lICFKMBRIDDataGridViewTextBoxColumn";
            this.lICFKMBRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lICFKMBRIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // licIDDataGridViewTextBoxColumn
            // 
            this.licIDDataGridViewTextBoxColumn.DataPropertyName = "Lic_ID";
            this.licIDDataGridViewTextBoxColumn.HeaderText = "Mat. Club Lic";
            this.licIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licIDDataGridViewTextBoxColumn.Name = "licIDDataGridViewTextBoxColumn";
            this.licIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.licIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // licnumDataGridViewTextBoxColumn
            // 
            this.licnumDataGridViewTextBoxColumn.DataPropertyName = "Lic_num";
            this.licnumDataGridViewTextBoxColumn.HeaderText = "Licence Number";
            this.licnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licnumDataGridViewTextBoxColumn.Name = "licnumDataGridViewTextBoxColumn";
            this.licnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.licnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // licobtDataGridViewTextBoxColumn
            // 
            this.licobtDataGridViewTextBoxColumn.DataPropertyName = "Lic_obt";
            this.licobtDataGridViewTextBoxColumn.HeaderText = "Obtention Date";
            this.licobtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licobtDataGridViewTextBoxColumn.Name = "licobtDataGridViewTextBoxColumn";
            this.licobtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licexpDataGridViewTextBoxColumn
            // 
            this.licexpDataGridViewTextBoxColumn.DataPropertyName = "Lic_exp";
            this.licexpDataGridViewTextBoxColumn.HeaderText = "Expiration date";
            this.licexpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licexpDataGridViewTextBoxColumn.Name = "licexpDataGridViewTextBoxColumn";
            this.licexpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licactiveDataGridViewCheckBoxColumn
            // 
            this.licactiveDataGridViewCheckBoxColumn.DataPropertyName = "Lic_active";
            this.licactiveDataGridViewCheckBoxColumn.HeaderText = "Is active";
            this.licactiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.licactiveDataGridViewCheckBoxColumn.Name = "licactiveDataGridViewCheckBoxColumn";
            this.licactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.licactiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // licpaysDataGridViewTextBoxColumn
            // 
            this.licpaysDataGridViewTextBoxColumn.DataPropertyName = "Lic_pays";
            this.licpaysDataGridViewTextBoxColumn.HeaderText = "Delivery country";
            this.licpaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licpaysDataGridViewTextBoxColumn.Name = "licpaysDataGridViewTextBoxColumn";
            this.licpaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.licpaysDataGridViewTextBoxColumn.Width = 75;
            // 
            // liccl1DataGridViewCheckBoxColumn
            // 
            this.liccl1DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl1";
            this.liccl1DataGridViewCheckBoxColumn.HeaderText = "Class     1";
            this.liccl1DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl1DataGridViewCheckBoxColumn.Name = "liccl1DataGridViewCheckBoxColumn";
            this.liccl1DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl1DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl2DataGridViewCheckBoxColumn
            // 
            this.liccl2DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl2";
            this.liccl2DataGridViewCheckBoxColumn.HeaderText = "Class     2";
            this.liccl2DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl2DataGridViewCheckBoxColumn.Name = "liccl2DataGridViewCheckBoxColumn";
            this.liccl2DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl2DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl3DataGridViewCheckBoxColumn
            // 
            this.liccl3DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl3";
            this.liccl3DataGridViewCheckBoxColumn.HeaderText = "Class     3";
            this.liccl3DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl3DataGridViewCheckBoxColumn.Name = "liccl3DataGridViewCheckBoxColumn";
            this.liccl3DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl3DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl4DataGridViewCheckBoxColumn
            // 
            this.liccl4DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl4";
            this.liccl4DataGridViewCheckBoxColumn.HeaderText = "Class     4";
            this.liccl4DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl4DataGridViewCheckBoxColumn.Name = "liccl4DataGridViewCheckBoxColumn";
            this.liccl4DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl4DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl5DataGridViewCheckBoxColumn
            // 
            this.liccl5DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl5";
            this.liccl5DataGridViewCheckBoxColumn.HeaderText = "Class     5";
            this.liccl5DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl5DataGridViewCheckBoxColumn.Name = "liccl5DataGridViewCheckBoxColumn";
            this.liccl5DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl5DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl6DataGridViewCheckBoxColumn
            // 
            this.liccl6DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl6";
            this.liccl6DataGridViewCheckBoxColumn.HeaderText = "Class     6";
            this.liccl6DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.liccl6DataGridViewCheckBoxColumn.Name = "liccl6DataGridViewCheckBoxColumn";
            this.liccl6DataGridViewCheckBoxColumn.ReadOnly = true;
            this.liccl6DataGridViewCheckBoxColumn.Width = 50;
            // 
            // btn_reloiad_dgv
            // 
            this.btn_reloiad_dgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reloiad_dgv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reloiad_dgv.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloiad_dgv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reloiad_dgv.Location = new System.Drawing.Point(123, 73);
            this.btn_reloiad_dgv.Name = "btn_reloiad_dgv";
            this.btn_reloiad_dgv.Size = new System.Drawing.Size(131, 23);
            this.btn_reloiad_dgv.TabIndex = 13;
            this.btn_reloiad_dgv.Text = "Reload All";
            this.btn_reloiad_dgv.UseVisualStyleBackColor = false;
            this.btn_reloiad_dgv.Click += new System.EventHandler(this.btn_reloiad_dgv_Click);
            // 
            // uc_licenses_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reloiad_dgv);
            this.Controls.Add(this.bt_search_mat);
            this.Controls.Add(this.lb_mat_club);
            this.Controls.Add(this.tb_search_mat);
            this.Controls.Add(this.bt_search_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_search_name);
            this.Controls.Add(this.dgv_licenses);
            this.Name = "uc_licenses_list";
            this.Size = new System.Drawing.Size(510, 473);
            this.Load += new System.EventHandler(this.uc_licenses_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_licenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_licenses;
        private System.Windows.Forms.DataGridView dgv_licenses;
        private System.Windows.Forms.Button bt_search_mat;
        private System.Windows.Forms.Label lb_mat_club;
        private System.Windows.Forms.TextBox tb_search_mat;
        private System.Windows.Forms.Button bt_search_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_search_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lICFKMBRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licobtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn licactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licpaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn liccl6DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_reloiad_dgv;
    }
}
