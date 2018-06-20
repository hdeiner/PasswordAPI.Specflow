using System;
using System.Text.RegularExpressions;

namespace PasswordAPI
{
    public class PasswordRules {
        private String password;
        public PasswordRules(String password) {
            this.password = password;
        }
        public String evaluate() {
            Regex regexLetters = new Regex(@"^.*[A-Za-z]+.*$");
            if (regexLetters.Matches(password).Count == 0) {
                return "password must have letters in it";
            }
            if (password.Length < 8) {
                return "password must be at least 8 characters long";
            }
            Regex regexSpaces = new Regex(@"^.*[ ]+.*$");
            if (regexSpaces.Matches(password).Count > 0) {
                return "password can not have any spaces in it";
            }
            Regex regexUpper = new Regex(@"^.*[A-Z]+.*$");
            Regex regexLower = new Regex(@"^.*[a-z]+.*$");
            if ((regexUpper.Matches(password).Count == 0) || (regexLower.Matches(password).Count == 0)) {
                return "password must have both upper and lower case letters in it";
            }
            Regex regexHasDigit = new Regex(@"^.*[0-9]+.*$");
            if (regexHasDigit.Matches(password).Count == 0) {
                return "password must have at least 1 digit in it";
            }
            Regex regexHasSpecial = new Regex(@"^.*[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)]+.*$");
            if (regexHasSpecial.Matches(password).Count == 0) {
                return "password must have at least 1 special case character in it";
            }
            return "password OK";
        }
    }
}
