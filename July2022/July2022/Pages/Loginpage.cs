
using NUnit.Framework;

namespace July2022.Pages
{
    public class Loginpage
    {
        public void LoginActions(IWebDriver driver)

        {
            driver.Manage().Window.Maximize();


            //Launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            Thread.Sleep(2000);
                
            //identify username textbox and enter valid username
                IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
                userNameTextBox.SendKeys("hari");

                //identify password textbox and enter valid password
                IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
                PasswordTextBox.SendKeys("123123");

                //identify Login Button and click on it

                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();


            
        }
    }
}
    


