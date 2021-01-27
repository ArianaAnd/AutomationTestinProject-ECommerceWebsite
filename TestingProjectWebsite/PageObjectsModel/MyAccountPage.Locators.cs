using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class MyAccountPage
    {
        private IWebElement accountButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        private IWebElement myWishListButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/ul/li/a/span"));
        private IWebElement firstWishListInTableButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/div/div[1]/table/tbody/tr/td[1]/a"));
    }
}
