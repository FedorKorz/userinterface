using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace UserInterfaceVisual;

public class BaseTest
{
    private dynamic browser;

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