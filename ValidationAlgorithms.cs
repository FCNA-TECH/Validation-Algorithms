//Valid Hex Code
bool IsValidHexCode(string str) 
{ 
    char[] allowedchar = new char[] { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', '1', '2', '3', '4', '5', '6', '7', '8', '9' };   // This array contains all the characters allowed in a hexadecimal code
    bool Answer = false; 
    if (str[0] == '#') 
    { 
        if (str.Length <= 7)      // A length check as all codes cannot exceed 6 as soecified in the project breif
        { 
            for(int i = 1; i < str.Length; i++) 
            { 
                if (allowedchar.Contains(str[i]))    // checking to see if all characters are allowed
                { 
                    Answer = true; 
                } 
                else 
                { 
                    Answer = false; 
                    break;               //even if just one character is not allowed then the whole hex code is incorrect
                } 
            } 
        } 
    } 
    return Answer; 
} 

// Tests
Console.WriteLine(IsValidHexCode("#CD5C5C"));        // True
Console.WriteLine(IsValidHexCode("#EAECEE"));        // True
Console.WriteLine(IsValidHexCode("#eaecee"));        // True
Console.WriteLine(IsValidHexCode("#CD5C58C"));       // Length exceeds 6 
Console.WriteLine(IsValidHexCode("#CD5C5Z"));        // Not all alphabetic characters in A-F 
Console.WriteLine(IsValidHexCode("#CD5C&C"));       // Contains unacceptable character 
Console.WriteLine(IsValidHexCode("CD5C5C"));        // Missing # 



// Duplicate Character Checker
int DuplicateCount(string str) 
{ 
    List<char> Duplicates = new List<char>();    // I used a list instead of an array as a list allows me to leave the length unspecified and i can continually add to it   
    int count = 0; 
    for(int f = 0; f < str.Length; f++)     // Character that is checking against all other characters
    { 
        for(int a = 0; a < str.Length; a++)    // Each character in the string
        { 
            if(str[f] == str[a] && !Duplicates.Contains(str[a]) && f != a)     // f != a so that the character doesnt check itself
            { 
                Duplicates.Add(str[a]);    // To stop the same character from being cunted again
                count += 1; 
            } 
        } 
    } 
    return count; 
} 

// Tests
Console.WriteLine(DuplicateCount("abcde"));                // 0
Console.WriteLine(DuplicateCount("aabbcde"));              // 2
Console.WriteLine(DuplicateCount("Indivisibilities"));     // 2
Console.WriteLine(DuplicateCount("Aa"));                   // 0  (Case Sensetive)


// Strange Pair Checker
bool IsStrangePair(string str1, string str2) 
{ 
    string realStr1 = str1.Trim();      // This is incase the user placed spaces in the front or the end 
    string realStr2 = str2.Trim();      // Spaces will automatially make every work a strange pair and thats not good 
    realStr1 = realStr1.ToLower(); 
    realStr2 = realStr2.ToLower(); 
    bool strangeness = false; 
    if(realStr1 == "" && realStr2 == "")   //  Due to the special case that both strings are empty
    { 
        strangeness = true; 
    } 
    else if (realStr1[0] == realStr2[realStr2.Length - 1] && realStr1[realStr1.Length - 1] == realStr2[0]) 
    { 
        strangeness = true; 
    } 
    return strangeness; 
} 

//Tests
Console.WriteLine(IsStrangePair("ratio", "orator"));        // True, "ratio" ends with "o" and "orator" starts with "o". "ratio" starts with "r" and "orator" ends with "r". 
Console.WriteLine(IsStrangePair("sparkling", "groups"));    // True
Console.WriteLine(IsStrangePair("bush", "hubris"));        // False
Console.WriteLine(IsStrangePair("", ""));                  // True, they both share nothing
