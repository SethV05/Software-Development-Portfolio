/*
 * Seth Vassey
 * CPT-206 A80H
 * Lab 3
 */
using System;
using System.Windows.Forms;

namespace SVassey_CPT_206_A80H_Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Refresh dropdown anytime you come back to MainForm
            this.Activated += MainForm_Activated;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshStatesDropdown();
        }


        // When you return from all other forms it reloads dropdown
        private void MainForm_Activated(object sender, EventArgs e)
        {
            RefreshStatesDropdown();
        }

        private void RefreshStatesDropdown()
        {
            // Save what user selected
            string previous = comboBoxStates.Text;

            // Reload data
            this.stateDataTableAdapter.Fill(this.stateDBDataSet.StateData);

            // Bind dropdown
            comboBoxStates.DataSource = stateDataBindingSource;
            comboBoxStates.DisplayMember = "State_Name";
            comboBoxStates.ValueMember = "State_Name";

            // Restore selection
            if (!string.IsNullOrWhiteSpace(previous))
            {
                comboBoxStates.SelectedValue = previous;
            }
        }
        private void btnStateInformation_Click(object sender, EventArgs e)
        {
            string selectedState = comboBoxStates.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedState))
            {
                MessageBox.Show("Please select a state first.");
                return;
            }

            using (StateInformationForm frm = new StateInformationForm(selectedState))
            {
                frm.ShowDialog();
            }
        }

        private void btnViewStateData_Click(object sender, EventArgs e)
        {
            using (DataGridForm frm = new DataGridForm())
            {
                frm.ShowDialog();
            }

            // Refresh immediately after closing database form
            RefreshStatesDropdown();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
