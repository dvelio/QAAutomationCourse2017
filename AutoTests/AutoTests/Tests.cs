using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MyTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("map-search")).Click();
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void FirstTestYavlena()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("map-search")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);

            driver.Close();
            driver.Quit();
        }

        [Test]
        public void Lesson2HoomeWork()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("map-search")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("brand")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("searchBox")).Click();
            driver.FindElement(By.Id("searchBox")).SendKeys("Sofia");
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
           
        }

        [Test]
        public void HomeWorkStefanS()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("област Пловдив, Пловдив");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void RentalsStefan()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'Едностаен апартамент')]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[5]")).Click();
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/vidin/vidin/quarter/residentialproperties/onebedroomapartment/']")).Click();
            driver.FindElement(By.CssSelector(".green-btn")).Click();
            Thread.Sleep(3000);
            
        }

        [Test]
        public void Lesson2HomeWorkMitko()
        {
            IWebDriver driver = driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("Pavlovo");
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.Id("searchBox-validation"));
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).Clear();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("Павлово");
            //Thread.Sleep(3000);
            driver.FindElement(By.Id("ui-id-2")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("brand")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("map-search")).Click();
            //Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
    }
}