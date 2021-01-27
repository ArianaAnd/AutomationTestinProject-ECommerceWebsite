using System;
using System.Threading;
using TestingProjectWebsite.PageObjectsModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public sealed class SearchBarSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public SearchBarSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I write '(.*)' in the search bar")]
        public void GivenIWriteInTheSearchBar(string p0)
        {
           HomePage homePage = new HomePage(Driver);
           homePage.searchTextBox.Click();
           homePage.searchTextBox.SendKeys("dress");
        }
        
        [Given(@"I click seach button")]
        public void GivenIClickSeachButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.searchButton.Click();
        }
        
        [Then(@"I am shwn only dresses")]
        public void ThenIAmShwnOnlyDresses()
        {
            
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/h1/span[1]")).Displayed);
        }
    }
}
