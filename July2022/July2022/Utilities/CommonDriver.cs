using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July2022.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginActions(IWebDriver driver)
        {
            driver = new ChromeDriver();

            Loginpage loginPageObj = new Loginpage();
            loginPageObj.LoginActions(driver);
        }
    }
}