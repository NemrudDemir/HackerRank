[Source](https://www.hackerrank.com/challenges/circular-array-rotation)
# Problem statement
John Watson knows of an operation called a right circular rotation on an array of integers.  One rotation operation moves the last array element to the first position and shifts all remaining elements right one.  To test Sherlock's abilities, Watson provides Sherlock with an array of integers.  Sherlock is to perform the rotation operation a number of times then determine the value of the element at a given position.

For each array, perform a number of right circular rotations and return the value of the element at a given index.

For example, array ![](./Resources/Element1.svg), number of rotations, ![](./Resources/Element2.svg) and indices to check, ![](./Resources/Element3.svg). 


First we perform the two rotations: 


![](./Resources/Element4.svg) 


Now return the values from the zero-based indices ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg) as indicated in the ![](./Resources/Element7.svg) array. 


![](./Resources/Element8.svg) 


![](./Resources/Element9.svg)  


**Function Description**  

Complete the circularArrayRotation function in the editor below.  It should return an array of integers representing the values at the specified indices.  

circularArrayRotation has the following parameter(s):  


* a: an array of integers to rotate  
* k: an integer, the rotation count  
* queries: an array of integers, the indices to report  

**Input Format**

The first line contains ![](./Resources/Element10.svg) space-separated integers, ![](./Resources/Element11.svg), ![](./Resources/Element12.svg), and ![](./Resources/Element13.svg), the number of elements in the integer array, the rotation count and the number of queries. 


The second line contains ![](./Resources/Element11.svg) space-separated integers, where each integer ![](./Resources/Element14.svg) describes array element ![](./Resources/Element15.svg) (where ![](./Resources/Element16.svg)). 


Each of the ![](./Resources/Element13.svg) subsequent lines contains a single integer denoting ![](./Resources/Element7.svg), the index of the element to return from ![](./Resources/Element17.svg).


**Constraints**


* ![](./Resources/Element18.svg)
* ![](./Resources/Element19.svg)
* ![](./Resources/Element20.svg)
* ![](./Resources/Element21.svg)    
* ![](./Resources/Element22.svg)

**Output Format**

For each query, print the value of the element at index ![](./Resources/Element7.svg) of the rotated array on a new line.


**Sample Input 0**

```
3 2 3
1 2 3
0
1
2
```

**Sample Output 0**

```
2
3
1
```

**Explanation 0**

After the first rotation, the array becomes ![](./Resources/Element23.svg). 


After the second (and final) rotation, the array becomes ![](./Resources/Element24.svg).   

Let's refer to the array's final state as array ![](./Resources/Element25.svg). For each query, we just have to print the value of ![](./Resources/Element26.svg) on a new line:


1. ![](./Resources/Element27.svg), ![](./Resources/Element28.svg).        
2. ![](./Resources/Element29.svg), ![](./Resources/Element30.svg).        
3. ![](./Resources/Element31.svg), ![](./Resources/Element32.svg).        
