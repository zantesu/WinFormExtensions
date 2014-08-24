using System;
using System.Runtime.InteropServices;

namespace WinFormExtensions
{
    internal class NativeInterop
    {
        public const int WmPrintclient = 0x0318;
        public const int PrfClient = 0x00000004;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public static bool IsWinXp
        {
            get
            {
                var os = Environment.OSVersion;
                return (os.Platform == PlatformID.Win32NT) &&
                    ((os.Version.Major > 5) || ((os.Version.Major == 5) && (os.Version.Minor == 1)));
            }
        }

        public static bool IsWinVista
        {
            get
            {
                var os = Environment.OSVersion;
                return (os.Platform == PlatformID.Win32NT) && (os.Version.Major >= 6);
            }
        }
    }
}
