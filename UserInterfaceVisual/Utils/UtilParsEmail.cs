using System.Text.RegularExpressions;
using ApiTest.Utils;

namespace UserInterfaceVisual.Utils;

public static class UtilParsEmail
{
    public static string getEmailName()
    {
        return UtilsJson.ReadJsonFile("email").Split("@")[0];
    }

    public static string getEmailDomain()
    {
        const string pattern = "(?<=@)[^.]+(?=\\.)";
        var rg = new Regex(pattern);
        var parsedEmailDomain = rg.Matches(UtilsJson.ReadJsonFile("email"));
        return parsedEmailDomain[0].Value;
    }

    public static string getEmailExtension()
    {
        return UtilsJson.ReadJsonFile("email").Split('.')[1];
    }
}