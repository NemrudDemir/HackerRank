[Source](https://www.hackerrank.com/challenges/save-the-prisoner)
# Problem statement
A jail has a number of prisoners and a number of treats to pass out to them.  Their jailer decides the fairest way to divide the treats is to seat the prisoners around a circular table in sequentially numbered chairs.  A chair number will be drawn from a hat.  Beginning with the prisoner in that chair, one candy will be handed to each prisoner sequentially around the table until all have been distributed.

The jailer is playing a little joke, though.  The last piece of candy looks like all the others, but it tastes awful.  Determine the chair number occupied by the prisoner who will receive that candy.

For example, there are ![](./Resources/Element1.svg) prisoners and ![](./Resources/Element2.svg) pieces of candy.  The prisoners arrange themselves in seats numbered ![](./Resources/Element3.svg) to ![](./Resources/Element1.svg).  Let's suppose two is drawn from the hat.  Prisoners receive candy at positions ![](./Resources/Element4.svg).  The prisoner to be warned sits in chair number ![](./Resources/Element5.svg).  


**Function Description**

Complete the saveThePrisoner function in the editor below.  It should return an integer representing the chair number of the prisoner to warn.  

saveThePrisoner has the following parameter(s):  


* n:  an integer, the number of prisoners  
* m:  an integer, the number of sweets  
* s:  an integer, the chair number to begin passing out sweets from  

**Input Format**

The first line contains an integer, ![](./Resources/Element6.svg), denoting the number of test cases. 


The next ![](./Resources/Element6.svg) lines each contain ![](./Resources/Element5.svg) space-separated integers: 


- ![](./Resources/Element7.svg): the number of prisoners 


- ![](./Resources/Element8.svg): the number of sweets 


- ![](./Resources/Element9.svg): the chair number to start passing out treats at  


**Constraints**


* ![](./Resources/Element10.svg)  
* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg)
* ![](./Resources/Element13.svg)

**Output Format**

For each test case, print the chair number of the prisoner who receives the awful treat on a new line.


**Sample Input 0**

```
2
5 2 1
5 2 2
```

**Sample Output 0**

```
2
3
```

**Explanation 0**

In first query, there are ![](./Resources/Element14.svg) prisoners and ![](./Resources/Element15.svg) sweets. Distribution starts at seat number ![](./Resources/Element16.svg).  Prisoners in seats numbered ![](./Resources/Element3.svg) and ![](./Resources/Element17.svg) get sweets.  Warn prisoner ![](./Resources/Element17.svg). 


In the second query, distribution starts at seat ![](./Resources/Element17.svg) so prisoners in seats ![](./Resources/Element17.svg) and ![](./Resources/Element5.svg) get sweets.  Warn prisoner ![](./Resources/Element5.svg).


**Sample Input 1**

```
2
7 19 2
3 7 3
```

**Sample Output 1**

```
6
3
```

**Explanation 1**

In the first test case, there are ![](./Resources/Element18.svg) prisoners, ![](./Resources/Element19.svg) sweets and they are passed out starting at chair ![](./Resources/Element20.svg).  The candies go all around twice and there are ![](./Resources/Element21.svg) more candies passed to each prisoner from seat ![](./Resources/Element17.svg) to seat ![](./Resources/Element2.svg).  

In the second test case, there are ![](./Resources/Element22.svg) prisoners, ![](./Resources/Element23.svg) candies and they are passed out starting at seat ![](./Resources/Element24.svg).  They go around twice, and there is one more to pass out to the prisoner at seat ![](./Resources/Element5.svg).  

