using NUnit.Framework;
using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceVisual.Utils
{
    public static class PassGenerator
    {
        public static String getPassword() 
        {
            var pwd = new Password().IncludeLowercase().IncludeUppercase().IncludeSpecial("-").IncludeNumeric().LengthRequired(10);
            return pwd.Next();
        }
    }
}
