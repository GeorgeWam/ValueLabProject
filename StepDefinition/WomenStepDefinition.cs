using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueLabProject.Pages;
using ValueLabProject.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TechTalk.SpecFlow;
using ValueLabProject.StepDefinition;

namespace ValueLabProject.StepDefinition
{
    [Binding]
    public class WomenStepDefinition
    {
        WomenPage womenPage;
      
        public WomenStepDefinition(WomenPage _womenPage )
        {
            womenPage = _womenPage;
            
        }

        [When(@"a user clicks the Women link")]
        public void WhenAUserClicksTheWomenLink()
        {
            womenPage.ClickWomenPageButton();
        }

        [When(@"a user clicks Dresses link")]
        public void WhenAUserClicksDressesLink()
        {
            womenPage.ClickDressLink();
        }

        [When(@"a user clicks Casual Dresses")]
        public void WhenAUserClicksCasualDresses()
        {
            womenPage.ClickCasualDress();
        }

        [When(@"a user scrols down")]
        public void WhenAUserScrolsDown()
        {
            womenPage.PageScrollDown();
        }

        [When(@"a user clicks a casual dress")]
        public void WhenAUserClicksACasualDress()
        {
            womenPage.ItemFirstCasualDress();
        }

        [When(@"a user clicks add to cart")]
        public void WhenAUserClicksAddToCart()
        {
            womenPage.ClickAddToCart();
        }

        [When(@"a user clicks proceed to checkout")]
        public void WhenAUserClicksProceedToCheckout()
        {
            womenPage.ClickProceedToCheckOut();
        }

        [Then(@"the SHOPPING-CART SUMMARY screen should display (.*) item message")]
        public void ThenTheSHOPPING_CARTSUMMARYScreenShouldDisplayItemMessage(string expectedResult)
        {
            string actualResult = womenPage.ShoppingCartSummary();
            Assert.AreEqual(actualResult, expectedResult, "actual result is not equal to expected result");
           
            
        }

    }

}

