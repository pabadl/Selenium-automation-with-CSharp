using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    //Strongly type parameters
    enum Propertytype
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    //Instancia del driver
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
