using System;
using System.Windows.Forms;


namespace Titan.PathFindTool
{
    public partial class FlickerFreePanel : Panel
    {
        public FlickerFreePanel()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
