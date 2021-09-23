using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Feature = "AP_OrderOverview")]
    public sealed class OderOverviewSteps : SharedSteps
    {
        [Given(@"I have chosen to confirm / complete my order")]
        public void GivenIHaveChosenToConfirmCompleteMyOrder()
        {
            base.AP_Website.AP_OrderOverview.ClickFinishOrder();
        }

        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            base.AP_Website.AP_OrderOverview.ClickFinishOrder();
        }

        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
        {
            base.AP_Website.AP_OrderOverview.ClickCancelOrder();
        }

        [When(@"I click the go back to products button")]
        public void WhenIClickTheGoBackToProductsButton()
        {
            base.AP_Website.AP_OrderOverview.ClickBackToProducts();
        }


    }
}
