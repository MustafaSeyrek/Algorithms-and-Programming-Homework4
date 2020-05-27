# Algorithms-and-Programming-Homework4
Question
Write a C# program that prints all words in given text that corresponds to given pattern.
The text contains only Turkish alphabet letters.
The pattern can contain letters and the characters * and/or -
Symbol * corresponds to any number of characters (zero or more).
Symbol - corresponds to only one character.

Examples:
string text = &quot;Oyuncak evi yıkıp yaksak yapsak da mı otursak yoksa yıkmasak onarsak da mı
otursak eve&quot;;
Input: *sak
Output: yaksak
yapsak
otursak
yıkmasak
onarsak
Input: y*sak
Output: yaksak
yapsak
yıkmasak
Input: ev-
Output: evi
eve
Input: ya-sak
Output: yaksak
yapsak
Input: yık*
Output: yıkıp
yıkmasak
Input: o-u*ak
Output: oyuncak
otursak
