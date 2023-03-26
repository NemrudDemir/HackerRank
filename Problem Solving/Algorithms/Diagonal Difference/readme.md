[Source](https://www.hackerrank.com/challenges/diagonal-difference)
# Problem statement
Given a square matrix, calculate the absolute difference between the sums of its diagonals.  

For example, the square matrix ![](./Resources/Element1.svg) is shown below:  

```
1 2 3
4 5 6
9 8 9  
```
The left-to-right diagonal = ![](./Resources/Element2.svg).  The right to left diagonal = ![](./Resources/Element3.svg).  Their absolute difference is ![](./Resources/Element4.svg).  


**Function description**

Complete the ![](./Resources/Element5.svg) function in the editor below.  It must return an integer representing the absolute diagonal difference.

diagonalDifference takes the following parameter:  


* arr: an array of integers . 

**Input Format**

The first line contains a single integer, ![](./Resources/Element6.svg),  the number of rows and columns in the matrix ![](./Resources/Element1.svg). 


Each of the next ![](./Resources/Element6.svg) lines describes a row, ![](./Resources/Element7.svg), and consists of ![](./Resources/Element6.svg) space-separated integers ![](./Resources/Element8.svg).


**Constraints**


* ![](./Resources/Element9.svg)

**Output Format**

Print the absolute difference between the sums of the matrix's two diagonals as a single integer.


**Sample Input**

```
3
11 2 4
4 5 6
10 8 -12
```

**Sample Output**

```
15
```

**Explanation**

The primary diagonal is:  

```
11
   5
     -12
```
Sum across the primary diagonal: 11 + 5 - 12 = 4 

The secondary diagonal is:



```
     4
   5
10
```
Sum across the secondary diagonal: 4 + 5 + 10 = 19 


Difference: |4 - 19| = 15


**Note:** |x| is the [absolute value](https://www.mathsisfun.com/numbers/absolute-value.html) of x

