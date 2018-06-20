
Next: run all tests from xUnit.net console runner
http://xunit.github.io/docs/getting-started-desktop

As in
```bash
PS C:\Users\Howard Deiner\source\repos\PasswordAPI.Specflow> .\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe .\PasswordAP
I.Specflow\bin\Debug\PasswordAPI.Specflow.dll -verbose
xUnit.net Console Runner (64-bit Desktop .NET 4.0.30319.42000)
    Discovering feature files embedded in assembly PasswordAPI.Specflow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    Discovering feature files from folder C:\Users\Howard Deiner\source\repos\PasswordAPI.Specflow\PasswordAPI.Specflow\bin\Debug
      Features\PasswordRules.feature
      Features\PasswordStrength.feature
  Discovering: PasswordAPI.Specflow
    Discovering feature files embedded in assembly PasswordAPI.Specflow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    Discovering feature files from folder C:\Users\Howard Deiner\source\repos\PasswordAPI.Specflow\PasswordAPI.Specflow\bin\Debug
      Features\PasswordRules.feature
      Features\PasswordStrength.feature
  Discovered:  PasswordAPI.Specflow
  Starting:    PasswordAPI.Specflow
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordSortOfOK
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordLength8
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordWithSpaces
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordLength8
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordDesirable
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordLength0
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordLength16With8SpecialCharacters
    PasswordStrengthUnitTests.PasswordStrengthUnitTests.testPasswordLength12With8RepeatedUpperLowerViolations
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordNoSpecialCaseChatacters
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordAllUpperCase
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordOK
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordAllLowerCase
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordLength1
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordAllNumbers
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordNoDigits
    PasswordRulesUnitTests.PasswordRulesUnitTests.testPasswordLength7
-> Using app.config
  Finished:    PasswordAPI.Specflow
=== TEST EXECUTION SUMMARY ===
   PasswordAPI.Specflow  Total: 26, Errors: 0, Failed: 0, Skipped: 0, Time: 1.504s```