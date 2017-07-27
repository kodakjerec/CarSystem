using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System;

namespace Car_Fun
{
    #region 調整表單大小
    public static class ResizeForm
    {
        public static double WidthChange = 0;
        public static double HeightChange = 0;
        public static double ChangeSize = 0, FontChangeSize = 0;

        public static void WSC_Resize(Form form)
        {
            //將視窗所有控制項大小調整至與  螢幕  相同
            WidthChange = (double)Screen.PrimaryScreen.WorkingArea.Width / form.Width;
            HeightChange = (double)(Screen.PrimaryScreen.WorkingArea.Height) / form.Height;
            ChangeSize = (double)WidthChange > HeightChange ? HeightChange : WidthChange;
            FontChangeSize = (double)ChangeSize - 0.3 < 1 ? 1 : ChangeSize;
            Controls_adjust(form);
        }

        public static void WSC_Resize(Form form, double type)
        {
            //將視窗所有控制項大小調整至與  *設計大小*  相同
            WidthChange = (double)Screen.PrimaryScreen.WorkingArea.Width / (1024 * type);
            HeightChange = (double)Screen.PrimaryScreen.WorkingArea.Height / (768 * type);
            ChangeSize = (double)WidthChange > HeightChange ? HeightChange : WidthChange;
            FontChangeSize = (double)ChangeSize - 0.3 < 1 ? 1 : ChangeSize;
            Controls_adjust(form);
        }

        public static void Controls_adjust(Form form)
        {
            #region 更改表單大小
            form.AutoScaleMode = AutoScaleMode.None;
            form.Width = (int)(form.Width * WidthChange);
            form.Height = (int)(form.Height * HeightChange);
            #endregion

            #region 更改表單起始位置
            int StartX = 0, StartY = 0;
            StartX = (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2;
            StartY = (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(StartX, StartY);
            #endregion

            #region 迴圈對每個控制項做變更
            foreach (Control con in form.Controls)
            {
                GetAllInitInfo(con);
            }
            #endregion
        }

        private static void GetAllInitInfo(Control CrlContainer)
        {
            CrlContainer.Size = new Size((int)(CrlContainer.Width * WidthChange), (int)(CrlContainer.Height * HeightChange));
            CrlContainer.Location = new Point((int)(CrlContainer.Location.X * WidthChange), (int)(CrlContainer.Location.Y * HeightChange));

            string tbName = CrlContainer.GetType().Name.ToString();
            //DataGridView的Header會因為字型變大而被截斷，因此調整Row高度而不調整字型
            if (tbName == "DataGridView")
            {
                DataGridView obj = CrlContainer as DataGridView;
                //列高
                obj.ColumnHeadersHeight = (int)(obj.ColumnHeadersHeight * ChangeSize);
                //列寬, 字形
                foreach (DataGridViewColumn column in obj.Columns)
                {
                    column.Width = (int)(column.Width * WidthChange);
                    if (column.DefaultCellStyle.Font != null)
                        column.DefaultCellStyle.Font = new Font(column.DefaultCellStyle.Font.Name, (float)(column.DefaultCellStyle.Font.Size * ChangeSize));
                }

                //行高
                obj.RowTemplate.Height = (int)(obj.RowTemplate.Height * HeightChange);
                //字形, 行寬==列寬
                foreach (DataGridViewRow row in obj.Rows)
                {
                    if (row.DefaultCellStyle.Font != null)
                    row.DefaultCellStyle.Font = new Font(row.DefaultCellStyle.Font.Name, (float)(row.DefaultCellStyle.Font.Size * ChangeSize));
                }

            }
            else
            {
                CrlContainer.Font = new Font(CrlContainer.Font.Name, (float)(CrlContainer.Font.Size * ChangeSize));
            }

            if (CrlContainer.Controls.Count > 0)
            {
                foreach (Control con in CrlContainer.Controls)
                {
                    GetAllInitInfo(con);
                }
            }
        }
    }
    #endregion
}