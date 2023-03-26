[Source](https://www.hackerrank.com/challenges/manasa-and-stones)
# Problem statement
Manasa is out on a hike with friends. She finds a trail of stones with numbers on them. She starts following the trail and notices that any two consecutive stones' numbers differ by one of two values.  Legend has it that there is a treasure trove at the end of the trail.  If Manasa can guess the value of the last stone, the treasure will be hers.

For example, assume she finds ![](./Resources/Element1.svg) stones and their differences are ![](./Resources/Element2.svg) or ![](./Resources/Element3.svg).  We know she starts with a ![](./Resources/Element4.svg) stone not included in her count.  The permutations of differences for the two stones would be ![](./Resources/Element5.svg) or ![](./Resources/Element6.svg).  Looking at each scenario, stones might have ![](./Resources/Element7.svg) or ![](./Resources/Element8.svg) on them.  The last stone might have any of  ![](./Resources/Element9.svg), or ![](./Resources/Element10.svg) on its face. 

Compute all possible numbers that might occur on the last stone given a starting stone with a ![](./Resources/Element4.svg) on it, a number of additional stones found, and the possible differences between consecutive stones.  Order the list ascending.


**Function Description**

Complete the stones function in the editor below.  It should return an array of integers representing all possible values of the last stone, sorted ascending.  

stones has the following parameter(s):  


* n: an integer, the number of non-zero stones  
* a: one possible integer difference  
* b: another possible integer difference  





**Input Format**


The first line contains an integer ![](./Resources/Element11.svg), the number of test cases.  

Each test case contains ![](./Resources/Element12.svg) lines: 


- The first line contains ![](./Resources/Element13.svg), the number of non-zero stones found. 


- The second line contains ![](./Resources/Element14.svg), one possible difference 


- The third line contains ![](./Resources/Element15.svg), the other possible difference.  





**Constraints**



* ![](./Resources/Element16.svg)
* ![](./Resources/Element17.svg)





**Output Format**


Space-separated list of numbers which are the possible values of the last stone in increasing order. 





**Sample Input**


```
2
3 
1
2
4
10
100
```




**Sample Output**


```
2 3 4 
30 120 210 300 
```




**Explanation**


With differences 1 and 2, all possible series for the first test case are given below:


1. 0,1,
**2**
2. 0,1,
**3**
3. 0,2,
**3**
4. 0,2,
**4**
Hence the answer ```2 3 4```. 

With differences 10 and 100, all possible series for the second test case are the following: 


1. 0, 10, 20, 
**30**
2. 0, 10, 20, 
**120**
3. 0, 10, 110, 
**120**
4. 0, 10, 110, 
**210**
5. 0, 100, 110, 
**120**
6. 0, 100, 110, 
**210**
7. 0, 100, 200, 
**210**
8. 0, 100, 200, 
**300**
Hence the answer ```30 120 210 300```.





