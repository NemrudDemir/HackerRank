[Source](https://www.hackerrank.com/challenges/designer-pdf-viewer)
# Problem statement
When you select a contiguous block of text in a PDF viewer, the selection is highlighted with a blue rectangle. In this PDF viewer, each word is highlighted independently. For example: 

![](./Resources/1471640108-6c01750b16-PDF-highighting.png)

In this challenge, you will be given a list of letter heights in the alphabet and a string.  Using the letter heights given, determine the area of the rectangle highlight in ![](./Resources/Element1.svg) assuming all letters are ![](./Resources/Element2.svg) wide.  

For example, the highlighted ![](./Resources/Element3.svg).  Assume the heights of the letters are ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg).  The tallest letter is ![](./Resources/Element6.svg) high and there are ![](./Resources/Element7.svg) letters.  The hightlighted area will be ![](./Resources/Element8.svg) so the answer is ![](./Resources/Element9.svg).  


**Function Description**  

Complete the designerPdfViewer function in the editor below.  It should return an integer representing the size of the highlighted area.  

designerPdfViewer has the following parameter(s):


* h: an array of integers representing the heights of each letter  
* word: a string  

**Input Format**

The first line contains ![](./Resources/Element10.svg) space-separated integers describing the respective heights of each consecutive lowercase English letter, ascii[a-z]. 


The second line contains a single word, consisting of lowercase English alphabetic letters.


**Constraints**


* ![](./Resources/Element11.svg), where ![](./Resources/Element12.svg) is an English lowercase letter.
* ![](./Resources/Element13.svg) contains no more than ![](./Resources/Element14.svg) letters.   

**Output Format**

Print a single integer denoting the area in ![](./Resources/Element1.svg) of highlighted rectangle when the given word is selected. Do not print units of measure.


**Sample Input 0**

```
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
abc
```

**Sample Output 0**

```
9
```

**Explanation 0**

We are highlighting the word ```abc```:

Letter heights are ![](./Resources/Element15.svg), ![](./Resources/Element16.svg) and ![](./Resources/Element17.svg). The tallest letter, ```b```, is ![](./Resources/Element18.svg) high. The selection area for this word is ![](./Resources/Element19.svg).


**Note:** Recall that the width of each character is ![](./Resources/Element2.svg).


**Sample Input 1**

```
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7
zaba
```

**Sample Output 1**

```
28
```

**Explanation 1**

The tallest letter in ![](./Resources/Element20.svg) is ![](./Resources/Element21.svg) at ![](./Resources/Element22.svg). The selection area for this word is ![](./Resources/Element23.svg).

