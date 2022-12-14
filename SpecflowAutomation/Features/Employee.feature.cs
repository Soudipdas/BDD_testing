// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "employee")]
    public partial class EmployeeFeature : object, Xunit.IClassFixture<EmployeeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "employee"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Employee.feature"
#line hidden
        
        public EmployeeFeature(EmployeeFeature.FixtureData fixtureData, SpecflowAutomation_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Employee", "In order to add employee records \r\nAs an admin\r\nI want to modify the employee det" +
                    "ails in dashboard", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Add Valid Employee")]
        [Xunit.TraitAttribute("FeatureTitle", "Employee")]
        [Xunit.TraitAttribute("Description", "Add Valid Employee")]
        [Xunit.TraitAttribute("Category", "low")]
        [Xunit.TraitAttribute("Category", "smoke")]
        [Xunit.InlineDataAttribute("Admin", "admin123", "Soudip", "X", "Das", "1001", "on", "soudip123", "Soudip@123", "Soudip@123", "enabled", new string[0])]
        public void AddValidEmployee(string username, string password, string firstname, string middlename, string lname, string empid, string toggle_Login, string account_User, string account_Password, string confirm_Password, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "low",
                    "smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("firstname", firstname);
            argumentsOfScenario.Add("middlename", middlename);
            argumentsOfScenario.Add("lname", lname);
            argumentsOfScenario.Add("empid", empid);
            argumentsOfScenario.Add("toggle_login", toggle_Login);
            argumentsOfScenario.Add("account_user", account_User);
            argumentsOfScenario.Add("account_password", account_Password);
            argumentsOfScenario.Add("confirm_password", confirm_Password);
            argumentsOfScenario.Add("status", status);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Valid Employee", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("I have browser with orangehrm page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.When(string.Format("I enter username as \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And(string.Format("I enter password as \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("I click on login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("I click on PIM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I click on Add Employee", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "firstname",
                            "middlename",
                            "lastname",
                            "employee_id",
                            "toggle_login_detail",
                            "username",
                            "password",
                            "confirm_password",
                            "status"});
                table2.AddRow(new string[] {
                            string.Format("{0}", firstname),
                            string.Format("{0}", middlename),
                            string.Format("{0}", lname),
                            string.Format("{0}", empid),
                            string.Format("{0}", toggle_Login),
                            string.Format("{0}", account_User),
                            string.Format("{0}", account_Password),
                            string.Format("{0}", confirm_Password),
                            string.Format("{0}", status)});
#line 16
 testRunner.And("I fill the add employee section", ((string)(null)), table2, "And ");
#line hidden
#line 19
 testRunner.And("I click on save employee", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.Then("I should be navigated to personal details section with added employee records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EmployeeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EmployeeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
