using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//Launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
userNameTextBox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
PasswordTextBox.SendKeys("123123");

//identify Login Button and click on it

IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
LoginButton.Click();

//check if user has logged in successfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


if(helloHari.Text == "Hello hari!") 

{

    Console.WriteLine("Logged in Succesfully, Test passed.");


}

else

{
    Console.WriteLine("Log in fail, Test failed.");

}

//create a new material record
// click on administration tab
Thread.Sleep(1500);

IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();

//select time and materials

IWebElement Tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
Tmoption.Click();
Thread.Sleep(1500);

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

Thread.Sleep(5000);

//go to lastpage

IWebElement goTOLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goTOLastPageButton.Click();

Thread.Sleep(3000);
//check if record is created successfully
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
//IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "july22")
{
    Console.WriteLine("New record created successfully");
}
else
{
    Console.WriteLine("New record haven't created");
}

