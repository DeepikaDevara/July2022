
namespace July2022.Pages
{
    public class Homepage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            // click on administration tab
            Thread.Sleep(1500);

            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            //select time and materials

            IWebElement Tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Tmoption.Click();
            Thread.Sleep(1500);
        }
    }
}
