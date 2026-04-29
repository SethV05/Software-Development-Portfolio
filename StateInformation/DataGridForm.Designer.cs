namespace SVassey_CPT_206_A80H_Lab_3
{
    partial class DataGridForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStates;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageTechJobsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDBDataSet = new SVassey_CPT_206_A80H_Lab_3.StateDBDataSet();
            this.stateDataTableAdapter = new SVassey_CPT_206_A80H_Lab_3.StateDBDataSetTableAdapters.StateDataTableAdapter();
            this.toolTipDatabase = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "View Database";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(27, 110);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 24);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(110, 107);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 32);
            this.txtSearch.TabIndex = 2;
            this.toolTipDatabase.SetToolTip(this.txtSearch, "Enter state name");
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(394, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.toolTipDatabase.SetToolTip(this.btnSearch, "Search the table for a state");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(534, 105);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.toolTipDatabase.SetToolTip(this.btnClear, "Clear selected entry in the table");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(902, 106);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 34);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "&Save Changes";
            this.toolTipDatabase.SetToolTip(this.btnSaveChanges, "Save your changes");
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(742, 105);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(138, 34);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "&Delete Selected";
            this.toolTipDatabase.SetToolTip(this.btnDeleteSelected, "Delete selected entry in the table");
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(924, 54);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.toolTipDatabase.SetToolTip(this.btnClose, "Exit to home");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStates
            // 
            this.dgvStates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStates.AutoGenerateColumns = false;
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stateNameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.flagDescriptionDataGridViewTextBoxColumn,
            this.flowerDataGridViewTextBoxColumn,
            this.birdDataGridViewTextBoxColumn,
            this.colorsDataGridViewTextBoxColumn,
            this.largestCitiesDataGridViewTextBoxColumn,
            this.capitolDataGridViewTextBoxColumn,
            this.medianIncomeDataGridViewTextBoxColumn,
            this.percentageTechJobsDataGridViewTextBoxColumn});
            this.dgvStates.DataSource = this.stateDataBindingSource;
            this.dgvStates.Location = new System.Drawing.Point(18, 147);
            this.dgvStates.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.RowHeadersWidth = 51;
            this.dgvStates.RowTemplate.Height = 24;
            this.dgvStates.Size = new System.Drawing.Size(1046, 360);
            this.dgvStates.TabIndex = 8;
            this.dgvStates.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.stateDataDataGridView_CellValidating);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "State_Name";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "State Name";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // flagDescriptionDataGridViewTextBoxColumn
            // 
            this.flagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Flag_Description";
            this.flagDescriptionDataGridViewTextBoxColumn.HeaderText = "Flag Description";
            this.flagDescriptionDataGridViewTextBoxColumn.Name = "flagDescriptionDataGridViewTextBoxColumn";
            // 
            // flowerDataGridViewTextBoxColumn
            // 
            this.flowerDataGridViewTextBoxColumn.DataPropertyName = "Flower";
            this.flowerDataGridViewTextBoxColumn.HeaderText = "Flower";
            this.flowerDataGridViewTextBoxColumn.Name = "flowerDataGridViewTextBoxColumn";
            // 
            // birdDataGridViewTextBoxColumn
            // 
            this.birdDataGridViewTextBoxColumn.DataPropertyName = "Bird";
            this.birdDataGridViewTextBoxColumn.HeaderText = "Bird";
            this.birdDataGridViewTextBoxColumn.Name = "birdDataGridViewTextBoxColumn";
            // 
            // colorsDataGridViewTextBoxColumn
            // 
            this.colorsDataGridViewTextBoxColumn.DataPropertyName = "Colors";
            this.colorsDataGridViewTextBoxColumn.HeaderText = "Colors";
            this.colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
            // 
            // largestCitiesDataGridViewTextBoxColumn
            // 
            this.largestCitiesDataGridViewTextBoxColumn.DataPropertyName = "Largest_Cities";
            this.largestCitiesDataGridViewTextBoxColumn.HeaderText = "Largest Cities";
            this.largestCitiesDataGridViewTextBoxColumn.Name = "largestCitiesDataGridViewTextBoxColumn";
            // 
            // capitolDataGridViewTextBoxColumn
            // 
            this.capitolDataGridViewTextBoxColumn.DataPropertyName = "Capitol";
            this.capitolDataGridViewTextBoxColumn.HeaderText = "Capitol";
            this.capitolDataGridViewTextBoxColumn.Name = "capitolDataGridViewTextBoxColumn";
            // 
            // medianIncomeDataGridViewTextBoxColumn
            // 
            this.medianIncomeDataGridViewTextBoxColumn.DataPropertyName = "Median_Income";
            this.medianIncomeDataGridViewTextBoxColumn.HeaderText = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.Name = "medianIncomeDataGridViewTextBoxColumn";
            // 
            // percentageTechJobsDataGridViewTextBoxColumn
            // 
            this.percentageTechJobsDataGridViewTextBoxColumn.DataPropertyName = "Percentage_Tech_Jobs";
            this.percentageTechJobsDataGridViewTextBoxColumn.HeaderText = "Tech Jobs %";
            this.percentageTechJobsDataGridViewTextBoxColumn.Name = "percentageTechJobsDataGridViewTextBoxColumn";
            // 
            // stateDataBindingSource
            // 
            this.stateDataBindingSource.DataMember = "StateData";
            this.stateDataBindingSource.DataSource = this.stateDBDataSetBindingSource;
            // 
            // stateDBDataSetBindingSource
            // 
            this.stateDBDataSetBindingSource.DataSource = this.stateDBDataSet;
            this.stateDBDataSetBindingSource.Position = 0;
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateDataTableAdapter
            // 
            this.stateDataTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1089, 528);
            this.Controls.Add(this.dgvStates);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.BindingSource stateDBDataSetBindingSource;
        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateDataBindingSource;
        private StateDBDataSetTableAdapters.StateDataTableAdapter stateDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn largestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageTechJobsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTipDatabase;
    }
}
