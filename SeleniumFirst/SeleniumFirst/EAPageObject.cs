using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class EAPageObject
    {
        //Para inicializar los objetos de esta pagina particular -> this
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitle { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement InputInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement InputFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement InputMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            InputInitial.EnterText(initial);
            InputFirstName.EnterText(firstName);
            InputMiddleName.EnterText(middleName);
            btnSave.Clicks();
            /*
            SeleniumSetMethods.EnterText(InputInitial, initial);
            SeleniumSetMethods.EnterText(InputFirstName, firstName);
            SeleniumSetMethods.EnterText(InputMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);
            
             * /
             * /*
            InputInitial.SendKeys(initial);
            InputFirstName.SendKeys(firstName);
            InputMiddleName.SendKeys(middleName);
            
            btnSave.Click();
            */
        }
    }
}
