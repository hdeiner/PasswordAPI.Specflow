using Xunit;
using PasswordAPI;

namespace PasswordRulesUnitTests
{
    public class PasswordRulesUnitTests
    {
        [Fact]
        public void testPasswordLength1() {
            Assert.Equal("password must be at least 8 characters long", new PasswordRules("a").evaluate());
        }

        [Fact]
        public void testPasswordLength7() {
            Assert.Equal("password must be at least 8 characters long", new PasswordRules("abcdefg").evaluate());
        }

        [Fact]
        public void testPasswordLength8() {
            Assert.NotEqual("password must be at least 8 characters long", new PasswordRules("abcdefgh").evaluate());
        }

        [Fact]
        public void testPasswordAllNumbers() {
            Assert.Equal("password must have letters in it", new PasswordRules("12345678").evaluate());
        }

        [Fact]
        public void testPasswordAllUpperCase() {
            Assert.Equal("password must have both upper and lower case letters in it", new PasswordRules("HOWARDDEINER").evaluate());
        }

        [Fact]
        public void testPasswordAllLowerCase() {
            Assert.Equal("password must have both upper and lower case letters in it", new PasswordRules("howarddeiner").evaluate());
        }

        [Fact]
        public void testPasswordNoDigits() {
            Assert.Equal("password must have at least 1 digit in it", new PasswordRules("HowardDeiner").evaluate());
        }

        [Fact]
        public void testPasswordNoSpecialCaseChatacters() {
            Assert.Equal("password must have at least 1 special case character in it", new PasswordRules("HowardDeiner1").evaluate());
        }

        [Fact]
        public void testPasswordWithSpaces() {
            Assert.Equal("password can not have any spaces in it", new PasswordRules("Howard Deiner!").evaluate());
        }

        [Fact]
        public void testPasswordOK() {
            Assert.Equal("password OK", new PasswordRules("bFihJv!srBChibW4ay#eXEksdh").evaluate());
        }
    }
}