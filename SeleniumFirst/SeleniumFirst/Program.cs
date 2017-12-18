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
        

        static void Main(string[] args)
        {

            
        }


        [SetUp]
        public void Initialize()
        {
            //reference for our browser
            //Global variable
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.EnterText("firstname", "juan", Propertytype.Name);
            SeleniumSetMethods.EnterText("lastname", "abad", Propertytype.Name);
            SeleniumSetMethods.SelectDropDown("continents", "Europe", Propertytype.Id);

            Console.WriteLine("The value from my name is: " + SeleniumGetMethods.GetText("firstname", Propertytype.Name));
            Console.WriteLine("The value from my last name is: " + SeleniumGetMethods.GetText("lastname", Propertytype.Name));
            Console.WriteLine("The value from the continent is: " + SeleniumGetMethods.GetTextFromDDL("continents", Propertytype.Id));

            SeleniumSetMethods.Click("submit", Propertytype.Id);
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
