using OpenQA.Selenium;
using SeleniumPOMWalkthrough.lib.driver_config;


namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_Website<T> where T : IWebDriver, new()
    {
        public AP_HomePage AP_HomePage { get; set; }
        public AP_UserPage AP_UserPage { get; set; }
        public AP_DeliveryDetailsPage AP_DeliveryDetailsPage { get; set; }
        public AP_ShoppingCart AP_ShoppingCart { get; set; }
        public AP_OrderOverview AP_OrderOverview { get; set; }
        public IWebDriver SeleniumDriver { get; set; }

        private IWebElement _header => SeleniumDriver.FindElement(By.ClassName("title"));

        //Constructor
        public AP_Website(int pageLoadInSecs = 10,int implicitWaitInSecs = 10)
        {
            //instantiate driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;

            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_UserPage = new AP_UserPage(SeleniumDriver);
            AP_DeliveryDetailsPage = new AP_DeliveryDetailsPage(SeleniumDriver);
            AP_ShoppingCart = new AP_ShoppingCart(SeleniumDriver);
            AP_OrderOverview = new AP_OrderOverview(SeleniumDriver);
        }

        //delete all cookies
        public void DeleteCookies() => SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        public string GetHeaderText() => _header.Text;

    }
}
