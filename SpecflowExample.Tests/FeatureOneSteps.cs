using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowExample.Tests
{
    [Binding]
    public class FeatureOneSteps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var featureTags = FeatureContext.Current.FeatureInfo.Tags;
            var scenarioTags = ScenarioContext.Current.ScenarioInfo.Tags;

            Assert.IsNotEmpty(featureTags, "Feature tags list was empty");
            Assert.IsNotEmpty(scenarioTags, "Scenario tags list was empty");
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
