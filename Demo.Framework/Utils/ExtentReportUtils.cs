using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Demo.Framework.Utils
{
    public class ExtentReportUtils
    {
        public ExtentReports CreateAReport(string pathToReport)
        {
            var extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(pathToReport);
            extent.AttachReporter(htmlReporter);
            return extent;
        }

        public ExtentTest StartTest(ExtentReports report, string nameOfTheTest)
        {
            return report.CreateTest(nameOfTheTest);
        }

        public void FlushAndCloseReport(ExtentReports report)
        {
            report.Flush();
        }
    }
}
