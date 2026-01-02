using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Helpers.UI.GridView
{
    public class clsGridColumnDefinition
    {
        public string ColumnName { get; set; }
        public string HeaderText { get; set; }
        public string DataProperty { get; set; }
        public bool ReadOnly { get; set; }
        public bool IsCheckBoxColumn { get; set; }
        public enum enColumnType { Default, Checkbox, Combo, Button, Image, Link }
        public enColumnType Type;

        public clsGridColumnDefinition(string ColumnName, string HeaderText, string DataProperty, enColumnType Type = enColumnType.Default, bool ReadOnly = true)
        {
            this.ColumnName = ColumnName;
            this.HeaderText = HeaderText;
            this.DataProperty = DataProperty;
            this.ReadOnly = ReadOnly;
            this.IsCheckBoxColumn = IsCheckBoxColumn;
            this.Type = Type;
        }
    }
}
