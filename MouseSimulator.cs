using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public static class MouseSimulatorLeft
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public uint type;
            public INPUTUNION union;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct INPUTUNION
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void SimulateLeftClick(int x, int y)
        {
            INPUT[] input = new INPUT[2];

            // Simulira pritisak levog tastera miša
            input[0] = new INPUT();
            input[0].type = INPUT_MOUSE;
            input[0].union.mi.dx = x;
            input[0].union.mi.dy = y;
            input[0].union.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

            // Simulira puštanje levog tastera miša
            input[1] = new INPUT();
            input[1].type = INPUT_MOUSE;
            input[1].union.mi.dx = x;
            input[1].union.mi.dy = y;
            input[1].union.mi.dwFlags = MOUSEEVENTF_LEFTUP;

            // Šalje input Windows operativnom sistemu
            SendInput((uint)input.Length, input, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}
