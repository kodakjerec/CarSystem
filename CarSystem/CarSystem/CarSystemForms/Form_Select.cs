using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarSystem
{
    public partial class FormSelect : Form
    {
        //選定值
        private string _SelectedValue = "";
        public string SelectedValue 
        {
            get { return _SelectedValue; }
            set { _SelectedValue = value; lbl_Selected.Text = value; }
        }

        public FormSelect()
        {
            InitializeComponent();
        }
        public FormSelect(DataTable dt, string OriginKey)
        {
            InitializeComponent();

            SelectedValue = OriginKey;
            dgv_SelectList.DataSource = dt;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_SelectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgv_SelectList.DataSource;
            SelectedValue = dt.Rows[e.RowIndex][0].ToString();
        }
    }
}
