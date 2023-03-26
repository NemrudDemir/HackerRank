[Source](https://www.hackerrank.com/challenges/library-fine/problem)
# Problem statement
Your local library needs your help! Given the expected and actual return dates for a library book, create a program that calculates the fine (if any). The fee structure is as follows: 


1. If the book is returned on or before the expected return date, no fine will be charged (i.e.: ![](./Resources/Element1.svg).
2. If the book is returned after the expected return day but still within the same calendar month and year as the expected return date, ![](./Resources/Element2.svg). 
3. If the book is returned after the expected return month but still within the same calendar year as the expected return date, the ![](./Resources/Element3.svg).   
4. If the book is returned after the calendar year in which it was expected, there is a fixed fine of ![](./Resources/Element4.svg).
Charges are based only on the least precise measure of lateness.  For example, whether a book is due January 1, 2017 or December 31, 2017, if it is returned January 1, 2018, that is a year late and the fine would be ![](./Resources/Element5.svg).  


**Function Description**  

Complete the libraryFine function in the editor below.  It must return an integer representing the fine due.  

libraryFine has the following parameter(s):  


* d1, m1, y1: returned date day, month and year  
* d2, m2, y2: due date day, month and year  

**Input Format**

The first line contains ![](./Resources/Element6.svg) space-separated integers, ![](./Resources/Element7.svg), denoting the respective ![](./Resources/Element8.svg), ![](./Resources/Element9.svg), and ![](./Resources/Element10.svg) on which the book was returned. 


The second line contains ![](./Resources/Element6.svg) space-separated integers, ![](./Resources/Element11.svg), denoting the respective ![](./Resources/Element8.svg), ![](./Resources/Element9.svg), and ![](./Resources/Element10.svg) on which the book was due to be returned.


**Constraints**


* ![](./Resources/Element12.svg)     
* ![](./Resources/Element13.svg)     
* ![](./Resources/Element14.svg)  
* ![](./Resources/Element15.svg)  

**Output Format**

Print a single integer denoting the library fine for the book received as input.  


**Sample Input**

```
9 6 2015
6 6 2015
```

**Sample Output**

```
45
```

**Explanation**

Given the following dates: 


Returned: ![](./Resources/Element16.svg) 


Due: ![](./Resources/Element17.svg)

Because ![](./Resources/Element18.svg), we know it is less than a year late. 


Because ![](./Resources/Element19.svg), we know it's less than a month late. 


Because ![](./Resources/Element20.svg), we know that it was returned late (but still within the same month and year).  

Per the library's fee structure, we know that our fine will be ![](./Resources/Element21.svg). We then print the result of ![](./Resources/Element22.svg) as our output.

