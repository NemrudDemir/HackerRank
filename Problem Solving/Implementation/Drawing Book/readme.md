[Source](https://www.hackerrank.com/challenges/drawing-book)
# Problem statement
Brie’s Drawing teacher asks her class to open their books to a page number. Brie can either start turning pages from the front of the book or from the back of the book. She always turns pages one at a time.  When she opens the book, page ![](./Resources/Element1.svg) is always on the right side:

![](./Resources/1481920803-d2b54f38f0-book.png)

When she flips page ![](./Resources/Element1.svg), she sees pages ![](./Resources/Element2.svg) and ![](./Resources/Element3.svg).  Each page except the last page will always be printed on both sides.  The last page may only be printed on the front, given the length of the book.  If the book is ![](./Resources/Element4.svg) pages long, and she wants to turn to page ![](./Resources/Element5.svg), what is the minimum number of pages she will turn?  She can start at the beginning or the end of the book. 

Given ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg), find and print the minimum number of pages Brie must turn in order to arrive at page ![](./Resources/Element5.svg). 


**Function Description**  

Complete the pageCount function in the editor below.  It should return the minimum number of pages Brie must turn.  

pageCount has the following parameter(s):  


* n: the number of pages in the book   
* p: the page number to turn to  

**Input Format**

The first line contains an integer ![](./Resources/Element4.svg), the number of pages in the book. 


The second line contains an integer, ![](./Resources/Element5.svg), the page that Brie's teacher wants her to turn to.


**Constraints**


* ![](./Resources/Element6.svg)
* ![](./Resources/Element7.svg)

**Output Format**

Print an integer denoting the minimum number of pages Brie must turn to get to page ![](./Resources/Element5.svg).  


**Sample Input 0**

```
6
2
```

**Sample Output 0**

```
1
```

**Explanation 0**

If Brie starts turning from page ![](./Resources/Element1.svg), she only needs to turn ![](./Resources/Element1.svg) page:

![](./Resources/1467398713-1decf68d06-UntitledDiagram6.png)

If Brie starts turning from page ![](./Resources/Element8.svg), she needs to turn ![](./Resources/Element2.svg) pages:

![](./Resources/1467397150-52d0a8213b-UntitledDiagram3.png)

Because we want to print the minumum number of page turns, we print ![](./Resources/Element1.svg) as our answer.


**Sample Input 1**

```
5
4
```

**Sample Output 1**

```
0
```

**Explanation 1**

If Brie starts turning from page ![](./Resources/Element1.svg), she needs to turn ![](./Resources/Element2.svg) pages:

![](./Resources/1467398281-32b69f6fa9-UntitledDiagram4.png)

If Brie starts turning from page ![](./Resources/Element9.svg), she doesn't need to turn any pages:

![](./Resources/1467398392-5d9ac72e45-UntitledDiagram5.png)

Because we want to print the minimum number of page turns, we print ![](./Resources/Element10.svg) as our answer.

