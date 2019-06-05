using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Bindings
{
    [Binding]
    public class TimenMaterialSteps
    {
        [Given(@"I am in the Horsedev Portal")]
        public void GivenIAmInTheHorsedevPortal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have Clicked Administration and Time and Material Tab")]
        public void GivenIHaveClickedAdministrationAndTimeAndMaterialTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click CreateNew Button and Enter valid data")]
        public void WhenIClickCreateNewButtonAndEnterValidData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to Create new record and Validate")]
        public void ThenIShouldBeAbleToCreateNewRecordAndValidate()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
