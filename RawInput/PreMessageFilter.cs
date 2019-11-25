using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;

namespace RawInput_dll
{
    public class PreMessageFilter : IMessageFilter
    {

        int x = 5;
        // true  to filter the message and stop it from being dispatched 
        // false to allow the message to continue to the next filter or control.

        public bool PreFilterMessage(ref Message m)
        {
            return false;
                //m.Msg == Win32.WM_KEYDOWN;
        }
    }
}
