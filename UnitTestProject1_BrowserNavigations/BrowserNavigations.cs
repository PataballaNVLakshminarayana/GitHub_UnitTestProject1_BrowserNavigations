using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1_BrowserNavigations
{
    [TestClass]
    public class BrowserNavigations
    {
        [TestMethod]
        public void BrowserNavigations_TC()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            _driver.Quit();
        }
        [TestMethod]
        public void BrowserFarword_TC()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?ifkv=AXH0vVt6y6OEY9ApTxQzhln3w2c4g0X7jtoDIO_XOg5nvxigQqll8Nv4Pi_RZ_5Br9PLz298KeaGrA&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-233599473%3A1744744959962660");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().Forward();
            Thread.Sleep(10000);
            _driver.Quit();
        }
        [TestMethod]
        public void BrowserBack_TC()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?ifkv=AXH0vVt6y6OEY9ApTxQzhln3w2c4g0X7jtoDIO_XOg5nvxigQqll8Nv4Pi_RZ_5Br9PLz298KeaGrA&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-233599473%3A1744744959962660");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().Back();
            Thread.Sleep(10000);
            _driver.Quit();
        }
        [TestMethod]
        public void BrowserRefresh_TC()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
            _driver.Navigate().Refresh();
            Thread.Sleep(10000);
            _driver.Quit();
        }
    }
}
