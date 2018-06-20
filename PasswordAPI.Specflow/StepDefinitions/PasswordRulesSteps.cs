using System;
using TechTalk.SpecFlow;
using Xunit;

namespace PasswordAPI.Specflow
{
    [Binding]
    public class PasswordRulesSteps
    {
        private PasswordRules passwordRules;

        [Given(@"I want to set my password to ""(.*)""")]
        public void GivenIWantToSetMyPasswordTo(String password)
        {
            passwordRules = new PasswordRules(password);
        }

        [Then(@"I then I should be told ""(.*)""")]
        public void ThenIThenIShouldBeTold(string passwordAdviceExpected)
        {
            Assert.Equal(passwordAdviceExpected, passwordRules.evaluate());
        }
    }
}
