using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public class DbTreeView : TreeView
    {
        private const int TvFirst = 0x1100;
        private const int TvmSetbkcolor = TvFirst + 29;
        private const int TvmSetextendedstyle = TvFirst + 44;

        private const int TvsExDoublebuffer = 0x0004;

        public DbTreeView()
        {
            // Enable default double buffering processing
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            // Disable default CommCtrl painting on non-Vista systems
            if (!NativeInterop.IsWinVista)
                SetStyle(ControlStyles.UserPaint, true);
        }

        private void UpdateExtendedStyles()
        {
            var style = 0;

            if (DoubleBuffered)
                style |= TvsExDoublebuffer;

            if (style != 0)
                NativeInterop.SendMessage(Handle, TvmSetextendedstyle, (IntPtr)TvsExDoublebuffer, (IntPtr)style);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateExtendedStyles();
            if (!NativeInterop.IsWinXp)
                NativeInterop.SendMessage(Handle, TvmSetbkcolor, IntPtr.Zero, (IntPtr)ColorTranslator.ToWin32(BackColor));
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
