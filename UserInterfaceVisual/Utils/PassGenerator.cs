using PasswordGenerator;

namespace UserInterfaceVisual.Utils;

public static class PassGenerator
{
    public static string getPassword()
    {
        var pwd = new Password().IncludeLowercase().IncludeUppercase().IncludeSpecial("-").IncludeNumeric()
            .LengthRequired(10);
        return pwd.Next();
    }
}