using ApiTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserInterfaceVisual.Utils
{
    public static class UtilParsEmail
    {

        public static String  getEmailName() 
        {
            return UtilsJson.ReadJsonFile("email").Split("@")[0];
        }

        public static String getEmailDomain()
        {
            string pattern = "(?<=@)[^.]+(?=\\.)";
            Regex rg = new Regex(pattern);
            MatchCollection parsedEmailDomain = rg.Matches(UtilsJson.ReadJsonFile("email"));
            return parsedEmailDomain[0].Value;
        }

        public static String getEmailExtension()
        {
            return UtilsJson.ReadJsonFile("email").Split('.')[1];
        }
    }
}
