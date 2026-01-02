using System.Windows.Forms;
using System;
using DVLD.Core.Utils.String;

namespace DVLD.UI.Utils.Presentation
{
    public class clsPresentationUtils
    {
        public enum enDirection { X, Y, All }

        public static void SetErrorAndFocus(ref TextBox TextBox, ErrorProvider ErrorProvider, string Message)
        {
            ErrorProvider.SetError(TextBox, Message);
            TextBox.Focus();
        }

        public static void DistributeColumnsInDataGridView(DataGridView Container, int minColumnWidth = 20)
        {
            if (Container == null || Container.ColumnCount == 0)
            {
                return;
            }

            int availableWidth = Container.Width;
            int columnCount = Container.ColumnCount;

            int baseColumnWidth = availableWidth / columnCount;

            baseColumnWidth = Math.Max(baseColumnWidth, minColumnWidth);

            for (int i = 0; i < columnCount; i++)
            {
                Container.Columns[i].Width = baseColumnWidth;
            }
        }

        public static void CenterControl(Control Perent, ref Control ControlToCenter, enDirection Direction)
        {
            if (Direction == enDirection.X || Direction == enDirection.All)
            {
                ControlToCenter.Left = (Perent.ClientSize.Width - ControlToCenter.Width) / 2;
            }
            if (Direction == enDirection.Y || Direction == enDirection.All)
            {
                ControlToCenter.Top = (Perent.ClientSize.Height - ControlToCenter.Height) / 2;
            }
        }

        public static bool PreventEnterStringInTextBox(TextBox TextBox, bool Checked = false)
        {
            if (!Checked && int.TryParse(TextBox.Text, out _))
            {
                return true;
            } else
            {
                if (TextBox.Text.Length > 0)
                {
                    TextBox.Text = clsStringUtils.RemoveLastChar(TextBox.Text);
                    TextBox.SelectionStart = TextBox.Text.Length;
                }
                return false;
            }
        }
    }
}
