using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ValueLabProject.Pages;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ValueLabProject.StepDefinition
{
    [Binding]
    public class ControlBoardStepDefinition
    {
        ControlBoardPage controlBoardPage;
        
       

        public ControlBoardStepDefinition(ControlBoardPage _controlBoardPage)
        {
            controlBoardPage = _controlBoardPage;
           
           
        }
        
       

        [When(@"the user clicks the GET SAVINGS NOW Link")]
        public void WhenTheUserClicksTheGETSAVINGSNOWLink()
        {
            controlBoardPage.ClickGetSavingsNowLink();
        }

        [Then(@"the GET SAVINGS NOW Url (.*) should be displayed")]
        public void ThenTheGETSAVINGSNOWUrlShouldBeDisplayed(string expectedUrl)
        {
            string actualURL = "http://automationpractice.com/index.php?controller=my-account";
            Assert.AreEqual(expectedUrl, actualURL, "expectedUrl is not equal to ActualURL");
           
        }

        [When(@"the user clicks the Contact us button")]
        public void WhenTheUserClicksTheContactUsButton()
        {
            controlBoardPage.ClickContactUsLink();
        }

        [Then(@"the (.*) screen is displayed")]
        public void ThenTheScreenIsDisplayed(string expectedScreenPage)
        {
            string actualScreenPage = controlBoardPage.CustomerServiceContactUsScreen();
            Assert.AreEqual(expectedScreenPage, actualScreenPage, "expectedScreenPage is not equal to actualScreenPage");
            
        }


        [When(@"the user fills in (.*) in the search field")]
        public void WhenTheUserFillsInInTheSearchField(string searchData)
        {
            controlBoardPage.EnterSearchData(searchData);
        }

        [When(@"the user clicks the search icon")]
        public void WhenTheUserClicksTheSearchIcon()
        {
            controlBoardPage.ClickSearchButton();
        }

        [Then(@"the screen should display (.*) with the searched item")]
        public void ThenTheScreenShouldDisplayWithTheSearchedItem(string expectedResult)
        {
            string actualResults = controlBoardPage.TopSellersSearchScreen();
            Assert.AreEqual(actualResults, expectedResult, "the actualResults is not equal to the expectedResult");
           

        }







       

    }
}
