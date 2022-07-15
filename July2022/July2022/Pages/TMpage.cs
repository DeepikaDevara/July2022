
namespace July2022.Pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on create new
            IWebElement Createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Createnewbutton.Click();
            Thread.Sleep(2000);

            //Input code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("july22");

            //Input Description
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("july22");

            //making Pricetag interactable
            IWebElement Pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Pricetag.Click();

            //Input Price
            IWebElement Price = driver.FindElement(By.XPath("//*[@id='Price']"));
            Price.SendKeys("99");

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();

            Thread.Sleep(3000);

            //go to lastpage
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            //check if record is created successfully
            IWebElement newCode = driver.FindElement(By.XPath("*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "july22")
            {
                Console.WriteLine("New record created successfully");
            }
            else
            {
                Console.WriteLine("New record haven't created");
            }
        }
    }
}
