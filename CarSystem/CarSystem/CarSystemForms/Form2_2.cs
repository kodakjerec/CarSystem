using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;

namespace CarSystem
{
    public partial class Form2_2 : Car_Fun.CarSystem_Sample_Form
    {

        DataTable dt_ComboList = new DataTable();   //準備貼圖的座標清單

        public Form2_2()
        {
            InitializeComponent();
        }
        private void Form2_2_Load(object sender, EventArgs e)
        {
            base.New_WSC_DLL_Form_Load(sender, e);

            Login_Server = ConfigurationManager.AppSettings["DC"];
            SetMasterBindingNavigator(null);
            SetButtonEnable("L");

            lbl_StartXY.Text = "Stock";
            GetComboList(btn_Stock.Text);
            PrintButtonList();
        }

        #region Default
        protected override void NewButton_Click(object sender, EventArgs e)
        {
            //base.NewButton_Click(sender, e);
        }
        protected override void DelButton_Click(object sender, EventArgs e)
        {
            //base.DelButton_Click(sender, e);
        }
        #endregion

        #region 區域選擇按鈕
        //倉別選擇
        private void btn_Stock_Click(object sender, EventArgs e)
        {
            lbl_StartXY.Text = "Stock";

            //選擇區域
            DataTable dt = GetSelectList(lbl_StartXY.Text);
            FormSelect frm1 = new FormSelect(dt, btn_Stock.Text);
            frm1.ShowDialog();
            btn_Stock.Text = frm1.SelectedValue;

            GetComboList(btn_Stock.Text);
            PrintButtonList();
        }
        //走道選擇
        private void btn_Aisle_Click(object sender, EventArgs e)
        {
            lbl_StartXY.Text = "Aisle";

            DataTable dt = GetSelectList(lbl_StartXY.Text);
            FormSelect frm1 = new FormSelect(dt, btn_Aisle.Text);
            frm1.ShowDialog();
            btn_Aisle.Text = frm1.SelectedValue;

            GetComboList(btn_Aisle.Text);
            PrintButtonList();
        }
        //料架選擇
        private void btn_Location_Click(object sender, EventArgs e)
        {
            lbl_StartXY.Text = "Location";

            DataTable dt = GetSelectList(lbl_StartXY.Text);
            FormSelect frm1 = new FormSelect(dt, btn_Location.Text);
            frm1.ShowDialog();
            btn_Location.Text = frm1.SelectedValue;

            GetComboList(btn_Location.Text);
            PrintButtonList();
        }
        #endregion

        /// <summary>
        /// 儲位下拉是選單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_SlotID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = dt_ComboList.Rows[cmb_SlotID.SelectedIndex];
            lbl_L_sdXY_sysno.Text = dr["L_sdXY_sysno"].ToString();
            txb_X_pos.Text = dr["X_pos"].ToString();
            txb_Y_pos.Text = dr["Y_pos"].ToString();
            txb_X_width.Text = dr["X_width"].ToString();
            txb_Y_width.Text = dr["Y_width"].ToString();
        }

        /// <summary>
        /// 更新回資料庫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateXYposition(lbl_L_sdXY_sysno.Text
                            , txb_X_pos.Text
                            , txb_Y_pos.Text
                            , txb_X_width.Text
                            , txb_Y_width.Text);
            MessageBox.Show("OK");
        }

        private void MapBtnClick(object sender, EventArgs e)
        {
            Car_Fun.myButton btn = sender as Car_Fun.myButton;

            switch (lbl_StartXY.Text)
            {
                case "Stock":
                    lbl_StartXY.Text = "Aisle";
                    btn_Aisle.Text = btn.Text;
                    break;
                case "Aisle":
                    lbl_StartXY.Text = "Location";
                    btn_Location.Text = btn.Text;
                    break;
                case "Location":
                    lbl_StartXY.Text = "Bin";
                    break;
            }
            GetComboList(btn.Text);
            PrintButtonList();
        }

        /// <summary>
        /// 下拉是選單
        /// </summary>
        private void GetComboList(string KeyValue)
        {
            dt_ComboList = GetComboList(lbl_StartXY.Text, KeyValue);
            cmb_SlotID.DataSource = dt_ComboList;
        }

        /// <summary>
        /// 貼圖
        /// </summary>
        private void PrintButtonList()
        {
            //貼圖
            int X_POS = 0, Y_POS = 0, X_Width = 0, Y_Width = 0, i = 0;
            bool NoLeftButton = false;
            while (NoLeftButton == false)
            {
                NoLeftButton = true;
                foreach (Control con in this.Controls)
                {
                    if (con.Name.ToUpper().IndexOf("DT_COMBOLIST_BTN") >= 0)
                    {
                        Controls.Remove(con);
                        NoLeftButton = false;
                    }
                }
            }

            foreach (DataRow dr in dt_ComboList.Rows)
            {
                i++;
                X_POS = Convert.ToInt32(dr["X_POS"]);
                Y_POS = Convert.ToInt32(dr["Y_POS"]);
                X_Width = Convert.ToInt32(dr["X_Width"]);
                Y_Width = Convert.ToInt32(dr["Y_Width"]);
                if (X_POS > 0 || Y_POS > 0)
                {
                    Car_Fun.myButton btn = new Car_Fun.myButton();
                    btn.Name = "DT_COMBOLIST_BTN" + i.ToString();
                    btn.Text = dr["Name"].ToString();
                    btn.ForeColor = Color_tbFocus_ForeColor;
                    btn.BackColor = Color_tbFocus_BackColor;
                    btn.Size = new Size(X_Width, Y_Width);
                    btn.Location = new Point(lbl_StartXY.Location.X + X_POS, lbl_StartXY.Location.Y + Y_POS);
                    btn.Click += MapBtnClick;
                    this.Controls.Add(btn);
                }
            }
            this.Refresh();
        }

        #region SQL查詢

        #region Select
        /// <summary>
        /// 取得查詢清單
        /// </summary>
        /// <param name="Column">關鍵欄位</param>
        /// <returns></returns>
        private DataTable GetSelectList(string Column)
        {
            string query =
            @"Select DISTINCT " + Column + " as [Name] "
            + @" From CarSystem.dbo.CarSlodXYPosition ";
            switch (Column)
            {
                case "Stock":
                    query += " where MapType='Aisle' "; break;
                case "Aisle":
                    query += " where MapType='Location' "; break;
                case "Location":
                    query += " where MapType='Bin' "; break;

            }
            query += " order by [Name]";
            Hashtable ht = new Hashtable();
            DataTable dt = IO.SqlQuery(Login_Server, query, ht).Tables[0];
            return dt;
        }
        /// <summary>
        /// 取得下拉式清單
        /// </summary>
        /// <param name="Column"></param>
        /// <param name="Keyvalue"></param>
        /// <returns></returns>
        private DataTable GetComboList(string Column, string Keyvalue)
        {
            string KeyColumn = "";
            switch (Column)
            {
                case "Stock":
                    KeyColumn = "Aisle"; break;
                case "Aisle":
                    KeyColumn = "Location"; break;
                case "Location":
                    KeyColumn = "Bin"; break;

            }

            string query =
            "Select " + KeyColumn + @" as [Name], X_pos, Y_pos, X_width, Y_width, L_sdXY_sysno 
             From CarSystem.dbo.CarSlodXYPosition ";
            query += " where " + Column + "=@Keyvalue";
            query += " and MapType=@KeyColumn ";
            query += " order by [Name]";
            Hashtable ht = new Hashtable();
            ht.Add("@Keyvalue", Keyvalue);
            ht.Add("@KeyColumn", KeyColumn);
            DataTable dt = IO.SqlQuery(Login_Server, query, ht).Tables[0];
            return dt;
        }
        #endregion

        #region Update
        private void UpdateXYposition(string sysno, string X_pos, string Y_pos, string X_width, string Y_width)
        {
            string query =
            @"Update CarSystem.dbo.CarSlodXYPosition 
            set X_pos=@X_pos, Y_pos=@Y_pos, X_width=@X_width, Y_width=@Y_width 
            where L_sdXY_sysno=@sysno";

            int SuccessCount = 0;
            Hashtable ht = new Hashtable();
            ht.Add("@X_pos", X_pos);
            ht.Add("@Y_pos", Y_pos);
            ht.Add("@X_width", X_width);
            ht.Add("@Y_width", Y_width);
            ht.Add("@sysno", sysno);
            IO.SqlUpdate(Login_Server, query, ht, ref SuccessCount);
        }
        #endregion

        #endregion

    }
}
