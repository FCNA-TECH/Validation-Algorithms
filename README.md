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

<br>
Strange Pair Checker: <br>
A pair of strings form a strange pair if both of the following are true: The 1st string's first letter = 2nd string's last letter. The 1st string's last letter = 2nd string's first letter. My task is to create a function that returns true if a pair of strings constitutes a strange pair, and false otherwise. It should work on a pair of empty strings (they trivially share nothing). For Example, <br>
<br>
IsStrangePair("ratio", "orator") ➞ true  <br>
// "ratio" ends with "o" and "orator" starts with "o".  <br> 
// "ratio" starts with "r" and "orator" ends with "r".  <br>
IsStrangePair("sparkling", "groups") ➞ true   <br>
IsStrangePair("bush", "hubris") ➞ false   <br>
IsStrangePair("", "") ➞ true   <br>

<br>
Number Palindrome Checker: <br>
A palindrome is a number that remains the same when reversed. My task is to create a function that returns true if a number is a palindrome.  <br>
<br>
IsPalindrome(838) ➞ true  <br>
IsPalindrome(4433) ➞ false  <br>
IsPalindrome(443344) ➞ true  <br>

<br>
Seven Boom! Checker: <br>
My task is to create a function that takes a list of numbers and return "Boom!" if the digit 7 appears in the array. Otherwise, return "there is no 7 in the array". <br>
<br>
SevenBoom([1, 2, 3, 4, 5, 6, 7]) ➞ "Boom!"  // 7 contains the number seven.  <br>
SevenBoom([8, 6, 33, 100]) ➞ "there is no 7 in the array"  // None of the items contain 7 within them.  <br>
SevenBoom([2, 55, 60, 97, 86]) ➞ "Boom!"  // 97 contains the number seven.  <br>

<br>
Reverse Case Function: <br>
