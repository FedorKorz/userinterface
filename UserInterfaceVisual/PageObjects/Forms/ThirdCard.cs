using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterfaceVisual.PageObjects.Forms;

public class ThirdCard : Form
{
    public ThirdCard() : base(By.XPath("//div[@class='personal-details__form']"), "Third Card")
    {
    }
}