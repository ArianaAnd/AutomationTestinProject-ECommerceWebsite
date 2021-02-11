using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class CreateAccountPage
        {
            private IWebDriver _driver;
            private WebDriverWait _driverWait;

            public CreateAccountPage(IWebDriver driver)
            {
                _driver = driver;

                _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(150));

                _driverWait.IgnoreExceptionTypes();
            }
            public void EnterCreateAccountCredentials(UserDto user)
            {
               
            System.Threading.Thread.Sleep(5000);
                femaleTitleRadioButton.Click();
                firstNameTextBox.Click();
                firstNameTextBox.SendKeys(user.userFirstName);
                lastNameTextBox.SendKeys(user.userLastName);
                passwordTextBox.Click();
                passwordTextBox.SendKeys(user.userPassword);
                daysDropdown.Click();
                firstDayDropdownOption.Click();
                monthsDropdown.Click();
                firstMonthDropdownOption.Click();
                yearsDropdown.Click();
                firstyearDropdown.Click();
                addressFirstNameTextBox.Click();
                addressFirstNameTextBox.SendKeys(user.userAddressFirstName);
                addressLastNameTextBox.SendKeys(user.userAddressLastName);
                addressTextBox.Click();
                addressTextBox.SendKeys(user.userAddress);
                cityTextBox.Click();
                cityTextBox.SendKeys(user.userCity);
                stateDropdown.Click();
                firstStateDropdownOption.Click();
                phoneTextBox.Click();
                phoneTextBox.SendKeys(user.userPhone);

            }
    }
    }
