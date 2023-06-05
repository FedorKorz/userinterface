using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.VisualStudio.CodeCoverage;
using Aquality.Selenium.Browsers;
using NUnit.Framework;
using System.Collections;
using System.Diagnostics;
using ApiTest.Utils;
using AngleSharp.Text;
using UserInterfaceVisual.Utils;

namespace UserInterfaceVisual.PageObjects.Forms
{
    public class SecondCard : Form
    {

        public SecondCard() : base(By.XPath("//div[@class='avatar-and-interests']"), "Second Card")
        {
            listOfInterests = new ArrayList();
        }

        private ILabel unselecentAllBox => ElementFactory.GetLabel(By.XPath("//label[@for='interest_unselectall']"), "Unselecent all checkbox");
        private ILink uploadImageLink => ElementFactory.GetLink(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "Upload link");
        private IButton nextCardButton => ElementFactory.GetButton(By.XPath("//button[contains(@class, 'button--white button--fluid')]"), "Next Page Button");
        dynamic interestLabels = AqualityServices.Get<IElementFactory>().FindElements<ITextBox>(By.XPath("//div[@class='avatar-and-interests__interests-list']//div[1]//span[2]"));
        private static string pathAvatar = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../")) + "Resources\\avatar.jpg";
        private ArrayList listOfInterests;  

        public void unselectAll()
        {
            unselecentAllBox.Click();
        }

        public void clickUplaodLink()
        {
            uploadImageLink.Click();
            UtilsSetImage.uploadImage(pathAvatar, 3000);
        }

        public void getIterestsList()
        {
            foreach (var interest in interestLabels)
            {
                listOfInterests.Add(interest.Text);
            }



            listOfInterests.Remove("Select all");
            listOfInterests.Remove("Unselect all");
            ArrayList generateInterests = UtilsGetValuesFromArray.genRandomValues(listOfInterests, Int32.Parse(UtilsJson.ReadJsonFile("maximumInterest")));

            foreach (var textBox in interestLabels)
            {
                if (generateInterests.Contains(textBox.Text.ToLower()))
                {
                    ElementFactory.GetLabel(By.XPath($"//label[@for='interest_{textBox.Text.ToLower().Replace("-","")}']"), "Interest label").Click();
                }
            }

        }

        public void goToNextPage()
        {
            nextCardButton.ClickAndWait();
        }
    }
}


