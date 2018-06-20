using System;
using TechTalk.SpecFlow;
using Xunit;

namespace PasswordAPI.Specflow
{
    [Binding]
    public class PasswordStrengthSteps
    {
        private PasswordStrength passwordStrength;

        [Given(@"I want to check the strength of my password ""(.*)""")]
        public void GivenIWantToCheckTheStrengthOfMyPassword(String password)
        {
            passwordStrength = new PasswordStrength(password);
        }

        [Then(@"I then I should be told that it has a strength of ""(.*)""")]
        public void ThenIThenIShouldBeToldThatItHasAStrengthOf(int passwordStrengthExpected)
        {
            Assert.Equal(passwordStrengthExpected, passwordStrength.evaluate());
        }
    }
}
