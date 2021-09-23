using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_ShoppingCart")]
    public sealed class ShoppingCartSteps : SharedSteps
    {
        [When(@"I click the continue shopping button")]
        public void WhenIClickTheContinueShoppingButton()
        {
            base.AP_Website.AP_ShoppingCart.ClickContinueShoppingButton();
        }

        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            base.AP_Website.AP_ShoppingCart.ClickCheckoutButton();
        }

        [Then(@"I should be taken back to user page")]
        public void ThenIShouldBeTakenBackToUserPage()
        {
            Assert.That(base.AP_Website.AP_ShoppingCart.GetHeaderText(), Is.EqualTo("Products").IgnoreCase);
        }

        [Then(@"I should be taken back to checkout page")]
        public void ThenIShouldBeTakenBackToCheckoutPage()
        {
            Assert.That(base.AP_Website.AP_ShoppingCart.GetHeaderText, Is.EqualTo("checkout: your information").IgnoreCase);
        }


    }
}
