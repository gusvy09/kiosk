using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ham
{
    internal class TransparentTabControl : TabControl
    {
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            // TabPage에 Panel을 추가하여 투명한 배경을 만듭니다.
            if (e.Control is TabPage tabPage)
            {
                var panel = new Panel
                {
                    Parent = tabPage,
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent
                };
            }
        }
    }
}
