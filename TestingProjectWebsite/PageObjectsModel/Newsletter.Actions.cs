﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class Newsletter
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public Newsletter(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }
    }
}
