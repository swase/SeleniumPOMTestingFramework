using SeleniumPOMWalkthrough.utils;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney")]
    public sealed class UserJourneySteps : SharedSteps
    {

        [When(@"I click the add to cart button for the backpack")]
        public void WhenIClickTheAddToCartButtonForTheBackpack()
        {
            base.AP_Website.AP_UserPage.AddItemToCart(Items.Jacket);
        }

        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            AP_Website.AP_ShoppingCart.ClickCheckoutButton();
        }

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            base.AP_Website.AP_DeliveryDetailsPage.InputDeliveryDetails(base._deliveryDetails);
            base.AP_Website.AP_DeliveryDetailsPage.ClickContinue();

        }

        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            AP_Website.AP_OrderOverview.ClickFinishOrder();
        }

    }
}
