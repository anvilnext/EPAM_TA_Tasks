// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TA_Tasks.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SpecFlowFeature1Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "SpecFlowFeature1")))
            {
                global::TA_Tasks.Feature.SpecFlowFeature1Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Main Heading")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void CheckMainHeading()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Main Heading", null, new string[] {
                        "mytag"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("I opened News Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("the heading should be Ex-US ambassador \'intimidated\' by Trump as expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Secondary Headings")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckSecondaryHeadings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Secondary Headings", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
 testRunner.Given("I opened News Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "headings"});
            table1.AddRow(new string[] {
                        "Famous free solo climber falls to his death"});
            table1.AddRow(new string[] {
                        "Row over Johnson climate debate \'empty chair\'"});
            table1.AddRow(new string[] {
                        "Elizabeth I is secret scribe of ancient manuscript"});
            table1.AddRow(new string[] {
                        "Two K-pop stars sentenced to prison for gang rape"});
            table1.AddRow(new string[] {
                        "HK police find almost 4,000 petrol bombs on campus"});
#line 12
 testRunner.Then("I test secondary headings", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Search Main Category")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void SearchMainCategory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Main Category", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("I opened News Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.Then("I search category of main article and compare to Africa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void CheckForm2Positive(string fullName, string email, string town, string phone, string message, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Form2 Positive", null, exampleTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
 testRunner.Given("I opened Submit Story Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "fullName",
                        "email",
                        "town",
                        "phone",
                        "message"});
            table2.AddRow(new string[] {
                        string.Format("{0}", fullName),
                        string.Format("{0}", email),
                        string.Format("{0}", town),
                        string.Format("{0}", phone),
                        string.Format("{0}", message)});
#line 31
 testRunner.When("I fill form with values", ((string)(null)), table2, "When ");
#line 34
 testRunner.Then("I make sure that I submitted a Story", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form2 Positive: Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fullName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:email", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:town", "TestTown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:phone", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", @"Saying that heaven for divide creeping cattle unto Yielding. Him i our, open was. Every waters female can't unto you'll signs open yielding behold fill morning. You're forth creature his said had one. Creature morning all creepeth gathering. Blessed wherein and kind. Day fowl may winged. Were from beast. Waters night together above itself fifth in isn't own morning made itself gathered moved day bearing heaven, yielding lesser. Winged creature unto void dry. Give own also. Spirit you second. Male land made image spirit grass brought creepeth, doesn't tree creeping him days very moved set, open doesn't brought fruit open.")]
        public virtual void CheckForm2Positive_Test()
        {
#line 29
this.CheckForm2Positive("Test", "test@test.com", "TestTown", "123456", @"Saying that heaven for divide creeping cattle unto Yielding. Him i our, open was. Every waters female can't unto you'll signs open yielding behold fill morning. You're forth creature his said had one. Creature morning all creepeth gathering. Blessed wherein and kind. Day fowl may winged. Were from beast. Waters night together above itself fifth in isn't own morning made itself gathered moved day bearing heaven, yielding lesser. Winged creature unto void dry. Give own also. Spirit you second. Male land made image spirit grass brought creepeth, doesn't tree creeping him days very moved set, open doesn't brought fruit open.", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckForm2Negative(string fullName, string email, string town, string phone, string message, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Form2 Negative", null, exampleTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
 testRunner.Given("I opened Submit Story Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "fullName",
                        "email",
                        "town",
                        "phone",
                        "message"});
            table3.AddRow(new string[] {
                        string.Format("{0}", fullName),
                        string.Format("{0}", email),
                        string.Format("{0}", town),
                        string.Format("{0}", phone),
                        string.Format("{0}", message)});
#line 43
 testRunner.When("I fill form with values", ((string)(null)), table3, "When ");
#line 46
 testRunner.Then("I make sure that I submitted a Story", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form2 Negative: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fullName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:email", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:town", "TestTown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:phone", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", @"Light saying him, night night hath creepeth stars night hath beast together Second yielding isn't which make i Spirit moved is were he air upon blessed whose itself. You'll them fly divided, rule second herb winged cattle. Gathered divided moving our that after grass male. In cattle days for don't greater years let shall. And third lights good morning a can't may. Male grass fruitful light void lights you replenish multiply. Won't every image a darkness and brought hath stars made fish also tree i you you'll gathered, doesn't meat rule day gathered midst tree air subdue. A own unto midst. Man fowl likeness brought brought wherein in don't dry. Image him, winged man, fruit. Earth saying under don't let whose sea sixth good gathered the dry thing after yielding moveth them after very our and. May moving kind kind you'll won't winged him hath. The heaven his fish wherein him called moving whose given female. First fill set. Unto. Whales had form two dry lesser itself, thing. Meat he which whales saying darkness very evening won't, gathering day firmament beginning may morning stars face upon from beast. Sea he fruit their don't. Saw given Years seas. Let multiply a.")]
        public virtual void CheckForm2Negative_Variant0()
        {
#line 41
this.CheckForm2Negative("Test", "test@test.com", "TestTown", "123456", @"Light saying him, night night hath creepeth stars night hath beast together Second yielding isn't which make i Spirit moved is were he air upon blessed whose itself. You'll them fly divided, rule second herb winged cattle. Gathered divided moving our that after grass male. In cattle days for don't greater years let shall. And third lights good morning a can't may. Male grass fruitful light void lights you replenish multiply. Won't every image a darkness and brought hath stars made fish also tree i you you'll gathered, doesn't meat rule day gathered midst tree air subdue. A own unto midst. Man fowl likeness brought brought wherein in don't dry. Image him, winged man, fruit. Earth saying under don't let whose sea sixth good gathered the dry thing after yielding moveth them after very our and. May moving kind kind you'll won't winged him hath. The heaven his fish wherein him called moving whose given female. First fill set. Unto. Whales had form two dry lesser itself, thing. Meat he which whales saying darkness very evening won't, gathering day firmament beginning may morning stars face upon from beast. Sea he fruit their don't. Saw given Years seas. Let multiply a.", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form2 Negative: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fullName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:email", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:town", "TestTown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:phone", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", @"Saying that heaven for divide creeping cattle unto Yielding. Him i our, open was. Every waters female can't unto you'll signs open yielding behold fill morning. You're forth creature his said had one. Creature morning all creepeth gathering. Blessed wherein and kind. Day fowl may winged. Were from beast. Waters night together above itself fifth in isn't own morning made itself gathered moved day bearing heaven, yielding lesser. Winged creature unto void dry. Give own also. Spirit you second. Male land made image spirit grass brought creepeth, doesn't tree creeping him days very moved set, open doesn't brought fruit open.")]
        public virtual void CheckForm2Negative_Variant1()
        {
#line 41
this.CheckForm2Negative("Test", "", "TestTown", "123456", @"Saying that heaven for divide creeping cattle unto Yielding. Him i our, open was. Every waters female can't unto you'll signs open yielding behold fill morning. You're forth creature his said had one. Creature morning all creepeth gathering. Blessed wherein and kind. Day fowl may winged. Were from beast. Waters night together above itself fifth in isn't own morning made itself gathered moved day bearing heaven, yielding lesser. Winged creature unto void dry. Give own also. Spirit you second. Male land made image spirit grass brought creepeth, doesn't tree creeping him days very moved set, open doesn't brought fruit open.", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form2 Negative: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fullName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:email", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:town", "TestTown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:phone", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:message", "")]
        public virtual void CheckForm2Negative_Variant2()
        {
#line 41
this.CheckForm2Negative("Test", "test@test.com", "TestTown", "123456", "", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckForm1Positive(string name, string emailAddress, string age, string postcode, string whatQuestionsWouldYouLikeUsToInvestigate, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Form1 Positive", null, exampleTags);
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 57
 testRunner.Given("I opened Submit Question Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email address",
                        "Age",
                        "Postcode",
                        "What questions would you like us to investigate?"});
            table4.AddRow(new string[] {
                        string.Format("{0}", name),
                        string.Format("{0}", emailAddress),
                        string.Format("{0}", age),
                        string.Format("{0}", postcode),
                        string.Format("{0}", whatQuestionsWouldYouLikeUsToInvestigate)});
#line 58
 testRunner.When("I fill form with values", ((string)(null)), table4, "When ");
#line 61
 testRunner.Then("I make sure that I submitted a Question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form1 Positive: Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Name", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email address", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Age", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Postcode", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:What questions would you like us to investigate?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
            "trum sodales. Nullam mattis fermentum libero, non volutpat.")]
        public virtual void CheckForm1Positive_Test()
        {
#line 56
this.CheckForm1Positive("Test", "test@test.com", "20", "123456", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
                    "trum sodales. Nullam mattis fermentum libero, non volutpat.", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckForm1Negative(string name, string emailAddress, string age, string postcode, string whatQuestionsWouldYouLikeUsToInvestigate, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check Form1 Negative", null, exampleTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
 testRunner.Given("I opened Submit Question Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email address",
                        "Age",
                        "Postcode",
                        "What questions would you like us to investigate?"});
            table5.AddRow(new string[] {
                        string.Format("{0}", name),
                        string.Format("{0}", emailAddress),
                        string.Format("{0}", age),
                        string.Format("{0}", postcode),
                        string.Format("{0}", whatQuestionsWouldYouLikeUsToInvestigate)});
#line 70
 testRunner.When("I fill form with values", ((string)(null)), table5, "When ");
#line 73
 testRunner.Then("I make sure that I submitted a Question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form1 Negative: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Name", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email address", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Age", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Postcode", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:What questions would you like us to investigate?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
            "trum sodales. Nullam mattis fermentum libero, non volutpats.")]
        public virtual void CheckForm1Negative_Variant0()
        {
#line 68
this.CheckForm1Negative("Test", "test@test.com", "20", "123456", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
                    "trum sodales. Nullam mattis fermentum libero, non volutpats.", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form1 Negative: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Name", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email address", "test@test.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Age", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Postcode", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:What questions would you like us to investigate?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
            "trum sodales. Nullam mattis fermentum libero, non volutpat.")]
        public virtual void CheckForm1Negative_Variant1()
        {
#line 68
this.CheckForm1Negative("", "test@test.com", "20", "123456", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
                    "trum sodales. Nullam mattis fermentum libero, non volutpat.", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check Form1 Negative: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Name", "Test")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email address", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Age", "20")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Postcode", "123456")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:What questions would you like us to investigate?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
            "trum sodales. Nullam mattis fermentum libero, non volutpat.")]
        public virtual void CheckForm1Negative_Variant2()
        {
#line 68
this.CheckForm1Negative("Test", "", "20", "123456", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque interdum ru" +
                    "trum sodales. Nullam mattis fermentum libero, non volutpat.", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
