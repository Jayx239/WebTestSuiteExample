using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTestSuite.Suite;
using WebTestSuiteExample.Suites;

namespace WebTestSuiteExample.EpicSuites
{
    class BrowseSharpSiteEpicSuite : EpicSuite
    {
        public BrowseSharpSiteEpicSuite() : base()
        {
            this.Suites.Add(new BrowseSharpSiteSuite());
        }
    }
}
