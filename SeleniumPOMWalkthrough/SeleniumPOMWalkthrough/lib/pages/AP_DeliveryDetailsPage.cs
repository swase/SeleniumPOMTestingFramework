using OpenQA.Selenium;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_DeliveryDetailsPage
    {
        #region
        //Input test fields
        private IWebDriver _seleniumDriver;
        private IWebElement _firstName => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastName => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postCode => _seleniumDriver.FindElement(By.Id("postal-code"));
        //Error Message
        private IWebElement _errorField => _seleniumDriver.FindElement(By.ClassName("error-message-container"));
        //Buttons
        private IWebElement _continueCheckout => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _cancelCheckout => _seleniumDriver.FindElement(By.Id("cancel"));
        private IWebElement _header => _seleniumDriver.FindElement(By.ClassName("title"));
        
        #endregion

        public AP_DeliveryDetailsPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public string GetErrorMessage() => _errorField.Text;
        public void ClickContinue() => _continueCheckout.Click();
        public void ClickCancel() => _cancelCheckout.Click();
        public string GetHeaderString() => _header.Text;

        public void InputDeliveryDetails(DeliveryDetails deliveryDetails)
        {
            _firstName.SendKeys(deliveryDetails.FirstName);
            _lastName.SendKeys(deliveryDetails.LastName);
            _postCode.SendKeys(deliveryDetails.PostalCode);
        }

        public void InputTempDetials()
        {
            _firstName.SendKeys("Mr");
            _lastName.SendKeys("Bean");
            _postCode.SendKeys("OX16 1TN");
        }
    }
}

