using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.utils;
using TechTalk.SpecFlow.Assist;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(4)]

namespace SeleniumPOMWalkthrough.BDD
{
    public class SharedSteps
    {
        public AP_Website<ChromeDriver> AP_Website { get; } = new AP_Website<ChromeDriver>();
        public DeliveryDetails _deliveryDetails;
        public Credentials _credentials;


        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }

        [Given(@"I have the following credentials")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }


        [Given(@"I am on the user page")]
        public void GivenIAmOnTheUserPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            AP_Website.AP_HomePage.InputUserName("standard_user");
            AP_Website.AP_HomePage.InputPassword("secret_sauce");
            AP_Website.AP_HomePage.ClickSignInButton();
        }

        [Given(@"I have navigated to shopping cart")]
        public void GivenIHaveNavigatedToShoppingCart()
        {
            GivenIAmOnTheUserPage();
            AP_Website.AP_UserPage.ClickShoppingCartButton();
        }

        [Given(@"I am on delivery details page")]
        public void GivenIAmOnDeliveryDetailsPage()
        {
            GivenIHaveNavigatedToShoppingCart();
            AP_Website.AP_ShoppingCart.ClickCheckoutButton();

        }

        [Given(@"I am on the order confirmation page")]
        public void GivenIAmOnOrderConfirmationPage()
        {
            GivenIAmOnDeliveryDetailsPage();
            AP_Website.AP_DeliveryDetailsPage.InputTempDetials();
            AP_Website.AP_DeliveryDetailsPage.ClickContinue();           
        }

        [Given(@"I have the following delivery information")]
        public void GivenIHaveTheFollowingDeliveryInfo(Table table)
        {
            _deliveryDetails = table.CreateInstance<DeliveryDetails>();
        }

        [When(@"I enter this delivery information")]
        public void WhenIEnterTheseDetails()
        {
            AP_Website.AP_DeliveryDetailsPage.InputDeliveryDetails(_deliveryDetails);
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_HomePage.InputSigninCredentials(_credentials);
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_HomePage.ClickSignInButton();
        }

        [When(@"I click the shopping cart image")]
        public void WhenIClickTheShoppingCartImage()
        {
            AP_Website.AP_UserPage.ClickShoppingCartButton();
        }

        [Then(@"the shopping cart should show (.*) items")]
        public void ThenTheShoppingCartShouldShowItems(int expectedTotalItems)
        {
            Assert.That(AP_Website.AP_UserPage.GetNumItemsInCart(), Is.EqualTo(expectedTotalItems));
        }

        [Then(@"the page with title ""(.*)"" is loaded")]
        public void ThenThePageWithTitleIsLoaded(string pageTitle)
        {
            Assert.That(AP_Website.GetHeaderText, Is.EqualTo(pageTitle).IgnoreCase);
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.DeleteCookies();
            AP_Website.SeleniumDriver.Quit();
        }

    }
}
