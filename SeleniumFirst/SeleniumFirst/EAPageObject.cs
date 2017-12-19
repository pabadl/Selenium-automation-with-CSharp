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

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement InputFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "Lastname")]
        public IWebElement InputLastName { get; set; }

        [FindsBy(How = How.Id, Using = "Lastname")]
        public IWebElement DDLContinents { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement btnSubmit { get; set; }
    }
}
