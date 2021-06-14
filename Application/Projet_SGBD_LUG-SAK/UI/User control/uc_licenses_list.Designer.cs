
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
            this.bs_licenses = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_licenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_licenses
            // 
            this.dgv_licenses.AutoGenerateColumns = false;
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
            this.dgv_licenses.Location = new System.Drawing.Point(3, 93);
            this.dgv_licenses.Name = "dgv_licenses";
            this.dgv_licenses.Size = new System.Drawing.Size(495, 373);
            this.dgv_licenses.TabIndex = 0;
            this.dgv_licenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licenses_CellClick);
            // 
            // bt_search_mat
            // 
            this.bt_search_mat.Location = new System.Drawing.Point(240, 34);
            this.bt_search_mat.Name = "bt_search_mat";
            this.bt_search_mat.Size = new System.Drawing.Size(165, 23);
            this.bt_search_mat.TabIndex = 12;
            this.bt_search_mat.Text = "Search by Mat. Owner";
            this.bt_search_mat.UseVisualStyleBackColor = true;
            // 
            // lb_mat_club
            // 
            this.lb_mat_club.AutoSize = true;
            this.lb_mat_club.Location = new System.Drawing.Point(7, 40);
            this.lb_mat_club.Name = "lb_mat_club";
            this.lb_mat_club.Size = new System.Drawing.Size(65, 13);
            this.lb_mat_club.TabIndex = 11;
            this.lb_mat_club.Text = "Mat. Owner:";
            // 
            // tb_search_mat
            // 
            this.tb_search_mat.Location = new System.Drawing.Point(102, 34);
            this.tb_search_mat.Name = "tb_search_mat";
            this.tb_search_mat.Size = new System.Drawing.Size(131, 20);
            this.tb_search_mat.TabIndex = 10;
            // 
            // bt_search_name
            // 
            this.bt_search_name.Location = new System.Drawing.Point(240, 3);
            this.bt_search_name.Name = "bt_search_name";
            this.bt_search_name.Size = new System.Drawing.Size(165, 23);
            this.bt_search_name.TabIndex = 9;
            this.bt_search_name.Text = "Search by name";
            this.bt_search_name.UseVisualStyleBackColor = true;
            this.bt_search_name.Click += new System.EventHandler(this.bt_search_name_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(8, 11);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(72, 13);
            this.lb_name.TabIndex = 8;
            this.lb_name.Text = "Name Owner:";
            // 
            // tb_search_name
            // 
            this.tb_search_name.Location = new System.Drawing.Point(102, 5);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(131, 20);
            this.tb_search_name.TabIndex = 7;
            // 
            // lICFKMBRIDDataGridViewTextBoxColumn
            // 
            this.lICFKMBRIDDataGridViewTextBoxColumn.DataPropertyName = "LIC_FK_MBR_ID";
            this.lICFKMBRIDDataGridViewTextBoxColumn.HeaderText = "Member Mat. Club";
            this.lICFKMBRIDDataGridViewTextBoxColumn.Name = "lICFKMBRIDDataGridViewTextBoxColumn";
            this.lICFKMBRIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // licIDDataGridViewTextBoxColumn
            // 
            this.licIDDataGridViewTextBoxColumn.DataPropertyName = "Lic_ID";
            this.licIDDataGridViewTextBoxColumn.HeaderText = "Mat. Club Lic";
            this.licIDDataGridViewTextBoxColumn.Name = "licIDDataGridViewTextBoxColumn";
            this.licIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // licnumDataGridViewTextBoxColumn
            // 
            this.licnumDataGridViewTextBoxColumn.DataPropertyName = "Lic_num";
            this.licnumDataGridViewTextBoxColumn.HeaderText = "Licence Number";
            this.licnumDataGridViewTextBoxColumn.Name = "licnumDataGridViewTextBoxColumn";
            // 
            // licobtDataGridViewTextBoxColumn
            // 
            this.licobtDataGridViewTextBoxColumn.DataPropertyName = "Lic_obt";
            this.licobtDataGridViewTextBoxColumn.HeaderText = "Obtention Date";
            this.licobtDataGridViewTextBoxColumn.Name = "licobtDataGridViewTextBoxColumn";
            // 
            // licexpDataGridViewTextBoxColumn
            // 
            this.licexpDataGridViewTextBoxColumn.DataPropertyName = "Lic_exp";
            this.licexpDataGridViewTextBoxColumn.HeaderText = "Expiration date";
            this.licexpDataGridViewTextBoxColumn.Name = "licexpDataGridViewTextBoxColumn";
            // 
            // licactiveDataGridViewCheckBoxColumn
            // 
            this.licactiveDataGridViewCheckBoxColumn.DataPropertyName = "Lic_active";
            this.licactiveDataGridViewCheckBoxColumn.HeaderText = "Is active";
            this.licactiveDataGridViewCheckBoxColumn.Name = "licactiveDataGridViewCheckBoxColumn";
            this.licactiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // licpaysDataGridViewTextBoxColumn
            // 
            this.licpaysDataGridViewTextBoxColumn.DataPropertyName = "Lic_pays";
            this.licpaysDataGridViewTextBoxColumn.HeaderText = "Delivery country";
            this.licpaysDataGridViewTextBoxColumn.Name = "licpaysDataGridViewTextBoxColumn";
            // 
            // liccl1DataGridViewCheckBoxColumn
            // 
            this.liccl1DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl1";
            this.liccl1DataGridViewCheckBoxColumn.HeaderText = "Class     1";
            this.liccl1DataGridViewCheckBoxColumn.Name = "liccl1DataGridViewCheckBoxColumn";
            this.liccl1DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl2DataGridViewCheckBoxColumn
            // 
            this.liccl2DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl2";
            this.liccl2DataGridViewCheckBoxColumn.HeaderText = "Class     2";
            this.liccl2DataGridViewCheckBoxColumn.Name = "liccl2DataGridViewCheckBoxColumn";
            this.liccl2DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl3DataGridViewCheckBoxColumn
            // 
            this.liccl3DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl3";
            this.liccl3DataGridViewCheckBoxColumn.HeaderText = "Class     3";
            this.liccl3DataGridViewCheckBoxColumn.Name = "liccl3DataGridViewCheckBoxColumn";
            this.liccl3DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl4DataGridViewCheckBoxColumn
            // 
            this.liccl4DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl4";
            this.liccl4DataGridViewCheckBoxColumn.HeaderText = "Class     4";
            this.liccl4DataGridViewCheckBoxColumn.Name = "liccl4DataGridViewCheckBoxColumn";
            this.liccl4DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl5DataGridViewCheckBoxColumn
            // 
            this.liccl5DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl5";
            this.liccl5DataGridViewCheckBoxColumn.HeaderText = "Class     5";
            this.liccl5DataGridViewCheckBoxColumn.Name = "liccl5DataGridViewCheckBoxColumn";
            this.liccl5DataGridViewCheckBoxColumn.Width = 50;
            // 
            // liccl6DataGridViewCheckBoxColumn
            // 
            this.liccl6DataGridViewCheckBoxColumn.DataPropertyName = "Lic_cl6";
            this.liccl6DataGridViewCheckBoxColumn.HeaderText = "Class     6";
            this.liccl6DataGridViewCheckBoxColumn.Name = "liccl6DataGridViewCheckBoxColumn";
            this.liccl6DataGridViewCheckBoxColumn.Width = 50;
            // 
            // bs_licenses
            // 
            this.bs_licenses.DataSource = typeof(DTO.LIC);
            // 
            // uc_licenses_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_search_mat);
            this.Controls.Add(this.lb_mat_club);
            this.Controls.Add(this.tb_search_mat);
            this.Controls.Add(this.bt_search_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_search_name);
            this.Controls.Add(this.dgv_licenses);
            this.Name = "uc_licenses_list";
            this.Size = new System.Drawing.Size(503, 473);
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
    }
}
