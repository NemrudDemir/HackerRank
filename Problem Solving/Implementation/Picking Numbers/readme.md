[Source](https://www.hackerrank.com/challenges/picking-numbers)
# Problem statement
Given an array of integers, find and print the maximum number of integers you can select from the array such that the absolute difference between any two of the chosen integers is less than or equal to ![](./Resources/Element1.svg).  For example, if your array is ![](./Resources/Element2.svg), you can create two subarrays meeting the criterion: ![](./Resources/Element3.svg) and ![](./Resources/Element4.svg).  The maximum length subarray has ![](./Resources/Element5.svg) elements.


**Function Description**  

Complete the pickingNumbers function in the editor below.  It should return an integer that represents the length of the longest array that can be created.  

pickingNumbers has the following parameter(s):  


* a: an array of integers  

**Input Format**

The first line contains a single integer ![](./Resources/Element6.svg), the size of the array ![](./Resources/Element7.svg). 


The second line contains ![](./Resources/Element6.svg) space-separated integers ![](./Resources/Element8.svg).


**Constraints**


* ![](./Resources/Element9.svg)
* ![](./Resources/Element10.svg)
* The answer will be ![](./Resources/Element11.svg). 

**Output Format**

A single integer denoting the maximum number of integers you can choose from the array such that the absolute difference between any two of the chosen integers is ![](./Resources/Element12.svg). 


**Sample Input 0**

```
6
4 6 5 3 3 1
```

**Sample Output 0**

```
3
```

**Explanation 0**

We choose the following multiset of integers from the array: ![](./Resources/Element13.svg). Each pair in the multiset has an absolute difference ![](./Resources/Element12.svg) (i.e., ![](./Resources/Element14.svg) and ![](./Resources/Element15.svg)), so we print the number of chosen integers, ![](./Resources/Element16.svg), as our answer.


**Sample Input 1**

```
6
1 2 2 3 1 2
```

**Sample Output 1**

```
5
```

**Explanation 1**

We choose the following multiset of integers from the array: ![](./Resources/Element17.svg).  Each pair in the multiset has an absolute difference ![](./Resources/Element12.svg) (i.e., ![](./Resources/Element18.svg), ![](./Resources/Element19.svg), and ![](./Resources/Element20.svg)), so we print the number of chosen integers, ![](./Resources/Element5.svg), as our answer.

