[Source](https://www.hackerrank.com/challenges/larrys-array/problem)
# Problem statement
Larry has been given a permutation of a sequence of natural numbers incrementing from ![](./Resources/Element1.svg) as an array.  He must determine whether the array can be sorted using the following operation any number of times:  


* Choose any ![](./Resources/Element2.svg) consecutive indices and rotate their elements in such a way that ![](./Resources/Element3.svg). 

For example, if ![](./Resources/Element4.svg):

```
A               rotate
[1,6,5,2,4,3]	[6,5,2]
[1,5,2,6,4,3]	[5,2,6]
[1,2,6,5,4,3]	[5,4,3]
[1,2,6,3,5,4]	[6,3,5]
[1,2,3,5,6,4]	[5,6,4]
[1,2,3,4,5,6]

YES
```

On a new line for each test case, print ```YES``` if ![](./Resources/Element5.svg) can be fully sorted.  Otherwise, print ```NO```.  


**Function Description**

Complete the larrysArray function in the editor below.  It must return a string, either ```YES``` or ```NO```.  

larrysArray has the following parameter(s):  


* A: an array of integers  





**Input Format**


The first line contains an integer ![](./Resources/Element6.svg), the number of test cases.   

The next ![](./Resources/Element6.svg) pairs of lines are as follows:  


* The first line contains an integer ![](./Resources/Element7.svg), the length of ![](./Resources/Element5.svg).
* The next line contains ![](./Resources/Element7.svg) space-separated integers ![](./Resources/Element8.svg).





**Constraints**



* ![](./Resources/Element9.svg)
* ![](./Resources/Element10.svg)
* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg) integers that increment by ![](./Resources/Element1.svg) from ![](./Resources/Element1.svg) to ![](./Resources/Element7.svg)





**Output Format**


For each test case, print ```YES``` if ![](./Resources/Element5.svg) can be fully sorted.  Otherwise, print ```NO```.





**Sample Input**


```
3
3
3 1 2
4
1 3 4 2
5
1 2 3 5 4
```




**Sample Output**


```
YES
YES
NO
```




**Explanation**


In the explanation below, the subscript of ![](./Resources/Element5.svg) denotes the number of operations performed.

Test Case 0:

![](./Resources/Element13.svg)

![](./Resources/Element5.svg) is now sorted, so we print ![](./Resources/Element14.svg) on a new line.

Test Case 1:

![](./Resources/Element15.svg). 

![](./Resources/Element16.svg). 

![](./Resources/Element5.svg) is now sorted, so we print ![](./Resources/Element14.svg) on a new line.

Test Case 2:


No sequence of rotations will result in a sorted ![](./Resources/Element5.svg). Thus, we print ![](./Resources/Element17.svg) on a new line.