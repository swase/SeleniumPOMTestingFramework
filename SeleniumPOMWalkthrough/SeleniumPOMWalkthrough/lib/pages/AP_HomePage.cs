using OpenQA.Selenium;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_HomePage
    {
        #region
        private IWebDriver _seleniumDriver;
        private string _homePageUrl = AppConfigReader.BaseURL;

        private IWebElement _signInButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _userName => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _password => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _errorField => _seleniumDriver.FindElement(By.Id("login_button_container"));
        private IWebElement _header => _seleniumDriver.FindElement(By.ClassName("title"));
        #endregion

        public AP_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        //Methods to interact with the web page
        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void ClickSignInButton() => _signInButton.Click();
        public void InputUserName(string username) => _userName.SendKeys(username);
        public void InputPassword(string password) => _password.SendKeys(password);
        public string GetErrorMessage() => _errorField.Text;
        public string GetHeaderText() => _header.Text;

        private IWebElement _emailField => this._seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => this._seleniumDriver.FindElement(By.Id("passwd"));

        public void InputSigninCredentials(Credentials credentials)
        {
            _userName.SendKeys(credentials.Email);
            _password.SendKeys(credentials.Password);
        }

    }
}
