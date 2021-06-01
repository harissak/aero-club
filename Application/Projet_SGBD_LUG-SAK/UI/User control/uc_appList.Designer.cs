
namespace UI.User_control
{
    partial class uc_appList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_app_list = new System.Windows.Forms.DataGridView();
            this.bt_search = new System.Windows.Forms.Button();
            this.bs_apps = new System.Windows.Forms.BindingSource(this.components);
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appimmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appclasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_apps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_app_list
            // 
            this.dgv_app_list.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_app_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_app_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_app_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.appimmaDataGridViewTextBoxColumn,
            this.appclasseDataGridViewTextBoxColumn,
            this.appdescrDataGridViewTextBoxColumn});
            this.dgv_app_list.DataSource = this.bs_apps;
            this.dgv_app_list.Location = new System.Drawing.Point(3, 98);
            this.dgv_app_list.Name = "dgv_app_list";
            this.dgv_app_list.Size = new System.Drawing.Size(601, 366);
            this.dgv_app_list.TabIndex = 0;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(129, 38);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Load All";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bs_apps
            // 
            this.bs_apps.DataSource = typeof(DTO.APP);
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "App_ID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "Mat. Club";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.appIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // appimmaDataGridViewTextBoxColumn
            // 
            this.appimmaDataGridViewTextBoxColumn.DataPropertyName = "App_imma";
            this.appimmaDataGridViewTextBoxColumn.HeaderText = "Immatriculation";
            this.appimmaDataGridViewTextBoxColumn.Name = "appimmaDataGridViewTextBoxColumn";
            this.appimmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appclasseDataGridViewTextBoxColumn
            // 
            this.appclasseDataGridViewTextBoxColumn.DataPropertyName = "App_classe";
            this.appclasseDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.appclasseDataGridViewTextBoxColumn.Name = "appclasseDataGridViewTextBoxColumn";
            this.appclasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appdescrDataGridViewTextBoxColumn
            // 
            this.appdescrDataGridViewTextBoxColumn.DataPropertyName = "App_descr";
            this.appdescrDataGridViewTextBoxColumn.HeaderText = "Description";
            this.appdescrDataGridViewTextBoxColumn.Name = "appdescrDataGridViewTextBoxColumn";
            this.appdescrDataGridViewTextBoxColumn.ReadOnly = true;
            this.appdescrDataGridViewTextBoxColumn.Width = 250;
            // 
            // uc_appList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.dgv_app_list);
            this.Name = "uc_appList";
            this.Size = new System.Drawing.Size(607, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_apps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_app_list;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.BindingSource bs_apps;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appimmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appclasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appdescrDataGridViewTextBoxColumn;
    }
}
