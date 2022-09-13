using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace SpecflowAutomation.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        public static IWebDriver driver;

        [AfterScenario]
        public void EndScenario()
        {
            if(driver!=null)
            {
                driver.Quit();
            }
        }


    }
}
