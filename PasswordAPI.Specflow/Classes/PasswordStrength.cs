using System;
using System.Text.RegularExpressions;

namespace PasswordAPI
{
    public class PasswordStrength
    {
        private String password;
        public PasswordStrength(String password) {
            this.password = password;
        }
        public int evaluate() {
            int strength = password.Length - 8;
            Regex regexHasSpecial = new Regex(@"[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)0-9]");
            Regex regexUpperCase = new Regex(@"[A-Z]");
            Regex regexLowerCase = new Regex(@"[a-z]");
            Regex regexSpecialCharacter = new Regex(@"[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)]");
            Regex regexDigit = new Regex(@"[0-9]");
            String character = " ";
            String previousCharacter = " ";
            for (int i = 0; i < password.Length; i++) {
                character = password.Substring(i, 1);
                if (regexHasSpecial.Match(character).Success) strength++;
                if ((regexUpperCase.Match(character).Success) && (regexUpperCase.Match(previousCharacter).Success)) strength--;
                if ((regexLowerCase.Match(character).Success) && (regexLowerCase.Match(previousCharacter).Success)) strength--;
                if ((regexSpecialCharacter.Match(character).Success) && (regexSpecialCharacter.Match(previousCharacter).Success)) strength--;
                if ((regexDigit.Match(character).Success) && (regexDigit.Match(previousCharacter).Success)) strength--;
                previousCharacter = character;
            }
            return strength;
        }
    }
}
