using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace AutoTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
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
            IWebDriver driver = new ChromeDriver();
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
            IWebDriver driver = new ChromeDriver();
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
            IWebDriver driver = new ChromeDriver();
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
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist/");
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
        public void ZdelkaStefan()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.FindElement(By.XPath("//*[contains(text(),'Съдействие при сделка')]")).Click();
            driver.FindElement(By.XPath("//div/label[7]/div[@class='icheckbox_flat-green checked']"));
               
            driver.Close();
            driver.Quit();

        }
        [Test]
        public void BrokerStefan()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/broker/");
            driver.FindElement(By.XPath("//div[2]/section/div[4]/a"));

            string[] arr = { "Аделина Янева", "Александър Кръстев", "Александър Младенов", "Ангел Стаменов" };
            for (var i = 0; i<=arr.Length-1; i++)
            {
                driver.FindElement(By.CssSelector(".input-search")).Clear();
                driver.FindElement(By.CssSelector(".input-search")).SendKeys(arr[i]);
                Thread.Sleep(3000);
                Assert.AreEqual(driver.FindElement(By.CssSelector("#brokers-grid-holder > div > div > article > div > div > div.header-group > h3 > a")).GetAttribute("title"), arr[i]);
                Thread.Sleep(3000);
            }
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void NewHome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            
            var element = driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/h1"));               // scrolling
            OpenQA.Selenium.Interactions.Actions actions = new Actions(driver);                            // scrolling
            actions.MoveToElement(element);                                                                // scrolling
            actions.Perform();                                                                             // scrolling
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("hide-cookies-message")).Click();                              //accept cookies
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/h1")).Click();
            Thread.Sleep(3000);
            bool isElementDisplayed=driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/div/p")).Displayed;       // verify message is displayed
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }

        private bool TryFindElement(By by)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Homework2EDLocatorsByName()
        {
            IWebDriver driver = new ChromeDriver();
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
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("[href *= '/propertylist/sales/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div2/div/section/div/div/div/div/form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[2]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'к.к. Слънчев бряг')]")).Click();
            driver.FindElement(By.CssSelector("[href *= 'propertylist/sales/burgas/sunny-beach-resort-area/quarter/residentialproperties/room/seaside-holiday-property/']")).Click();
            driver.FindElement(By.XPath("")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icheckbox_flat-green")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon - search____ICON")).Click();
            driver.Close();
            driver.Quit();

        }

        [Test]
        public void HW1Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("searchBox")).SendKeys("София");
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            Thread.Sleep(1000);
            Assert.AreEqual(driver.Url, "https://yavlenawebsite.melontech.com/properties/all/%D0%A1%D0%BE%D1%84%D0%B8%D1%8F%20(%D1%81%D1%82%D0%BE%D0%BB%D0%B8%D1%86%D0%B0)/%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/?view=Hybrid");
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void HW2Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[1]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[2]/a[4]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[3]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[4]/a[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[5]/a[5]")).Click();
            driver.FindElement(By.CssSelector("#dea027c8-24d0-4197-9ec3-714423fca021 > a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#SenderName")).SendKeys("Дидо");
            driver.FindElement(By.CssSelector("#SenderPhone")).SendKeys("0888888888");
            driver.FindElement(By.CssSelector("#SenderEmail")).SendKeys("bla@abv.bg");
            driver.FindElement(By.CssSelector("#send-broker-message > div.modal-footer > input.green-btn")).Click();
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void HW3Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/ html / body / div[2] / div / section[1] / aside[1] / nav / ul / li[5] / a")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact_PropertyAssessment")).Selected, true);



        }

        [Test]
        public void HW1Mitko()
        {
            IWebDriver driver = new ChromeDriver();
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
        public void HW3Mitko()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("a.offer_filter_btn:nth-of-type(1)")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a.offer_filter_btn:nth-of-type(4)")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//form/p[3]/a[3]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//form/p[4]/a[7]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Парцел']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//form/p[5]/a[98]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Свържи се с брокер']")).Click();
            Thread.Sleep(3000);
        }
            [Test]
        public void HW4Dido()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/broker/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".hide-cookies-message")).Click();
            driver.FindElement(By.CssSelector("a.green-btn:nth-child(1)"));
            Thread.Sleep(1000);
            IList<IWebElement> List = driver.FindElements(By.CssSelector("article.broker-card h3.name a"));

            ArrayList NewList = new ArrayList();
            foreach (IWebElement UserName in List)
            {
                NewList.Add(UserName.Text);
                Console.WriteLine(NewList);
            }


            foreach (string Name in NewList)
            {
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).Clear();
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).SendKeys(Name);
                Thread.Sleep(1000);
                Assert.AreEqual(Name, driver.FindElement(By.CssSelector(".name > a:nth-child(1)")).Text);
                Thread.Sleep(1000);

            }

        }
    }
}

