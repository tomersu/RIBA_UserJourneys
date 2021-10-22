using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;

namespace RIBAStudentRegistration.Hooks
{
    public class HooksSetUp
    {
        public ExtentReports extent = null;
        public IWebDriver driver;
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            extent = new ExtentReports();
            var currentDate = DateTime.Now.ToString("yyyy-mm-dd-hh-mm-ss");
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, $"TestReport-{currentDate}.html");           
            var htmlReporter = new ExtentHtmlReporter(startupPath);
            extent.AttachReporter(htmlReporter);
            extent.CreateTest("Test").Info("Test Started");
        }
        [AfterScenario]
        public void Teardown()
        {
            extent.Flush();
            driver.Close();
            driver.Quit();
        }
    }
}
