[Source](https://www.hackerrank.com/challenges/absolute-permutation/problem)
# Problem statement
We define ![](./Resources/Element1.svg) to be a permutation of the first ![](./Resources/Element2.svg) natural numbers in the range ![](./Resources/Element3.svg). Let ![](./Resources/Element4.svg) denote the value at position ![](./Resources/Element5.svg) in permutation ![](./Resources/Element1.svg) using ![](./Resources/Element6.svg)-based indexing. 

![](./Resources/Element1.svg) is considered to be an absolute permutation if  ![](./Resources/Element7.svg) holds true for every ![](./Resources/Element8.svg).

Given ![](./Resources/Element2.svg) and ![](./Resources/Element9.svg), print the lexicographically smallest absolute permutation ![](./Resources/Element1.svg).  If no absolute permutation exists, print ```-1```.

For example, let ![](./Resources/Element10.svg) giving us an array ![](./Resources/Element11.svg).  If we use ![](./Resources/Element6.svg) based indexing, create a permutation where every ![](./Resources/Element7.svg).  If ![](./Resources/Element12.svg), we could rearrange them to ![](./Resources/Element13.svg):  

```
pos[i]  i      |Difference|
3       1       2
4       2       2
1       3       2
2       4       2
```


**Function Description**

Complete the absolutePermutation function in the editor below.  It should return an integer that represents the smallest lexicographically smallest permutation, or ![](./Resources/Element14.svg) if there is none.  

absolutePermutation has the following parameter(s):  


* n: the upper bound of natural numbers to consider, inclusive  
* k: the integer difference between each element and its index





**Input Format**


The first line contains an integer ![](./Resources/Element15.svg), the number of test cases. 


Each of the next ![](./Resources/Element15.svg) lines contains ![](./Resources/Element16.svg) space-separated integers, ![](./Resources/Element2.svg) and ![](./Resources/Element9.svg).  





**Constraints**



* ![](./Resources/Element17.svg)
* ![](./Resources/Element18.svg)
* ![](./Resources/Element19.svg)





**Output Format**


On a new line for each test case, print the lexicographically smallest absolute permutation.  If no absolute permutation exists, print ```-1```.





**Sample Input**


```
3
2 1
3 0
3 2
```




**Sample Output**


```
2 1
1 2 3
-1
```




**Explanation**


Test Case 0:

![](./Resources/1462506998-dfe183c6f5-perm.png)

Test Case 1:

![](./Resources/1462507102-236cbbd84c-perm1.png)

Test Case 2:


No absolute permutation exists, so we print ```-1``` on a new line.