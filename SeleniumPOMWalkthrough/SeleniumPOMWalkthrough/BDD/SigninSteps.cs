using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope (Feature = "AP_Signin")]
    public sealed class SigninSteps : SharedSteps
    {
        [Given(@"I have not entered any credentials")]
        public void GivenIHaveNotEnteredAnyCredentials()
        {
            AP_Website.AP_HomePage.InputUserName("");
            AP_Website.AP_HomePage.InputPassword("");
        }

        [Given(@"I enter ""(.*)""")]
        public void GivenIHaveEnter(string email)
        {
            AP_Website.AP_HomePage.InputUserName(email);
        }

        [Given(@"I don't enter a password")]
        public void GivenIDonTEnterAPassword()
        {
        }

        [Given(@"I enter an invalid password ""(.*)""")]
        public void GivenIEnterAnInvalidPassword(string password)
        {
            AP_Website.AP_HomePage.InputPassword(password);
        }


        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_HomePage.GetErrorMessage(), Does.Contain(expected));
        }

        [Then(@"the resulting page navigated to should have title ""(.*)""")]
        public void ThenTheResultingPageNavigatedToShouldHaveTitle(string expectedTitle)
        {
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo(expectedTitle));
        }


    }
}
