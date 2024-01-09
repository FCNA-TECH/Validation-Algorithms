# Validation-Algorithms
This project contains: A Hexadecimal Checker, Duplicate Character Checker, Strange Pair Checker, Number Palindrome Checker, Seven Boom! Checker and a Reverse Case function. <br>

These projects are 6 coding challenges set during the christmas holidays, they are simple algorithms written in C#, that can be implemented in other C# programmes.
Below is the explaination and criteria of each poject/challenge and the expected outcome. <br>

Valid Hexadecimal Code: <br>
My task was to reate a function that determines whether a string is a valid hex code. 
A hex code must begin with a pound key # and is exactly 6 characters in length. Each character must be a digit from 0-9 or an alphabetic character from A-F. 
All alphabetic characters may be uppercase or lowercase. For example, <br>
IsValidHexCode("#CD5C5C") ➞ true <br>
IsValidHexCode("#EAECEE") ➞ true <br>
IsValidHexCode("#eaecee") ➞ true <br>
IsValidHexCode("#CD5C58C") ➞ false   // Length exceeds 6  <br>
IsValidHexCode("#CD5C5Z") ➞ false    // Not all alphabetic characters in A-F   <br> 
IsValidHexCode("#CD5C&C") ➞ false    // Contains unacceptable character   <br>
IsValidHexCode("CD5C5C") ➞ false     // Missing #   <br>

<br>
Duplicate Character Checker: <br>
My task is to create a function that takes a string and returns the number of alphanumeric characters that occur more than once.  <br>
Duplicate characters are case sensitive. The input string will contain only alphanumeric characters. For example, <br>
DuplicateCount("abcde") ➞ 0  <br>
DuplicateCount("aabbcde") ➞ 2  <br>
DuplicateCount("Indivisibilities") ➞ 2  <br>
DuplicateCount("Aa") ➞ 0                  // Case sensitive   <br>
