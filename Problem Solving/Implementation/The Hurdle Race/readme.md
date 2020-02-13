[Source](https://www.hackerrank.com/challenges/the-hurdle-race)
# Problem statement
Dan is playing a video game in which his character competes in a hurdle race.  Hurdles are of varying heights, and Dan has a maximum height he can jump.  There is a magic potion he can take that will increase his maximum height by ![](./Resources/Element1.svg) unit for each dose.  How many doses of the potion must he take to be able to jump all of the hurdles.

Given an array of hurdle heights ![](./Resources/Element2.svg), and an initial maximum height Dan can jump,  ![](./Resources/Element3.svg), determine the minimum number of doses Dan must take to be able to clear all the hurdles in the race.  

For example, if ![](./Resources/Element4.svg) and Dan can jump ![](./Resources/Element1.svg) unit high naturally, he must take ![](./Resources/Element5.svg) doses of potion to be able to jump all of the hurdles.  


**Function Description**  

Complete the hurdleRace function in the editor below.  It should return the minimum units of potion Dan needs to drink to jump all of the hurdles.  

hurdleRace has the following parameter(s):  


* k: an integer denoting the height Dan can jump naturally  
* height: an array of integers denoting the heights of each hurdle  

**Input Format**

The first line contains two space-separated integers ![](./Resources/Element6.svg) and ![](./Resources/Element3.svg), the number of hurdles and the maximum height Dan can jump naturally. 


The second line contains ![](./Resources/Element6.svg) space-separated integers ![](./Resources/Element7.svg) where ![](./Resources/Element8.svg).


**Constraints**


* ![](./Resources/Element9.svg)  
* ![](./Resources/Element10.svg)  

**Output Format**

Print an integer denoting the minimum doses of magic potion Dan must drink to complete the hurdle race.


**Sample Input 0**

```
5 4
1 6 3 5 2
```

**Sample Output 0**

```
2
```

**Explanation 0**

Dan's character can jump a maximum of ![](./Resources/Element11.svg) units, but the tallest hurdle has a height of ![](./Resources/Element12.svg):

![](./Resources/1485458269-d39e09fb78-hurdle.png)

To be able to jump all the hurdles, Dan must drink ![](./Resources/Element13.svg) doses.


**Sample Input 1**

```
5 7
2 5 4 5 2
```

**Sample Output 1**

```
0
```

**Explanation 1**

Dan's character can jump a maximum of ![](./Resources/Element14.svg) units, which is enough to cross all the hurdles:

![](./Resources/1485458562-e680371e5a-hurdle1.png)

Because he can already jump all the hurdles, Dan needs to drink ![](./Resources/Element15.svg) doses.

