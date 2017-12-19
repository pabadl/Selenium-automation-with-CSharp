using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        //Constructor para inicializar los objetos de esta pagina particular -> this
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement InputName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement InputPassword { get; set; }
       
        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            //UserName
            InputName.SendKeys(userName);
            //password
            InputPassword.SendKeys(password);
            //Click button
            btnLogin.Submit();

            //Return the page object
            return new EAPageObject();

        }

    }
}
