
namespace UI.User_control
{
    partial class uc_appList_del
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
            this.bt_app_delete = new System.Windows.Forms.Button();
            this.bt_add_app = new System.Windows.Forms.Button();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appimmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appclasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_apps = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_apps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_app_list
            // 
            this.dgv_app_list.AutoGenerateColumns = false;
            this.dgv_app_list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.dgv_app_list.Location = new System.Drawing.Point(10, 4);
            this.dgv_app_list.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_app_list.Name = "dgv_app_list";
            this.dgv_app_list.RowHeadersWidth = 51;
            this.dgv_app_list.Size = new System.Drawing.Size(648, 433);
            this.dgv_app_list.TabIndex = 0;
            this.dgv_app_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_app_list_CellClick);
            this.dgv_app_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_app_list_CellContentClick);
            // 
            // bt_app_delete
            // 
            this.bt_app_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_app_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_app_delete.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_app_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_app_delete.Location = new System.Drawing.Point(132, 446);
            this.bt_app_delete.Margin = new System.Windows.Forms.Padding(5);
            this.bt_app_delete.Name = "bt_app_delete";
            this.bt_app_delete.Size = new System.Drawing.Size(149, 39);
            this.bt_app_delete.TabIndex = 3;
            this.bt_app_delete.Text = "Delete A/C";
            this.bt_app_delete.UseVisualStyleBackColor = false;
            this.bt_app_delete.Click += new System.EventHandler(this.bt_app_delete_Click);
            // 
            // bt_add_app
            // 
            this.bt_add_app.Location = new System.Drawing.Point(5, 53);
            this.bt_add_app.Margin = new System.Windows.Forms.Padding(4);
            this.bt_add_app.Name = "bt_add_app";
            this.bt_add_app.Size = new System.Drawing.Size(100, 28);
            this.bt_add_app.TabIndex = 2;
            this.bt_add_app.Text = "Add Aircraft";
            this.bt_add_app.UseVisualStyleBackColor = true;
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "App_ID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "Mat. Club";
            this.appIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.appIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.appIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // appimmaDataGridViewTextBoxColumn
            // 
            this.appimmaDataGridViewTextBoxColumn.DataPropertyName = "App_imma";
            this.appimmaDataGridViewTextBoxColumn.HeaderText = "Immatriculation";
            this.appimmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appimmaDataGridViewTextBoxColumn.Name = "appimmaDataGridViewTextBoxColumn";
            this.appimmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.appimmaDataGridViewTextBoxColumn.Width = 125;
            // 
            // appclasseDataGridViewTextBoxColumn
            // 
            this.appclasseDataGridViewTextBoxColumn.DataPropertyName = "App_classe";
            this.appclasseDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.appclasseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appclasseDataGridViewTextBoxColumn.Name = "appclasseDataGridViewTextBoxColumn";
            this.appclasseDataGridViewTextBoxColumn.ReadOnly = true;
            this.appclasseDataGridViewTextBoxColumn.Width = 60;
            // 
            // appdescrDataGridViewTextBoxColumn
            // 
            this.appdescrDataGridViewTextBoxColumn.DataPropertyName = "App_descr";
            this.appdescrDataGridViewTextBoxColumn.HeaderText = "Description";
            this.appdescrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appdescrDataGridViewTextBoxColumn.Name = "appdescrDataGridViewTextBoxColumn";
            this.appdescrDataGridViewTextBoxColumn.ReadOnly = true;
            this.appdescrDataGridViewTextBoxColumn.Width = 300;
            // 
            // bs_apps
            // 
            this.bs_apps.DataSource = typeof(DTO.APP);
            this.bs_apps.CurrentChanged += new System.EventHandler(this.bs_apps_CurrentChanged);
            // 
            // uc_appList_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_app_delete);
            this.Controls.Add(this.dgv_app_list);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_appList_del";
            this.Size = new System.Drawing.Size(662, 502);
            this.Load += new System.EventHandler(this.uc_appList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_apps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_app_list;
        private System.Windows.Forms.BindingSource bs_apps;
        private System.Windows.Forms.Button bt_app_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appimmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appclasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appdescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_add_app;
    }
}
