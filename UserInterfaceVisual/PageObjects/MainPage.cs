using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterfaceVisual.pageObjects;

public class MainPage : Form
{
    public MainPage() : base(By.XPath("//div[@class='logo__icon']"), "MainPage")
    {
    }

    private ITextBox EmailTextBox =>
        ElementFactory.GetTextBox(By.XPath("//a[@class='start__link']"), "First Card Link");

    private IButton CookiePanel => ElementFactory.GetButton(By.XPath("//div[@class='cookies']"), "Cookies Panel");

    private IButton AcceptCookiesButton =>
        ElementFactory.GetButton(By.XPath("(//button[normalize-space()='Not really, no'])[1]"),
            "Accept Cookies button");

    private ITextBox TimerValue =>
        ElementFactory.GetTextBox(By.XPath("//div[@class='timer timer--white timer--center']"), "Timer");

    private IButton HideHelpFormButton =>
        ElementFactory.GetButton(By.XPath("//button[contains(@class, 'send-to-bottom')]"), "Hide Form Button");

    public void getFirstCard()
    {
        EmailTextBox.State.WaitForClickable();
        if (EmailTextBox.State.IsDisplayed) EmailTextBox.Click();
    }

    public bool isCookiesPanelDisplayed()
    {
        CookiePanel.WaitAndClick();
        return CookiePanel.State.IsDisplayed;
    }

    public void acceptCookies()
    {
        AcceptCookiesButton.WaitAndClick();
    }

    public bool isCookiesPanelClosed()
    {
        return !CookiePanel.State.IsDisplayed;
    }

    public string getTimer()
    {
        return TimerValue.Text;
    }

    public void hideHelpForm()
    {
        HideHelpFormButton.Click();
        HideHelpFormButton.State.WaitForNotDisplayed();
    }

    public bool isHelpFormDisplayed()
    {
        return HideHelpFormButton.State.IsDisplayed;
    }
}