using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Toggler
{
	internal class Program
	{
		const int SW_HIDE = 0, SW_RESTORE = 9;

		[DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool IsWindowVisible(IntPtr hWnd);

		static void Main(string[] args)
		{
			IntPtr hWnd = FindWindow(null, "iCUE");

			if (hWnd == IntPtr.Zero)
			{
				Console.WriteLine("iCUE window not found.");
				return;
			}

			if (IsWindowVisible(hWnd))
			{
				ShowWindow(hWnd, SW_HIDE);
			}
			else
			{
				ShowWindow(hWnd, SW_RESTORE);
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct WindowPlacement
	{
		public int length;
		public int flags;
		public int showCmd;
		public Point ptMinPosition;
		public Point ptMaxPosition;
		public Rectangle rcNormalPosition;
	}
}