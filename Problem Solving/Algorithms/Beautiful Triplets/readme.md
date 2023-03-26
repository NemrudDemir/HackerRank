[Source](https://www.hackerrank.com/challenges/beautiful-triplets)
# Problem statement
Given a sequence of integers ![](./Resources/Element1.svg), a triplet ![](./Resources/Element2.svg) is beautiful if:


* ![](./Resources/Element3.svg)
* ![](./Resources/Element4.svg)

Given an increasing sequenc of integers and the value of ![](./Resources/Element5.svg), count the number of beautiful triplets in the sequence.

For example, the sequence ![](./Resources/Element6.svg) and ![](./Resources/Element7.svg).  There are three beautiful triplets, by index: ![](./Resources/Element8.svg).  To test the first triplet, ![](./Resources/Element9.svg) and ![](./Resources/Element10.svg).  


**Function Description**

Complete the beautifulTriplets function in the editor below.  It must return an integer that represents the number of beautiful triplets in the sequence.  

beautifulTriplets has the following parameters:  


* d: an integer  
* arr: an array of integers, sorted ascending  





**Input Format**


The first line contains ![](./Resources/Element11.svg) space-separated integers ![](./Resources/Element12.svg) and ![](./Resources/Element5.svg), the length of the sequence and the beautiful difference. 


The second line contains ![](./Resources/Element12.svg) space-separated integers ![](./Resources/Element13.svg).





**Constraints**



* ![](./Resources/Element14.svg)
* ![](./Resources/Element15.svg)
* ![](./Resources/Element16.svg)
* ![](./Resources/Element17.svg)





**Output Format**


Print a single line denoting the number of beautiful triplets in the sequence.





**Sample Input**


```
7 3
1 2 4 5 7 8 10
```




**Sample Output**


```
3
```




**Explanation**


The input sequence is ![](./Resources/Element18.svg), and our beautiful difference ![](./Resources/Element19.svg). There are many possible triplets ![](./Resources/Element20.svg), but our only beautiful triplets are ![](./Resources/Element21.svg) , ![](./Resources/Element22.svg) and ![](./Resources/Element23.svg) by value not index. Please see the equations below:     

![](./Resources/Element24.svg)

![](./Resources/Element25.svg)

![](./Resources/Element26.svg)



Recall that a beautiful triplet satisfies the following equivalence relation: ![](./Resources/Element27.svg) where ![](./Resources/Element3.svg). 





