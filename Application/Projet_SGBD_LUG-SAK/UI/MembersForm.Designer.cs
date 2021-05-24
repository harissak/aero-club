
namespace UI
{
    partial class MembersForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMembersScreen = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.dgwShowMembers = new System.Windows.Forms.DataGridView();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.membersDataSet = new UI.MembersDataSet();
            this.mbrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mbrTableAdapter = new UI.MembersDataSetTableAdapters.MbrTableAdapter();
            this.mbrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelMembersScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMembersScreen
            // 
            this.panelMembersScreen.Controls.Add(this.btnAddMember);
            this.panelMembersScreen.Controls.Add(this.btnSearch);
            this.panelMembersScreen.Controls.Add(this.tbMemberID);
            this.panelMembersScreen.Controls.Add(this.label1);
            this.panelMembersScreen.Controls.Add(this.tbMemberName);
            this.panelMembersScreen.Controls.Add(this.dgwShowMembers);
            this.panelMembersScreen.Controls.Add(this.lblMemberID);
            this.panelMembersScreen.Controls.Add(this.lblMemberName);
            this.panelMembersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMembersScreen.Location = new System.Drawing.Point(0, 0);
            this.panelMembersScreen.Name = "panelMembersScreen";
            this.panelMembersScreen.Size = new System.Drawing.Size(935, 758);
            this.panelMembersScreen.TabIndex = 0;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(536, 132);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(149, 32);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add new member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.addNewMember);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchMember);
            // 
            // tbMemberID
            // 
            this.tbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberID.Location = new System.Drawing.Point(184, 68);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(212, 26);
            this.tbMemberID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberName.Location = new System.Drawing.Point(184, 26);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(212, 26);
            this.tbMemberName.TabIndex = 9;
            // 
            // dgwShowMembers
            // 
            this.dgwShowMembers.AutoGenerateColumns = false;
            this.dgwShowMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mbrIDDataGridViewTextBoxColumn,
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
            this.dgwShowMembers.DataSource = this.mbrBindingSource;
            this.dgwShowMembers.Location = new System.Drawing.Point(64, 184);
            this.dgwShowMembers.Name = "dgwShowMembers";
            this.dgwShowMembers.RowHeadersWidth = 51;
            this.dgwShowMembers.RowTemplate.Height = 24;
            this.dgwShowMembers.Size = new System.Drawing.Size(851, 559);
            this.dgwShowMembers.TabIndex = 6;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(27, 74);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(113, 20);
            this.lblMemberID.TabIndex = 8;
            this.lblMemberID.Text = "Member ID: ";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(27, 26);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(139, 20);
            this.lblMemberName.TabIndex = 7;
            this.lblMemberName.Text = "Member name: ";
            // 
            // membersDataSet
            // 
            this.membersDataSet.DataSetName = "MembersDataSet";
            this.membersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbrBindingSource
            // 
            this.mbrBindingSource.DataMember = "Mbr";
            this.mbrBindingSource.DataSource = this.membersDataSet;
            // 
            // mbrTableAdapter
            // 
            this.mbrTableAdapter.ClearBeforeFill = true;
            // 
            // mbrIDDataGridViewTextBoxColumn
            // 
            this.mbrIDDataGridViewTextBoxColumn.DataPropertyName = "Mbr_ID";
            this.mbrIDDataGridViewTextBoxColumn.HeaderText = "Mbr_ID";
            this.mbrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrIDDataGridViewTextBoxColumn.Name = "mbrIDDataGridViewTextBoxColumn";
            this.mbrIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mbrIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrnomDataGridViewTextBoxColumn
            // 
            this.mbrnomDataGridViewTextBoxColumn.DataPropertyName = "Mbr_nom";
            this.mbrnomDataGridViewTextBoxColumn.HeaderText = "Mbr_nom";
            this.mbrnomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnomDataGridViewTextBoxColumn.Name = "mbrnomDataGridViewTextBoxColumn";
            this.mbrnomDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrprenomDataGridViewTextBoxColumn
            // 
            this.mbrprenomDataGridViewTextBoxColumn.DataPropertyName = "Mbr_prenom";
            this.mbrprenomDataGridViewTextBoxColumn.HeaderText = "Mbr_prenom";
            this.mbrprenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrprenomDataGridViewTextBoxColumn.Name = "mbrprenomDataGridViewTextBoxColumn";
            this.mbrprenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrsexeDataGridViewTextBoxColumn
            // 
            this.mbrsexeDataGridViewTextBoxColumn.DataPropertyName = "Mbr_sexe";
            this.mbrsexeDataGridViewTextBoxColumn.HeaderText = "Mbr_sexe";
            this.mbrsexeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrsexeDataGridViewTextBoxColumn.Name = "mbrsexeDataGridViewTextBoxColumn";
            this.mbrsexeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrnaissDataGridViewTextBoxColumn
            // 
            this.mbrnaissDataGridViewTextBoxColumn.DataPropertyName = "Mbr_naiss";
            this.mbrnaissDataGridViewTextBoxColumn.HeaderText = "Mbr_naiss";
            this.mbrnaissDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnaissDataGridViewTextBoxColumn.Name = "mbrnaissDataGridViewTextBoxColumn";
            this.mbrnaissDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbradrsDataGridViewTextBoxColumn
            // 
            this.mbradrsDataGridViewTextBoxColumn.DataPropertyName = "Mbr_adrs";
            this.mbradrsDataGridViewTextBoxColumn.HeaderText = "Mbr_adrs";
            this.mbradrsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbradrsDataGridViewTextBoxColumn.Name = "mbradrsDataGridViewTextBoxColumn";
            this.mbradrsDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrnumboiteDataGridViewTextBoxColumn
            // 
            this.mbrnumboiteDataGridViewTextBoxColumn.DataPropertyName = "Mbr_num_boite";
            this.mbrnumboiteDataGridViewTextBoxColumn.HeaderText = "Mbr_num_boite";
            this.mbrnumboiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrnumboiteDataGridViewTextBoxColumn.Name = "mbrnumboiteDataGridViewTextBoxColumn";
            this.mbrnumboiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrcpDataGridViewTextBoxColumn
            // 
            this.mbrcpDataGridViewTextBoxColumn.DataPropertyName = "Mbr_cp";
            this.mbrcpDataGridViewTextBoxColumn.HeaderText = "Mbr_cp";
            this.mbrcpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrcpDataGridViewTextBoxColumn.Name = "mbrcpDataGridViewTextBoxColumn";
            this.mbrcpDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrlocDataGridViewTextBoxColumn
            // 
            this.mbrlocDataGridViewTextBoxColumn.DataPropertyName = "Mbr_loc";
            this.mbrlocDataGridViewTextBoxColumn.HeaderText = "Mbr_loc";
            this.mbrlocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrlocDataGridViewTextBoxColumn.Name = "mbrlocDataGridViewTextBoxColumn";
            this.mbrlocDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrmailDataGridViewTextBoxColumn
            // 
            this.mbrmailDataGridViewTextBoxColumn.DataPropertyName = "Mbr_mail";
            this.mbrmailDataGridViewTextBoxColumn.HeaderText = "Mbr_mail";
            this.mbrmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrmailDataGridViewTextBoxColumn.Name = "mbrmailDataGridViewTextBoxColumn";
            this.mbrmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrfixtelDataGridViewTextBoxColumn
            // 
            this.mbrfixtelDataGridViewTextBoxColumn.DataPropertyName = "Mbr_fix_tel";
            this.mbrfixtelDataGridViewTextBoxColumn.HeaderText = "Mbr_fix_tel";
            this.mbrfixtelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrfixtelDataGridViewTextBoxColumn.Name = "mbrfixtelDataGridViewTextBoxColumn";
            this.mbrfixtelDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrgsmDataGridViewTextBoxColumn
            // 
            this.mbrgsmDataGridViewTextBoxColumn.DataPropertyName = "Mbr_gsm";
            this.mbrgsmDataGridViewTextBoxColumn.HeaderText = "Mbr_gsm";
            this.mbrgsmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrgsmDataGridViewTextBoxColumn.Name = "mbrgsmDataGridViewTextBoxColumn";
            this.mbrgsmDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrcotvalideDataGridViewTextBoxColumn
            // 
            this.mbrcotvalideDataGridViewTextBoxColumn.DataPropertyName = "Mbr_cot_valide";
            this.mbrcotvalideDataGridViewTextBoxColumn.HeaderText = "Mbr_cot_valide";
            this.mbrcotvalideDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrcotvalideDataGridViewTextBoxColumn.Name = "mbrcotvalideDataGridViewTextBoxColumn";
            this.mbrcotvalideDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbrestpilDataGridViewCheckBoxColumn
            // 
            this.mbrestpilDataGridViewCheckBoxColumn.DataPropertyName = "Mbr_est_pil";
            this.mbrestpilDataGridViewCheckBoxColumn.HeaderText = "Mbr_est_pil";
            this.mbrestpilDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mbrestpilDataGridViewCheckBoxColumn.Name = "mbrestpilDataGridViewCheckBoxColumn";
            this.mbrestpilDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mbrestadmDataGridViewCheckBoxColumn
            // 
            this.mbrestadmDataGridViewCheckBoxColumn.DataPropertyName = "Mbr_est_adm";
            this.mbrestadmDataGridViewCheckBoxColumn.HeaderText = "Mbr_est_adm";
            this.mbrestadmDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mbrestadmDataGridViewCheckBoxColumn.Name = "mbrestadmDataGridViewCheckBoxColumn";
            this.mbrestadmDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mbrpasswDataGridViewTextBoxColumn
            // 
            this.mbrpasswDataGridViewTextBoxColumn.DataPropertyName = "Mbr_passw";
            this.mbrpasswDataGridViewTextBoxColumn.HeaderText = "Mbr_passw";
            this.mbrpasswDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbrpasswDataGridViewTextBoxColumn.Name = "mbrpasswDataGridViewTextBoxColumn";
            this.mbrpasswDataGridViewTextBoxColumn.Width = 125;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 758);
            this.Controls.Add(this.panelMembersScreen);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.panelMembersScreen.ResumeLayout(false);
            this.panelMembersScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbrBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMembersScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.DataGridView dgwShowMembers;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnAddMember;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MembersDataSet membersDataSet;
        private System.Windows.Forms.BindingSource mbrBindingSource;
        private MembersDataSetTableAdapters.MbrTableAdapter mbrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbrIDDataGridViewTextBoxColumn;
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