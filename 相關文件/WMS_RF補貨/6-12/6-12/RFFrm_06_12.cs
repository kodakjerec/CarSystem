using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using mobileSDK.Common;
using mobileSDK.Common.Windows.Control;
using mobileSDK.Common.Windows.Data;
using mobileSDK.Common.Windows.UI.Controls;
using mobileSDK.WS_MLSJ;
using RF.app.RFForms;
using System.Collections;
using RF.app.Forms;
using System.Diagnostics;
using RF.app.Business;
using RF.app.Model;

using DataGridCustomColumns;


//歷史記錄
//1.00 00000000 lzx1995 新建頁面

//1.01 20160629 lzx1995 改checkbox為X:V
//1.02 20160711 lzx1995 补货单商品加入拼版明细变成可回库

namespace RF.app.RFForms
{
    public partial class RFFrm_06_12 : Form
    {       
        #region 頁面變數
        
        private Basmodule _bm = new Basmodule();
        private ArrayList _txt1 = new ArrayList();
        private ArrayList _txt2 = new ArrayList();
        private ArrayList _txt3 = new ArrayList();

        private ArrayList _return = new ArrayList();

        private DataTable dtQuery = new DataTable();
        private DataTable dtOut = new DataTable();
        private DataTable dtIn = new DataTable();
        private DataTable dtQty = new DataTable();
        DataTable dtReturn = new DataTable();

        private bool bOutSlotCheck = false;
        private bool bInSlotCheck = false;
        private bool bFormClose = true;
        private bool bIsOnLine = true;
        private bool bClick = false;
        private bool bRemove = false;

        private string str_msg = "";
        private long methid = 0;

        private int PageIndex = 0;//用于标识页面
        private int i = 0;//用于标识明细条数

        private int dtQueryRowIndex = 0;
        private int qtyRowIndex = 0;
        private ArrayList arrltLockTable = new ArrayList();
        private ArrayList arrltLockTable_item = new ArrayList();

        DataGridTableStyle _datagridstyleOpeStockinformhead_grid_repl_head_query = new DataGridTableStyle();
        DataGridTableStyle _datagridstyleOpeStockinformhead_grid_repl_head_in = new DataGridTableStyle();
        DataGridTableStyle _datagridstyleOpeStockinformhead_grid_repl_head_qty = new DataGridTableStyle();

        //private DelegateBase.AppendDynamicControlTextBoxLostFocusCallBack adct;

        #endregion

        #region 頁面初始化

        public RFFrm_06_12()
        {
            InitializeComponent();
            Ini();
        }

        private void RFFrm_06_12_Load(object sender, EventArgs e)
        {
            _bm.EnabledTextbox(_txt2, false, "txS_repi_outslodid_outCheck");
            _bm.TextBoxReadOnly(_txt2, true, "txS_repi_outslodid_outCheck");
            _bm.Optionfields(_txt2, "txS_repi_outslodid_outCheck");
            _bm.EnabledTextbox(_txt3, false, "txS_slod_id1");
            _bm.TextBoxReadOnly(_txt3, true, "txS_slod_id1");
            _bm.Optionfields(_txt3, "txS_slod_id1");
            cbbsL_reph_id.BackColor = Basmodule.gOptionColor;
            cbbsI_reph_type.BackColor = Basmodule.gOptionColor;
            cbbsI_reph_flag.BackColor = Basmodule.gOptionColor;
            getCbbs_L_reph_id();
            getCbbs_reph_type();
            getCbbs_reph_flag();
            cbbsL_reph_id.Focus();
        }
        
        //初始化事件
        private void Ini()
        {
            if (Screen.PrimaryScreen.WorkingArea.Width >= 480)
            {
                imageListtoolbar.ImageSize = new Size(imageListtoolbar.ImageSize.Width * 2, imageListtoolbar.ImageSize.Height * 2);
            }

            Text = "補貨作業-" + register.UserId + " - 1.02 - dsl";
            IniControls();
            toolBarButtonVisible(false, false, false, true, false, false, true, true, false, false);
        }

        //控制項初始化
        private void IniControls()
        {
            //取得 txt
            getTxt(tabPage1, ref _txt1);
            getTxt(tabPage2, ref _txt2);
            getTxt(tabPage3, ref _txt3);

            _bm.SetGridViewStyle(this.Name, ref grid_repl_head, ref _datagridstyleOpeStockinformhead_grid_repl_head_query, null);
            _bm.SetGridViewStyle(this.Name, ref grid_qty, ref _datagridstyleOpeStockinformhead_grid_repl_head_qty, null);
            _bm.SetGridViewStyle(this.Name, ref grid_repl_item, ref _datagridstyleOpeStockinformhead_grid_repl_head_in, null);
           // _bm.SetGridViewCol_checkbox(this.Name, grid_qty,  ref _datagridstyleOpeStockinformhead_grid_repl_head_qty, ref bIsOnLine);
           // _bm.SetGridViewStyle(this.Name, ref grid_qty, ref _datagridstyleOpeStockinformhead_grid_repl_head_qty, _bm.strConn_1);
        }

        #endregion

        #region toolBar_Click

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            //點擊確認按鈕
            if (e.Button == toolBarButtonConfirmation)
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                toolBarButtonConfirmation_Click();
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            //點擊查詢按鈕
            else if (e.Button == toolBarButtonQuery)
            {
                toolBarButtonQuery_Click();
            }
            //點擊完成按鈕
            else if (e.Button == toolBarButtonreplenishsave)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            //點擊取消按鈕
            else if (e.Button == toolBarButtonCancel)
            {
                toolBarButtonCancel_Click();
            }
            //點擊補登按鈕
            else if (e.Button == toolBarButtonreplenish)
            {
                toolBarButtonreplenish_Click();
            }
            //點擊刪除按鈕
            else if (e.Button == toolBarButtonDel)
            {
                toolBarButtonDel_Click();
            }
            //點擊修改按鈕
            else if (e.Button == toolBarButtonedit)
            {
                toolBarButtonedit_Click();
            }
            //點擊列印按鈕
            else if (e.Button == toolBarButtonPrint)
            {
                toolBarButtonPrint_Click();
            }
            //點擊返回首頁按鈕
            else if (e.Button == toolBarButtonHome)
            {
                toolBarButtonHome_Click();
            }
            //點擊登出按鈕
            else if (e.Button == toolBarButtonLogout)
            {
                toolBarButtonLogout_Click();
            }
        }

        #region 有使用

        //點擊查詢按鈕
        private void toolBarButtonQuery_Click()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.SelectedIndex = 0;
            }
            cbbsL_reph_id.Enabled = true;
            cbbsI_reph_type.Enabled = true;
            cbbsI_reph_flag.Enabled = true;
            toolBarButtonVisible(false, false, false, true, false, false, true, true, false, false);
            //if (cbbsL_reph_id.Items.Count > 0)
            //{
            //    cbbsL_reph_id.SelectedIndex = 0;
            //}
            //if (cbbsI_reph_type.Items.Count > 0)
            //{
            //    cbbsI_reph_type.SelectedIndex = 0;
            //}
            //if (cbbsI_reph_flag.Items.Count > 0)
            //{
            //    cbbsI_reph_flag.SelectedIndex = 0;
            //}
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        //點擊確認按鈕
        private void toolBarButtonConfirmation_Click()
        {
            if (PageIndex == 0)
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                getData_P1(cbbsL_reph_id.Text.Trim(), cbbsI_reph_type.SelectedValue.ToString().Trim(), cbbsI_reph_flag.SelectedValue.ToString().Trim());
                cbbsL_reph_id.SelectedIndex = 0;
                cbbsI_reph_type.SelectedIndex = 0;
                cbbsI_reph_flag.SelectedIndex = 0;
                cbbsL_reph_id.Enabled = false;
                cbbsI_reph_type.Enabled = false;
                cbbsI_reph_flag.Enabled = false;
                toolBarButtonVisible(true, false, false, false, false, false, true, true, false, false);
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            else if (PageIndex == 1)
            {
                _return.Clear();
               
                if (bOutSlotCheck)
                {

                    //执行补货单作业
                    if (callSP_repl_rfcfm(dtQuery.Rows[dtQueryRowIndex]["L_reph_id"].ToString().Trim(), dtOut.Rows[0]["L_repi_sysno"].ToString().Trim(), 1, "") && callSP_repl_rfcfm(dtQuery.Rows[dtQueryRowIndex]["L_reph_id"].ToString().Trim(), dtOut.Rows[0]["L_repi_sysno"].ToString().Trim(), 0, ""))
                    {
                        bRemove = true;
                        //如果有拼板商品
                        if (dtQty.Rows.Count > 0)
                        {
                            

                            for (int h = 0; h < dtQty.Rows.Count; h++)
                            {

                                string sql = "  select 0 NO, L_slom_sysno,S_SLOD_ID,S_MERP_BARCODE,(L_SLOM_1QTY-L_SLOM_RESERQTY)qty from SLOT_MER left JOIN   MER_DATA    ON L_SLOM_MERDSYSNO=L_MERD_SYSNO left JOIN MER_PACKAGE ON L_MERD_SYSNO=L_MERP_MERDSYSNO left join SLOT_DATA on L_MERD_SYSNO=L_SLOD_MERDSYSNO WHERE (L_SLOM_1QTY-L_SLOM_RESERQTY)>0 and S_SLOM_SLODID='" + txS_repi_outslodid_out.Text + "' and I_merp_boxflag=1 and I_slod_type>=3 and S_merp_barcode='" + grid_qty[h, 2].ToString() + "' and S_slod_id='" + grid_qty[h, 1].ToString() + "'";

                                DataTable dt1 = _bm.GetDataTable(sql, _bm.strConn_1);

                                
                                //如果有勾选
                                if (grid_qty[h, 0].ToString() == "V")
                                {
                                    if (grid_qty[h, 1].ToString().Trim() == "")
                                    {
                                        MessageBox.Show("商品" + grid_qty[h, 2].ToString().Trim() + "未設定揀貨儲位，無法進行補貨");
                                        break;
                                    }
                                    else
                                    {
                                        //因为库存数据有可能有多条
                                        if (dt1 != null)
                                        {
                                            for (int hh = 0; hh < dt1.Rows.Count; hh++)
                                            {
                                                string SqlInsert = "insert into tmp_RFrepi (S_tmpr_outslodid,L_tmpr_outslomsysno,L_tmpr_rephid,L_tmpr_takeqty,S_tmpr_Computer,I_tmpr_mark) values ('" + txS_repi_outslodid_out.Text + "'," + dt1.Rows[hh]["L_slom_sysno"].ToString().Trim() + "," + dtQuery.Rows[dtQueryRowIndex]["L_reph_id"].ToString().Trim() + "," + dt1.Rows[hh]["qty"].ToString().Trim() + ",'" + _bm.gComputer + "',0)";

                                                _bm.ExecSql(SqlInsert, ref str_msg, _bm.strConn_1);
                                            }
                                        }
                                    }
                                }
                                //如果没有勾选
                                if (grid_qty[h, 0].ToString() == "X")
                                {
                                    if (dt1 != null)
                                    {
                                        for (int hh = 0; hh < dt1.Rows.Count; hh++)
                                        {
                                            //将该行的商储识别码加入数组中
                                            _return.Add(dt1.Rows[hh]["L_slom_sysno"].ToString());
                                            string SqlInsert = "insert into tmp_RFrepi (S_tmpr_outslodid,L_tmpr_outslomsysno,L_tmpr_rephid,L_tmpr_takeqty,S_tmpr_Computer,I_tmpr_mark) values ('" + txS_repi_outslodid_out.Text + "'," + dt1.Rows[hh]["L_slom_sysno"].ToString().Trim() + "," + dtQuery.Rows[dtQueryRowIndex]["L_reph_id"].ToString().Trim() + "," + dt1.Rows[hh]["qty"].ToString().Trim() + ",'" + _bm.gComputer + "',1)";

                                            _bm.ExecSql(SqlInsert, ref str_msg, _bm.strConn_1);


                                        }
                                    }
                                }
                            }

                                //完成拼版
                                if (callSP_REPL_MERGE(0, "", methid, 0))
                                {
                                    //如果有回库商品
                                    if (_return.Count > 0)
                                    {
                                        tabControl1.SelectedIndex = 2;
                                        grid_repl_itemBind();
                                    }
                                    //如果沒有回庫商品
                                    if (_return.Count == 0)
                                    {
                                        getData_P2(txL_repi_rephid_out.Text.Trim());
                                        setData_P2(dtOut, 0);
                                        txS_repi_outslodid_outCheck.Text = "";
                                        txS_repi_outslodid_outCheck.Focus();
                                    }
                                }
                        }
                        //如果没有拼板商品
                        else
                        {
                            getData_P2(txL_repi_rephid_out.Text.Trim());
                            setData_P2(dtOut, 0);
                            txS_repi_outslodid_outCheck.Text = "";
                            txS_repi_outslodid_outCheck.Focus();
                        }

                   }
                }
                else
                {
                    MessageBox.Show("請先檢核移出儲位!");
                }

            }


            if (PageIndex == 2)
            {
                if (bClick)
                {
                    if (bInSlotCheck)
                    {
                        for (int j = 0; j < _return.Count; j++)
                        {
                            int slotsyson = Convert.ToInt32(_return[j].ToString());
                            if (callSP_REPL_MERGE(1, txS_slod_id1.Text, methid, slotsyson))
                            {
                                if (j == _return.Count - 1)
                                {
                                    MessageBox.Show("回庫成功！");
                                    bRemove = false;
                                    bClick = false;
                                    tabControl1.SelectedIndex = 1;
                                    getData_P2(dtQuery.Rows[0]["L_reph_id"].ToString().Trim());
                                    setData_P2(dtOut, 0);
                                    grid_qtyBind();
                                    txS_slod_id1.Text = "";
                                    txS_repi_outslodid_outCheck.Text = "";
                                    txS_repi_outslodid_outCheck.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("請先輸入移入儲位");
                    }
                }

            }

        }

        #endregion

        #region 無使用

        //點擊取消按鈕
        private void toolBarButtonCancel_Click()
        {
            //if (cbbsL_reph_id.Items.Count > 0)
            //{
            //    cbbsL_reph_id.SelectedIndex = 0;
            //}
            //if (cbbsI_reph_type.Items.Count > 0)
            //{
            //    cbbsI_reph_type.SelectedIndex = 0;
            //}
            //if (cbbsI_reph_flag.Items.Count > 0)
            //{
            //    cbbsI_reph_flag.SelectedIndex = 0;
            //}
            toolBarButtonVisible(true, false, false, false, false, false, true, true, false, false);
        }

        //點擊補登按鈕
        private void toolBarButtonreplenish_Click()
        {

        }

        //點擊刪除按鈕
        private void toolBarButtonDel_Click()
        {

        }

        //點擊修改按鈕
        private void toolBarButtonedit_Click()
        {

        }

        //點擊列印按鈕
        private void toolBarButtonPrint_Click()
        {

        }

        //點擊完成按鈕
        private void toolBarButtonreplenishsave_Click()
        {

        }

        #endregion

        #region 通用

        //點擊返回首頁按鈕
        private void toolBarButtonHome_Click()
        { 
            if (RFFrm_Closing())
            {
                JobMenuF fchild = JobMenuF.ShowForm();
                register.Forms.Add(fchild);
                this.Close();
            }
        }

        //點擊登出按鈕
        private void toolBarButtonLogout_Click()
        {
            if (_bm.ExitForm())
            {
                this.Close();
                this.Dispose();
                register.Dispose();
                Application.DoEvents();
                Application.Exit();
                Process.GetCurrentProcess();
                Process.GetCurrentProcess().Kill();
            }
        }

        #endregion

        #endregion

        #region 公用方法
        private void grid_qtyBind()
        {
            if (txL_repi_rephid_out.Text != "")
            {
                string sql = @" select 'X' bo, S_SLOD_ID,S_MERP_BARCODE,dbo.fn_Get_merpackqtyUnit(L_merd_sysno,'01',sum(L_SLOM_1QTY-L_SLOM_RESERQTY))qty
 from SLOT_MER left JOIN   MER_DATA    ON L_SLOM_MERDSYSNO=L_MERD_SYSNO
 left JOIN MER_PACKAGE ON L_MERD_SYSNO=L_MERP_MERDSYSNO
 left join SLOT_DATA on L_MERD_SYSNO=L_SLOD_MERDSYSNO 
  WHERE (L_SLOM_1QTY-L_SLOM_RESERQTY)>0  and S_SLOM_SLODID='" + txS_repi_outslodid_out.Text + "' and I_merp_boxflag=1 and I_slod_type>=3  group by S_SLOD_ID,S_MERP_BARCODE,L_merd_sysno";

                dtQty = _bm.GetDataTable(sql, _bm.strConn_1);
                _bm.SetGridViewCol(this.Name, grid_qty, sql, ref _datagridstyleOpeStockinformhead_grid_repl_head_qty, ref bIsOnLine);
            }
        }

        private void grid_repl_itemBind()
        {



            string SqlReturen = @"select S_MERP_BARCODE,L_meti_adjqty as qty,S_SLOD_ID from metr_item join MER_PACKAGE on L_MERP_MERDSYSNO=L_meti_merdsysno join SLOT_DATA on L_SLOD_MERDSYSNO=L_meti_merdsysno where I_merp_boxflag=1 and I_slod_type>=3 and s_meti_slodid=s_meti_newslodid and  L_METI_METHID=" + methid;
            _bm.SetGridViewCol(this.Name, grid_repl_item, SqlReturen, ref _datagridstyleOpeStockinformhead_grid_repl_head_in, ref bIsOnLine);

   
//            for (int k = 0; k < _return.Count; k++)
//            {
//                string SqlReturen = @"select 0 NO, S_SLOD_ID,S_MERP_BARCODE,dbo.fn_Get_merpackqtyUnit(L_merd_sysno,'01',sum(L_SLOM_1QTY-L_SLOM_RESERQTY))qty
// from SLOT_MER left JOIN   MER_DATA    ON L_SLOM_MERDSYSNO=L_MERD_SYSNO
// left JOIN MER_PACKAGE ON L_MERD_SYSNO=L_MERP_MERDSYSNO
// left join SLOT_DATA on L_MERD_SYSNO=L_SLOD_MERDSYSNO 
//  WHERE L_slom_sysno={0} and I_merp_boxflag=1 and I_slod_type>=3  group by S_SLOD_ID,S_MERP_BARCODE,L_merd_sysno";
//                SqlReturen= string.Format(SqlReturen, _return[k]);
//                DataTable dttt = new DataTable();
//                dttt=_bm.GetDataTable(SqlReturen, _bm.strConn_1);
//                if (dttt != null)
//                {
                    
//                    if (k == 0)
//                    {
//                        dtReturn = dttt.Copy();
//                        dtReturn.Clear();
//                    }
//                    dtReturn.Rows.Add(dttt.Rows[0].ItemArray);
//                }
                    
//            }

//                foreach (DataColumn column in dtReturn.Columns)
//                {

//                    column.ColumnName = column.ColumnName.ToUpper();
//                    if (column.ColumnName.ToUpper() == "NO")
//                    {
//                        foreach (DataRow row in dtReturn.Rows)
//                        {
//                            row["NO"] = i;
//                            i = i + 1;
//                        }
//                    }
//                }
            
//            //DataView dataView = ds.Tables[0].DefaultView;
//            dtReturn.TableName = "tablename";

//            _datagridstyleOpeStockinformhead_grid_repl_head_in.MappingName = dtReturn.TableName;

//            grid_repl_item.TableStyles.Clear();
//            grid_repl_item.TableStyles.Add(_datagridstyleOpeStockinformhead_grid_repl_head_in);
//            grid_repl_item.DataSource = dtReturn;
        }




        #region 讀取資料  

        private bool getData_P1(string L_reph_id, string S_reph_type, string S_reph_flag)
        {
            bool getDataOk = false;
            bool bNoSelect = false;
            try
            {
                string strSql = "";
                strSql = @"
select 0 NO, L_reph_id,N_basd_name S_reph_type,S_optd_name S_reph_flag 
from repl_head with(nolock)
join basic_data with(nolock) on I_reph_type=I_basd_seq and S_basd_column = 'repl_opname'
join option_data with(nolock) on I_reph_flag=I_optd_flag and S_optd_fieldname='reph_flag' and (I_optd_flag=135 or I_optd_flag=140)";


                if ((L_reph_id != null) && (L_reph_id != "") && (L_reph_id != "System.Data.DataRowView"))
                {
                    strSql += "and L_reph_id='" + L_reph_id.Trim() + "' ";
                    bNoSelect = true;
                }
                if ((S_reph_type != null) && (S_reph_type != "") && (S_reph_type != "System.Data.DataRowView"))
                {
                    strSql += "and I_reph_type='" + S_reph_type.Trim() + "' ";
                    bNoSelect = true;
                }
                if ((S_reph_flag != null) && (S_reph_flag != "") && (S_reph_flag != "System.Data.DataRowView"))
                {
                    strSql += "and I_reph_flag='" + S_reph_flag.Trim() + "' ";
                    bNoSelect = true;
                }

                if (!bNoSelect)
                {
                    strSql += "and (I_reph_flag=135 or I_reph_flag=140) ";
                }

                strSql += "and I_reph_type<>3 ";
                strSql += " order by I_reph_type desc,I_reph_flag desc ";

                dtQuery = _bm.GetDataTable(strSql, _bm.strConn_1);
                dataGridViewBind(strSql, ref dtQuery, grid_repl_head, _datagridstyleOpeStockinformhead_grid_repl_head_query);
                if ((dtQuery != null) && (dtQuery.Rows != null) && (dtQuery.Rows.Count > 0))
                {
                    getData_P2(dtQuery.Rows[0]["L_reph_id"].ToString().Trim());
                }
                else
                {
                    getData_P2("");
                    _bm.WarnMsgbox("對不起，沒有找到相關資料！");
                }
            }
            catch (Exception ex)
            {
                _bm.WarnMsgbox(ex.Message);
            }
            finally
            {

            }
            return getDataOk;
        }

        private bool getData_P2(string L_reph_id)
        {
            bool getDataOk = false;
            bClick = false;
            _return.Clear();
            try
            {
                string strSql = "";
                strSql = @"
select *,
(select 
(case when L_qty1>0 then convert(nvarchar,L_qty1,LEN(L_qty1))+S_unit1 else '' end)+ 
(case when L_qty2>0 then convert(nvarchar,L_qty2,LEN(L_qty2))+S_unit2 else '' end)+ 
(case when L_qty3>0 then convert(nvarchar,L_qty3,LEN(L_qty3))+S_unit3 else '' end) 
from fn_Get_merpackqty(L_repi_merdsysno,S_merl_merpgroup,L_repi_replqty))S_capi_qty
from (
select 
S_slod_id,
L_repi_rephid,
L_repi_sysno,
N_basd_name S_reph_type,
S_slod_piczid,
N_picz_name,
S_repi_outslodid,
L_repi_merdsysno,
S_merd_id,
N_merd_name,
L_repi_replqty,
I_slod_type,
S_slod_pick,
(case when S_merl_merpgroup is null or RTrim(LTrim(S_merl_merpgroup))='' then '01' else RTrim(LTrim(S_merl_merpgroup)) end)S_merl_merpgroup
from repl_head with(nolock)
join repl_item with(nolock) on L_reph_id=L_repi_rephid
join basic_data with(nolock) on I_reph_type=I_basd_seq and S_basd_column = 'repl_opname'
join slot_data with(nolock) on l_repi_merdsysno=l_slod_merdsysno
join pick_zone with(nolock) on S_slod_piczid=S_picz_id
join mer_data with(nolock) on L_repi_merdsysno=L_merd_sysno
left join mer_list with(nolock) on L_repi_merlsysno=L_merl_sysno
where L_reph_id='" + L_reph_id +@"' and I_repi_rfflag=0
)newData
order by I_slod_type desc,S_slod_pick ";

                dtOut = _bm.GetDataTable(strSql, _bm.strConn_1);
                if ((dtOut != null) && (dtOut.Rows != null) && (dtOut.Rows.Count > 0))
                {
                    setData_P2(dtOut, 0);
                }
                else
                {
                    setData_P2(new DataTable(), 0);   
                    //_bm.WarnMsgbox("對不起，沒有找到相關資料！");
                }
            }
            catch (Exception ex)
            {
                _bm.WarnMsgbox(ex.Message);
            }
            finally
            {

            }
            return getDataOk;
        }

       

        private bool getCbbs_L_reph_id()
        {
            bool getDataOk = true;
            try
            {
                string strSql = string.Empty; 
                DataTable dtCbbsL_reph_id = new DataTable();

                strSql = @"select convert(nvarchar,l_reph_id)l_reph_id from repl_head with(nolock) where (I_reph_flag=135 or I_reph_flag=140)  and I_reph_type<>3 ";
                
                dtCbbsL_reph_id = _bm.GetDataTable(strSql, _bm.strConn_1);

                cbbs_Load(cbbsL_reph_id, dtCbbsL_reph_id, "l_reph_id", "l_reph_id", true);

                //if (dtCbbsL_meth_id.Rows.Count <= 0)
                //{
                //    _bm.WarnMsgbox("對不起，沒有找到相關的資料！");
                //}
            }
            catch (Exception ex)
            {
                getDataOk = false;
            }
            finally
            {

            }
            return getDataOk;
        }

        private bool getCbbs_reph_type()
        {
            bool getDataOk = true;
            try
            {
                string strSql = string.Empty; //取得商品資料 及 商品包裝資料
                DataTable dtCbbs_reph_type = new DataTable();

                strSql = @"select convert(nvarchar,I_basd_seq)I_basd_seq,N_basd_name from basic_data with(nolock) where S_basd_column = 'repl_opname' and I_basd_seq<>3 ";

                dtCbbs_reph_type = _bm.GetDataTable(strSql, _bm.strConn_1);

                cbbs_Load(cbbsI_reph_type, dtCbbs_reph_type, "N_basd_name", "I_basd_seq", true);

                //if (dtCbbs_metr_opname.Rows.Count <= 0)
                //{
                //    _bm.WarnMsgbox("對不起，沒有找到相關的資料！");
                //}
            }
            catch (Exception ex)
            {
                getDataOk = false;
            }
            finally
            {

            }
            return getDataOk;
        }

        private bool getCbbs_reph_flag()
        {
            bool getDataOk = true;
            try
            {
                string strSql = string.Empty; //取得商品資料 及 商品包裝資料
                DataTable dtCbbs_reph_flag = new DataTable();

                strSql = @"select convert(nvarchar,I_optd_flag)I_optd_flag,S_optd_name from option_data with(nolock) where S_optd_fieldname='reph_flag' and (I_optd_flag=135 or I_optd_flag=140) ";

                dtCbbs_reph_flag = _bm.GetDataTable(strSql, _bm.strConn_1);

                cbbs_Load(cbbsI_reph_flag, dtCbbs_reph_flag, "S_optd_name", "I_optd_flag", true);

                //if (dtCbbs_metr_opname.Rows.Count <= 0)
                //{
                //    _bm.WarnMsgbox("對不起，沒有找到相關的資料！");
                //}
            }
            catch (Exception ex)
            {
                getDataOk = false;
            }
            finally
            {

            }
            return getDataOk;
        }

        #endregion

        #region 呼叫 Store Precedure

        private bool callSP_repl_rfcfm(string L_reph_id, string L_repi_sysno, int I_adjtype,string L_merd_sysno)
        {
            bool bCall_SP = false;
            string strReturn = string.Empty;
            string strMsg = string.Empty;

            mobileSDK.WS_MLSJ.SqlParameter[] Params = new mobileSDK.WS_MLSJ.SqlParameter[9];
            for (int n = 0; n <= Params.Length - 1; n++)
            {
                Params[n] = new mobileSDK.WS_MLSJ.SqlParameter();
            }

            Params[0].ParameterName = "I_inputtype";
            Params[0].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[0].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[0].Value = 1;

            Params[1].ParameterName = "S_empd_id";
            Params[1].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Char;
            Params[1].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[1].Value = register.UserId;

            Params[2].ParameterName = "S_computer";
            Params[2].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[2].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[2].Value = _bm.gComputer;

            Params[3].ParameterName = "I_result";
            Params[3].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[3].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;

            Params[4].ParameterName = "S_result";
            Params[4].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[4].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;
            Params[4].Size = 1000;

            Params[5].ParameterName = "L_reph_id";
            Params[5].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.BigInt;
            Params[5].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[5].Value = Convert.ToInt64(L_reph_id);

            Params[6].ParameterName = "L_repi_sysno";
            Params[6].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.BigInt;
            Params[6].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[6].Value = Convert.ToInt64(L_repi_sysno);

            Params[7].ParameterName = "I_adjtype";
            Params[7].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[7].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[7].Value = I_adjtype;

            Params[8].ParameterName = "I_notfinish";
            Params[8].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[8].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;


            if (_bm.ExecProcdure(Params, "SP_repl_rfcfm", ref strReturn, ref strMsg, _bm.strConn_1))
            {
                if (strReturn.Length > 0)
                {
                    string[] s = strReturn.Split(',');
                    if (s[0].ToString() == "0")
                    {
                        if (!arrltLockTable.Contains(L_reph_id))
                        {
                            arrltLockTable.Add(L_reph_id);
                        }
                        
                        _bm.PlaySound(Operationalstatus.Success);
                        if (I_adjtype == 0)
                        {
                            if (s[s.Length - 1] == "0")
                            {
                                if (arrltLockTable.Contains(L_reph_id))
                                {
                                    arrltLockTable.Remove(L_reph_id);
                                }   

                                lockRelease("repl_item", _bm.gComputer, register.UserId, "SP_REPL_RFCFM", "", "");
                                _bm.InfoMsgbox("補貨單號： " + L_reph_id + " 作業已完成！", Operationalstatus.Success);

                            }
                        }
                        //_bm.InfoMsgbox(s[0].ToString(),Operationalstatus.Success);
                        //_bm.InfoMsgbox("保存執行成功！", Operationalstatus.Success);
                        //setData_P1(new DataTable());
                        bCall_SP = true;
                    }
                    else
                    {
                        _bm.PlaySound(Operationalstatus.Failure);
                        _bm.WarnMsgbox("執行失敗！|" + strReturn);
                    }
                }
                else
                {
                    _bm.PlaySound(Operationalstatus.Failure);
                    _bm.WarnMsgbox("執行失敗！|strReturn長度為0" + strReturn);
                }
            }
            else
            {
                _bm.PlaySound(Operationalstatus.Failure);
                _bm.WarnMsgbox("SP_repl_rfcfm執行失敗！|" + strReturn);
            }
            return bCall_SP;
        }



        private bool callSP_REPL_MERGE(int I_adjtype, string s_slodid_in, long s_meth_id, int L_SLOM_SYSNO_return)
        {
            bool bCall_SP = false;
            string strReturn = string.Empty;
            string strMsg = string.Empty;

            mobileSDK.WS_MLSJ.SqlParameter[] Params = new mobileSDK.WS_MLSJ.SqlParameter[9];
            for (int n = 0; n <= Params.Length - 1; n++)
            {
                Params[n] = new mobileSDK.WS_MLSJ.SqlParameter();
            }

            Params[0].ParameterName = "I_inputtype";
            Params[0].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[0].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[0].Value = 1;

            Params[1].ParameterName = "S_empdid";
            Params[1].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Char;
            Params[1].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[1].Value = register.UserId;

            Params[2].ParameterName = "S_computer";
            Params[2].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[2].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[2].Value = _bm.gComputer;

            Params[3].ParameterName = "I_result";
            Params[3].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[3].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;

            Params[4].ParameterName = "S_result";
            Params[4].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[4].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;
            Params[4].Size = 1000;

            Params[5].ParameterName = "I_adjtype";
            Params[5].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[5].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[5].Value = I_adjtype;

            Params[6].ParameterName = "S_SLOM_SLODID_in";
            Params[6].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[6].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[6].Value = s_slodid_in;

            Params[7].ParameterName = "L_SLOM_SYSNO_return";
            Params[7].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[7].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[7].Value = L_SLOM_SYSNO_return;

            Params[8].ParameterName = "L_meti_methid";
            Params[8].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.BigInt;
            Params[8].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[8].Value = s_meth_id;




            if (_bm.ExecProcdure(Params, "SP_REPL_MERGE", ref strReturn, ref strMsg, _bm.strConn_1))
            {
                if (strReturn.Length > 0)
                {
                    string[] s = strReturn.Split(',');
                    if (s[0].ToString() == "0")
                    {

                        _bm.PlaySound(Operationalstatus.Success);   
                        bCall_SP = true;
                        if (I_adjtype == 0)
                        {
                            methid = Convert.ToInt64(s[1].ToString());
                        }
                    }
                    else
                    {
                        _bm.PlaySound(Operationalstatus.Failure);
                        _bm.WarnMsgbox("執行失敗！|" + strReturn);
                    }
                }
                else
                {
                    _bm.PlaySound(Operationalstatus.Failure);
                    _bm.WarnMsgbox("執行失敗！|strReturn長度為0" + strReturn);
                }
            }
            else
            {
                _bm.PlaySound(Operationalstatus.Failure);
                _bm.WarnMsgbox("SP_REPL_MERGE執行失敗！|" + strReturn);
            }
            return bCall_SP;
        }

        private bool callSP_LockRequest(string S_loct_name, string S_loct_id, string S_loct_formname)
        {
            bool bCall_SP = false;
            string strReturn = string.Empty;
            string strMsg = string.Empty;

            mobileSDK.WS_MLSJ.SqlParameter[] Params = new mobileSDK.WS_MLSJ.SqlParameter[8];
            for (int n = 0; n <= Params.Length - 1; n++)
            {
                Params[n] = new mobileSDK.WS_MLSJ.SqlParameter();
            }

            Params[0].ParameterName = "S_loct_name";
            Params[0].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[0].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[0].Value = S_loct_name;

            Params[1].ParameterName = "S_loct_id";
            Params[1].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[1].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[1].Value = S_loct_id;

            Params[2].ParameterName = "S_loct_user";
            Params[2].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[2].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[2].Value = register.UserId;

            Params[3].ParameterName = "S_loct_where";
            Params[3].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[3].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[3].Value =  _bm.gComputer;

            Params[4].ParameterName = "S_loct_formname";
            Params[4].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[4].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[4].Value = S_loct_formname;

            Params[5].ParameterName = "I_reuslt";
            Params[5].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[5].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;

            Params[6].ParameterName = "S_result";
            Params[6].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[6].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;
            Params[6].Size = 100;

            Params[7].ParameterName = "LockRequest";
            Params[7].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Char;
            Params[7].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;
            Params[7].Size = 1;



            if (_bm.ExecProcdure(Params, "SP_LockRequest", ref strReturn, ref strMsg, _bm.strConn_1))
            {
                if (strReturn.Length > 0)
                {
                    string[] s = strReturn.Split(',');
                    if (s[0].ToString() == "0")
                    {
                        //_bm.PlaySound(Operationalstatus.Success);

                        if (s[s.Length - 1] == "Y")
                        {
                            _bm.WarnMsgbox(s[1].ToString());
                            bCall_SP = false;
                        }
                        else
                        {

                            bCall_SP = true;
                        }
                    }
                    else
                    {
                        _bm.PlaySound(Operationalstatus.Failure);
                        _bm.WarnMsgbox("執行失敗！|" + strReturn);
                    }
                }
                else
                {
                    _bm.PlaySound(Operationalstatus.Failure);
                    _bm.WarnMsgbox("執行失敗！|strReturn長度為0" + strReturn);
                }
            }
            else
            {
                _bm.PlaySound(Operationalstatus.Failure);
                _bm.WarnMsgbox("SP_repl_rfcfm執行失敗！|" + strReturn);
            }
            return bCall_SP;
        }

        private bool callSP_LockRelease(string S_loct_name, string S_loct_id)
        {
            bool bCall_SP = false;
            string strReturn = string.Empty;
            string strMsg = string.Empty;

            mobileSDK.WS_MLSJ.SqlParameter[] Params = new mobileSDK.WS_MLSJ.SqlParameter[6];
            for (int n = 0; n <= Params.Length - 1; n++)
            {
                Params[n] = new mobileSDK.WS_MLSJ.SqlParameter();
            }

            Params[0].ParameterName = "S_loct_name";
            Params[0].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[0].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[0].Value = S_loct_name;

            Params[1].ParameterName = "S_loct_id";
            Params[1].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Char;
            Params[1].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[1].Value = S_loct_id;

            Params[2].ParameterName = "S_loct_user";
            Params[2].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[2].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[2].Value = register.UserId;

            Params[3].ParameterName = "S_loct_where";
            Params[3].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.Int;
            Params[3].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Input;
            Params[3].Value = _bm.gComputer;


            Params[4].ParameterName = "I_reuslt";
            Params[4].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.BigInt;
            Params[4].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;

            Params[5].ParameterName = "S_result";
            Params[5].SqlDbType = mobileSDK.WS_MLSJ.SqlDbType.VarChar;
            Params[5].Direction = mobileSDK.WS_MLSJ.ParameterDirection.Output;
            Params[5].Size = 100;


            if (_bm.ExecProcdure(Params, "SP_LockRelease", ref strReturn, ref strMsg, _bm.strConn_1))
            {
                if (strReturn.Length > 0)
                {
                    string[] s = strReturn.Split(',');
                    if (s[0].ToString() == "0")
                    {
                        //_bm.PlaySound(Operationalstatus.Success);
                        
                        bCall_SP = true;                        
                    }
                    else
                    {
                        _bm.PlaySound(Operationalstatus.Failure);
                        _bm.WarnMsgbox("執行失敗！|" + strReturn);
                    }
                }
                else
                {
                    _bm.PlaySound(Operationalstatus.Failure);
                    _bm.WarnMsgbox("執行失敗！|strReturn長度為0" + strReturn);
                }
            }
            else
            {
                _bm.PlaySound(Operationalstatus.Failure);
                _bm.WarnMsgbox("SP_repl_rfcfm執行失敗！|" + strReturn);
            }
            return bCall_SP;
        }

        #endregion

        #region 其它

        //設定資料到 GridView
        private void dataGridViewBind(string strsql, ref DataTable dt, DataGrid dgGrid, DataGridTableStyle gridStyle)
        {
            _bm.SetGridViewCol(this.Name, dgGrid, strsql, ref gridStyle,_bm.strConn_1);
            dt = (DataTable)dgGrid.DataSource;
        }

        //設定 ToolButton 是否顯示
        private void toolBarButtonVisible(bool bQuery, bool bEdit, bool bDelete, bool bConfirmation, bool bCancel, bool bPrint, bool bHome, bool bLogout, bool bReplenishSave, bool Replenish)
        {
            toolBarButtonQuery.Visible = bQuery;
            toolBarButtonedit.Visible = bEdit;
            toolBarButtonDel.Visible = bDelete;
            toolBarButtonConfirmation.Visible = bConfirmation;
            toolBarButtonCancel.Visible = bCancel;
            toolBarButtonPrint.Visible = bPrint;
            toolBarButtonHome.Visible = bHome;
            toolBarButtonLogout.Visible = bLogout;
            toolBarButtonreplenishsave.Visible = bReplenishSave;
            toolBarButtonreplenish.Visible = Replenish;
        }
        
        //取得所有的 txt
        private void getTxt(Control mControl, ref ArrayList myTxt)
        {
            foreach (Control control in mControl.Controls)
            {
                if (control is CFTextBox)
                {
                    if (((CFTextBox)control).Name.Substring(0, 2) == "tx")
                    {
                        myTxt.Add(control);
                    }
                }
                else if ((control is TabControl) || (control is Panel))
                {
                    getTxt(control, ref myTxt);
                }
            }
        }

        private void setData_P2(DataTable setDt,int setRowIndex)
        {
            bRemove = false;
            if ((setDt.Rows != null) && (setDt.Rows.Count > 0))
            {
                txL_repi_rephid_out.Text = setDt.Rows[setRowIndex]["L_repi_rephid"].ToString().Trim();
                txS_repi_outslodid_out.Text = setDt.Rows[setRowIndex]["S_repi_outslodid"].ToString().Trim();
                txS_merd_id_out.Text = setDt.Rows[setRowIndex]["S_merd_id"].ToString().Trim();
                txN_merd_name_out.Text = setDt.Rows[setRowIndex]["N_merd_name"].ToString().Trim(); ;
                txS_capi_qty_out.Text = setDt.Rows[setRowIndex]["S_capi_qty"].ToString().Trim();
                txS_slod_id.Text = setDt.Rows[setRowIndex]["S_SLOD_ID"].ToString().Trim();
                txS_repi_outslodid_outCheck.Text = "";
            }
            else
            {
                txL_repi_rephid_out.Text = "";
                txS_repi_outslodid_out.Text = "";
                txS_repi_outslodid_outCheck.Text = "";
                txS_merd_id_out.Text = "";
                txN_merd_name_out.Text = "";
                txS_capi_qty_out.Text = "";
            }
        }



        private void cbbs_Load(ComboBox cbbs, DataTable dtCbbs, string keyText, string keyValue,bool firstDataNull)
        {
            if (firstDataNull == true)
            {
                //注意事項：因為新增的Row，都以 "" 寫入，所以在cbbs 的sql 語法需將 非字串型態的欄位由sql 語法先轉換為 nvarchar，以防 addRow[]=""時錯誤
                DataRow addRow = dtCbbs.NewRow();
                for (int i = 0; i < dtCbbs.Columns.Count; i++)
                {
                    addRow[dtCbbs.Columns[i].ColumnName.ToString()] = "";
                }
                dtCbbs.Rows.InsertAt(addRow,0);
            }
            cbbs.DataSource = dtCbbs;
            cbbs.DisplayMember = keyText;
            cbbs.ValueMember = keyValue;
            cbbs.Focus();
            if (dtCbbs.Rows.Count > 0)
            {
                cbbs.SelectedIndex = 0;
            }
        }

        private void clearGrid(DataGrid clearDataGrid, string strSql_Clear)
        {
            dataGridViewBind(strSql_Clear, ref dtIn, clearDataGrid, _datagridstyleOpeStockinformhead_grid_repl_head_in);
        }

        private void lockRelease(string releaseTable, string releasePC, string releaseUser, string releaseFormName, string releaseId, string releaseException)
        {
            if (releaseId != "")
            {
                callSP_LockRelease(releaseTable, releaseId);
            }
            else
            {
                string strDelete = "";
                if (releaseTable != "")
                {
                    strDelete = "delete from locktable where S_loct_user='" + releaseUser + "' and S_loct_where='" + releasePC + "' and S_loct_formname='" + releaseFormName + "' and S_loct_name='" + releaseTable + "'";
                }
                else
                {
                    strDelete = "delete from locktable where S_loct_user='" + releaseUser + "' and S_loct_where='" + releasePC + "' and S_loct_formname='" + releaseFormName + "' ";
                }
                if (releaseException != "")
                {
                    strDelete = strDelete + " and S_loct_id not in(" + releaseException + ")";
                }
                _bm.ExecSql(strDelete, _bm.strConn_1);
            }
        }

        private bool RFFrm_Closing()
        {
            bFormClose = true;
            string strMsg = "單據";
            if (arrltLockTable.Count > 0)
            {
                if (MessageBox.Show(strMsg + "作業未完成，請問是否離開?", "離開確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.No)
                {
                    bFormClose = false;
                }
            }

            if (bFormClose)
            {
                lockRelease("", _bm.gComputer, register.UserId, "SP_REPL_RFCFM", "", "");
            }
            return bFormClose;
        }

        #endregion 

        #endregion 

        #region 一般事件 

        #region DataGridView

        private void grid_metr_head_CurrentCellChanged(object sender, EventArgs e)
        {
            int myRowIndex = ((DataGrid)sender).CurrentRowIndex;
            if ((myRowIndex >= 0) && (myRowIndex < dtQuery.Rows.Count))
            {
                dtQueryRowIndex = myRowIndex;
                getData_P2(dtQuery.Rows[myRowIndex]["L_reph_id"].ToString().Trim());
                if (dtOut.Rows.Count > 0)
                {
                    grid_qtyBind();
                }
            }
        }

        private void grid_metr_head_DoubleClick(object sender, EventArgs e)
        {

            if ((dtOut != null) && (dtOut.Rows != null) && (dtOut.Rows.Count >0))
            {
                tabControl1.SelectedIndex = 1;
                int myRowIndex = ((DataGrid)sender).CurrentRowIndex;
                if ((myRowIndex >= 0) && (myRowIndex < dtQuery.Rows.Count))
                {
                    dtQueryRowIndex = myRowIndex;
                    getData_P2(dtQuery.Rows[myRowIndex]["L_reph_id"].ToString().Trim());
                    if (dtOut.Rows.Count > 0)
                    {
                        grid_qtyBind();
                    }
                }
            }
        }

        #endregion     

        #region TextBox

        private void txS_meti_slodid_outCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((TextBox)sender).Text.Trim() != "")
                {
                    if (((TextBox)sender).Text.Trim().ToUpper() == txS_repi_outslodid_out.Text.Trim().ToUpper())
                    {
                        bOutSlotCheck = true;
      
                    }
                    else
                    {
                        MessageBox.Show("移出儲位與指定儲位不同，請重新確認!");
                        ((TextBox)sender).Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("請輸入移出儲位!");
                }
            }
        }



        private void txS_meti_slodid_outCheck_TextChanged(object sender, EventArgs e)
        {
            bOutSlotCheck = false;
        }



        #region 特殊用途(only Num,直接轉大寫)

        private void txS_meti_slodid_outCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (char.IsLower(e.KeyChar))
                {
                    ((TextBox)sender).SelectedText = char.ToUpper(e.KeyChar).ToString();
                    e.Handled = true;
                }
            }
        }
        private void txS_slod_id1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (char.IsLower(e.KeyChar))
                {
                    ((TextBox)sender).SelectedText = char.ToUpper(e.KeyChar).ToString();
                    e.Handled = true;
                }
            }
        }

        private void txS_meti_slodid_inCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                if (char.IsLower(e.KeyChar))
                {
                    ((TextBox)sender).SelectedText = char.ToUpper(e.KeyChar).ToString();
                    e.Handled = true;
                }
            }
        }

        private void txL_meti_adjqty_outCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txL_meti_adjqty_inCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } 

        #endregion

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0)
            {
                cbbsL_reph_id.Enabled = true;
                cbbsI_reph_type.Enabled = true;
                cbbsI_reph_flag.Enabled = true;
                toolBarButtonVisible(false, false, false, true, false, false, true, true, false, false);
                cbbsL_reph_id.Focus();
                PageIndex = 0;
            }
            else if (((TabControl)sender).SelectedIndex == 1)
            {
                toolBarButtonVisible(true, false, false, true, false, false, true, true, false, false);
                txS_repi_outslodid_outCheck.Focus();
                PageIndex = 1;
            }
            else if (((TabControl)sender).SelectedIndex == 2)
            {
                if (bRemove)
                {
                    toolBarButtonVisible(true, false, false, true, false, false, true, true, false, false);
                    txS_slod_id1.Focus();
                    PageIndex = 2;
                }
                else
                {
                    tabControl1.SelectedIndex = 1;
                }

            }
        }

        private void RFFrm_06_12_Closing(object sender, CancelEventArgs e)
        {
            //if (!RFFrm_Closing())
            //{
            //    e.Cancel = true;
            //}
        }


        #endregion
        //回库输入储位编号
        private void txS_slod_id1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bClick = true;

                DataTable dtSlotType=new DataTable();

                string select_slot="select * from SLOT_DATA where s_slod_id='"+txS_slod_id1.Text+"'";
                dtSlotType=_bm.GetDataTable(select_slot,_bm.strConn_1);
                if (dtSlotType.Rows.Count>0)
                {
                    if (dtSlotType.Rows[0]["S_slod_pick"].ToString().Trim().ToUpper() == "P")
                    {
                        MessageBox.Show("僅允許上架保管儲位，請重新輸入！");
                        txS_slod_id1.Text = "";
                        txS_slod_id1.Focus();
                    }
                    else
                    {
                        bInSlotCheck = true;
                    }
                }
                else
                {
                    MessageBox.Show("此儲位不存在，請重新輸入！");
                    txS_slod_id1.Text = "";
                    txS_slod_id1.Focus();
                }
            }
        }

        private void txS_slod_id1_TextChanged(object sender, EventArgs e)
        {
            bInSlotCheck = false;
        }

        private void RFFrm_06_12_Activated(object sender, EventArgs e)
        {
            cbbsL_reph_id.Focus();
        }

        private void grid_qty_Click(object sender, EventArgs e)
        {

            string bo = grid_qty[qtyRowIndex, 0].ToString();
            if (bo == "X")
            {
                grid_qty[qtyRowIndex, 0] = "V";
            }
            if (bo == "V")
            {
                grid_qty[qtyRowIndex, 0] = "X";
            }
        }

        private void grid_qty_CurrentCellChanged(object sender, EventArgs e)
        {
            qtyRowIndex = ((DataGrid)sender).CurrentRowIndex;
        }




        


    }
}