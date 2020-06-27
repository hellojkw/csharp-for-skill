using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;

namespace EXCEL2020
{
    public static class WorksheetBaseExtension
    {
        public static Tools.Controls.Button CreateButton(this Tools.WorksheetBase worksheetBase, string buttonName, Excel.Range range, Action action)
        {
            var button = new Tools.Controls.Button();
            button.Text = buttonName;
            button.Click += (sender, args) => action?.Invoke();
            worksheetBase.Controls.AddControl(button, range, buttonName);

            return button;
        }

        public static Excel.Range GetCell(this Tools.WorksheetBase worksheetBase, int row, int column)
        {
            return (Excel.Range)worksheetBase.Cells[row, column];
        }
    }
}
