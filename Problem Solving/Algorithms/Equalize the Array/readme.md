[Source](https://www.hackerrank.com/challenges/equality-in-a-array/problem)
# Problem statement
Karl has an array of integers.  He wants to reduce the array until all remaining elements are equal.  Determine the minimum number of elements to delete to reach his goal.

For example, if his array is ![](./Resources/Element1.svg), we see that he can delete the ![](./Resources/Element2.svg) elements ![](./Resources/Element3.svg) and ![](./Resources/Element4.svg) leaving ![](./Resources/Element5.svg). He could also delete both twos and either the ![](./Resources/Element3.svg) or the ![](./Resources/Element4.svg), but that would take ![](./Resources/Element4.svg) deletions.  The minimum number of deletions is ![](./Resources/Element2.svg).


**Function Description**  

Complete the equalizeArray function in the editor below. It must return an integer that denotes the minimum number of deletions required.  

equalizeArray has the following parameter(s):  


* arr: an array of integers  

**Input Format**

The first line contains an integer ![](./Resources/Element6.svg), the number of elements in ![](./Resources/Element7.svg). 


The next line contains ![](./Resources/Element6.svg) space-separated integers ![](./Resources/Element8.svg).


**Constraints**


* ![](./Resources/Element9.svg)
* ![](./Resources/Element10.svg)

**Output Format**

Print a single integer that denotes the minimum number of elements Karl must delete for all elements in the array to be equal.


**Sample Input**

```
5
3 3 2 1 3
```

**Sample Output**

```
2   
```

**Explanation**

Array ![](./Resources/Element11.svg). If we delete ![](./Resources/Element12.svg) and ![](./Resources/Element13.svg), all of the elements in the resulting array, ![](./Resources/Element14.svg), will be equal. Deleting these ![](./Resources/Element2.svg) elements is minimal.  Our only other options would be to delete ![](./Resources/Element15.svg) elements to get an array of either ![](./Resources/Element16.svg) or ![](./Resources/Element17.svg).

