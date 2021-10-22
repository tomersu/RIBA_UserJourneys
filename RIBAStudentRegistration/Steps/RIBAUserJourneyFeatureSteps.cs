using System;
using TechTalk.SpecFlow;
using RIBAStudentRegistration.Pages;
using RIBAStudentRegistration.Hooks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace RIBAStudentRegistration.Steps
{
    [Binding]
    [Scope(Tag = "RIBAUserJourneyRegistrationpage")]
    public class RIBAUserJourneyFeatureSteps : HooksSetUp
    {
        public RIBAUserJourneyPages Journey;
        ExtentTest test = null;
        [Given(@"I navigate to RIBA Url")]
        public void GivenINavigateToRIBAUrl()
        {
            Journey = new RIBAUserJourneyPages(driver);
            Journey.NavigatetoRBIRegistrationpage();

        }

        [Given(@"I click on allow all cookies button")]
        public void GivenIClickOnAllowAllCookiesButton()
        {
            Journey.Cookies();
        }
        [Then(@"It will show me the Registration Form")]
        public void ThenItWillShowMeTheRegistrationForm()
        {
            try
            {
                test = extent.CreateTest("Registration Form Opens").Info("Registration Test -For Valid Scenario");

                Journey.VerifyRegistrationPageOpened();
                test.Log(Status.Info, "Shown Success Opening of Registration Page");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            // Journey.VerifyRegistrationPageOpened();
        }

        [When(@"I enter email in Your Email")]
        public void WhenIEnterEmailInYourEmail()
        {
            Journey.EnterEmail();
            test.Log(Status.Info, "Correct Email");

        }

        [When(@"I select Title")]
        public void WhenISelectTitle()
        {
            Journey.Title();
            test.Log(Status.Info, "Correct Title");
        }

        [When(@"I enter First name")]
        public void WhenIEnterFirstName()
        {
            Journey.EnterFirstName();
            test.Log(Status.Info, "Correct FirstName");
        }

        [When(@"I enter Surname")]
        public void WhenIEnterSurname()
        {
            Journey.EnterSurname();
            test.Log(Status.Info, "Correct Surname");
        }

        [When(@"I select Gender")]
        public void WhenISelectGender()
        {
            Journey.Gender();
            test.Log(Status.Info, "Correct Gender");
        }

        [When(@"I enter date in DD/MM/YYYY format")]
        public void WhenIEnterDateInDDMMYYYYFormat()
        {
            Journey.EnterDateOfBirth();
            test.Log(Status.Info, "Correct DOB");
        }

        [When(@"I select Ethnic origin")]
        public void WhenISelectEthnicOrigin()
        {
            Journey.Ethinicity();
            test.Log(Status.Info, "Correct Ethinicity");
        }

        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            Journey.YourPhoneNumber();
            test.Log(Status.Info, "Correct PhoneNumber");
        }

        [When(@"I enter Secondary email")]
        public void WhenIEnterSecondaryEmail()
        {
            Journey.YourSecondaryEmail();
            test.Log(Status.Info, "Correct Secondary email");
        }

        [When(@"I select the overseas check box")]
        public void WhenISelectTheOverseasCheckBox()
        {
            Journey.Overseas();
            test.Log(Status.Info, "Correct Overseas");

            Journey.HomeCountry();
            test.Log(Status.Info, "Correct HomeCountry");
        }
        [When(@"I enter Address lineone, Address linetwo, Address linethree\.")]
        public void WhenIEnterAddressLineoneAddressLinetwoAddressLinethree_()
        {
            Journey.AddressLine1();
            test.Log(Status.Info, "Correct AddressLine1");
            Journey.AddressLine2();
            test.Log(Status.Info, "Correct AddressLine2");
            Journey.AddressLine3();
            test.Log(Status.Info, "Correct AddressLine3");
        }

        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {
            Journey.TownorCity();
            test.Log(Status.Info, "Correct TownorCity");
        }

        [When(@"I enter County or Region")]
        public void WhenIEnterCountyOrRegion()
        {
            Journey.County();
            test.Log(Status.Info, "Correct County");
        }

        [When(@"I enter PostCode")]
        public void WhenIEnterPostCode()
        {
            Journey.Postcode();
            test.Log(Status.Info, "Correct Postcode");
        }

        [When(@"I select Country")]
        public void WhenISelectCountry()
        {
            Journey.Country();
            test.Log(Status.Info, "Correct Country");
        }

        [When(@"I select Partone institution")]
        public void WhenISelectPartOneInstitution()
        {
            Journey.Part1InstitutionName();
            test.Log(Status.Info, "Correct Part1InstitutionName");
        }

        [When(@"I select Partone course name")]
        public void WhenISelectPartOneCourseName()
        {
            Journey.Part1CourseName();
            test.Log(Status.Info, "Correct Part1CourseName");

        }

        [When(@"I enter Partone start date")]
        public void WhenIEnterPartOneStartDate()
        {
            Journey.Part1StartDate();
            test.Log(Status.Info, "Correct Part1StartDate");

        }

        [When(@"I enter Partone completion date")]
        public void WhenIEnterPartOneCompletionDate()
        {
            Journey.Part1CompletiontDate();
            test.Log(Status.Info, "Correct Part1CompletiontDate");

        }

        [When(@"I select Parttwo Institution name")]
        public void WhenISelectParttwoInstitutionName()
        {
            Journey.Part2InstitutionName();
            test.Log(Status.Info, "Correct Part2InstitutionName");
        }
        [When(@"I select Parttwo course name")]
        public void WhenISelectParttwoCourseName()
        {
            Journey.Part2CourseName();
            test.Log(Status.Info, "Correct Part2CourseName");

        }

        [When(@"I enter Parttwo start date")]
        public void WhenIEnterParttwoStartDate()
        {
            Journey.Part2StartDate();
            test.Log(Status.Info, "Correct Part2StartDate");
        }

        [When(@"I enter Parttwo completion date")]
        public void WhenIEnterParttwoCompletionDate()
        {
            Journey.Part2CompletiontDate();
            test.Log(Status.Info, "Correct Part2CompletiontDate");
        }


        [When(@"I enter Password in Password Section")]
        public void WhenIEnterPasswordInPasswordSection()
        {
            Journey.Password();
            test.Log(Status.Info, "Correct Password");
        }

        [When(@"I enter in password in Retype Password")]
        public void WhenIEnterInPasswordInRetypePassword()
        {
            Journey.RetypePassword();
            test.Log(Status.Info, "Correct RetypePassword");
        }

        [When(@"I select check box of Declaration")]
        public void WhenISelectCheckBoxOfDeclaration()
        {
            Journey.Declaration();
            test.Log(Status.Info, "Correct Declaration");
        }

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            Journey.RegisterBtn();
            test.Log(Status.Info, "Correct RegisterBtn");
        }

        [Then(@"I will see success page")]
        public void ThenIWillSeeSuccessPage()
        {
            try
            {
                test = extent.CreateTest("Registration Test").Info("Registration Test -For Valid Scenario");
                Journey.SuccessinRegistration();
                test.Log(Status.Info, "Shown Success Registration Page");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                test.Log(Status.Info, "Success page can't be opened");
                throw;
            }
            /* finally
             {
                 if (driver !=null)
                 {
                     driver.Quit();
                 }
             }*/


        }

    }
}
