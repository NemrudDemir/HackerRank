[Source](https://www.hackerrank.com/challenges/service-lane)
# Problem statement
Calvin is driving his favorite vehicle on the 101 freeway. He notices that the check engine light of his vehicle is on, and he wants to service it immediately to avoid any risks. Luckily, a service lane runs parallel to the highway. The service lane varies in width along its length.

![](./Resources/1331)

You will be given an array of widths at points along the road (indices), then a list of the indices of entry and exit points. Considering each entry and exit point pair, calculate the maximum size vehicle that can travel that segment of the service lane safely.

For example, there are ![](./Resources/Element1.svg) measurements yielding ![](./Resources/Element2.svg).  If our entry index, ![](./Resources/Element3.svg) and our exit, ![](./Resources/Element4.svg), there are two segment widths of ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg) respectively.  The widest vehicle that can fit through both is ![](./Resources/Element5.svg).  If ![](./Resources/Element7.svg) and ![](./Resources/Element8.svg), our widths are ![](./Resources/Element9.svg) which limits vehicle width to ![](./Resources/Element10.svg).  


**Function Description**

Complete the serviceLane function in the editor below.  It should return an array of integers representing the maximum width vehicle that can pass through each segment of the highway described.  

serviceLane has the following parameter(s):  


* n: an integer denoting the size of the ![](./Resources/Element11.svg) array
* cases: a two dimensional array of integers where each element is an array of two integers representing starting and ending indices for a segment to consider . 





**Input Format**


The first line of input contains two integers, ![](./Resources/Element12.svg) and ![](./Resources/Element13.svg), where ![](./Resources/Element12.svg) denotes the number of width measurements you will receive and ![](./Resources/Element13.svg) the number of test cases. The next line has ![](./Resources/Element12.svg) space-separated integers which represent the array ![](./Resources/Element14.svg).

The next ![](./Resources/Element13.svg) lines contain two integers, ![](./Resources/Element15.svg) and ![](./Resources/Element16.svg), where ![](./Resources/Element15.svg) is the start index and ![](./Resources/Element16.svg) is the end index of the segment being considered.





**Constraints**



* ![](./Resources/Element17.svg)
* ![](./Resources/Element18.svg)
* ![](./Resources/Element19.svg)
* ![](./Resources/Element20.svg)
* ![](./Resources/Element21.svg)





**Output Format**


For each test case, print the number that represents the largest vehicle type that can pass through the entire segment of the service lane between indexes ![](./Resources/Element15.svg) and ![](./Resources/Element16.svg) inclusive.





**Sample Input**


```
8 5
2 3 1 2 3 2 3 3
0 3
4 6
6 7
3 5
0 7
```




**Sample Output**


```
1
2
3
2
1
```




**Explanation**


Below is the representation of the lane:

```
   |HIGHWAY|Lane|    ->    Width

0: |       |--|            2
1: |       |---|           3
2: |       |-|             1
3: |       |--|            2
4: |       |---|           3
5: |       |--|            2
6: |       |---|           3
7: |       |---|           3
```

1. ![](./Resources/Element22.svg): From index ![](./Resources/Element23.svg) through ![](./Resources/Element6.svg) we have widths ![](./Resources/Element24.svg) and ![](./Resources/Element5.svg).  Nothing wider than ![](./Resources/Element10.svg) can pass all segments. 
2. ![](./Resources/Element25.svg): From index ![](./Resources/Element26.svg) through ![](./Resources/Element27.svg) we have widht ![](./Resources/Element28.svg) and ![](./Resources/Element6.svg).  Nothing wider than ![](./Resources/Element5.svg) can pass all segments.
3. ![](./Resources/Element29.svg): ![](./Resources/Element30.svg) .
4. ![](./Resources/Element31.svg): ![](./Resources/Element32.svg)
5. ![](./Resources/Element33.svg): ![](./Resources/Element34.svg).




