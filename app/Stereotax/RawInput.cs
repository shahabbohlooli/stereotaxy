using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Drawing.Text;
//using WindowsFormsApplication1;
using System.Management;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Linearstar.Windows.RawInput;
using System.Windows.Forms;
namespace Stereotaxy
{
    class RawInputReceiverWindow : NativeWindow
    {
        public event EventHandler<RawInputEventArgs> Input;

        public RawInputReceiverWindow()
        {
            CreateHandle(new CreateParams
            {
                X = 0,
                Y = 0,
                Width = 0,
                Height = 0,
                Style = 0x800000,
            });
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;

            if (m.Msg == WM_INPUT)
            {
                var data = RawInputData.FromHandle(m.LParam);

                Input?.Invoke(this, new RawInputEventArgs(data));
            }

            base.WndProc(ref m);
        }
    }
    class RawInputEventArgs : EventArgs
    {
        public RawInputEventArgs(RawInputData data)
        {
            Data = data;
        }

        public RawInputData Data { get; }
    }
}
