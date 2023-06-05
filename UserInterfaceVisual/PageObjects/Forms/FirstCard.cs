using AngleSharp.Common;
using ApiTest.Utils;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceVisual.pageObjects;
using UserInterfaceVisual.Utils;

namespace UserInterfaceVisual.PageObjects.Forms
{
    public class FirstCard : Form
    {
        public FirstCard() : base(By.XPath("//div[@class='login-form__container']"), "Firs Card")
        {

        }
        private ITextBox PasswordTextBox => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Choose Password']"), "Password field");
        private ITextBox emailLogin => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Your email']"), "Email Login field");
        private ITextBox emailDomain => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "Domain field");
        private IComboBox dropdowExtension => ElementFactory.GetComboBox(By.XPath("//div[@class='dropdown__field']"), "Extension field");
        private ICheckBox termsCheckBox => ElementFactory.GetCheckBox(By.XPath("//label[@for='accept-terms-conditions']"), "Terms checkbox");
        private ICheckBox nextCardButton => ElementFactory.GetCheckBox(By.XPath("//a[@class='button--secondary']"), "Second Card button");



        public void setPasswrod()
        {
            PasswordTextBox.State.WaitForDisplayed();
            PasswordTextBox.ClearAndType(PassGenerator.getPassword(), true);
        }

        public void setEmailLogin()
        {
            emailLogin.ClearAndType(UtilParsEmail.getEmailName());
        }

        public void setEmailDomain()
        {
            emailDomain.ClearAndType(UtilParsEmail.getEmailDomain());
        }

        public void clickExtensionDropdown()
        {
            dropdowExtension.ClickAndWait();
        }

        public void setEmailExtenstion()
        {
            var textBoxes = AqualityServices.Get<IElementFactory>().FindElements<ITextBox>(By.XPath("//div[@class='dropdown__list-item']"));
           
            for (int i = 0; i < textBoxes.Count - 1; i++)
            {
                if (textBoxes[i].Text.Contains(UtilParsEmail.getEmailExtension()))
                {
                    textBoxes[i].ClickAndWait();
                    break;
                }
            }
        }

        public void uncheckTermsCheckBox()
        {
            if (!termsCheckBox.IsChecked)
            {
                termsCheckBox.Check();
            }
        }

        public void goToSecondCard()
        {
            nextCardButton.ClickAndWait();
        }

    }
}
