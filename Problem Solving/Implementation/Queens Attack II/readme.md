[Source](https://www.hackerrank.com/challenges/queens-attack-2/problem)
# Problem statement
You will be given a square chess board with one queen and a number of obstacles placed on it.  Determine how many squares the queen can attack.  

A [queen](https://en.wikipedia.org/wiki/Queen_%28chess%29) is standing on an ![](./Resources/Element1.svg) [chessboard](https://en.wikipedia.org/wiki/Chess). The chess board's rows are numbered from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg), going from bottom to top.  Its columns are numbered from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg), going from left to right. Each square is referenced by a tuple, ![](./Resources/Element4.svg), describing the row, ![](./Resources/Element5.svg), and column, ![](./Resources/Element6.svg), where the square is located.

The queen is standing at position ![](./Resources/Element7.svg).  In a single move, she can attack any square in any of the eight directions (left, right, up, down, and the four diagonals). In the diagram below, the green circles denote all the cells the queen can attack from ![](./Resources/Element8.svg): 

![](./Resources/1485426500-a4039ebb00-chess1.png)

There are obstacles on the chessboard, each preventing the queen from attacking any square beyond it on that path. For example, an obstacle at location ![](./Resources/Element9.svg) in the diagram above prevents the queen from attacking cells ![](./Resources/Element9.svg), ![](./Resources/Element10.svg), and ![](./Resources/Element11.svg):

![](./Resources/1485459132-3fdc1f1ca3-chess_4_.png)

Given the queen's position and the locations of all the obstacles, find and print the number of squares the queen can attack from her position at ![](./Resources/Element7.svg).  In the board above, there are ![](./Resources/Element12.svg) such squares.


**Function Description**  

Complete the queensAttack function in the editor below.  It should return an integer that describes the number of squares the queen can attack.  

queensAttack has the following parameters: 


- n: an integer, the number of rows and columns in the board 


- k: an integer, the number of obstacles on the board 


- r_q: integer, the row number of the queen's position 


- c_q: integer, the column number of the queen's position 


- obstacles: a two dimensional array of integers where each element is an array of ![](./Resources/Element13.svg) integers, the row and column of an obstacle  


**Input Format**

The first line contains two space-separated integers ![](./Resources/Element3.svg) and ![](./Resources/Element14.svg), the length of the board's sides and the number of obstacles. 


The next line contains two space-separated integers ![](./Resources/Element15.svg) and ![](./Resources/Element16.svg), the queen's row and column position. 


Each of the next ![](./Resources/Element14.svg) lines contains two space-separated integers ![](./Resources/Element17.svg) and ![](./Resources/Element18.svg), the row and column position of ![](./Resources/Element19.svg).       


**Constraints**


* ![](./Resources/Element20.svg)
* ![](./Resources/Element21.svg)
* A single cell may contain more than one obstacle.
* There will never be an obstacle at the position where the queen is located.


**Subtasks**

For ![](./Resources/Element22.svg) of the maximum score: 


* ![](./Resources/Element23.svg)
* ![](./Resources/Element24.svg)

For ![](./Resources/Element25.svg) of the maximum score: 


* ![](./Resources/Element26.svg)
* ![](./Resources/Element21.svg)


**Output Format**

Print the number of squares that the queen can attack from position ![](./Resources/Element7.svg).


**Sample Input 0**

```
4 0
4 4
```

**Sample Output 0**

```
9
```

**Explanation 0**

The queen is standing at position ![](./Resources/Element8.svg) on a ![](./Resources/Element27.svg) chessboard with no obstacles:

![](./Resources/1485426553-3064e08638-chess2.png)


**Sample Input 1**

```
5 3
4 3
5 5
4 2
2 3
```

**Sample Output 1**

```
10
```

**Explanation 1**

The queen is standing at position ![](./Resources/Element28.svg) on a ![](./Resources/Element29.svg) chessboard with ![](./Resources/Element30.svg) obstacles:

![](./Resources/1485426870-84a6a0ce97-chess3.png)

The number of squares she can attack from that position is ![](./Resources/Element31.svg).


**Sample Input 2**

```
1 0
1 1
```

**Sample Output 2**

```
0
```

**Explanation 2**

Since there is only one square, and the queen is on it, the queen can move 0 squares.

