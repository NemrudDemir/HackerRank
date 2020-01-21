[Source](https://www.hackerrank.com/challenges/apple-and-orange)
# Problem statement
Sam's house has an apple tree and an orange tree that yield an abundance of fruit. In the diagram below, the red region denotes his house, where ![](./Resources/Element1.svg) is the start point, and ![](./Resources/Element2.svg) is the endpoint. The apple tree is to the left of his house, and the orange tree is to its right. You can assume the trees are located on a single point, where the apple tree is at point ![](./Resources/Element3.svg), and the orange tree is at point ![](./Resources/Element4.svg).

![](./Resources/1474218925-f2a791d52c-Appleandorange2.png)

When a fruit falls from its tree, it lands ![](./Resources/Element5.svg) units of distance from its tree of origin along the ![](./Resources/Element6.svg)-axis. A negative value of ![](./Resources/Element5.svg) means the fruit fell ![](./Resources/Element5.svg) units to the tree's left, and a positive value of ![](./Resources/Element5.svg) means it falls ![](./Resources/Element5.svg) units to the tree's right. 

Given the value of ![](./Resources/Element5.svg) for ![](./Resources/Element7.svg) apples and ![](./Resources/Element8.svg) oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range ![](./Resources/Element9.svg))?

For example, Sam's house is between ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg).  The apple tree is located at ![](./Resources/Element12.svg) and the orange at ![](./Resources/Element13.svg).  There are ![](./Resources/Element14.svg) apples and ![](./Resources/Element15.svg) oranges.  Apples are thrown ![](./Resources/Element16.svg) units distance from ![](./Resources/Element3.svg), and ![](./Resources/Element17.svg) units distance.  Adding each apple distance to the position of the tree, they land at ![](./Resources/Element18.svg).  Oranges land at ![](./Resources/Element19.svg).  One apple and two oranges land in the inclusive range ![](./Resources/Element20.svg) so we print 

```
1
2
```

**Function Description**  

Complete the countApplesAndOranges function in the editor below.  It should print the number of apples and oranges that land on Sam's house, each on a separate line.  

countApplesAndOranges has the following parameter(s):  


* s: integer, starting point of Sam's house location.       
* t: integer, ending location of Sam's house location.     
* a: integer, location of the Apple tree.      
* b: integer, location of the Orange tree.         
* apples: integer array, distances at which each apple falls from the tree.      
* oranges: integer array, distances at which each orange falls from the tree.  

**Input Format**

The first line contains two space-separated integers denoting the respective values of ![](./Resources/Element1.svg) and ![](./Resources/Element2.svg). 


The second line contains two space-separated integers denoting the respective values of ![](./Resources/Element3.svg) and ![](./Resources/Element4.svg). 


The third line contains two space-separated integers denoting the respective values of ![](./Resources/Element7.svg) and ![](./Resources/Element8.svg). 


The fourth line contains ![](./Resources/Element7.svg) space-separated integers denoting the respective distances that each apple falls from point ![](./Resources/Element3.svg). 


The fifth line contains ![](./Resources/Element8.svg) space-separated integers denoting the respective distances that each orange falls from point ![](./Resources/Element4.svg).


**Constraints**


* ![](./Resources/Element21.svg)
* ![](./Resources/Element22.svg)
* ![](./Resources/Element23.svg)

**Output Format**

Print two integers on two different lines:


1. The first integer:  the number of apples that fall on Sam's house.
2. The second integer:  the number of oranges that fall on Sam's house.  

**Sample Input 0**

```
7 11
5 15
3 2
-2 2 1
5 -6
```

**Sample Output 0**

```
1
1
```

**Explanation 0**

The first apple falls at position ![](./Resources/Element24.svg). 


The second apple falls at position ![](./Resources/Element25.svg). 


The third apple falls at position ![](./Resources/Element26.svg). 


The first orange falls at position ![](./Resources/Element27.svg). 


The second orange falls at position ![](./Resources/Element28.svg). 


Only one fruit (the second apple) falls within the region between ![](./Resources/Element29.svg) and ![](./Resources/Element30.svg), so we print ![](./Resources/Element31.svg) as our first line of output. 


Only the second orange falls within the region between ![](./Resources/Element29.svg) and ![](./Resources/Element30.svg), so we print ![](./Resources/Element31.svg) as our second line of output.  

