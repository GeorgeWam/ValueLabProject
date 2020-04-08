using OpenQA.Selenium;
using System.Threading;
using ValueLabProject.Hooks;

namespace ValueLabProject.Pages
{
    public class ControlBoardPage
    {
        Context context;
        public ControlBoardPage(Context _context)
        {
            context = _context;
        }

        //Identifying Elements
        By signInLink = By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a");
        By emailAddressField = By.Id("email");
        By passwordField = By.Id("passwd");
        By signInButton = By.CssSelector("#SubmitLogin > span");
        By accountName = By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(1) > a > span");
        By getSavingsNowLink = By.CssSelector("#header > div.banner > div > div > a > img");
        By contactUsLink = By.CssSelector("#contact-link > a");
        By customerServiceContactUsScreen = By.CssSelector("#center_column > h1");
        By searchField = By.Id("search_query_top");
        By searchButton = By.CssSelector("#searchbox > button");
        By topSellers = By.CssSelector("#best-sellers_block_right > h4 > a");

        //Writing methods for the elements
        public void SelectSignInLink()
        {
            context.driver.FindElement(signInLink).Click();
        }

        public void EnterEmailAddress(string emailAddress)
        {
            context.driver.FindElement(emailAddressField).SendKeys(emailAddress);
        }

        public void EnterPassword(string password)
        {
            context.driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            context.driver.FindElement(signInButton).Click();
        }

        public string UserAccountName()
        {
            return context.driver.FindElement(accountName).Text.Trim();
        }

        public void ClickGetSavingsNowLink()
        {
            context.driver.FindElement(getSavingsNowLink).Click();
        }

        public string GetSavingsNowUrl()
        {
            return context.driver.Url.Trim();
        }

        public void ClickContactUsLink()
        {
            context.driver.FindElement(contactUsLink).Click();
        }

        public string CustomerServiceContactUsScreen()
        {
            return context.driver.FindElement(customerServiceContactUsScreen).Text.Trim();
        }

        public void EnterSearchData(string searchData)
        {
            var searchfieldDetails = context.driver.FindElement(searchField);
            searchfieldDetails.Clear();
            searchfieldDetails.SendKeys(searchData);
        }

        public void ClickSearchButton()
        {
            context.driver.FindElement(searchButton).Click();
        }

        public string TopSellersSearchScreen()
        {
            return context.driver.FindElement(topSellers).Text.Trim();
        }

    }
}
