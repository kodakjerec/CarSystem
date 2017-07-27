using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class Form6_1_MultiMerdid : Car_Fun.CarSystem_Sample_Form
    {
        public int SelectIndex = 0;
        public Form6_1_MultiMerdid()
        {
            InitializeComponent();
        }

        public Form6_1_MultiMerdid(DataTable dt)
        {
            InitializeComponent();
            dataGridView_CrePage.AutoGenerateColumns = false;
            dataGridView_CrePage.DataSource = dt;
        }

        private void dataGridView_CrePage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            SelectIndex = e.RowIndex;
            this.Close();
        }

        private void Form6_1_MultiMerdid_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);

            SetMasterBindingNavigator(null);
            SetButtonEnable("L");
        }
    }
}
