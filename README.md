# _{Repeats Counter}_

#### _{Counts the number of times a word is repeated in a given text.}, {2/16/18}_

#### By _**{Ian Goodrich}**_

## Description/Specs

## Specs: ##
  1. Trim off accidental/unwanted extra spaces in "Test String"
  Input: "Word "
  Output: "Word"
  Why: Extra Spaces should be the most common problem with deciphering the user's intended "Test String"

  2. Take in the "Target String" (the larger string the user is applying the "Test String" to) and split into string arrays.
  Input: "Hello World"
  Output: {"Hello"} {"World"}
  Why: This will allow each word in the "Target String" to be converted into a discrete package that be more easily manipulated.

  3. Create "Removals Array" (TBD)
  Input: If the Test String contains any non-letter-character it WILL be tested.
  Output: Any non-letter-character NOT included in the Test String, but present in the (still to be developed) "Removals Array" will taken out of each individual string in the string array created in the previous step.  
  Why: Sans a specific set of test criteria, it seems most utilitarian to allow the User search for  a Test String that could contain non-letter-characters. Possible applications would include searching a code block for a specific phrase or method that might contain such characters. Or social media applications such as searching for usernames or Twitter handles that often include such characters.  

  4. Split the string arrays into "cleaned" arrays, removing all unwanted characters.
  Input: {"#CatPerson4."} (with '.' on the removals array, but "#CatPerson4" being the Test String )
  Output:{"#CatPerson4"}}
  Why: for the purposes of comparison, as stated above.

  5. Compare Arrays.
  Input: Test String :"HI", Target Array: ["hi", "there"]
  Output: "HI" is in "hi there" 1 time(s).
  Why: I will testing on a case-insensitive basis. This will streamline the development process and allow for capital letters at the beginning of sentences. I believe it will also be more user-friendly this way.

  6. Count and return the number of repeats of the Test String in the Target String.
  Input: Test String :"HI", Target Array: ["hi", "there"]
  Output: "HI" is in "hi there" 1 time(s).
  Why: This is what the app is supposed to do. 

## Setup/Installation Requirements


* _Clone this GitHub repository_

```
git clone https://github.com/LeeMellon/WordRepateCounter.git
```

* _Install the .NET Framework_

  .NET Core 1.1 SDK (Software Development Kit)

  .NET runtime.

  See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Run the program_
  1. In the command line, cd into the project folder.
  2. In the command line, type 'dotnet restore'. Enter to install the required software packages.  It make take a few minutes to complete this process.
  3. In the command line, type 'dotnet build'. Any error messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
  4. In the command line, type 'dotnet run' Enter.

* _View program on web browser at port localhost:5000/_

* _Follow the prompts._

## Known Bugs

_{Are there issues that have not yet been resolved that you want to let users know you know?  Outline any issues that would impact use of your application.  Share any workarounds that are in place. }_

## Support and contact details


_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* Bootstrap
* C#
* .Net Core 1.1

*MIT License*

Copyright (c) 2018 **_Ian Goodrich_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
