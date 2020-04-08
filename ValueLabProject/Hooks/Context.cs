using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ValueLabProject.Hooks
{
    public class Context
    {
        //Innitiating the driver and BaseURL
        public IWebDriver driver;
        public string baseUrl = "http://automationpractice.com/index.php";


        //Launching the web browser, maximixing the window, Navigating to the URL
        public void LaunchAnAUT()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            Thread.Sleep(2000);
        }



        //Closing An Application Under test
        public void CloseAnAUT()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
