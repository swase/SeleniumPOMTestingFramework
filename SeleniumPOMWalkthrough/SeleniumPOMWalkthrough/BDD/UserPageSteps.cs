using TechTalk.SpecFlow;
using NUnit.Framework;
using SeleniumPOMWalkthrough.utils;


namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_UserPage")]
    public sealed class UserPageSteps : SharedSteps
    {
        private int _numItemsInCartBefore;

        [Given(@"all the items have been added to the cart")]
        public void GivenAllTheItemsHaveBeenAddedToTheCart()
        {
            base.AP_Website.AP_UserPage.AddAllItemsToCart();
        }

        [When(@"I click the remove button for all items on the page")]
        public void WhenIClickTheRemoveButtonForAllItemsOnThePage()
        {
            base.AP_Website.AP_UserPage.RemoveAllItemsFromCart();
        }

        [When(@"I click the add to cart button for the backpack")]
        public void WhenIClickTheAddToCartButtonForTheItem()
        {
            _numItemsInCartBefore = base.AP_Website.AP_UserPage.GetNumItemsInCart();
            base.AP_Website.AP_UserPage.AddItemToCart(Items.Backpack);
        }

        [When(@"I click the add to cart button for all items on the page")]
        public void WhenIClickTheAddToCartForAlItemsOnThePage()
        {
            base.AP_Website.AP_UserPage.AddAllItemsToCart();
        }


        [Then(@"the shopping cart button should increase by 1")]
        public void ThenTheShoppingCartButtonShouldIncreaseBy()
        {
            
            Assert.That(base.AP_Website.AP_UserPage.GetNumItemsInCart(), Is.EqualTo(_numItemsInCartBefore + 1));
        }

    }
}
