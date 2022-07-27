using July2022.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace July2022.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            Loginpage LoginpageObj = new Loginpage();
            LoginpageObj.LoginActions(driver);
        }

        [When(@"when I navigate to time and material page")]
        public void WhenWhenINavigateToTimeAndMaterialPage()
        {
            Homepage homepageObj = new Homepage();
            homepageObj.GoToTMpage(driver);
        }

        [When(@"I create a new record")]
        public void WhenICreateANewRecord()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created Successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMpage tmPageObj = new TMpage();
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);


            Assert.That(newCode == "july22", "Actual code and expected code do not match");
            Assert.That(newDescription == "july22", "Actual Descrition and expected description do not match");
            Assert.That(newPrice == "$99.00", "Actual price and expected price do not match");

        }

        [When(@"I update '([^']*)', '([^']*)', '([^']*)' of an existing material record")]
        public void WhenIUpdateOfAnExistingMaterialRecord(string p0, string p1, string p2)
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTM(driver, p0, p1, p2);

        }

        [Then(@"the '([^']*)', '([^']*)', '([^']*)' should be edited/Updated")]
        public void ThenTheShouldBeEditedUpdated(string p0, string p1, string p2)
        {
            TMpage tmPageObj = new TMpage();
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedPrice = tmPageObj.GetPrice(driver);

            Assert.That(editedCode == p0, "Actual code and expected code do not match");
            Assert.That(editedDescription == p1, "Actual Description and expected description do not match");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match");

        }


    }
}
