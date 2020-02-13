[Source](https://www.hackerrank.com/challenges/cats-and-a-mouse)
# Problem statement
Two cats and a mouse are at various positions on a line.  You will be given their starting positions.  Your task is to determine which cat will reach the mouse first, assuming the mouse doesn't move and the cats travel at equal speed.  If the cats arrive at the same time, the mouse will be allowed to move and it will escape while they fight.

You are given ![](./Resources/Element1.svg) queries in the form of ![](./Resources/Element2.svg), ![](./Resources/Element3.svg), and ![](./Resources/Element4.svg) representing the respective positions for cats ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg), and for mouse ![](./Resources/Element7.svg). Complete the function ![](./Resources/Element8.svg) to return the appropriate answer to each query, which will be printed on a new line.


* If cat ![](./Resources/Element5.svg) catches the mouse first, print ```Cat A```.
* If cat ![](./Resources/Element6.svg) catches the mouse first, print ```Cat B```.
* If both cats reach the mouse at the same time, print ```Mouse C``` as the two cats fight and mouse escapes.  
For example, cat ![](./Resources/Element5.svg) is at position ![](./Resources/Element9.svg) and cat ![](./Resources/Element6.svg) is at ![](./Resources/Element10.svg).  If mouse ![](./Resources/Element7.svg) is at position ![](./Resources/Element11.svg), it is ![](./Resources/Element12.svg) units from cat ![](./Resources/Element5.svg) and ![](./Resources/Element13.svg) unit from cat ![](./Resources/Element6.svg).  Cat ![](./Resources/Element6.svg) will catch the mouse.  


**Function Description**  

Complete the catAndMouse function in the editor below.  It should return one of the three strings as described.  

catAndMouse has the following parameter(s):  


* x: an integer, Cat ![](./Resources/Element5.svg)'s position  
* y: an integer, Cat ![](./Resources/Element6.svg)'s position  
* z: an integer, Mouse ![](./Resources/Element7.svg)'s position  

**Input Format**

The first line contains a single integer, ![](./Resources/Element1.svg), denoting the number of queries. 


Each of the ![](./Resources/Element1.svg) subsequent lines contains three space-separated integers describing the respective values of ![](./Resources/Element2.svg) (cat ![](./Resources/Element5.svg)'s location), ![](./Resources/Element3.svg) (cat ![](./Resources/Element6.svg)'s location), and ![](./Resources/Element4.svg) (mouse ![](./Resources/Element7.svg)'s location).


**Constraints**


* ![](./Resources/Element14.svg)  
* ![](./Resources/Element15.svg)  

**Output Format**

For each query, return ```Cat A``` if cat ![](./Resources/Element5.svg) catches the mouse first, ```Cat B``` if cat ![](./Resources/Element6.svg) catches the mouse first, or ```Mouse C``` if the mouse escapes.


**Sample Input 0**

```
2
1 2 3
1 3 2
```

**Sample Output 0**

```
Cat B
Mouse C
```

**Explanation 0**

Query 0: The positions of the cats and mouse are shown below:
![](./Resources/1480434477-7418fccf34-cat.png)

Cat ![](./Resources/Element6.svg) will catch the mouse first, so we print ```Cat B``` on a new line.

Query 1: In this query, cats ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg) reach mouse ![](./Resources/Element7.svg) at the exact same time:
![](./Resources/1480434557-601bef86ba-cat1.png)

Because the mouse escapes, we print ```Mouse C``` on a new line.

