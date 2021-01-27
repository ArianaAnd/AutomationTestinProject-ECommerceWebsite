using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class MyAccountPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public MyAccountPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }
        public void CheckWishList()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 0)");
            accountButton.Click();
            Thread.Sleep(500);
            myWishListButton.Click();
            firstWishListInTableButton.Click();
        }
    }
}
