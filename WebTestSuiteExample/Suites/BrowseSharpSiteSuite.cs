using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTestSuite.Suite;
using WebTestSuite.Test;
using WebTestSuiteExample.Tests.BrowseSharpSite;

namespace WebTestSuiteExample.Suites
{
    class BrowseSharpSiteSuite : TestSuite
    {
        private ChromeDriver _webDriver;

        public BrowseSharpSiteSuite() : base()
        {
            this.SuiteDescription.Client = "BrowseSharp Site";
            this.SuiteDescription.SuiteName = "Test Form Page";
            this._webDriver = new ChromeDriver();
            this.Tests = new List<ITest>(); // To Be removed in next WebTestSuite release, base constructor will handle this
            this.Tests.Add(new TestFormStructure(this._webDriver));
        }
    }
}
