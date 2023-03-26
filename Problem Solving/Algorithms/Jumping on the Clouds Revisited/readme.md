[Source](https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited)
# Problem statement
Aerith is playing a cloud hopping game. In this game, there are sequentially numbered clouds that can be thunderheads or cumulus clouds.  Her character must jump from cloud to cloud until it reaches the start again.  

To play, Aerith is given an array of clouds, ![](./Resources/Element1.svg) and an energy level ![](./Resources/Element2.svg). She starts from ![](./Resources/Element3.svg) and uses ![](./Resources/Element4.svg) unit of energy to make a jump of size ![](./Resources/Element5.svg) to cloud ![](./Resources/Element6.svg). If Aerith lands on a thundercloud, ![](./Resources/Element7.svg), her energy (![](./Resources/Element8.svg)) decreases by ![](./Resources/Element9.svg) additional units. The game ends when Aerith lands back on cloud ![](./Resources/Element10.svg).

Given the values of ![](./Resources/Element11.svg), ![](./Resources/Element5.svg), and the configuration of the clouds as an array ![](./Resources/Element1.svg), can you determine the final value of ![](./Resources/Element8.svg) after the game ends?

For example, give ![](./Resources/Element12.svg) and ![](./Resources/Element13.svg), the indices of her path are ![](./Resources/Element14.svg).  Her energy level reduces by ![](./Resources/Element4.svg) for each jump to ![](./Resources/Element15.svg).  She landed on one thunderhead at an additional cost of ![](./Resources/Element9.svg) energy units.  Her final energy level is ![](./Resources/Element16.svg).


**Note:** Recall that ![](./Resources/Element17.svg) refers to the [modulo operation](https://en.wikipedia.org/wiki/Modulo_operation).  In this case, it serves to make the route circular.  If Aerith is at ![](./Resources/Element18.svg) and jumps ![](./Resources/Element4.svg), she will arrive at ![](./Resources/Element3.svg).  


**Function Description**  

Complete the jumpingOnClouds function in the editor below.  It should return an integer representing the energy level remaining after the game.  

jumpingOnClouds has the following parameter(s):  


* c: an array of integers representing cloud types  
* k: an integer representing the length of one jump  

**Input Format**

The first line contains two space-separated integers, ![](./Resources/Element11.svg) and ![](./Resources/Element5.svg), the number of clouds and the jump distance. 


The second line contains ![](./Resources/Element11.svg) space-separated integers ![](./Resources/Element19.svg) where ![](./Resources/Element20.svg). Each cloud is described as follows:


* If ![](./Resources/Element21.svg), then cloud ![](./Resources/Element22.svg) is a cumulus cloud.
* If ![](./Resources/Element7.svg), then cloud ![](./Resources/Element22.svg) is a thunderhead.

**Constraints**


* ![](./Resources/Element23.svg) 
* ![](./Resources/Element24.svg)
* ![](./Resources/Element25.svg)
* ![](./Resources/Element26.svg)

**Output Format**

Print the final value of ![](./Resources/Element8.svg) on a new line.


**Sample Input**

```
8 2
0 0 1 0 0 1 1 0
```

**Sample Output**

```
92
```

**Explanation**

In the diagram below, red clouds are thunderheads and purple clouds are cumulus clouds:

![](./Resources/1462454878-26f414ec0f-may4.png)

Observe that our thunderheads are the clouds numbered ![](./Resources/Element9.svg), ![](./Resources/Element27.svg), and ![](./Resources/Element28.svg). Aerith makes the following sequence of moves:


1. Move: ![](./Resources/Element29.svg), Energy: ![](./Resources/Element30.svg).
2. Move: ![](./Resources/Element31.svg), Energy: ![](./Resources/Element32.svg).
3. Move: ![](./Resources/Element33.svg), Energy: ![](./Resources/Element34.svg).
4. Move: ![](./Resources/Element35.svg), Energy: ![](./Resources/Element36.svg).
