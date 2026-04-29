using StateLibrary;

namespace SVassey_CPT_206_A80H_Lab_3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Button btnStateInformation;
        private System.Windows.Forms.Button btnViewStateData;
        private System.Windows.Forms.Button btnClose;

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateDataBindingSource;
        private StateDBDataSetTableAdapters.StateDataTableAdapter stateDataTableAdapter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.btnStateInformation = new System.Windows.Forms.Button();
            this.btnViewStateData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.stateDBDataSet = new SVassey_CPT_206_A80H_Lab_3.StateDBDataSet();
            this.stateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDataTableAdapter = new SVassey_CPT_206_A80H_Lab_3.StateDBDataSetTableAdapters.StateDataTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipMainMenu = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "State Population Database";
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxStates.Location = new System.Drawing.Point(244, 155);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(300, 29);
            this.comboBoxStates.TabIndex = 1;
            this.toolTipMainMenu.SetToolTip(this.comboBoxStates, "Select a state!");
            // 
            // btnStateInformation
            // 
            this.btnStateInformation.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStateInformation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStateInformation.Location = new System.Drawing.Point(177, 258);
            this.btnStateInformation.Name = "btnStateInformation";
            this.btnStateInformation.Size = new System.Drawing.Size(160, 64);
            this.btnStateInformation.TabIndex = 2;
            this.btnStateInformation.Text = "&State Selected State";
            this.toolTipMainMenu.SetToolTip(this.btnStateInformation, "View the selected states data!");
            this.btnStateInformation.UseVisualStyleBackColor = false;
            this.btnStateInformation.Click += new System.EventHandler(this.btnStateInformation_Click);
            // 
            // btnViewStateData
            // 
            this.btnViewStateData.BackColor = System.Drawing.Color.Cyan;
            this.btnViewStateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStateData.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStateData.Location = new System.Drawing.Point(352, 258);
            this.btnViewStateData.Name = "btnViewStateData";
            this.btnViewStateData.Size = new System.Drawing.Size(160, 64);
            this.btnViewStateData.TabIndex = 3;
            this.btnViewStateData.Text = "&View State Data";
            this.toolTipMainMenu.SetToolTip(this.btnViewStateData, "View all the states data!");
            this.btnViewStateData.UseVisualStyleBackColor = false;
            this.btnViewStateData.Click += new System.EventHandler(this.btnViewStateData_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(268, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 64);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Exit";
            this.toolTipMainMenu.SetToolTip(this.btnClose, "Exit the applicaiton!");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateDataBindingSource
            // 
            this.stateDataBindingSource.DataMember = "StateData";
            this.stateDataBindingSource.DataSource = this.stateDBDataSet;
            // 
            // stateDataTableAdapter
            // 
            this.stateDataTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "State List:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStateInformation;
            this.BackColor = System.Drawing.Color.Bisque;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.btnStateInformation);
            this.Controls.Add(this.btnViewStateData);
            this.Controls.Add(this.btnClose);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu SVassey Lab 3 ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipMainMenu;
    }
}
