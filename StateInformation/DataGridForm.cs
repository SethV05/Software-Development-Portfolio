/*
 * Seth Vassey
 * CPT-206 A80H
 * Lab 3
 */
using StateLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SVassey_CPT_206_A80H_Lab_3
{
    public partial class DataGridForm : Form
    {
        // Holds in-memory state data
        private readonly StateDBDataSet _ds = new StateDBDataSet();

        // Handles database read/write operations
        private readonly StateDBDataSetTableAdapters.StateDataTableAdapter _ta =
            new StateDBDataSetTableAdapters.StateDataTableAdapter();

        // Manages binding, filtering, and editing
        private readonly BindingSource _bs = new BindingSource();

        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            // Load data from database into dataset
            this.stateDataTableAdapter.Fill(this.stateDBDataSet.StateData);
            _ta.Fill(_ds.StateData);

            // Bind dataset to grid through BindingSource
            _bs.DataSource = _ds.StateData;
            dgvStates.DataSource = _bs;

            dgvStates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStates.MultiSelect = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get search text safely
            string text = (txtSearch.Text ?? "").Replace("'", "''").Trim();

            // Show all records if search is empty
            if (string.IsNullOrWhiteSpace(text))
            {
                _bs.RemoveFilter();
                return;
            }

            // Build filter that searches all columns
            DataTable table = _ds.StateData;
            List<string> parts = new List<string>();

            foreach (DataColumn c in table.Columns)
                parts.Add($"Convert([{c.ColumnName}], 'System.String') LIKE '%{text}%'");

            // Apply filter
            _bs.Filter = string.Join(" OR ", parts);
        }

        // Reset search and show all records

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            _bs.RemoveFilter();
        }


        // Removes the currently selected row 
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (_bs.Current == null) return;
            _bs.RemoveCurrent();
        }


        // Saves all changes
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                _bs.EndEdit();

                int rows = _ta.Update(_ds.StateData);
                MessageBox.Show($"Saved. Rows affected: {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed:\n" + ex.Message);
            }
        }

        // Validations
        private void stateDataDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvStates.Rows[e.RowIndex].IsNewRow) return;

            string col = dgvStates.Columns[e.ColumnIndex].DataPropertyName;
            string val = (e.FormattedValue ?? "").ToString().Trim();

            // Allows punctuation
            bool IsSafeText(string s)
            {
                foreach (char c in s)
                {
                    if (char.IsLetterOrDigit(c)) continue;
                    if (char.IsWhiteSpace(c)) continue;
                    if (",.&/\\-'\"):;".Contains(c)) continue;

                    return false;
                }
                return true;
            }

      
            bool IsNameText(string s)
            {
                foreach (char c in s)
                {
                    if (char.IsLetter(c) || c == ' ' || c == '-' || c == '\'')
                        continue;
                    return false;
                }
                return true;
            }

            if (col == "State_Name")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("State Name is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("State Name cannot be only numbers."); e.Cancel = true; return; }
                if (!IsNameText(val)) { MessageBox.Show("State Name can only contain letters, spaces, hyphens, and apostrophes."); e.Cancel = true; return; }
                if (val.Length > 50) { MessageBox.Show("State Name must be 50 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Population")
            {
                if (!long.TryParse(val, out long p) || p < 0) { MessageBox.Show("Population must be a non-negative whole number."); e.Cancel = true; return; }
                return;
            }

            if (col == "Flag_Description")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Flag Description is required."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Flag Description contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 500) { MessageBox.Show("Flag Description must be 500 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Flower")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Flower is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("Flower cannot be only numbers."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Flower contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 50) { MessageBox.Show("Flower must be 50 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Bird")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Bird is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("Bird cannot be only numbers."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Bird contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 50) { MessageBox.Show("Bird must be 50 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Colors")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Colors is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("Colors cannot be only numbers."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Colors contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 100) { MessageBox.Show("Colors must be 100 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Largest_Cities")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Largest Cities is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("Largest Cities cannot be only numbers."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Largest Cities contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 200) { MessageBox.Show("Largest Cities must be 200 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Capitol")
            {
                if (string.IsNullOrWhiteSpace(val)) { MessageBox.Show("Capitol is required."); e.Cancel = true; return; }
                if (long.TryParse(val, out _)) { MessageBox.Show("Capitol cannot be only numbers."); e.Cancel = true; return; }
                if (!IsSafeText(val)) { MessageBox.Show("Capitol contains an invalid character."); e.Cancel = true; return; }
                if (val.Length > 50) { MessageBox.Show("Capitol must be 50 characters or less."); e.Cancel = true; return; }
                return;
            }

            if (col == "Median_Income")
            {
                if (!int.TryParse(val, out int inc) || inc < 0) { MessageBox.Show("Median Income must be a non-negative whole number."); e.Cancel = true; return; }
                return;
            }

            if (col == "Percentage_Tech_Jobs")
            {
                if (!double.TryParse(val, out double pct) || pct < 0 || pct > 100) { MessageBox.Show("Tech Jobs % must be a number from 0 to 100."); e.Cancel = true; return; }
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
