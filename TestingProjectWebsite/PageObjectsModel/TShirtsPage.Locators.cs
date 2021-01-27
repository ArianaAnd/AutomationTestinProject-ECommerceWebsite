using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class TShirtsPage
    {
        public IWebElement fadedshortSleeveShirtButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div/a[1]/img"));
        public IWebElement blueColorButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li/div/div[2]/div[3]/ul/li[2]/a"));
        private IWebElement fadedshortSleeveShirtAddToCartButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li/div/div[2]/div[2]/a[1]"));
        public IWebElement moreButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li/div/div[2]/div[2]/a[2]"));
        public IWebElement tShirtButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a"));
    }
}
