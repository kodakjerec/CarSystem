using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Car_IO;
using System.Collections;

namespace Car_Fun
{
    public partial class CarSystem_Sample_Form : Form
    {
        #region 引用C++的函數
        #region 此處用於取得計算機視窗的控制碼
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion

        #region 隱藏Windows工具列
        [DllImport("SHELL32", CallingConvention = CallingConvention.StdCall)]
        protected static extern uint SHAppBarMessage(int dwMessage, ref APPBARDATA pData);

        protected int ABM_SETSTATE = 10;

        protected int ABM_GETSTATE = 4;

        [StructLayout(LayoutKind.Sequential)]
        protected struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }


        [StructLayout(LayoutKind.Sequential)]
        protected struct APPBARDATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public int lParam;
        }
        #endregion
        #endregion

        public CarSystem_Sample_Form()
        {
            InitializeComponent();
            DisableAllKeyboard();

            CarSystem_FormBindingNavigator.Visible = false;
            foreach (ToolStripItem tsb in CarSystem_FormBindingNavigator.Items)
            {
                if (tsb.Name.IndexOf("Button") > 0)
                    if (tsb.Name.IndexOf("Leave") < 0)
                        tsb.Visible = false;
            }
        }

        #region 全域變數設定
        protected static string FormStatus = "Search";  //目前程式執行狀態
        protected static string strLockFormName = "CarSys001";
        protected BindingSource MasterBS;   //母表單
        protected BindingSource ChildBS;    //子表單
        protected DataSet ChildBSSet;       //子表單DateSet
        protected DataTable ChildBSTable;   //子表單DataTable
        protected List<object> MasterObj;   //統一啟用/不啟用的物件集合
        public static IO_DB IO = new IO_DB();      //通用存取IO
        public static F_LogIn UserInf = new F_LogIn();  //通用使用者資訊
        public string Login_Server = "pxwms_n";  //通用登入Server
        public F_Msg fMsg = new F_Msg();
        public RecLog reclog = new RecLog();
        #endregion

        #region 一定要做的設定

        #region 新增時自動給值
        protected void BindingSource_AddingNew(BindingSource bs)
        {
            if (bs == null)
                return;
            DataView view = (DataView)bs.List;
            DataRowView drv = (DataRowView)bs.Current;
            foreach (DataColumn column in view.Table.Columns)
            {
                if (column.DataType == Type.GetType("System.String"))
                {
                    drv[column.ColumnName] = "";
                }
                else if (column.DataType == Type.GetType("System.Boolean"))
                {
                    drv[column.ColumnName] = false;
                }
                else if (column.DataType == Type.GetType("System.DateTime"))
                {
                    drv[column.ColumnName] = DateTime.Now.ToString();
                }
                else if (column.DataType == Type.GetType("System.Int32"))
                {
                    drv[column.ColumnName] = 0;
                }
            }
        }
        #endregion

        #region 指定資料繫結的Table--Master 設定母表單
        public void SetMasterBindingNavigator(BindingSource bs)
        {
            CarSystem_FormBindingNavigator.Visible = true;
            MasterBS = bs;
            CarSystem_FormBindingNavigator.BindingSource = MasterBS;
        }
        #endregion

        #region 指定資料繫結的Table--Master 設定子表單
        public void SetChildBindingNavigator(BindingSource bs)
        {
            ChildBS = bs;
            //ChildBSSet = ((DataSet)ChildBS.DataSource);
            //ChildBSTable = ((DataSet)ChildBS.DataSource).Tables[0];
        }
        #endregion

        #region 要開啟的按鈕, 有標記的才開啟 N E D C O S L F E0 P SE
        private string enable_string;
        public void SetButtonEnable(string Enable_string_User)
        {
            enable_string = Enable_string_User;
            SetButtonEnable();
        }
        public void SetButtonEnable()
        {
            if (enable_string == null || enable_string.Length == 0)
                enable_string = "L";

            enable_string = enable_string.ToUpper();
            if (enable_string.IndexOf('N') > -1)
                bindingNavigatorNewButton.Visible = true;

            if (enable_string.IndexOf('E') > -1)
                bindingNavigatorEditButton.Visible = true;

            if (enable_string.IndexOf('D') > -1)
                bindingNavigatorDelButton.Visible = true;

            if (enable_string.IndexOf("S ") > -1)
                bindingNavigatorSaveButton.Visible = true;

            if (enable_string.IndexOf("O ") > -1)
                bindingNavigatorOKButton.Visible = true;

            if (enable_string.IndexOf('C') > -1)
                bindingNavigatorCanceButton.Visible = true;
            if (enable_string.IndexOf('L') > -1)
                bindingNavigatorLeaveButton.Visible = true;
            if (enable_string.IndexOf('F') > -1)
                bindingNavigatorSearchButton.Visible = true;
            if (enable_string.IndexOf('P') > -1)
                bindingNavigatorPreviousButton.Visible = true;
            if (enable_string.IndexOf("SE ") > -1)
                bindingNavigatorSettingsButton.Visible = true;
        }
        #endregion

        #endregion

        #region 按鈕動作:Model
        //新增
        protected virtual void NewButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "New";
            MasterBS.AddNew();
            BindingSource_AddingNew(MasterBS);
            MasterBS.Filter = "";
            if (ChildBS != null)
                ChildBS.Filter = "";
            bindingNavigatorNewButton.Enabled = false;
            bindingNavigatorEditButton.Enabled = false;
            bindingNavigatorDelButton.Enabled = false;
            bindingNavigatorSaveButton.Enabled = true;
            bindingNavigatorCanceButton.Enabled = true;
            bindingNavigatorSearchButton.Enabled = false;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = true;
                bindingNavigatorDelItemButton.Visible = true;
            }
            Object_Enable(MasterObj, true);
        }
        //修改
        protected virtual void EditButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Edit";
            bindingNavigatorNewButton.Enabled = false;
            bindingNavigatorEditButton.Enabled = false;
            bindingNavigatorDelButton.Enabled = false;
            bindingNavigatorSaveButton.Enabled = true;
            bindingNavigatorCanceButton.Enabled = true;
            bindingNavigatorSearchButton.Enabled = false;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = true;
                bindingNavigatorDelItemButton.Visible = true;
            }
            Object_Enable(MasterObj, true);
        }
        //刪除
        protected virtual void DelButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Del";
            DialogResult dr1 = MessageBox.Show("確定刪除資料??", "刪除確認", MessageBoxButtons.YesNo);
            if (dr1 == System.Windows.Forms.DialogResult.No)
                return;
            DelButton_Click_SubFunction();
            FormStatus = "Search";
        }
        //刪除的子程式，放置確定刪除時應該做的事情
        protected virtual void DelButton_Click_SubFunction()
        {
            if (ChildBS != null && ChildBS.Count > 0)
            {
                //DataRowView只能刪除眼前所看到的資料，建議使用Table來做刪除
                foreach (DataRowView drv in ChildBS.CurrencyManager.List)
                {
                    drv.Delete();
                }
                ChildBS.EndEdit();
            }
            MasterBS.RemoveCurrent();
            MasterBS.EndEdit();
        }
        //儲存
        protected virtual void SaveButton_Click(object sender, EventArgs e)
        {
            FormStatus = "Save";
            MasterBS.EndEdit();
            if (ChildBS != null)
                ChildBS.EndEdit();
            FormStatus = "Search";
            bindingNavigatorNewButton.Enabled = true;
            bindingNavigatorEditButton.Enabled = true;
            bindingNavigatorDelButton.Enabled = true;
            bindingNavigatorSaveButton.Enabled = false;
            bindingNavigatorCanceButton.Enabled = false;
            bindingNavigatorSearchButton.Enabled = true;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = false;
                bindingNavigatorDelItemButton.Visible = false;
            }
            Object_Enable(MasterObj, false);
        }
        //取消
        protected virtual void CancelButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Cancel";
            DialogResult dr1 = MessageBox.Show("資料尚未儲存，確定取消??", "取消確認", MessageBoxButtons.YesNo);
            if (dr1 == System.Windows.Forms.DialogResult.No)
                return;
            ((DataSet)MasterBS.DataSource).RejectChanges();
            MasterBS.CancelEdit();
            if (ChildBS != null)
            {
                ((DataSet)ChildBS.DataSource).RejectChanges();
                ChildBS.CancelEdit();
            }
            FormStatus = "Search";
            bindingNavigatorNewButton.Enabled = true;
            bindingNavigatorEditButton.Enabled = true;
            bindingNavigatorDelButton.Enabled = true;
            bindingNavigatorSaveButton.Enabled = false;
            bindingNavigatorCanceButton.Enabled = false;
            bindingNavigatorSearchButton.Enabled = true;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = false;
                bindingNavigatorDelItemButton.Visible = false;
            }
            Object_Enable(MasterObj, false);
        }
        //離開
        protected virtual void LeaveButton_Click(object sender, System.EventArgs e)
        {
            if (bindingNavigatorSaveButton.Visible == true)   //儲存按鈕有啟用
            {
                if (bindingNavigatorSaveButton.Enabled == true)
                {
                    DialogResult dr1 = MessageBox.Show("資料尚未儲存，確定離開程式??", "離開確認", MessageBoxButtons.YesNo);
                    if (dr1 == System.Windows.Forms.DialogResult.No)
                    {
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                }
            }
            this.Close();
        }
        //查詢按鈕
        protected virtual void SearchButton_Click(object sender, EventArgs e)
        {
            if (MasterBS.Count > 0)
                bindingNavigatorEditButton.Enabled = true;
            else
                bindingNavigatorEditButton.Enabled = false;
            Object_Enable(MasterObj, false);
        }
        //新增明細
        protected virtual void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildBS != null)
                {
                    ChildBS.AddNew();
                    BindingSource_AddingNew(ChildBS);
                }
            }
            catch
            {
                if (ChildBS != null)
                    ChildBS.RemoveCurrent();
            }
        }
        //刪除明細
        protected virtual void DelItemButton_Click(object sender, EventArgs e)
        {
            if (ChildBS != null && ChildBS.Count > 0)
                ChildBS.RemoveCurrent();
        }
        //上一步
        protected virtual void PreviousButton_Click(object sender, EventArgs e)
        {

        }
        //設定
        protected virtual void SettingsButton_Click(object sender, EventArgs e)
        { }
        //確認
        protected virtual void OKButton_Click(object sender, EventArgs e)
        { }
        //GridView指標移動通用函數
        protected virtual void IndexChange_Click(object sender, System.EventArgs e)
        {
        }
        //表單物件的啟用/不啟用
        protected virtual void Object_Enable(List<object> IwantObj, bool Iwant)
        {
            if (IwantObj == null)
                return;
            foreach (Object obj1 in IwantObj)
            {
                if (obj1 is TextBox)
                {
                    ((TextBox)obj1).ReadOnly = !Iwant;
                }
                else if (obj1 is Button)
                {
                    ((Button)obj1).Enabled = Iwant;
                }
                else if (obj1 is ComboBox)
                {
                    ((ComboBox)obj1).Enabled = Iwant;
                }
                else if (obj1 is DateTimePicker)
                {
                    ((DateTimePicker)obj1).Enabled = Iwant;
                }
            }
        }
        #endregion

        #region 通用設定:View
        //設定通用的顯示和排版
        #region 顏色定義
        //基本畫面
        public Color Color_BackColor = Color.Black;   //背景顏色
        public Color Color_ForeColor = Color.White;  //前景顏色
        //TextBox可用欄位
        public Color Color_tbEnable_ForeColor = Color.White;
        public Color Color_tbEnable_BackColor = SystemColors.MenuHighlight;
        //TextBox目標欄位
        public Color Color_tbFocus_ForeColor = Color.Black;
        public Color Color_tbFocus_BackColor = Color.Yellow;
        //Menu選單顏色
        public Color Color_Menu_ForeColor = Color.Black;         //選單前景顏色
        public Color Color_Menu_BackColor = SystemColors.ButtonFace;       //選單顏色
        //Label顏色
        public Color Color_lb_ForeColor = Color.White;
        public Color Color_lb_BackColor = Color.Transparent;
        //Label顏色_Warning
        public Color Color_lbWarning_ForeColor = Color.Red;
        public Color Color_lbWarning_BackColor = Color.Black;
        //Label顏色_memo
        public Color Color_lbMemo_ForeColor = Color.White;
        public Color Color_lbMemo_BackColor = Color.Transparent;
        //Label顏色_memo_重要
        public Color Color_lbMemoImportant_ForeColor = Color.Black;
        public Color Color_lbMemoImportant_BackColor = Color.Yellow;
        #endregion

        #region 統一介面顏色
        private void New_WSC_DLL_Form_Uniform()
        {
            this.BackColor = Color_BackColor;
            CarSystem_FormBindingNavigator.BackColor = Color_Menu_BackColor;

            New_WSC_DLL_Form_Uniform_SubFun1(this);

        }
        private void New_WSC_DLL_Form_Uniform_SubFun1(Control MainControl)
        {
            foreach (Control tb in MainControl.Controls)
            {
                string tbName = tb.GetType().Name.ToString();
                if (tbName == "Label")
                {
                    ((Label)tb).TextAlign = ContentAlignment.MiddleLeft;
                    if (tb.Tag !=null)
                    {
                        switch (tb.ForeColor.Name)
                        {
                            case "Red":
                                tb.ForeColor = Color_lbWarning_ForeColor;
                                tb.BackColor = Color_lbWarning_BackColor; break;
                            case "Black":
                                tb.ForeColor = Color_lbMemo_ForeColor;
                                tb.BackColor = Color_lbMemo_BackColor; break;
                            case "White":
                                tb.ForeColor = Color_lb_ForeColor;
                                tb.BackColor = Color_lb_BackColor;
                                break;
                        }
                    }
                }
                else if (tbName == "MyButton")
                {
                    ((myButton)tb).ChangeBkColor(this.BackColor);
                    if (tb.BackColor != Color.Transparent)
                    {
                        tb.BackColor = Color_Menu_BackColor;
                        tb.ForeColor = Color_Menu_ForeColor;
                    }
                    tb.PreviewKeyDown += Button_PreviewKeyDown;
                    tb.KeyDown += Button_KeyDown;
                }
                else if (tbName == "Button")
                {
                    if (tb.BackColor != Color.Transparent)
                    {
                        tb.BackColor = Color_Menu_BackColor;
                        tb.ForeColor = Color_Menu_ForeColor;
                    }
                    tb.PreviewKeyDown += Button_PreviewKeyDown;
                    tb.KeyDown += Button_KeyDown;
                }
                else if (tbName == "RadioButton")
                {
                    tb.BackColor = Color_Menu_BackColor;
                    tb.ForeColor = Color_Menu_ForeColor;
                }
                else if (tbName == "TextBox")
                {
                    if (((TextBox)tb).ReadOnly != true)
                    {
                        tb.BackColor = Color_tbEnable_BackColor;
                        tb.ForeColor = Color_tbEnable_ForeColor;
                        tb.DoubleClick += TextBox_DoubleClick;
                        tb.Click += TextBox_DoubleClick;
                        tb.GotFocus += TextBox_GotFocus;
                        tb.LostFocus += TextBox_LostFocus;
                        tb.KeyDown += ToolStripTextBox_KeyDown;
                    }
                }
                else if (tbName == "ToolStripTextBoxControl")
                {
                    tb.KeyDown += ToolStripTextBox_KeyDown;
                }
                else if (tbName == "ToolStrip")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "Panel")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "GroupBox")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "TabControl")
                {
                    TabControl obj = tb as TabControl;
                    obj.Appearance = TabAppearance.Buttons;
                    obj.ItemSize = new Size(0, 1);
                    obj.SizeMode = TabSizeMode.Fixed;
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "TabPage")
                {
                    tb.BackColor = this.Color_BackColor;
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
            }
        }
        #endregion

        #region TextBox顯示
        //TextBox連點兩下全選
        protected void TextBox_DoubleClick(object sender, EventArgs e)
        {
            //反白
            ((TextBox)sender).SelectAll();
        }
        //TextBox只能輸入數字,BackSpace,Enter
        protected void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //TextBox預設值為0
        protected void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = "0";
        }
        /// <summary>
        ///                     後+前
        /// 可以使用的TextBox   SystemColors.MenuHighlight+Color.White
        /// 獲得焦點的TextBox   Color.Yellow+Color.Black
        /// 不能用的TextBox     SystemColors.Window+SystemColors.WindowText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //TextBox離開焦點
        void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.BackColor = Color_tbEnable_BackColor;
            tb.ForeColor = Color_tbEnable_ForeColor;
        }
        //TextBox接受到焦點
        void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.BackColor = Color_tbFocus_BackColor;
            tb.ForeColor = Color_tbFocus_ForeColor;
        }
        #endregion

        #region 車機Form特殊功能
        //物件上的Tab=按下Enter
        protected void ToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //自動跳到下一個TextBox
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        //物件接收焦點時全選
        protected void ToolStripTextBox_GotFocus(object sender, EventArgs e)
        {
            //反白
            ((ToolStripTextBox)sender).SelectAll();
        }
        //按鈕禁止透過鍵盤輸入
        protected void Button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                case Keys.Enter:
                    e.IsInputKey = true; break;
            }
        }
        protected void Button_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        //設定通用的按鍵指令
        protected virtual void WSC_Sample_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bindingNavigatorLeaveButton.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
                bindingNavigatorAddItemButton.PerformClick();
            else if (e.KeyCode == Keys.F12)
                bindingNavigatorDelItemButton.PerformClick();
        }
        #endregion

        #region Button通用功能 按鈕亮燈不亮燈
        Button Previous_button; //紀錄前一個亮燈的按鈕,就不需要用foreach搜尋
        protected virtual void Button_GotFocus(object sender, EventArgs e)
        {
            if (Previous_button != null)
                Previous_button.ForeColor = System.Drawing.Color.Black;
            ((Button)sender).ForeColor = System.Drawing.Color.Red;
            Previous_button = (Button)sender;
        }
        protected virtual void Button_LostFocus(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = System.Drawing.Color.Black;
        }
        #endregion

        //Form讀取
        protected virtual void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            //統一介面顏色規格
            New_WSC_DLL_Form_Uniform();

            //指定Server
            Login_Server = UserInf.DBName;

            //指定鎖單時用到的FormName
            strLockFormName = "CarSys" + this.Name;

            //視窗自動調整大小
            ResizeForm.WSC_Resize(this);
        }

        /// <summary>
        /// 最大化螢幕專用,複寫原本的功能讓程式不作用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CarSystem_Sample_Form_Resize(object sender, EventArgs e)
        {

        }
        #endregion

        #region 其他小功能

        #region WSC自定讀取中的等待視窗
        Thread LoadingWindowThread;
        WaitWindow ww;

        #region Thread的執行
        protected void StartLoadingShow()
        {
            ww = new WaitWindow();
            ww.SetMessage("查詢中，請稍等");
            CheckThreadState();
        }

        protected void StartLoadingShow(string TitleText)
        {
            ww = new WaitWindow();
            ww.SetMessage(TitleText);
            CheckThreadState();
        }
        private void CheckThreadState()
        {
            if (LoadingWindowThread == null || LoadingWindowThread.ThreadState == ThreadState.Aborted)
            {
                LoadingWindowThread = new Thread(CreateLoadingWindow);
            }
            LoadingWindowThread.Start();
        }
        /// <summary>
        /// 存取不同執行緒的元件時，用委派的方式
        /// </summary>
        protected void CreateLoadingWindow()
        {
            this.Invoke(new MethodInvoker(CreateLoadingWindowShowDialog));
        }
        protected void CreateLoadingWindowShowDialog()
        {
            ww.TopMost = true;
            ww.ShowDialog();
        }
        #endregion

        #region Thread的關閉
        protected void CloseLoadingShow()
        {
            this.Invoke(new MethodInvoker(HideLoadingWindow));

            //避免重複呼叫到關閉程式
            if (LoadingWindowThread != null)
            {
                LoadingWindowThread.Abort();
            }
            LoadingWindowThread = null;
        }
        protected void HideLoadingWindow()
        {
            ww.Close();
        }
        #endregion

        #endregion

        #region 螢幕小鍵盤
        #region 螢幕小鍵盤_數字
        protected virtual void Click_Show_frmKeyboardNumber(object sender, System.EventArgs e)
        {
            Control FocusItem = (Control)sender;

            IntPtr FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_EngNumber");

            if (FindKeyboard_NumberWindow != IntPtr.Zero)
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Close();
            }

            FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_Number");

            if (FindKeyboard_NumberWindow == IntPtr.Zero)
            {
                Keyboard_Number frm1 = new Keyboard_Number();
                frm1.Tag = this.Handle;
                frm1.Owner = this;
                frm1.Show();
            }
            else
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Tag = this.Handle;
                frmBef.Owner = this;
                frmBef.Show();
                //Keyboard_Number frm1 = new Keyboard_Number();
                //frm1.Tag = this.Handle;
                //frm1.Owner = this;
                //frm1.Show();
            }

            FocusItem.Focus();
        }
        #endregion

        #region 螢幕小鍵盤_英文數字
        protected virtual void Click_Show_frmKeyboardEngNumber(object sender, System.EventArgs e)
        {
            Control FocusItem = (Control)sender;
            IntPtr FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_Number");

            if (FindKeyboard_NumberWindow != IntPtr.Zero)
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Close();
            }

            FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_EngNumber");

            if (FindKeyboard_NumberWindow == IntPtr.Zero)
            {
                Keyboard_EngNumber frm1 = new Keyboard_EngNumber();
                frm1.Tag = this.Handle;
                frm1.Owner = this;
                frm1.Show();
            }
            else
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Tag = this.Handle;
                frmBef.Owner = this;
                frmBef.Show();
                //Keyboard_EngNumber frm1 = new Keyboard_EngNumber();
                //frm1.Tag = this.Handle;
                //frm1.Owner = this;
                //frm1.Show();
            }
            FocusItem.Focus();
        }
        #endregion

        #region 隱藏小鍵盤
        protected void DisableAllKeyboard()
        {
            IntPtr FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_Number");

            if (FindKeyboard_NumberWindow != IntPtr.Zero)
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Close();
            }

            FindKeyboard_NumberWindow = FindWindow(null, "Keyboard_EngNumber");

            if (FindKeyboard_NumberWindow != IntPtr.Zero)
            {
                Form frmBef = (Form)Control.FromHandle(FindKeyboard_NumberWindow);
                frmBef.Close();
            }
        }
        #endregion
        #endregion

        #region 單據操作要建立log
        /// <summary>
        /// 寫入log
        /// </summary>
        /// <param name="strDB"></param>
        /// <param name="sqlcom"></param>
        /// <param name="Prm"></param>
        public void SqlCarOperateLog(string Sysno, string Action, int Defqty, int Actqty)
        {
            string cmdstring = @"Insert Into CarSystem.dbo.CaroperateLog(UserID,UserIP,Project,Sysno,Action,Defqty,Actqty)
                values (@UserID,@UserIP,@Project,@Sysno,@Action,@Defqty,@Actqty)";
            Hashtable ht_Param = new Hashtable();
            ht_Param.Add("@UserID", UserInf.UserID);
            ht_Param.Add("@UserIP", UserInf.IP);
            ht_Param.Add("@Project", this.Name);
            ht_Param.Add("@Sysno", Sysno);
            ht_Param.Add("@Action", Action);
            ht_Param.Add("@Defqty", Defqty);
            ht_Param.Add("@Actqty", Actqty);
            IO.SqlQuery(Login_Server, cmdstring, ht_Param);
            reclog.ExLog("00","Login");
        }
        #endregion

        #region 鎖單,釋放單據

        public string strLockRequestString = "";   //鎖單,釋放單據失敗的回傳資訊
        /// <summary>
        /// 鎖定單號
        /// </summary>
        /// <param name="WorkType">單據類別</param>
        /// <param name="LockString">鎖定字串(unique)</param>
        /// <returns>True=鎖單成功 False=鎖單失敗</returns>
        protected bool LockRequest(string WorkType, string LockString)
        {
            bool IsOk = true;

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@S_loct_name", WorkType);
            ht1.Add("@S_loct_id", LockString);
            ht1.Add("@S_loct_user", UserInf.UserID);
            ht1.Add("@S_loct_where", UserInf.ComputerName);
            ht1.Add("@S_loct_formname", strLockFormName);

            OutValue_finish.Add("@I_reuslt", 0);
            OutValue_finish.Add("@S_result", "");
            OutValue_finish.Add("@LockRequest", "");
            DataSet DS_Query = IO.SqlSp(Login_Server, "[SP_LockRequest_CarSystem]", ht1, ref OutValue_finish);
            int I_result = Convert.ToInt32(OutValue_finish["@I_reuslt"].ToString());
            string S_result = OutValue_finish["@S_result"].ToString(),
                LockRequest = OutValue_finish["@LockRequest"].ToString();
            strLockRequestString = S_result;

            if (LockRequest == "Y")
                IsOk = false;

            return IsOk;
        }

        /// <summary>
        /// 釋放單號
        /// </summary>
        /// <param name="WorkType">單據類別</param>
        /// <param name="LockString">鎖定字串(unique)</param>
        /// <returns>True=釋放成功 False=釋放失敗</returns>
        public bool LockRelease(string WorkType, string LockString)
        {
            bool IsOk = true;

            Hashtable ht1 = new Hashtable(), OutValue_finish = new Hashtable();
            ht1.Add("@S_loct_name", WorkType);
            ht1.Add("@S_loct_id", LockString);
            ht1.Add("@S_loct_user", UserInf.UserID);
            ht1.Add("@S_loct_where", UserInf.ComputerName);

            OutValue_finish.Add("@I_reuslt", 0);
            OutValue_finish.Add("@S_result", "");
            DataSet DS_Query = IO.SqlSp(Login_Server, "[SP_LockRelease_CarSystem]", ht1, ref OutValue_finish);
            int I_result = Convert.ToInt32(OutValue_finish["@I_reuslt"].ToString());
            string S_result = OutValue_finish["@S_result"].ToString();
            strLockRequestString = S_result;

            if (I_result == 0)
                IsOk = true;

            return IsOk;
        }
        #endregion

        #region 字典搜尋
        /// <summary>
        /// 字典搜尋
        /// </summary>
        /// <param name="dt_Source">來源Table</param>
        /// <param name="ColumnName">欲查詢欄位</param>
        /// <param name="SearchString">查詢值</param>
        /// <returns>行數代號</returns>
        protected int MyDictionaryFind(DataTable dt_Source, string ColumnName, string SearchString)
        {
            int Search_Index = -1;
            //建立Dictionary
            Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
            int i = 0;
            foreach (DataRow dr in dt_Source.Rows)
            {
                if (MyDictionary.ContainsKey(dr[ColumnName].ToString()) == false)
                {
                    MyDictionary.Add(dr[ColumnName].ToString(), i);
                    i++;
                }
            }
            //查詢
            if (MyDictionary.ContainsKey(SearchString))
            {
                Search_Index = MyDictionary[SearchString];
            }
            return Search_Index;
        }
        #endregion

        #endregion
    }

}
