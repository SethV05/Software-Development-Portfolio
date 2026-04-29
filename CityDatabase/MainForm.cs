//Seth Vassey
//CPT-206-A80H
//Lab 2 CityDB

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVassey_CPT_206_A80H_Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
        }

        private void bntPopAsc_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopAsc(cityDBDataSet.City);
        }

        private void btnPopDesc_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopDesc(cityDBDataSet.City);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByGetTotal(cityDBDataSet.City);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByAvgPopulation(cityDBDataSet.City);

        }

        private void btnCityName_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCityName(cityDBDataSet.City);
        }

        private void btnMaxPop_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByMaxPopulation(cityDBDataSet.City);
        }

        private void btnMinPop_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByMinPopulation(cityDBDataSet.City);

        }

        private void BntExit_Click(object sender, EventArgs e)
        {
        
            if (MessageBox.Show("Exit the application?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cityDBDataSet.City.Clear();
            cityTableAdapter.Fill(cityDBDataSet.City);
        }
    }
}
