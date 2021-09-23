using OpenQA.Selenium;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_OrderOverview
    {

        #region
        private IWebDriver _seleniumDriver;
        private IWebElement _finishOrder => _seleniumDriver.FindElement(By.Id("finish"));
        private IWebElement _cancelOrder => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _backToProducts => _seleniumDriver.FindElement(By.Id("back-to-products"));
        #endregion
        public AP_OrderOverview(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void ClickCancelOrder() => _cancelOrder.Click();
        public void ClickFinishOrder() => _finishOrder.Click();
        public void ClickBackToProducts() => _backToProducts.Click();
    }
}
