using System;
using TechTalk.SpecFlow;
using RIBAStudentRegistration.Pages;

using RIBAStudentRegistration.Hooks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace RIBAStudentRegistration.Steps
{
    [Binding]
    [Scope(Tag = "UnmatchPassword")]
    public class RegistrationPasswordCheckSteps : HooksSetUp
    {
        public UnmatchedPassword Pwd;
        ExtentTest test = null;

        [Given(@"I navigate to RIBA Url for registrartion")]
        public void GivenINavigateToRIBAUrlForRegistrartion()
        {
            Pwd = new UnmatchedPassword(driver);
            Pwd.NavigatetoRBIRegistrationpage();
        }

        [Given(@"I click on allow all cookies button")]
        public void GivenIClickOnAllowAllCookiesButton()
        {
            Pwd.Cookies();
        }

        [When(@"I enter email in Your Email")]
        public void WhenIEnterEmailInYourEmail()
        {
            Pwd.EnterEmail();
            test.Log(Status.Info, "Correct Email");
        }

        [When(@"I select Title")]
        public void WhenISelectTitle()
        {
            Pwd.Title();
            test.Log(Status.Info, "Correct Title");

        }

        [When(@"I enter First name")]
        public void WhenIEnterFirstName()
        {
            Pwd.EnterFirstName();
            test.Log(Status.Info, "Correct FirstName");
        }

        [When(@"I enter Surname")]
        public void WhenIEnterSurname()
        {
            Pwd.EnterSurname();
            test.Log(Status.Info, "Correct Surname");

        }

        [When(@"I select Gender")]
        public void WhenISelectGender()
        {
            Pwd.Gender();
            test.Log(Status.Info, "Correct Gender");
        }

        [When(@"I enter date in DD/MM/YYYY format")]
        public void WhenIEnterDateInDDMMYYYYFormat()
        {
            Pwd.EnterDateOfBirth();
            test.Log(Status.Info, "Correct DOB");
        }

        [When(@"I select Ethnic origin")]
        public void WhenISelectEthnicOrigin()
        {
            Pwd.Ethinicity();
            test.Log(Status.Info, "Correct Ethinicity");

        }

        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            Pwd.YourPhoneNumber();
            test.Log(Status.Info, "Correct PhoneNumber");
        }

        [When(@"I enter Secondary email")]
        public void WhenIEnterSecondaryEmail()
        {
            Pwd.YourSecondaryEmail();
            test.Log(Status.Info, "Correct Secondary email");

        }

        [When(@"I select the overseas check box")]
        public void WhenISelectTheOverseasCheckBox()
        {
            Pwd.Overseas();
            test.Log(Status.Info, "Correct Overseas");

            Pwd.HomeCountry();
            test.Log(Status.Info, "Correct HomeCountry");

        }

        [When(@"I enter Address lineone, Address linetwo, Address linethree\.")]
        public void WhenIEnterAddressLineoneAddressLinetwoAddressLinethree_()
        {
            Pwd.AddressLine1();
            test.Log(Status.Info, "Correct AddressLine1");
            Pwd.AddressLine2();
            test.Log(Status.Info, "Correct AddressLine2");
            Pwd.AddressLine3();
            test.Log(Status.Info, "Correct AddressLine3");
        }

        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {

            Pwd.TownorCity();
            test.Log(Status.Info, "Correct TownorCity");
        }

        [When(@"I enter County or Region")]
        public void WhenIEnterCountyOrRegion()
        {
            Pwd.County();
            test.Log(Status.Info, "Correct County");

        }

        [When(@"I enter PostCode")]
        public void WhenIEnterPostCode()
        {
            Pwd.Postcode();
            test.Log(Status.Info, "Correct Postcode");
        }

        [When(@"I select Country")]
        public void WhenISelectCountry()
        {
            Pwd.Country();
            test.Log(Status.Info, "Correct Country");
        }

        [When(@"I select Partone institution")]
        public void WhenISelectPartoneInstitution()
        {
            Pwd.Part1InstitutionName();
            test.Log(Status.Info, "Correct Part1InstitutionName");
        }

        [When(@"I select Partone course name")]
        public void WhenISelectPartoneCourseName()
        {
            Pwd.Part1CourseName();
            test.Log(Status.Info, "Correct Part1CourseName");

        }

        [When(@"I enter Partone start date")]
        public void WhenIEnterPartoneStartDate()
        {
            Pwd.Part1StartDate();
            test.Log(Status.Info, "Correct Part1StartDate");

        }

        [When(@"I enter Partone completion date")]
        public void WhenIEnterPartoneCompletionDate()
        {
            Pwd.Part1CompletiontDate();
            test.Log(Status.Info, "Correct Part1CompletiontDate");
        }

        [When(@"I select Parttwo Institution name")]
        public void WhenISelectParttwoInstitutionName()
        {
            Pwd.Part2InstitutionName();
            test.Log(Status.Info, "Correct Part2InstitutionName");
        }

        [When(@"I select Parttwo course name")]
        public void WhenISelectParttwoCourseName()
        {
            Pwd.Part2CourseName();
            test.Log(Status.Info, "Correct Part2CourseName");
        }

        [When(@"I enter Parttwo start date")]
        public void WhenIEnterParttwoStartDate()
        {
            Pwd.Part2StartDate();
            test.Log(Status.Info, "Correct Part2StartDate");
        }

        [When(@"I enter Parttwo completion date")]
        public void WhenIEnterParttwoCompletionDate()
        {
            Pwd.Part2CompletiontDate();
            test.Log(Status.Info, "Correct Part2CompletiontDate");

        }

        [When(@"I enter Password in Password Section")]
        public void WhenIEnterPasswordInPasswordSection()
        {
            Pwd.Password();
            test.Log(Status.Info, "Correct Password");
        }

        [When(@"I enter in password in Retype Password")]
        public void WhenIEnterInPasswordInRetypePassword()
        {
            Pwd.RetypePassword();
            test.Log(Status.Info, "Correct RetypePassword");
        }

        [When(@"I select check box of Declaration")]
        public void WhenISelectCheckBoxOfDeclaration()
        {
            Pwd.Declaration();
            test.Log(Status.Info, "Correct Declaration");
        }

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            Pwd.RegisterBtn();
            test.Log(Status.Info, "Correct RegisterBtn");
        }

        [Then(@"It will show me the Registration Form page")]
        public void ThenItWillShowMeTheRegistrationFormPage()
        {
            try
            {
                test = extent.CreateTest("Registration Form Opens").Info("Registration Test -For Valid Scenario");

                Pwd.VerifyRegistrationPageOpened();
                test.Log(Status.Info, "Shown Success Opening of Registration Page");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }

        }

        [Then(@"I will see passwordunmatched error")]
        public void ThenIWillSeepasswordunmatchederror()
        {
            try
            {
                test = extent.CreateTest("Password Unmatched Test").Info("Registration Test -For Valid Scenario");
                Pwd.PasswordUnmatche();
                test.Log(Status.Info, "Password unmatched Test passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                test.Log(Status.Info, "Password unmatched Test failed");
                throw;
            }
        }
    }
}
