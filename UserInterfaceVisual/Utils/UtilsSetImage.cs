using WindowsInput;
using WindowsInput.Native;

namespace UserInterfaceVisual.Utils;

public static class UtilsSetImage
{
    public static void uploadImage(string pathAvatar, int timeDelay)
    {
        var virtualKeyboard = new InputSimulator();
        Thread.Sleep(timeDelay);
        virtualKeyboard.Keyboard.TextEntry(pathAvatar);
        virtualKeyboard.Keyboard.KeyPress(VirtualKeyCode.RETURN);
    }
}