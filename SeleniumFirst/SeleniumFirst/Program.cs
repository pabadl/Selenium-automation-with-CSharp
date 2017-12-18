using NUnit.Framework;
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
        //reference for our browser
        //Global variable
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            

           

           
            
        }


        [SetUp]
        public void Initialize()
        {
            //navigate to google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operation
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");


        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
