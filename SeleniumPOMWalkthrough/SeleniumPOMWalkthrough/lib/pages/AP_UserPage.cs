using OpenQA.Selenium;
using System;
using SeleniumPOMWalkthrough.utils;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_UserPage
    {
        #region
        private IWebDriver _seleniumDriver;
        private string _userPageURL = AppConfigReader.UserPageURL;
        private IWebElement _header => _seleniumDriver.FindElement(By.ClassName("title"));
        private IWebElement _shoppingCart => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private UserPageAddInventoryItems Items { get;} = new UserPageAddInventoryItems();

        //private IWebElement _inventoryListName => _seleniumDriver.FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _continuShoppingButton => _seleniumDriver.FindElement(By.Id("continue-shopping"));

        #endregion

        public AP_UserPage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_userPageURL);
        public void ClickShoppingCartButton() => _shoppingCart.Click();
        public void ClickContinueShoppingButton() => _continuShoppingButton.Click();

        public void AddItemToCart(Items item) => _seleniumDriver.FindElement(By.Id(Items.GetAddItemId(item))).Click();
        public void RemoveItemFromCart(Items item) => _seleniumDriver.FindElement(By.Id(Items.GetRemoveItemId(item))).Click();
        public string GetHeaderText() => _header.Text;
        public int GetNumItemsInCart() => _shoppingCart.Text == null  || _shoppingCart.Text.Length  == 0 
            ? 0 : Int32.Parse(_shoppingCart.Text);
        public string GetPageTitle() => _seleniumDriver.Title;
        
        public void AddAllItemsToCart()
        {
            foreach(var item in Items.Inventory.Keys)
            {
                _seleniumDriver.FindElement(By.Id(Items.GetAddItemId(item))).Click();
            }
        }

        public void RemoveAllItemsFromCart()
        {
            foreach (var item in Items.Inventory.Keys)
            {
                try
                {
                    _seleniumDriver.FindElement(By.Id(Items.GetRemoveItemId(item))).Click();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }

    }

}
