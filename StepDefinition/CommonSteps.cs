using System;
using System.IO;
using TechTalk.SpecFlow;
using ValueLabProject.Hooks;
using OpenQA.Selenium;
using ValueLabProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace ValueLabProject.StepDefinition
{
    [Binding]
    public class CommonSteps
    {
        Context context;
        static ExtentTest feature;
        static ExtentTest scenario;
        static ExtentReports report;

        ControlBoardPage controlBoardPage;
        public CommonSteps(Context _context, ControlBoardPage _controlBoardPage)
        {
            context = _context;
            controlBoardPage = _controlBoardPage;
        }

        [Given(@"that the online shopping url is launched")]
        public void GivenThatTheOnlineShoppingUrlIsLaunched()
        {
            context.LaunchAnAUT();
            scenario = feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [BeforeTestRun]
        public static void ReportGenerator()
        {
            var testResultReport = new ExtentV3HtmlReporter(Directory.GetCurrentDirectory() + @"\TestResult.html");
            testResultReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            report = new ExtentReports();
            report.AttachReporter(testResultReport);
        }

        [Given(@"a user clicks the sign in button")]
        public void GivenAUserClicksTheSignInButton()
        {
            controlBoardPage.SelectSignInLink();
        }

        [Given(@"a user fill in their email address with (.*)")]
        public void GivenAUserFillInTheirEmailAddress(string emailAddress)
        {
            controlBoardPage.EnterEmailAddress(emailAddress);
        }

        [Given(@"a user fill in their password with (.*)")]
        public void GivenAUserFillInTheirPassword(string password)
        {
            controlBoardPage.EnterPassword(password);
        }

        [When(@"the user clicks the sign in button")]
        public void WhenTheUserClicksTheSignInButton()
        {
            controlBoardPage.ClickSignInButton();
        }

        [Then(@"the users name (.*) should be displayed on their home screen")]
        public void ThenTheUsersNameShouldBeDisplayedOnTheirHomeScreen(string expectedResult)
        {
            string actualResult = controlBoardPage.UserAccountName();
            Assert.AreEqual(expectedResult, actualResult, "expectedResult is not equal to ActualResult");


        }

        [AfterTestRun]
        public static void ReportCleaner()
        {
            report.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            feature = report.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [AfterStep]
        public void StepsInTheReport()
        {
            var typeOfStep = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            //Cater for a step that passed
            if (ScenarioContext.Current.TestError == null)
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
            }
            //Cater for a step that failed
            if (ScenarioContext.Current.TestError != null)
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
            //Cater for a step that has not been implemented
            if (ScenarioContext.Current.ScenarioExecutionStatus.ToString().Equals("StepDefinitionPending"))
            {
                if (typeOfStep.Equals("Given"))
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
                else if (typeOfStep.Equals("When"))
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
                else if (typeOfStep.Equals("Then"))
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
            }
        }



        //Close Application
        [AfterScenario]
        public void CloseApplication()
        {
            try
            {
                if (ScenarioContext.Current.TestError != null)  //this condition will always be true when a test fails
                {
                    string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
                    string directory = Directory.GetCurrentDirectory() + @"\Screenshots\";
                    TakeScreenshot(directory, scenarioName);
                }
            }
            catch (Exception)
            {

            }

            context.CloseAnAUT();
        }


        public void TakeScreenshot(string directory, string scenarioName)
        {
            Screenshot screenshot = ((ITakesScreenshot)context.driver).GetScreenshot();
            string path = directory + scenarioName + DateTime.Now.ToString("yyyy-MM-dd") + ".png";
            string Screenshot = screenshot.AsBase64EncodedString;
            byte[] screenshotAsByteArray = screenshot.AsByteArray;
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }
    }
}
