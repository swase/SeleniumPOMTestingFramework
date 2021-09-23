using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_DeliveryDetails")]
    public sealed class DeliveryDetailsSteps : SharedSteps
    {
        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            base.AP_Website.AP_DeliveryDetailsPage.ClickContinue();
        }

        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
        {
            base.AP_Website.AP_DeliveryDetailsPage.ClickCancel();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string errorMsg)
        {
            Assert.That(base.AP_Website.AP_DeliveryDetailsPage.GetErrorMessage(), Is.EqualTo(errorMsg));
        }

    }
}
