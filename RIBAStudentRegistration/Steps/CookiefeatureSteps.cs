using System;
using TechTalk.SpecFlow;
using RIBAStudentRegistration.Pages;
using RIBAStudentRegistration.Hooks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace RIBAStudentRegistration.Steps
{
    [Binding]
    [Scope(Tag = "CookieManageCheck")]
    public class CookiefeatureSteps : HooksSetUp
    {
        public CookiePage Cookie;
        ExtentTest test = null;
        [Given(@"I navigate to RIBA Url")]
        [Given(@"I navigate to RIBA Url for cookie test")]
        public void GivenINavigateToRIBAUrlForCookieTest()
        {
            Cookie = new CookiePage(driver);
            Cookie.NavigatetoRBIRegistrationpageforcookietest();

        }



        [When(@"I click on Manage my preferenes button")]
        public void WhenIClickOnManageMyPreferenesButton()
        {

            Cookie.ManageCookie();

        }

        [When(@"I click on prefernces option")]
        public void WhenIClickOnPreferncesOption()
        {

            Cookie.Prefernces();

        }

        [When(@"I click on Allow my selection")]
        public void WhenIClickOnAllowMySelection()
        {

            Cookie.AllowMySelection();
            //test.Log(Status.Info, "Allow my Selection passed");
        }

        [Then(@"I will see reistration page")]
        public void ThenIWillSeeReistrationPage()
        {

            Cookie.VerifyRegistrationPageOpened();
            // test.Log(Status.Info, "Registration page opens: Passed");
        }
    }
}
