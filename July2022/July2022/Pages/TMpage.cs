
using July2022.Utilities;
using NUnit.Framework;

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

            //go to lastpage
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();


            //check if record is created
            


        }

        public string GetCode(IWebDriver driver)

        {
            IWebElement newCode = driver.FindElement(By.XPath("*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }


        public void EditTM(IWebDriver driver, string code, string description, string price)
        {
            Thread.Sleep(3000);
            //go to lastpage
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();

            Thread.Sleep(3000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(1000);
            editButton.Click();
          
            //Input code
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));

            CodeTextBox.Click();
            CodeTextBox.Clear();
            CodeTextBox.SendKeys(code);

            //Input Description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));

            descriptionTextBox.Click();
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(description);

            //making Pricetag interactable
            IWebElement priceNew = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceEdit = driver.FindElement(By.XPath("//*[@id='Price']"));

            priceNew.Click();
            priceEdit.Clear();
            priceNew.Click();
            priceEdit.SendKeys(price);

            //Click on save button
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveButton.Click();

            Thread.Sleep(3000);

            //go to lastpage
            IWebElement gotoLastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            //check if record is edited
           
           
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }

        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //go to lastpage
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();

            IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]"));
            Deletebutton.Click();
            Thread.Sleep(1500);
            //click on ok
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();


            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement deletedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(deletedCode.Text != "NewRecord", "Code record has not been deleted");
            Assert.That(deletedTypeCode.Text != "M", "Typecode record hasn't been deleted");
            Assert.That(deletedDescription.Text != "NewRecord", "Description record hasn't been deleted");
            Assert.That(deletedPrice.Text != "90", "Price record hasn't been deleted");
        }
}
}