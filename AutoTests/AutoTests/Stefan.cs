using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutoTests
{ 
    [TestFixture]

    public class Stefan
    {


        [Test]
        public void HomeWorkStefanS()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();
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
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'Съдействие при сделка')]")).Click();
            driver.FindElement(By.XPath("//div[@class='icheckbox_flat-green checked']"));

            driver.Close();
            driver.Quit();

        }
        [Test]
        public void BrokerStefan()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/broker/");
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();
            driver.FindElement(By.XPath("//div[2]/section/div[4]/a"));

            string[] arr = { "Аделина Янева", "Александър Кръстев", "Александър Младенов", "Ангел Стаменов" };
            for (var i = 0; i <= arr.Length - 1; i++)
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

            driver.FindElement(By.CssSelector("h1.home-title")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(@"//h1/parent::div[contains(@class, 'open')]"));
            //bool isElementDisplayed = driver.FindElement(By.XPath("//h1[contains(@class,'home-title')]/../div[@class='seo-text-wrapper']")).Displayed;       // verify message is displayed
            //Assert.AreEqual(false, isElementDisplayed);
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }

        [Test]
        public void AllCitiesSs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();                              //accept cookies
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".all-cities.cities-btn")).Click();
            Thread.Sleep(3000);

            IWebElement body = driver.FindElement(By.XPath("//*[contains(text(),'Царево')]"));       //open link in new tab
            body.SendKeys(Keys.Control.ToString() + 't');                                            //open link in new tab
            Actions action = new Actions(driver);                                                    //open link in new tab
            action.KeyDown(Keys.Control).MoveToElement(body).Click().Perform();                      //open link in new tab


            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());                       // switch tab
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".view-mode:nth-child(1)")).Click();                // view by list
            Thread.Sleep(3000);

            //driver.FindElement(By.CssSelector("[href*='/broker/sendmessageforproperty?brokerId=FB2CD300-4BF0-43C5-953D-750ACD624169&serviceId=6df97f77-0b50-45d7-81b6-29c7873acc85']")).Click(); //abc
            driver.FindElement(By.CssSelector(".list-results-list article:nth-of-type(3) a.green-btn.broker-link")).Click();

            driver.Close();
            driver.Quit();

        }



        public void SofiaOver(IWebDriver driver)
        {
            IWebElement sofiaOver = driver.FindElement(By.ClassName("sofia-section"));
            Actions action = new Actions(driver);
            action.MoveToElement(sofiaOver).Perform();
        }
        public void VarnaOver(IWebDriver driver)
        {
            IWebElement varnaOver = driver.FindElement(By.ClassName("varna-section"));
            Actions action = new Actions(driver);
            action.MoveToElement(varnaOver).Perform();
        }

        public void BurgasOver(IWebDriver driver)
        {
            IWebElement burgasOver = driver.FindElement(By.ClassName("burgas-section"));
            Actions action = new Actions(driver);
            action.MoveToElement(burgasOver).Perform();
        }
        public void StaraZagoraOver(IWebDriver driver)
        {
            IWebElement SzOver = driver.FindElement(By.ClassName("bl-section"));
            Actions action = new Actions(driver);
            action.MoveToElement(SzOver).Perform();
        }
        [Test]
        public void MoluseOver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();
            Thread.Sleep(3000);
            
            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'3-стаен до €90 000')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'2-стаен до €65 000')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'къща до €150 000 (в област София)')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'магазин за продажба')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'2-стаен (наем)')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            SofiaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'3-стаен (наем)')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click(); 

            VarnaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'2-стаен до €40 000')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            VarnaOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'3-стаен до €75 000')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            VarnaOver(driver);
           
            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'жилище под наем')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();  
 
            BurgasOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'2-стаен до €50 000')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            BurgasOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'3-стаен до €80 000')]")).Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();
            
            BurgasOver(driver);


            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//article[contains(@class,'burgas-section')]//a[contains(text(),'жилище под наем')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click(); 
            
            var element = driver.FindElement(By.ClassName("bl-section"));               // scrolling
            OpenQA.Selenium.Interactions.Actions actions = new Actions(driver);                            // scrolling
            actions.MoveToElement(element);                                                                // scrolling
            actions.Perform();                                                                             // scrolling
            Thread.Sleep(3000);

            StaraZagoraOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'2-стаен за продажба')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            StaraZagoraOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//*[contains(text(),'3-стаен за продажба')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            StaraZagoraOver(driver);

            Thread.Sleep(3000);       // implicity wait doesnt work at this plase since it gives an result that the element bellow is not visible
            driver.FindElement(By.XPath("//article[contains(@class,'bl-section')]//a[contains(text(),'жилище под наем')]")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();

            







            driver.Close();
            driver.Quit();
        }

    }
}

