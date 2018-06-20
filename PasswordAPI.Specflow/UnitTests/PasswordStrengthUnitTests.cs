using Xunit;
using PasswordAPI;

namespace PasswordStrengthUnitTests
{
    public class PasswordStrengthUnitTests
    {
        [Fact]
        public void testPasswordLength0()  {
            Assert.Equal(-8, new PasswordStrength("").evaluate());
        }

        [Fact]
        public void testPasswordLength8() {
            Assert.Equal(0, new PasswordStrength("aBcDeFgH").evaluate());
        }
        [Fact]
        public void testPasswordLength16With8SpecialCharacters() {
            Assert.Equal(16, new PasswordStrength("a!b@c#d$e%f^g&h*").evaluate());
        }

        [Fact]
        public void testPasswordLength12With8RepeatedUpperLowerViolations() {
            Assert.Equal(-4, new PasswordStrength("HowardDeiner").evaluate());
        }

        [Fact]
        public void testPasswordSortOfOK() {
            Assert.Equal(-1, new PasswordStrength("passWord1!").evaluate());
        }

        [Fact]
        public void testPasswordDesirable() {
            Assert.Equal(11, new PasswordStrength("bFihJv!srBChibW4ay#eXEksdh").evaluate());
        }
    }
}
