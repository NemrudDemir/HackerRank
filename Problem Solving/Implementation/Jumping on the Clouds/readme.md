[Source](https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem)
# Problem statement
Emma is playing a new mobile game that starts with consecutively numbered clouds.  Some of the clouds are thunderheads and others are cumulus.  She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus ![](./Resources/Element1.svg) or ![](./Resources/Element2.svg).  She must avoid the thunderheads.  Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud.  It is always possible to win the game.  

For each game, Emma will get an array of clouds numbered ![](./Resources/Element3.svg) if they are safe or ![](./Resources/Element1.svg) if they must be avoided.  For example, ![](./Resources/Element4.svg) indexed from ![](./Resources/Element5.svg).  The number on each cloud is its index in the list so she must avoid the clouds at indexes ![](./Resources/Element1.svg) and ![](./Resources/Element6.svg).  She could follow the following two paths: ![](./Resources/Element7.svg) or ![](./Resources/Element8.svg).  The first path takes ![](./Resources/Element9.svg) jumps while the second takes ![](./Resources/Element10.svg).


**Function Description**  

Complete the jumpingOnClouds function in the editor below.  It should return the minimum number of jumps required, as an integer.  

jumpingOnClouds has the following parameter(s):  


* c: an array of binary integers  

**Input Format**

The first line contains an integer ![](./Resources/Element11.svg), the total number of clouds. 
The second line contains ![](./Resources/Element11.svg) space-separated binary integers describing clouds ![](./Resources/Element12.svg) where ![](./Resources/Element13.svg).


**Constraints**


* ![](./Resources/Element14.svg)
* ![](./Resources/Element15.svg)
* ![](./Resources/Element16.svg)

**Output Format**

Print the minimum number of jumps needed to win the game.


**Sample Input 0**

```
7
0 0 1 0 0 1 0
```

**Sample Output 0**

```
4
```

**Explanation 0:** 


Emma must avoid ![](./Resources/Element17.svg) and ![](./Resources/Element18.svg). She can win the game with a minimum of ![](./Resources/Element10.svg) jumps:

![](./Resources/1461134731-c258160d15-jump2.png)


**Sample Input 1**

```
6
0 0 0 0 1 0
```

**Sample Output 1**

```
3
```

**Explanation 1:** 


The only thundercloud to avoid is ![](./Resources/Element19.svg). Emma can win the game in ![](./Resources/Element9.svg) jumps:

![](./Resources/1461136358-764298d363-jump5.png)

