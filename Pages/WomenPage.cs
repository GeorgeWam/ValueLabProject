using OpenQA.Selenium;
using System.Threading;
using ValueLabProject.Hooks;
using System.Threading.Tasks;

namespace ValueLabProject.Pages
{
    public class WomenPage
    {
        Context context;
        public WomenPage(Context _context)
        {
            context = _context;
        }

        //Identifying Elements 
        By womenPageButton = By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a");
        By dressLink = By.CssSelector("#categories_block_left > div > ul > li.last > a");
        By casualDress = By.CssSelector("#categories_block_left > div > ul > li:nth-child(1) > a");
        By firstCasualDress = By.CssSelector("#center_column > ul > li > div > div.left-block > div > a.product_img_link > img");
        By addToCart = By.CssSelector("#add_to_cart > button > span");
        By proceedToCheckOut = By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a > span");
        By shoppingCartSummary = By.CssSelector("#cart_title > span");
        By popUp = By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6");

        //Writing methods 
        public void ClickWomenPageButton()
        {
            context.driver.FindElement(womenPageButton).Click();
        }

        public void ClickDressLink()
        {
            context.driver.FindElement(dressLink).Click();
        }

        public void PageScrollDown()
        {
            var js = (IJavaScriptExecutor)context.driver;
            js.ExecuteScript("window.scrollTo(document.body.scrollHeight,250)");
        }

        public void ClickCasualDress()
        {
            context.driver.FindElement(casualDress).Click();
        }

        public void ItemFirstCasualDress()
        {
            context.driver.FindElement(firstCasualDress).Click();
        }

        public void ClickAddToCart()
        {
            context.driver.FindElement(addToCart).Click();
            Thread.Sleep(2000);
        }

        public void ClickProceedToCheckOut()
        {
           
            context.driver.FindElement(popUp).Text.Trim();
            Thread.Sleep(2000);

            context.driver.FindElement(proceedToCheckOut).Click();
        }

        public string ShoppingCartSummary()
        {
            return context.driver.FindElement(shoppingCartSummary).Text.Trim();
        }
    }
}
