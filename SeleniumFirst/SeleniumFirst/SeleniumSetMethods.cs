using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(string element, string value, Propertytype elementtype)
        {
            if (elementtype == Propertytype.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == Propertytype.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        public static void Click(string element, Propertytype elementtype)
        {
            if (elementtype == Propertytype.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == Propertytype.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(string element, string value, Propertytype elementtype)
        {
            if (elementtype == Propertytype.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == Propertytype.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
