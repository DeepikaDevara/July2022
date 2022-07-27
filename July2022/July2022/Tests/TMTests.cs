using July2022.Pages;
using July2022.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July2022.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            Loginpage LoginpageObj = new Loginpage();
            LoginpageObj.LoginActions(driver);

            Homepage homepageObj = new Homepage();
            homepageObj.GoToTMpage(driver);
        }
        

        [Test, Order(1), Description("Check if user is able to create Material record with valid data")]
        public void CreateTMTest()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTM(driver);
        }
        [Test, Order(2), Description("Check if user is able to Edit the created record")]
    public void EditTMTest()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTM(driver, "AA", "BB", "CC");

        }
        [Test, Order(3), Description("Check if user is able to Delete the created record")]
    public void DeleteTM()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
    public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
