using ApiTest.Utils;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Configurations;
using NUnit.Framework;
using UserInterfaceVisual.pageObjects;
using UserInterfaceVisual.PageObjects.Forms;
using UserInterfaceVisual.Utils;

namespace UserInterfaceVisual
{
    public class Tests : BaseTest
    {
        
        [Test]
        public void Test1()
        {
            MainPage mainPage = new MainPage();
            mainPage.State.WaitForDisplayed();
            Assert.True(mainPage.State.IsDisplayed, "Main page hasn't been opened");
            mainPage.getFirstCard();

            FirstCard firstCard = new FirstCard();
            firstCard.State.WaitForDisplayed();
            Assert.True(firstCard.State.IsDisplayed, "Second card hasn't been displayed");
            firstCard.setPasswrod();
            firstCard.setEmailLogin();
            firstCard.setEmailDomain();
            firstCard.clickExtensionDropdown();
            firstCard.setEmailExtenstion();
            firstCard.uncheckTermsCheckBox();
            firstCard.goToSecondCard();

            SecondCard secondCard = new SecondCard();
            Assert.True(secondCard.State.IsDisplayed, "Second card hasn't been opened");
            secondCard.unselectAll();
            secondCard.clickUplaodLink();
            secondCard.getIterestsList();
            secondCard.goToNextPage();
            ThirdCard thirdCard = new ThirdCard();
            Assert.True(thirdCard.State.IsDisplayed, "Third card hasn't been opened");
        }
        

        //Minor

        [Test]
        public void Test2()
        {
            MainPage mainPage = new MainPage();
            mainPage.State.WaitForDisplayed();
            Assert.True(mainPage.State.IsDisplayed, "Main page hasn't been opened");
            mainPage.getFirstCard();
            mainPage.hideHelpForm();
            Assert.IsFalse(mainPage.isHelpFormDisplayed());
            
        }
        
        [Test]
        public void Test3()
        {
            MainPage mainPage = new MainPage();
            mainPage.State.WaitForDisplayed();
            Assert.True(mainPage.State.IsDisplayed, "Main page hasn't been opened");
            mainPage.getFirstCard();
            Assert.True(mainPage.isCookiesPanelDisplayed(), "Cookies panels hasn't loaded");
            mainPage.acceptCookies();
            Assert.True(mainPage.isCookiesPanelClosed(), "Cookies panels hasn't closed");
        }
        
        [Test]
        public void Test4() 
        {
            MainPage mainPage = new MainPage();
            mainPage.State.WaitForDisplayed();
            mainPage.getFirstCard();
            Assert.That(UtilsJson.ReadJsonFile("initialTime"), Is.EqualTo(mainPage.getTimer()), "Website's time doesn't match with Test Data");
        }
        
    }
}