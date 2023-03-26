[Source](https://www.hackerrank.com/challenges/big-sorting/problem)
# Problem statement
Consider an array of numeric strings where each string is a positive number with anywhere from ![](./Resources/Element1.svg) to ![](./Resources/Element2.svg) digits. Sort the array's elements in non-decreasing, or ascending order of their integer values and return the sorted array.


**Example**

![](./Resources/Element3.svg)

Return the array ['1', '3', '150', '200']. 


**Function Description**

Complete the bigSorting function in the editor below.  

bigSorting has the following parameter(s):  


* string unsorted[n]: an unsorted array of integers as strings  


**Returns**


* string[n]:  the array sorted in numerical order  





**Input Format**


The first line contains an integer, ![](./Resources/Element4.svg), the number of strings in ![](./Resources/Element5.svg). 


Each of the ![](./Resources/Element4.svg) subsequent lines contains an integer string, ![](./Resources/Element6.svg).





**Constraints**



* ![](./Resources/Element7.svg)
* Each string is guaranteed to represent a positive integer.
* There will be no leading zeros.
* The total number of digits across all strings in ![](./Resources/Element5.svg) is between ![](./Resources/Element1.svg) and ![](./Resources/Element2.svg) (inclusive).





**Sample Input 0**


```
6
31415926535897932384626433832795
1
3
10
3
5
```





**Sample Output 0**


```
1
3
3
5
10
31415926535897932384626433832795
```





**Explanation 0**


The initial array of strings is ![](./Resources/Element8.svg). When we order each string by the real-world integer value it represents, we get: 

![](./Resources/Element9.svg)

We then print each value on a new line, from smallest to largest.





**Sample Input 1**


```
8
1
2
100
12303479849857341718340192371
3084193741082937
3084193741082938
111
200
```





**Sample Output 1**


```
1
2
100
111
200
3084193741082937
3084193741082938
12303479849857341718340192371
```