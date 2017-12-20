using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        // Extended method for entering text in the control
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
           
                new SelectElement(element).SelectByText(value);
        }
    }
}
