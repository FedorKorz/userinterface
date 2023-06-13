using ApiTest.Utils;
using NUnit.Framework;
using UserInterfaceVisual.pageObjects;
using UserInterfaceVisual.PageObjects.Forms;

namespace UserInterfaceVisual;

public class Tests : BaseTest
{
    [Test]
    public void Test1()
    {
        var mainPage = new MainPage();
        mainPage.State.WaitForDisplayed();
        Assert.That(mainPage.State.IsDisplayed, Is.True, "Main page hasn't been opened");
        mainPage.getFirstCard();

        var firstCard = new FirstCard();
        firstCard.State.WaitForDisplayed();
        Assert.That(firstCard.State.IsDisplayed, Is.True, "Second card hasn't been displayed");
        firstCard.setPasswrod();
        firstCard.setEmailLogin();
        firstCard.setEmailDomain();
        firstCard.clickExtensionDropdown();
        firstCard.setEmailExtenstion();
        firstCard.uncheckTermsCheckBox();
        firstCard.goToSecondCard();

        var secondCard = new SecondCard();
        Assert.That(secondCard.State.IsDisplayed, Is.True, "Second card hasn't been opened");
        secondCard.unselectAll();
        secondCard.clickUplaodLink();
        secondCard.getIterestsList();
        secondCard.goToNextPage();
        var thirdCard = new ThirdCard();
        Assert.That(thirdCard.State.IsDisplayed, Is.True, "Third card hasn't been opened");
    }

    [Test]
    public void Test2()
    {
        var mainPage = new MainPage();
        mainPage.State.WaitForDisplayed();
        Assert.That(mainPage.State.IsDisplayed, Is.True, "Main page hasn't been opened");
        mainPage.getFirstCard();
        mainPage.hideHelpForm();
        Assert.That(mainPage.isHelpFormDisplayed(), Is.False);
    }

    [Test]
    public void Test3()
    {
        var mainPage = new MainPage();
        mainPage.State.WaitForDisplayed();
        Assert.That(mainPage.State.IsDisplayed, Is.True, "Main page hasn't been opened");
        mainPage.getFirstCard();
        Assert.That(mainPage.isCookiesPanelDisplayed(), Is.True, "Cookies panels hasn't loaded");
        mainPage.acceptCookies();
        Assert.That(mainPage.isCookiesPanelClosed(), Is.True, "Cookies panels hasn't closed");
    }

    [Test]
    public void Test4()
    {
        var mainPage = new MainPage();
        mainPage.State.WaitForDisplayed();
        mainPage.getFirstCard();
        Assert.That(UtilsJson.ReadJsonFile("initialTime"), Is.EqualTo(mainPage.getTimer()),
            "Website's time doesn't match with Test Data");
    }
}