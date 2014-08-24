using System;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public class DbListView : ListView
    {
        public DbListView()
        {
            // Enable internal ListView double-buffering
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            // Disable default CommCtrl painting on non-XP systems
            if (!NativeInterop.IsWinXp)
                SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (GetStyle(ControlStyles.UserPaint))
            {
                var m = new Message
                            {
                                HWnd = Handle,
                                Msg = NativeInterop.WmPrintclient,
                                WParam = e.Graphics.GetHdc(),
                                LParam = (IntPtr) NativeInterop.PrfClient
                            };
                DefWndProc(ref m);
                e.Graphics.ReleaseHdc(m.WParam);
            }
            base.OnPaint(e);
        }
    }
}
