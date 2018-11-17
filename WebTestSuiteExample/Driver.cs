
using WebTestSuiteExample.EpicSuites;

namespace WebTestSuiteExample
{
    class Driver
    {
        static void Main(string[] args)
        {
            BrowseSharpSiteEpicSuite epicSuite = new BrowseSharpSiteEpicSuite();
            epicSuite.Execute();
            epicSuite.PrintSummaryString();
        }
    }
}
