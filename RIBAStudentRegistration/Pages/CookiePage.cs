using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using FluentAssertions;
using NUnit.Framework;

namespace RIBAStudentRegistration.Pages
{
    public class CookiePage
    {
        public IWebDriver driver;
        public CookiePage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        protected string RIBAUrl = "https://uat-register.architecture.com/students";

        [FindsBy(How = How.XPath, Using = "//button[@id='CybotCookiebotDialogBodyLevelButtonCustomize']")]
        public IWebElement ManageMyPreferencesButton;
        [FindsBy(How = How.XPath, Using = "//h1")]
        public IWebElement RegistrationTitle;
        [FindsBy(How = How.XPath, Using = "(//input[@id='CybotCookiebotDialogBodyLevelButtonPreferencesInline'])[1]")]
        public IWebElement Preferencesoption;
        [FindsBy(How = How.Id, Using = "CybotCookiebotDialogBodyLevelButtonLevelOptinAllowallSelection")]
        public IWebElement AllowmySelectionbtn;

        public void NavigatetoRBIRegistrationpageforcookietest()
        {
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl(RIBAUrl);//will navigate to the BMI site
            Thread.Sleep(3000);
            driver.Manage().Cookies.DeleteCookieNamed("");
            driver.Manage().Cookies.DeleteAllCookies();// will delete all cookies

        }
        public void ManageCookie()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(ManageMyPreferencesButton));
            ManageMyPreferencesButton.Click();
        }
        public void Prefernces()
        {

            String javascript = "document.getElementById('CybotCookiebotDialogBodyLevelButtonPreferencesInline').click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(javascript);

        }
        public void AllowMySelection()
        {
            AllowmySelectionbtn.Click();
        }
        public void VerifyRegistrationPageOpened()
        {
            RegistrationTitle.Text.Should().Contain("REGISTER");
        }

    }
}
