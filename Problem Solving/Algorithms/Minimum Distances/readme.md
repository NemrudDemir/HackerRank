[Source](https://www.hackerrank.com/challenges/minimum-distances)
# Problem statement
We define the distance between two array values as the number of indices between the two values.  Given ![](./Resources/Element1.svg), find the minimum distance between any pair of equal elements in the array. If no such value exists, print ![](./Resources/Element2.svg).

For example, if ![](./Resources/Element3.svg), there are two matching pairs of values: ![](./Resources/Element4.svg).  The indices of the ![](./Resources/Element5.svg)'s are ![](./Resources/Element6.svg) and ![](./Resources/Element7.svg), so their distance is ![](./Resources/Element8.svg).  The indices of the ![](./Resources/Element9.svg)'s are ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg), so their distance is ![](./Resources/Element12.svg).


**Function Description**

Complete the minimumDistances function in the editor below.  It should return the minimum distance between any two matching elements.  

minimumDistances has the following parameter(s):  


* a: an array of integers  





**Input Format**


The first line contains an integer ![](./Resources/Element13.svg), the size of array ![](./Resources/Element1.svg). 


The second line contains ![](./Resources/Element13.svg) space-separated integers ![](./Resources/Element14.svg).





**Constraints**



* ![](./Resources/Element15.svg)
* ![](./Resources/Element16.svg)





**Output Format**


Print a single integer denoting the minimum ![](./Resources/Element17.svg) in ![](./Resources/Element1.svg).  If no such value exists, print ![](./Resources/Element2.svg).


**Sample Input**

```
6
7 1 3 4 1 7
```

**Sample Output**

```
3
```

**Explanation**


Here, we have two options:


* ![](./Resources/Element18.svg) and ![](./Resources/Element19.svg) are both ![](./Resources/Element20.svg), so ![](./Resources/Element21.svg).
* ![](./Resources/Element22.svg) and ![](./Resources/Element23.svg) are both ![](./Resources/Element24.svg), so ![](./Resources/Element25.svg).

The answer is ![](./Resources/Element26.svg).





