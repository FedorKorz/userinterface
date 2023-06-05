using Aquality.Selenium.Browsers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceVisual
{
    public class BaseTest
    {

        dynamic browser;
        [SetUp]
        public void Setup()
        {
            browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo("https://userinyerface.com/");
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void Teardown()
        {
            browser.Quit();
        }

    }
}
