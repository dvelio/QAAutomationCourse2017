using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutoTests
{
    [TestFixture]
    public class Tsani
    {
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
        public void Lesson3HomeWorkTsanka()
        {
            // https://yavlenawebsite.melontech.com/propertylist
            // Digit 1: Услуга
            // Digit 2: Тип имот
            // Digit 3: Вид имот
            // Digit 4+5: Област
            // Choose “Град“ that has some properties

            // Create a test that:
            // Opens the url
            // Clicks on the respective Услуга, Тип имот, Вид имот, Област,  град depending on your number and choice of City
            // Click on “Свържи се с брокер” button for the (preferably) second property in the list 
            // Commit and push the test
            // Tsanka - 67890


            string url = "https://yavlenawebsite.melontech.com/propertylist";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // Usluga = 6 - Отговаря на Наем
            // Find by xPath
            string xPathService = "//a[contains(@href, '/propertylist/rentals/')]";
            FindByXpathAndClick(driver, xPathService);

            // Find by CssLocator
            // string cssService = "a[href='/propertylist/rentals/']";
            // my second selector
            // string cssService = ".offer_filter_btn:nth-child(2)";
            // FindByCssLocatorAndClick(driver,cssService);

            // Тип имот = 7 -  Бизнес имоти
            // Find by xPath
            string xPathTypeProperty = "//a[contains(@href, '/propertylist/rentals/district/location/quarter/commercialproperties/')]";
            FindByXpathAndClick(driver, xPathTypeProperty);


            // Find by CssLocator
            // string cssTypeProperty = "a[href='/propertylist/rentals/district/location/quarter/commercialproperties/']";
            // FindByCssLocatorAndClick(driver, cssTypeProperty);

            // Вид имот = 8  - Заведение
            // Find by xPath
            string xPathProperty = "//a[contains(@href, '/propertylist/rentals/district/location/quarter/commercialproperties/restaurant/')]";
            FindByXpathAndClick(driver, xPathProperty);


            // Find by cssLocator
            //string cssPropery = "a[href='/propertylist/rentals/district/location/quarter/commercialproperties/restaurant/']";
            //FindByCssLocatorAndClick(driver, cssProperty);

            // Област = 90 (всички области са 28 - деля 90 на 28 и остатъкът е 6 - значи 6 та област - Враца
            string xPathDistrict = "//a[contains(@href, '/propertylist/rentals/vratsa/location/quarter/commercialproperties/restaurant/')]";
            FindByXpathAndClick(driver, xPathDistrict);

            // Find by cssLocator
            // string cssDistrict = "a[href='/propertylist/rentals/vratsa/location/quarter/commercialproperties/restaurant/']";
            // FindByCssLocatorAndClick(driver, cssDistrict);


            // Град - Враца
            // Find by xPath
            string xPathCity = "//a[contains(text(),'гр. Враца')]";
            FindByXpathAndClick(driver, xPathCity);
            // Find by cssLocator 
            // string cssCity = "a[href='/propertylist/rentals/vratsa/vratsa/quarter/commercialproperties/restaurant/']";
            // FindByCssLocatorAndClick(driver, cssCity);


            // Втори резултат - ако няма такъв , да се кликне на първия
            // 3.After clicking on the link for the service new webpage is opened.On the newly opened page make sure the correct checkbox is ticked: next to the service you chose in the previous screen


            //System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> links = driver.FindElements(By.LinkText("Свържи се с брокер"));
            IList<IWebElement> links = driver.FindElements(By.LinkText("Свържи се с брокер"));
            int i = links.Count;
            if (i == 0)
            {
                throw new Exception("No results");
            }
            else if (i >= 2)
            { links[1].Click(); }
            else
            { links[0].Click(); }

            Thread.Sleep(3000);
            //TestCleanUp
            DriverCleanUp(driver);


        }

        [Test]
        public void Lesson3HomeWorkExtraTsanka()
        {

            // 1.Open https://yavlenawebsite.melontech.com/service/
            // 2.On the left there are links to different services
            // Everyone should click on a different service:
            // Tsanka Продажба
            // 3.After clicking on the link for the service new webpage is opened.On the newly opened page make sure the correct checkbox is ticked: next to the service you chose in the previous screen


            // 1.Open https://yavlenawebsite.melontech.com/service/
            string url = "https://yavlenawebsite.melontech.com/service/";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            // 2.On the left there are links to different services
            // Everyone should click on a different service:
            // Tsanka Продажба

            string cssUsluga = "a[href='/service/sale']";
            FindByCssLocatorAndClick(driver, cssUsluga);

            //3.After clicking on the link for the service new webpage is opened.On the newly opened page make sure the correct checkbox is ticked: next to the service you chose in the previous screen
            IWebElement myElement = driver.FindElement(By.Name("SellProperty"));
            if (!myElement.Selected)
            {
                Console.WriteLine("Is not selected");
                throw new Exception("Not checked");
            }

            Thread.Sleep(3000);
            //TestCleanUp
            DriverCleanUp(driver);


        }

        [Test]
        public void Lesson3HomeWorkAdditionalTsanka()
        {

            //1.Open https://yavlenawebsite.melontech.com/broker/

            //2.Click on the „зареди още“ button.
            //This way all the brokers are listed

            //3.For each broker check that if you type their name in the Search field, only one broker is listed – the one you are searching for



            //1.Open https://yavlenawebsite.melontech.com/broker/
            string url = "https://yavlenawebsite.melontech.com/broker/";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


            IWebElement cookiesBut = driver.FindElement(By.CssSelector("*[class^='hide-cookies-message']"));
            cookiesBut.Click();

            //2.Click on the „зареди още“ button.
            //This way all the brokers are listed
            Thread.Sleep(5000);


            IWebElement moreResults = driver.FindElement(By.PartialLinkText("Зареди"));
            moreResults.Click();

            //3.For each broker check that if you type their name in the Search field, only one broker is listed – the one you are searching for


            Thread.Sleep(3000);

            IList<IWebElement> moreBrokers = driver.FindElements(By.CssSelector("h3.name"));
            String[] allBrokersText = new String[moreBrokers.Count];

            for (int i = 0; i < moreBrokers.Count; i++)
            {
                allBrokersText[i] = moreBrokers[i].Text;
                Console.WriteLine(moreBrokers[i].Text);
            }



            IWebElement searchByName = driver.FindElement(By.ClassName("input-search"));



            for (int j = 0; j < allBrokersText.Length; j++)
            {
                driver.FindElement(By.ClassName("input-search")).Clear();
                driver.FindElement(By.ClassName("input-search")).SendKeys(allBrokersText[j]);
                Thread.Sleep(2000);
                String.Compare(allBrokersText[j], driver.FindElement(By.CssSelector(".name")).Text);
                Thread.Sleep(2000);

            }


            Thread.Sleep(5000);
            //TestCleanUp
            DriverCleanUp(driver);


        }

        private static void FindByCssLocatorAndClick(IWebDriver myDriver, string strToFindBy)
        {
            IWebElement cssElement = myDriver.FindElement(By.CssSelector(strToFindBy));
            cssElement.Click();
        }

        private static void FindByXpathAndClick(IWebDriver myDriver, string strToFindBy)
        {
            IWebElement cssElement = myDriver.FindElement(By.XPath(strToFindBy));
            cssElement.Click();
        }


        private static void DriverCleanUp(IWebDriver myDriver)

        {
            myDriver.Close();
            myDriver.Quit();
        }
    }
}
