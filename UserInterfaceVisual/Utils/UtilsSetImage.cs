using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace UserInterfaceVisual.Utils
{
    public static class UtilsSetImage
    {
        public static void uploadImage(string pathAvatar, int timeDelay)
        {
            InputSimulator virtualKeyboard = new InputSimulator();
            Thread.Sleep(timeDelay);
            virtualKeyboard.Keyboard.TextEntry(pathAvatar);
            virtualKeyboard.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
    }
}
