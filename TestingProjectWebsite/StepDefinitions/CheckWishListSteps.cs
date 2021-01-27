using System;
using TestingProjectWebsite.PageObjectsModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class CheckWishListSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public CheckWishListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I add a dress to the wish list")]
        public void WhenIAddADressToTheWishList()
        {

            HomePage homePage = new HomePage(Driver);
            homePage.homeButton.Click();
            homePage.blouseButton.Click();
            DressesPage dressPage = new DressesPage(Driver);
            dressPage.AddDressToWishList();
        }
        
        [When(@"navigate to account")]
        public void WhenNavigateToAccount()
        {
            MyAccountPage accountPage = new MyAccountPage(Driver);
            accountPage.CheckWishList();
        }
        
        [Then(@"I see the dress added to the wishlist")]
        public void ThenISeeTheDressAddedToTheWishlist()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0,500)");

            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/div/div[2]/div/div/ul/li/div/div[2]/div/p")).Text.Contains("Faded Short Sleeve T-shirts"));
        }
    }
}
