# TextAnalysisApplication
This is a c# winform application that analyses text files, perform searching, sorting and displaying corresponding to words length and frequency.

Requirement:
------------
The application needs to be able to read all the text from a text file into the memory. Once you open a new file, the memory will
be wiped and read in the new file, all the analysis display will be refreshed. It has these specific analysis tasks:  
* most common words (words that have the largest appearation)
* longest words
* shortest words
* average word length (sum of all words' length divide by count of words)
* search word (shows the time this word appears in the file)
* search length (shows the all the words with such length)
* List of all unique words (list all the words, ignore duplicate listing)
* bar table (shows all the unique words and their frequency)

Points:
-------
* raw data (read from text.file) is store in a List<string>.
* due to the requirement that the text file does not have symbles, store text file into a List word by word, we can use space to split.
* to store the words occurance and words of specific lengthes, I used 2 Dictionary. The one has word as key and occurance as value, the other one has length as key and SortedSet of word as value.
* the development implements MVC model

Quickshot:
----------
![quickshot](https://github.com/scottszb1987/TextAnalysisApplication/blob/master/shot.PNG?raw=true)
