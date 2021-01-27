using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProjectWebsite.PageObjectsModel
{
   partial class CreateAccountPage
    {
        //Your Personal Information
        private IWebElement femaleTitleRadioButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div/div/form/div[1]/div[1]/div[2]/label/div/span/input"));
        private IWebElement firstNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[2]/input"));
        private IWebElement lastNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[3]/input"));

        private IWebElement emailTextBox =>
            _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input"));//already completed


        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[5]/input"));
        private IWebElement daysDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[1]/div/select"));
        private IWebElement firstDayDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[1]/div/select/option[2]"));
        private IWebElement monthsDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[2]/div/select"));
        private IWebElement firstMonthDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[2]/div/select/option[2]"));
        private IWebElement yearsDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[3]/div/select"));
        private IWebElement firstyearDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[3]/div/select/option[32]"));

        //Your Address
        private IWebElement addressFirstNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[1]/input"));
        private IWebElement addressLastNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[2]/input"));
        private IWebElement addressTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[4]/input"));
        private IWebElement cityTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[6]/input"));
        private IWebElement stateDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select"));
        private IWebElement firstStateDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select/option[2]"));
        private IWebElement zipCodeTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[8]/input"));
        private IWebElement phoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[13]/input"));
        public IWebElement registerButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
    }
}
