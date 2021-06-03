
namespace UI.User_control
{
    partial class uc_mbrList
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
            this.dgvMbrList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.bs_members_list = new System.Windows.Forms.BindingSource(this.components);
            this.Mbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrprenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrsexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrnaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbradrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrnumboiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrcpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrlocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrfixtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrgsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrcotvalideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbrestpilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mbrestadmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mbrpasswDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_members_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMbrList
            // 
            this.dgvMbrList.AutoGenerateColumns = false;
            this.dgvMbrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMbrList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mbr_ID,
            this.mbrnomDataGridViewTextBoxColumn,
            this.mbrprenomDataGridViewTextBoxColumn,
            this.mbrsexeDataGridViewTextBoxColumn,
            this.mbrnaissDataGridViewTextBoxColumn,
            this.mbradrsDataGridViewTextBoxColumn,
            this.mbrnumboiteDataGridViewTextBoxColumn,
            this.mbrcpDataGridViewTextBoxColumn,
            this.mbrlocDataGridViewTextBoxColumn,
            this.mbrmailDataGridViewTextBoxColumn,
            this.mbrfixtelDataGridViewTextBoxColumn,
            this.mbrgsmDataGridViewTextBoxColumn,
            this.mbrcotvalideDataGridViewTextBoxColumn,
            this.mbrestpilDataGridViewCheckBoxColumn,
            this.mbrestadmDataGridViewCheckBoxColumn,
            this.mbrpasswDataGridViewTextBoxColumn});
            this.dgvMbrList.DataSource = this.bs_members_list;
            this.dgvMbrList.Location = new System.Drawing.Point(5, 162);
            this.dgvMbrList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMbrList.Name = "dgvMbrList";
            this.dgvMbrList.RowHeadersWidth = 51;
            this.dgvMbrList.RowTemplate.Height = 24;
            this.dgvMbrList.Size = new System.Drawing.Size(853, 564);
            this.dgvMbrList.TabIndex = 0;
            this.dgvMbrList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemCliked);
            this.dgvMbrList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMbrList_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMemberID
            // 
            this.tbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberID.Location = new System.Drawing.Point(187, 57);
            this.tbMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(212, 26);
            this.tbMemberID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberName.Location = new System.Drawing.Point(187, 14);
            this.tbMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(212, 26);
            this.tbMemberName.TabIndex = 15;
            // 
            // bs_members_list
            // 
            this.bs_members_list.DataSource = typeof(DTO.MBR);
            // 
            // Mbr_ID
            // 
            this.Mbr_ID.DataPropertyName = "Mbr_ID";
            this.Mbr_ID.HeaderText = "Mbr_ID";
            this.Mbr_ID.MinimumWidth = 6;
            this.Mbr_ID.Name = "Mbr_ID";
            this.Mbr_ID.Width = 125;
            // 
            // mbrnomDataGridViewTextBoxColumn
            // 
            this.mbrnomDataGridViewTextBoxColumn.DataPropertyName = "Mbr_nom";
            this.mbrnomDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.mbrnomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnomDataGridViewTextBoxColumn.Name = "mbrnomDataGridViewTextBoxColumn";
            this.mbrnomDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrprenomDataGridViewTextBoxColumn
            // 
            this.mbrprenomDataGridViewTextBoxColumn.DataPropertyName = "Mbr_prenom";
            this.mbrprenomDataGridViewTextBoxColumn.HeaderText = "PRÉNOM";
            this.mbrprenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrprenomDataGridViewTextBoxColumn.Name = "mbrprenomDataGridViewTextBoxColumn";
            this.mbrprenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrsexeDataGridViewTextBoxColumn
            // 
            this.mbrsexeDataGridViewTextBoxColumn.DataPropertyName = "Mbr_sexe";
            this.mbrsexeDataGridViewTextBoxColumn.HeaderText = "SEX";
            this.mbrsexeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrsexeDataGridViewTextBoxColumn.Name = "mbrsexeDataGridViewTextBoxColumn";
            this.mbrsexeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrnaissDataGridViewTextBoxColumn
            // 
            this.mbrnaissDataGridViewTextBoxColumn.DataPropertyName = "Mbr_naiss";
            this.mbrnaissDataGridViewTextBoxColumn.HeaderText = "DATE DE NAISSANCE";
            this.mbrnaissDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnaissDataGridViewTextBoxColumn.Name = "mbrnaissDataGridViewTextBoxColumn";
            this.mbrnaissDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbradrsDataGridViewTextBoxColumn
            // 
            this.mbradrsDataGridViewTextBoxColumn.DataPropertyName = "Mbr_adrs";
            this.mbradrsDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.mbradrsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbradrsDataGridViewTextBoxColumn.Name = "mbradrsDataGridViewTextBoxColumn";
            this.mbradrsDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrnumboiteDataGridViewTextBoxColumn
            // 
            this.mbrnumboiteDataGridViewTextBoxColumn.DataPropertyName = "Mbr_num_boite";
            this.mbrnumboiteDataGridViewTextBoxColumn.HeaderText = "NUMERO DE BOITS";
            this.mbrnumboiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnumboiteDataGridViewTextBoxColumn.Name = "mbrnumboiteDataGridViewTextBoxColumn";
            this.mbrnumboiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrcpDataGridViewTextBoxColumn
            // 
            this.mbrcpDataGridViewTextBoxColumn.DataPropertyName = "Mbr_cp";
            this.mbrcpDataGridViewTextBoxColumn.HeaderText = "CODE POSTAL";
            this.mbrcpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrcpDataGridViewTextBoxColumn.Name = "mbrcpDataGridViewTextBoxColumn";
            this.mbrcpDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrlocDataGridViewTextBoxColumn
            // 
            this.mbrlocDataGridViewTextBoxColumn.DataPropertyName = "Mbr_loc";
            this.mbrlocDataGridViewTextBoxColumn.HeaderText = "VILLE";
            this.mbrlocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrlocDataGridViewTextBoxColumn.Name = "mbrlocDataGridViewTextBoxColumn";
            this.mbrlocDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrmailDataGridViewTextBoxColumn
            // 
            this.mbrmailDataGridViewTextBoxColumn.DataPropertyName = "Mbr_mail";
            this.mbrmailDataGridViewTextBoxColumn.HeaderText = "E MAIL";
            this.mbrmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrmailDataGridViewTextBoxColumn.Name = "mbrmailDataGridViewTextBoxColumn";
            this.mbrmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrfixtelDataGridViewTextBoxColumn
            // 
            this.mbrfixtelDataGridViewTextBoxColumn.DataPropertyName = "Mbr_fix_tel";
            this.mbrfixtelDataGridViewTextBoxColumn.HeaderText = "TÉLÉPHONE FIXE";
            this.mbrfixtelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrfixtelDataGridViewTextBoxColumn.Name = "mbrfixtelDataGridViewTextBoxColumn";
            this.mbrfixtelDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrgsmDataGridViewTextBoxColumn
            // 
            this.mbrgsmDataGridViewTextBoxColumn.DataPropertyName = "Mbr_gsm";
            this.mbrgsmDataGridViewTextBoxColumn.HeaderText = "GSM";
            this.mbrgsmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrgsmDataGridViewTextBoxColumn.Name = "mbrgsmDataGridViewTextBoxColumn";
            this.mbrgsmDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrcotvalideDataGridViewTextBoxColumn
            // 
            this.mbrcotvalideDataGridViewTextBoxColumn.DataPropertyName = "Mbr_cot_valide";
            this.mbrcotvalideDataGridViewTextBoxColumn.HeaderText = "COTISATION";
            this.mbrcotvalideDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrcotvalideDataGridViewTextBoxColumn.Name = "mbrcotvalideDataGridViewTextBoxColumn";
            this.mbrcotvalideDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrestpilDataGridViewCheckBoxColumn
            // 
            this.mbrestpilDataGridViewCheckBoxColumn.DataPropertyName = "Mbr_est_pil";
            this.mbrestpilDataGridViewCheckBoxColumn.HeaderText = "MBR EST PILOT";
            this.mbrestpilDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mbrestpilDataGridViewCheckBoxColumn.Name = "mbrestpilDataGridViewCheckBoxColumn";
            this.mbrestpilDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mbrestadmDataGridViewCheckBoxColumn
            // 
            this.mbrestadmDataGridViewCheckBoxColumn.DataPropertyName = "Mbr_est_adm";
            this.mbrestadmDataGridViewCheckBoxColumn.HeaderText = "MBR EST ADMIN";
            this.mbrestadmDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mbrestadmDataGridViewCheckBoxColumn.Name = "mbrestadmDataGridViewCheckBoxColumn";
            this.mbrestadmDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mbrpasswDataGridViewTextBoxColumn
            // 
            this.mbrpasswDataGridViewTextBoxColumn.DataPropertyName = "Mbr_passw";
            this.mbrpasswDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.mbrpasswDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrpasswDataGridViewTextBoxColumn.Name = "mbrpasswDataGridViewTextBoxColumn";
            this.mbrpasswDataGridViewTextBoxColumn.Width = 125;
            // 
            // uc_mbrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.dgvMbrList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_mbrList";
            this.Size = new System.Drawing.Size(861, 730);
            this.Load += new System.EventHandler(this.ucRech_mbr);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMbrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_members_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMbrList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.BindingSource bs_members_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrprenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrsexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbradrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrnumboiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrcpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrlocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrfixtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrgsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrcotvalideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mbrestpilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mbrestadmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrpasswDataGridViewTextBoxColumn;
    }
}
