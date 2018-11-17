using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebTestSuite.Exception;
using WebTestSuite.Test;

namespace WebTestSuiteExample.Tests.BrowseSharpSite
{
    class TestFormStructure : WebTest
    {
        public TestFormStructure(IWebDriver webDriver) : base(webDriver)
        {
        }
        protected override bool TryTest()
        {
            _webDriver.Navigate().GoToUrl("http://browsesharp.org/testsitesforms.html");
            var userNameInput = _webDriver.FindElement(By.Name("UserName"));
            if (userNameInput.GetAttribute("placeholder") != "UserName")
                throw new MissMatchException("UserName", userNameInput.GetAttribute("placeholder"), "Username placeholder missmatch");
            _webDriver.Close();
            return true;
        }
    }
}
