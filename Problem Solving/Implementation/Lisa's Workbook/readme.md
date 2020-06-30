[Source](https://www.hackerrank.com/challenges/lisa-workbook)
# Problem statement
Lisa just got a new math workbook.  A workbook contains exercise problems, grouped into chapters.  Lisa believes a problem to be special if its index (within a chapter) is the same as the page number where it's located.  The format of Lisa's book is as follows:


* There are ![](./Resources/Element1.svg) chapters in Lisa's workbook, numbered from ![](./Resources/Element2.svg) to ![](./Resources/Element1.svg).
* The ![](./Resources/Element3.svg) chapter has ![](./Resources/Element4.svg) problems, numbered from ![](./Resources/Element2.svg) to ![](./Resources/Element4.svg).
* Each page can hold up to![](./Resources/Element5.svg) problems. Only a chapter's last page of exercises may contain fewer than ![](./Resources/Element5.svg) problems.
* Each new chapter starts on a new page, so a page will never contain problems from more than one chapter.
* The page number indexing starts at ![](./Resources/Element2.svg).

Given the details for Lisa's workbook, can you count its number of special problems?

For example, Lisa's workbook contains ![](./Resources/Element6.svg) problems for chapter ![](./Resources/Element2.svg), and ![](./Resources/Element7.svg) problems for chapter ![](./Resources/Element8.svg).  Each page can hold ![](./Resources/Element9.svg) problems.  The first page will hold ![](./Resources/Element10.svg) problems for chapter ![](./Resources/Element2.svg).  Problem ![](./Resources/Element2.svg) is on page ![](./Resources/Element2.svg), so it is special.  Page ![](./Resources/Element8.svg) contains only Chapter ![](./Resources/Element2.svg), Problem ![](./Resources/Element11.svg), so no special problem is on page ![](./Resources/Element8.svg).  Chapter ![](./Resources/Element8.svg) problems start on page ![](./Resources/Element10.svg) and there are ![](./Resources/Element8.svg) problems.  Since there is no problem ![](./Resources/Element10.svg) on page ![](./Resources/Element10.svg), there is no special problem on that page either.  There is ![](./Resources/Element2.svg)special problem in her workbook.


**Note:** See the diagram in the Explanation section for more details.  


**Function Description**

Complete the workbook function in the editor below.  It should return an integer that represents the number of special problems in the workbook.  

workbook has the following parameter(s):  


* n: an integer that denotes the number of chapters  
* k: an integer that denotes the maximum number of problems per page  
* arr: an array of integers that denote the number of problems in each chapter  





**Input Format**


The first line contains two integers ![](./Resources/Element1.svg) and ![](./Resources/Element5.svg), the number of chapters and the maximum number of problems per page. 


The second line contains ![](./Resources/Element1.svg) space-separated integers ![](./Resources/Element4.svg) where ![](./Resources/Element4.svg) denotes the number of problems in the ![](./Resources/Element3.svg) chapter.





**Constraints**



* ![](./Resources/Element12.svg)





**Output Format**


Print the number of special problems in Lisa's workbook.





**Sample Input**


```
5 3  
4 2 6 1 10
```




**Sample Output**


```
4
```




**Explanation**


The diagram below depicts Lisa's workbook with ![](./Resources/Element13.svg) chapters and a maximum of ![](./Resources/Element9.svg) problems per page. Special problems are outlined in red, and page numbers are in yellow squares.

![](./Resources/1456473832-d122786d1e-bear_workbook.png)

There are ![](./Resources/Element11.svg) special problems and thus we print the number ![](./Resources/Element11.svg) on a new line.





