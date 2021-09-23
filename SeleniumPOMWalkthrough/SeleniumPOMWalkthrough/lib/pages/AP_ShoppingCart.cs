using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_ShoppingCart
    {
        #region
        private IWebDriver _seleniumDriver;
        private IWebElement _header => _seleniumDriver.FindElement(By.ClassName("title"));
        private IWebElement _checkout => _seleniumDriver.FindElement(By.Id("checkout"));
        private IWebElement _inventoryListName => _seleniumDriver.FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _continuShoppingButton => _seleniumDriver.FindElement(By.Id("continue-shopping"));

        #endregion

        public AP_ShoppingCart(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        public void ClickContinueShoppingButton() => _continuShoppingButton.Click();
        public void ClickCheckoutButton() => _checkout.Click();
        public string GetHeaderText() => _header.Text;
        public string GetPageTitle() => _seleniumDriver.Title;


    }

}