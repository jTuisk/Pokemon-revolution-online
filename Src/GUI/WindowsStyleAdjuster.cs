
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Pokemon_revolution_online_bot.Src.GUI
{

    public class WindowStyleAdjuster
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool AdjustWindowRect(ref RECT lpRect, uint dwStyle, bool bMenu);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        private const int GWL_STYLE = -16;
        private const uint WS_BORDER = 0x00800000;
        private const uint WS_CAPTION = 0x00C00000;
        private const uint WS_THICKFRAME = 0x00040000;

        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_FRAMECHANGED = 0x0020;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void MoveChild(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint=true)
        {
            MoveWindow(hWnd, X, Y, nWidth, nHeight, bRepaint);
        }

        public static void RemoveBorders(IntPtr handle, int desiredWidth, int desiredHeight)
        {
            int style = GetWindowLong(handle, GWL_STYLE);
            SetWindowLong(handle, GWL_STYLE, style & ~(int)(WS_BORDER | WS_CAPTION | WS_THICKFRAME));
            RECT rect = new RECT
            {
                Left = 0,
                Top = 0,
                Right = desiredWidth,
                Bottom = desiredHeight
            };

            AdjustWindowRect(ref rect, (uint)(style & ~(int)(WS_BORDER | WS_CAPTION | WS_THICKFRAME)), false);
            int adjustedWidth = rect.Right - rect.Left;
            int adjustedHeight = rect.Bottom - rect.Top;
            SetWindowPos(handle, IntPtr.Zero, 0, 0, adjustedWidth, adjustedHeight, SWP_NOZORDER | SWP_NOMOVE | SWP_FRAMECHANGED);
        }
    }

}
