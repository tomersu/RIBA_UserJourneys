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
    public class RIBAUserJourneyPages
    {
        public IWebDriver driver;
        public RIBAUserJourneyPages(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }
        protected string RIBAUrl = "https://uat-register.architecture.com/students";



        [FindsBy(How = How.Id, Using = "CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")]
        public IWebElement AllowallCookieButton;
        [FindsBy(How = How.XPath, Using = "//h1")]
        public IWebElement RegistrationTitle;
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement YourEmailtxt;
        [FindsBy(How = How.Id, Using = "Title")]
        public IWebElement TitleSelect;

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNametxt;
        [FindsBy(How = How.Id, Using = "Surname")]
        public IWebElement SurNametxt;
        [FindsBy(How = How.Id, Using = "Gender")]
        public IWebElement GenderSelect;
        [FindsBy(How = How.Id, Using = "DOB")]
        public IWebElement DOBtxt;
        [FindsBy(How = How.Id, Using = "Ethnicity")]
        public IWebElement EthnicitySelect;
        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        public IWebElement PhoneNumbertxt;
        [FindsBy(How = How.Id, Using = "SecondaryEmail")]
        public IWebElement SecondaryEmailtxt;
        [FindsBy(How = How.XPath, Using = "//div[@class='form-input-container__input']//i[@class='checkbox__check']")]
        public IWebElement Overseaschkbox;
        [FindsBy(How = How.Id, Using = "InternationalCountry")]
        public IWebElement HomeCountrySelect;

        [FindsBy(How = How.Id, Using = "AddressLine1")]
        public IWebElement AddressLine1txt;
        [FindsBy(How = How.Id, Using = "AddressLine2")]
        public IWebElement AddressLine2txt;
        [FindsBy(How = How.Id, Using = "AddressLine3")]
        public IWebElement AddressLine3txt;
        [FindsBy(How = How.Id, Using = "TownOrCity")]
        public IWebElement TownOrCitytxt;
        [FindsBy(How = How.Id, Using = "County")]
        public IWebElement Countytxt;
        [FindsBy(How = How.Id, Using = "Postcode")]
        public IWebElement Postcodetxt;
        [FindsBy(How = How.XPath, Using = "//select[@id='Country']")]
        public IWebElement CountrySelect;
        [FindsBy(How = How.Id, Using = "PartOneInstitutionName")]
        public IWebElement PartOneInstitutionNameSelect;
        [FindsBy(How = How.Id, Using = "PartOneCourseName")]
        public IWebElement PartOneCourseNameSelect;

        [FindsBy(How = How.Id, Using = "PartOneStartDate")]
        public IWebElement PartOneStartDatetxt;
        [FindsBy(How = How.Id, Using = "PartOneCompletionDate")]
        public IWebElement PartOneCompletionDatetxt;
        [FindsBy(How = How.XPath, Using = "//select[@id='PartTwoInstitutionName']")]
        public IWebElement PartTwoInstitutionNameSelect;
        [FindsBy(How = How.Id, Using = "PartTwoCourseName")]
        public IWebElement PartTwoCourseNameSelect;
        [FindsBy(How = How.Id, Using = "PartTwoStartDate")]
        public IWebElement PartTwoStartDatetxt;
        [FindsBy(How = How.Id, Using = "PartTwoCompletionDate")]
        public IWebElement PartTwoCompletionDatetxt;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Passwordtxt;
        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement ConfirmPasswordtxt;
        [FindsBy(How = How.XPath, Using = "(//i[@class='checkbox__check'])[2]")]
        public IWebElement Declarationcheckbox;
        [FindsBy(How = How.Id, Using = "RegisterButton")]
        public IWebElement RegisterButton;



        public void NavigatetoRBIRegistrationpage()
        {
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl(RIBAUrl);//will navigate to the BMI site
            Thread.Sleep(2000);
            driver.Manage().Cookies.DeleteAllCookies();// will delete all cookies

            // AllowallCookieButton.Click(); // will accept the cookie
        }
        public void Cookies()

        {
            try
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                wait.Until(ExpectedConditions.ElementToBeClickable(AllowallCookieButton));
                AllowallCookieButton.Click(); // will accept the cookie

            }
            catch (Exception e)
            {
                driver.Navigate().Refresh();

            }
        }
        public void VerifyRegistrationPageOpened()
        {

            RegistrationTitle.Text.Should().Contain("REGISTER");
        }
        public void EnterEmail()
        {

            YourEmailtxt.Clear();
            YourEmailtxt.SendKeys("abcde@gmail.com");
        }
        public void Title()
        {
            SelectElement SelectingTitle = new SelectElement(TitleSelect);
            SelectingTitle.SelectByValue("Mrs");
        }
        public void EnterFirstName()
        {
            FirstNametxt.Clear();
            FirstNametxt.SendKeys("tina");
        }
        public void EnterSurname()
        {
            SurNametxt.Clear();
            SurNametxt.SendKeys("nigam");
        }
        public void Gender()
        {
            SelectElement SelGender = new SelectElement(GenderSelect);
            SelGender.SelectByValue("Female");
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", TownOrCitytxt);//Scroll to the element
        }
        public void EnterDateOfBirth()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds (5));
            wait.Until(ExpectedConditions.ElementToBeClickable(DOBtxt));
            DOBtxt.Clear();
            DOBtxt.SendKeys("01/01/2001");
        }
        public void Ethinicity()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(EthnicitySelect));
            SelectElement SelEthinic = new SelectElement(EthnicitySelect);
            SelEthinic.SelectByValue("AABI");

        }
        public void YourPhoneNumber()
        {
            PhoneNumbertxt.Clear();
            PhoneNumbertxt.SendKeys("2073073686");
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", TownOrCitytxt);//Scroll to the element
        }
        public void YourSecondaryEmail()
        {
            SecondaryEmailtxt.Clear();
            SecondaryEmailtxt.SendKeys("abcdef@gmail.com");
        }
        public void Overseas()
        {

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.ElementToBeClickable(Overseaschkbox));
            //Overseaschkbox.Clear();
            Overseaschkbox.Click();
        }
        public void AddressLine1()
        {
            AddressLine1txt.Clear();
            AddressLine1txt.SendKeys("55, Portland");
        }
        public void AddressLine2()
        {
            AddressLine2txt.Clear();
            AddressLine2txt.SendKeys("romford");
        }
        public void AddressLine3()
        {
            AddressLine3txt.Clear();
            AddressLine3txt.SendKeys("london");
        }
        public void TownorCity()
        {
            TownOrCitytxt.Clear();
            TownOrCitytxt.SendKeys("london");
        }
        public void County()
        {
            Countytxt.Clear();
            Countytxt.SendKeys("Essex");
        }
        public void Postcode()
        {
            Postcodetxt.Clear();
            Postcodetxt.SendKeys("rr7 268");
        }
        public void HomeCountry()
        {
            SelectElement SelHomeCountry = new SelectElement(HomeCountrySelect);
            SelHomeCountry.SelectByValue("India");

        }
        public void Country()
        {
            SelectElement SelCountry = new SelectElement(CountrySelect);
            //SelCountry.Should()
            //   string name=(SelCountry.SelectedOption);
            SelCountry.SelectByText("United Kingdom");

        }
        public void Part1InstitutionName()
        {
            SelectElement SelPartOneInstitutionName = new SelectElement(PartOneInstitutionNameSelect);
            SelPartOneInstitutionName.SelectByValue("Aarhus School of Architecture");
        }
        public void Part1CourseName()
        {
            SelectElement SelPartOneCourseName = new SelectElement(PartOneCourseNameSelect);
            SelPartOneCourseName.SelectByValue("Master of Arts in Architecture");
        }
        public void Part1StartDate()
        {
            PartOneStartDatetxt.Clear();
            PartOneStartDatetxt.SendKeys("11/11/2017");
        }
        public void Part1CompletiontDate()
        {
            PartOneCompletionDatetxt.Clear();
            PartOneCompletionDatetxt.SendKeys("11/11/2018");
        }
        public void Part2InstitutionName()
        {
            SelectElement SelParttwoInstitutionName = new SelectElement(PartTwoInstitutionNameSelect);
            SelParttwoInstitutionName.SelectByIndex(1);
        }
        public void Part2CourseName()
        {
            SelectElement SelParttwoCourseName = new SelectElement(PartTwoCourseNameSelect);
            SelParttwoCourseName.SelectByIndex(1);
        }
        public void Part2StartDate()
        {
            PartTwoStartDatetxt.Clear();
            PartTwoStartDatetxt.SendKeys("11/11/2020");
        }
        public void Part2CompletiontDate()
        {
            PartTwoCompletionDatetxt.Clear();
            PartTwoCompletionDatetxt.SendKeys("11/11/2021");
        }
        public void Password()
        {
            Passwordtxt.Clear();
            Passwordtxt.SendKeys("AutomationTester1");
        }
        public void RetypePassword()
        {
            ConfirmPasswordtxt.Clear();
            ConfirmPasswordtxt.SendKeys("AutomationTester1");
        }
        public void Declaration()
        {
            //if (!Declarationcheckbox.Selected)
            // {
            Declarationcheckbox.Click();
            // }
        }
        public void RegisterBtn()
        {
            RegisterButton.Click();



        }
        public void SuccessinRegistration()
        {
            Thread.Sleep(2000);
            driver.Url.Contains("uat-register.architecture.com/Students/Success").Should().BeTrue();


        }



    }

}
