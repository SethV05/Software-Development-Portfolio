namespace SVassey_CPT_206_A80H_Lab_3
{
    partial class StateInformationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.DataGridView dgvOneState;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStateName = new System.Windows.Forms.Label();
            this.dgvOneState = new System.Windows.Forms.DataGridView();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.stateDataTableAdapter = new SVassey_CPT_206_A80H_Lab_3.StateDBDataSetTableAdapters.StateDataTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipStateInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "State Information";
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateName.Location = new System.Drawing.Point(226, 107);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(20, 26);
            this.lblStateName.TabIndex = 1;
            this.lblStateName.Text = "-";
            // 
            // dgvOneState
            // 
            this.dgvOneState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOneState.AutoGenerateColumns = false;
            this.dgvOneState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOneState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvOneState.DataSource = this.stateDataBindingSource;
            this.dgvOneState.Location = new System.Drawing.Point(11, 145);
            this.dgvOneState.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOneState.Name = "dgvOneState";
            this.dgvOneState.RowHeadersWidth = 51;
            this.dgvOneState.RowTemplate.Height = 24;
            this.dgvOneState.Size = new System.Drawing.Size(1053, 271);
            this.dgvOneState.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(965, 420);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.toolTipStateInfo.SetToolTip(this.btnClose, "Return Back to Home");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // stateDataTableAdapter
            // 
            this.stateDataTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected State:";
            // 
            // StateInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1075, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOneState);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StateInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "State Details";
            this.Load += new System.EventHandler(this.StateInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneState)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipStateInfo;
    }
}
