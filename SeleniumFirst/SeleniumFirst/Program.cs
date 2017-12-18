using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference for our browser
            IWebDriver driver = new ChromeDriver();

            //navigate to google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operation
            element.SendKeys("executeautomation");

            driver.Close();
        }
    }
}
