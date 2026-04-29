/*
 * Seth Vassey
 * CPT-206 A80H
 * Lab 3
 */
using StateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SVassey_CPT_206_A80H_Lab_3
{
    public partial class StateInformationForm : Form
    {
        private readonly string _stateName;

        private readonly StateDBDataSet _ds = new StateDBDataSet();
        private readonly StateDBDataSetTableAdapters.StateDataTableAdapter _ta =
        new StateDBDataSetTableAdapters.StateDataTableAdapter();
        private readonly BindingSource _bs = new BindingSource();

        public StateInformationForm()
        {
            InitializeComponent();
            _stateName = "";
        }

        // constructor used when opening from MainForm
        public StateInformationForm(string stateName) : this()
        {
            _stateName = stateName ?? "";
        }

        private void StateInformationForm_Load(object sender, EventArgs e)
        {
            // Load data from database
            _ta.Fill(_ds.StateData);

            // Find the selected state row
            var row = _ds.StateData
                         .FirstOrDefault(r => r.State_Name == _stateName);

            if (row == null)
            {
                MessageBox.Show("State not found.");
                return;
            }

            State state = new State
            {
                State_Name = row.State_Name,
                Population = row.Population,
                Flag_Description = row.Flag_Description,
                Flower = row.Flower,
                Bird = row.Bird,
                Colors = row.Colors,
                Largest_Cities = row.Largest_Cities,
                Capitol = row.Capitol,
                Median_Income = row.Median_Income,
                Percentage_Tech_Jobs = row.Percentage_Tech_Jobs
            };

            // Show state name in label
            lblStateName.Text = state.State_Name;

            // Bind grid
            BindingSource bs = new BindingSource();
            bs.DataSource = new List<State> { state };

            dgvOneState.DataSource = bs;

            dgvOneState.ReadOnly = true;
            dgvOneState.AllowUserToAddRows = false;
            dgvOneState.AllowUserToDeleteRows = false;
            dgvOneState.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
