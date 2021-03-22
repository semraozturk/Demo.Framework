using System;
using AventStack.ExtentReports;
using Demo.Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Demo.Framework.Core
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        protected static ExtentReports _report;
        private static readonly ExtentReportUtils _extentReportUtils = new ExtentReportUtils();

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _report = _extentReportUtils.CreateAReport(@"Report/extent-report.html");
        }

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _extentReportUtils.FlushAndCloseReport(_report);
        }
    }
}