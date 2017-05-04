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
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'Едностаен апартамент')]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[5]")).Click();
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/vidin/vidin/quarter/residentialproperties/onebedroomapartment/']")).Click();
            driver.FindElement(By.CssSelector(".green-btn")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

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
        [Test]
        public void Homework2EDLocatorsByName()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icheckbox_flat-green")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("green-btn")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void Homework3EDCssSelectors()
        //Selected number 10125
        // 1. Opens the url
        // 2. Clicks on the respective Услуга, Тип имот, Вид имот, Област,  град depending on your number and choice of City
        // 3. Click on “Свържи се с брокер” button for the (preferably) second property in the list
        // Commit and push the test
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("[href *= '/propertylist/sales/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div2/div/section/div/div/div/div/form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[2]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'к.к. Слънчев бряг')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icheckbox_flat-green")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon - search____ICON")).Click();
            driver.Close();
            driver.Quit();
        }

    }
}