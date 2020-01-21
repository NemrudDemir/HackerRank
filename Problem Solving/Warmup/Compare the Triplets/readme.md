[Source](https://www.hackerrank.com/challenges/compare-the-triplets)
# Problem statement
Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from ![](./Resources/Element1.svg) to ![](./Resources/Element2.svg) for three categories: problem clarity, originality, and difficulty. 

We define the rating for Alice's challenge to be the triplet ![](./Resources/Element3.svg), and the rating for Bob's challenge to be the triplet ![](./Resources/Element4.svg).

Your task is to find their comparison points by comparing ![](./Resources/Element5.svg) with ![](./Resources/Element6.svg), ![](./Resources/Element7.svg) with ![](./Resources/Element8.svg), and ![](./Resources/Element9.svg) with ![](./Resources/Element10.svg). 


* If ![](./Resources/Element11.svg), then Alice is awarded ![](./Resources/Element1.svg) point. 
* If ![](./Resources/Element12.svg), then Bob is awarded ![](./Resources/Element1.svg) point. 
* If ![](./Resources/Element13.svg), then neither person receives a point.
Comparison points is the total points a person earned.

Given ![](./Resources/Element14.svg) and ![](./Resources/Element15.svg), determine their respective comparison points.

For example, ![](./Resources/Element16.svg) and ![](./Resources/Element17.svg).  For elements ![](./Resources/Element18.svg), Bob is awarded a point because ![](./Resources/Element19.svg).  For the equal elements ![](./Resources/Element7.svg) and ![](./Resources/Element8.svg), no points are earned.  Finally, for elements ![](./Resources/Element20.svg), ![](./Resources/Element21.svg) so Alice receives a point.  Your return array would be ![](./Resources/Element22.svg) with Alice's score first and Bob's second.  


**Function Description**

Complete the function compareTriplets in the editor below.  It must return an array of two integers, the first being Alice's score and the second being Bob's.  

compareTriplets has the following parameter(s):


* a: an array of integers representing Alice's challenge rating  
* b: an array of integers representing Bob's challenge rating  

**Input Format**

The first line contains ![](./Resources/Element23.svg) space-separated integers, ![](./Resources/Element5.svg), ![](./Resources/Element7.svg), and ![](./Resources/Element9.svg), describing the respective values in triplet ![](./Resources/Element14.svg). 


The second line contains ![](./Resources/Element23.svg) space-separated integers, ![](./Resources/Element6.svg), ![](./Resources/Element8.svg), and ![](./Resources/Element10.svg), describing the respective values in triplet ![](./Resources/Element15.svg).


**Constraints**


* ![](./Resources/Element24.svg)
* ![](./Resources/Element25.svg)

**Output Format**

Return an array of two integers denoting the respective comparison points earned by Alice and Bob.


**Sample Input 0**

```
5 6 7
3 6 10
```

**Sample Output 0**

```
1 1
```

**Explanation 0**

In this example: 


* ![](./Resources/Element26.svg)
* ![](./Resources/Element27.svg)
Now, let's compare each individual score:


* ![](./Resources/Element28.svg), so Alice receives ![](./Resources/Element1.svg) point.
* ![](./Resources/Element29.svg), so nobody receives a point.
* ![](./Resources/Element30.svg), so Bob receives ![](./Resources/Element1.svg) point.
Alice's comparison score is ![](./Resources/Element1.svg), and Bob's comparison score is ![](./Resources/Element1.svg). Thus, we return the array ![](./Resources/Element22.svg).  


**Sample Input 1**

```
17 28 30
99 16 8
```

**Sample Output 1**

```
2 1
```

**Explanation 1**

Comparing the ![](./Resources/Element31.svg) elements, ![](./Resources/Element32.svg) so Bob receives a point. 


Comparing the ![](./Resources/Element33.svg) and ![](./Resources/Element34.svg) elements, ![](./Resources/Element35.svg) and ![](./Resources/Element36.svg) so Alice receives two points. 


The return array is ![](./Resources/Element37.svg).  

