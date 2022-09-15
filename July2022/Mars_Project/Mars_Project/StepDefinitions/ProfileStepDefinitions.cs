using Mars_Project.Page;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        
        Login loginPageObj = new Login();
        ProfileNEducation profileNEducationObj = new ProfileNEducation();
        LanguagePage languagepage = new LanguagePage();
        PasswordChangePage password = new PasswordChangePage();
        SkillPage SkillPageobj = new SkillPage();

        [Given(@"Login with valid email address and password")]
        public void GivenLoginWithValidEmailAddressAndPassword()
        {
            driver = new ChromeDriver();

            loginPageObj.LoginSteps(driver);
        }

        [Then(@"Should be able to successfully login to the website")]
        public void ThenShouldBeAbleToSuccessfullyLoginToTheWebsite()
        {
            string welcomemessage = profileNEducationObj.welcomeMessage(driver);
            Assert.That(welcomemessage == "Hi Dee", "Login unsuccessful.");
        }

        [Given(@"I succesfully logged in to website")]
        public void GivenISuccesfullyLoggedInToWebsite()
        {
            driver = new ChromeDriver();

            loginPageObj.LoginSteps(driver);


            string welcomemessage = profileNEducationObj.welcomeMessage(driver);
            Assert.That(welcomemessage == "Hi Dee", "Login unsuccessful.");
        }

        [When(@"I navigate to language tab in the profile")]
        public void WhenINavigateToLanguageTabInTheProfile()
        {
            languagepage.NavigateLanguage(driver);
        }

        [When(@"I create language details with '([^']*)'")]
        public void WhenICreateLanguageDetailsWith(string p0)
        {
            languagepage.LanguageAdd(driver, p0);
        }

        [Then(@"the new record for language should be created with '([^']*)' successfully")]
        public void ThenTheNewRecordForLanguageShouldBeCreatedWithSuccessfully(string p0)
        {
            string newlanguage = languagepage.newLanguage(driver);

            Assert.That(newlanguage == p0, "New language has not been added successfully");
        }

        [When(@"I Edit '([^']*)' details")]
        public void WhenIEditDetails(string p0)
        {
            languagepage.LanguageEdit(driver, p0);
        }

        [Then(@"the existing record for '([^']*)' should be updated successfully")]
        public void ThenTheExistingRecordForShouldBeUpdatedSuccessfully(string p0)
        {
            string editedlanguage = languagepage.EditedLanguage(driver);

            Assert.That(editedlanguage == p0, "The language does not updated successfully");
        }

        [When(@"I delete language details")]
        public void WhenIDeleteLanguageDetails()
        {
            languagepage.LanguageDelete(driver);
        }

        [Then(@"the record for language should be deleted succesfully")]
        public void ThenTheRecordForLanguageShouldBeDeletedSuccesfully()
        {
            string deletedlanguage = languagepage.DeletedLanguage(driver);

            Assert.That(deletedlanguage != "Telugu", "The language does not updated successfully");
        }

        [When(@"I navigate to Skill tab in the profile")]
        public void WhenINavigateToSkillTabInTheProfile()
        {
            SkillPageobj.NavigateSkill(driver);
        }

        [When(@"I create skill details with '([^']*)'")]
        public void WhenICreateSkillDetailsWith(string p0)
        {
            SkillPageobj.SkillAdd(driver, p0);
        }

        [Then(@"the new record for skill should be created with '([^']*)' succesfully")]
        public void ThenTheNewRecordForSkillShouldBeCreatedWithSuccesfully(string p0)
        {
            string newskill = SkillPageobj.newSkill(driver);

            Assert.That(newskill == p0, "New skill has not been added");
        }

        [When(@"I Edit skill details with '([^']*)'")]
        public void WhenIEditSkillDetailsWith(string p0)
        {
            SkillPageobj.SkillEdit(driver, p0);
        }

        [Then(@"the existing record for '([^']*)'  should be updated succesfully in skill")]
        public void ThenTheExistingRecordForShouldBeUpdatedSuccesfullyInSkill(string p0)
        {
            string editedskill = SkillPageobj.EditedSkill(driver);
            Assert.That(editedskill == p0, "The skill has not updated");
        }

        [When(@"I Delete skill details")]
        public void WhenIDeleteSkillDetails()
        {
            SkillPageobj.SkillDelete(driver);
        }

        [Then(@"the  last record in skill should be deleted succesfully")]
        public void ThenTheLastRecordInSkillShouldBeDeletedSuccesfully()
        {
            string deletedskill = SkillPageobj.DeletedSkill(driver);
            Assert.That(deletedskill != "Animation", "The skill has not deleted");
        }

        [When(@"I navigate to Education tab in the profile")]
        public void WhenINavigateToEducationTabInTheProfile()
        {
            profileNEducationObj.NavigateEducation(driver);
        }

        [When(@"I create education details")]
        public void WhenICreateEducationDetails()
        {
            profileNEducationObj.AddEducation(driver);
        }

        [Then(@"the new record for education should be created succesfully")]
        public void ThenTheNewRecordForEducationShouldBeCreatedSuccesfully()
        {
            string NewCollege = profileNEducationObj.NewCollege(driver);
            Assert.That(NewCollege == "JNTU", "Actual degree and expected degree name does not match");
        }

        [When(@"I Edit '([^']*)','([^']*)' education details")]
        public void WhenIEditEducationDetails(string p0, string p1)
        {
            profileNEducationObj.NavigateEducation(driver);
            profileNEducationObj.EditEducation(driver, p0, p1);
        }

        [Then(@"the existing record for education '([^']*)','([^']*)' should be updated succesfully")]
        public void ThenTheExistingRecordForEducationShouldBeUpdatedSuccesfully(string p0, string p1)
        {
            string EditedCollege = profileNEducationObj.EditedCollege(driver);

            Assert.That(EditedCollege == p0, "Actual College and expected College name does not match");
     
        }

        [When(@"I delete education details")]
        public void WhenIDeleteEducationDetails()
        {
            profileNEducationObj.DeleteEducation(driver);
        }

        [Then(@"the record for education should be deleted succesfully")]
        public void ThenTheRecordForEducationShouldBeDeletedSuccesfully()
        {
            string deletedCollege = profileNEducationObj.deletedCollege(driver);
            Assert.That(deletedCollege != "JNTU", " record hasn't deleted succesfully");
        }

        [When(@"I navigate to change password in the profile")]
        public void WhenINavigateToChangePasswordInTheProfile()
        {
            password.NavigateChangePassword(driver);
        }

        [When(@"Update from '([^']*)', '([^']*)'")]
        public void WhenUpdateFrom(string p0, string p1)
        {
            password.ChangePassword(driver, p0, p1);
        }

        [Then(@"Password should be updated successfully")]
        public void ThenPasswordShouldBeUpdatedSuccessfully()
        {
            //string pwdheader = password.DefaultModal(driver);
            //Assert.That(pwdheader = "Change Password", "Password changed successfully");

        }
    }
}
