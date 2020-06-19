[Source](https://www.hackerrank.com/challenges/non-divisible-subset/problem)
# Problem statement
Given a set of distinct integers, print the size of a maximal subset of ![](./Resources/Element1.svg) where the sum of any ![](./Resources/Element2.svg) numbers in ![](./Resources/Element3.svg) is not evenly divisible by ![](./Resources/Element4.svg).

For example, the array ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg).  One of the arrays that can be created is ![](./Resources/Element7.svg).  Another is ![](./Resources/Element8.svg).  After testing all permutations, the maximum length solution array has ![](./Resources/Element9.svg) elements.  


**Function Description**  

Complete the nonDivisibleSubset function in the editor below.  It should return an integer representing the length of the longest subset of ![](./Resources/Element1.svg) meeting the criteria.  

nonDivisibleSubset has the following parameter(s):  


* S: an array of integers  
* k: an integer  

**Input Format**

The first line contains ![](./Resources/Element2.svg) space-separated integers, ![](./Resources/Element10.svg) and ![](./Resources/Element4.svg), the number of values in ![](./Resources/Element1.svg) and the non factor. 


The second line contains ![](./Resources/Element10.svg) space-separated integers describing ![](./Resources/Element11.svg), the unique values of the set.


**Constraints**


* ![](./Resources/Element12.svg)
* ![](./Resources/Element13.svg)
* ![](./Resources/Element14.svg)
* All of the given numbers are distinct.

**Output Format**

Print the size of the largest possible subset (![](./Resources/Element3.svg)).


**Sample Input**

```
4 3
1 7 2 4
```

**Sample Output**

```
3
```

**Explanation**

The sums of all permutations of two elements from ![](./Resources/Element15.svg) are:

```
1 + 7 = 8
1 + 2 = 3
1 + 4 = 5
7 + 2 = 9
7 + 4 = 11
2 + 4 = 6
```
We see that only ![](./Resources/Element16.svg) will not ever sum to a multiple of ![](./Resources/Element17.svg).

