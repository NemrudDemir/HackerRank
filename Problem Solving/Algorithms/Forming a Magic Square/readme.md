[Source](https://www.hackerrank.com/challenges/magic-square-forming/problem)
# Problem statement
We define a [magic square](https://en.wikipedia.org/wiki/Magic_square) to be an ![](./Resources/Element1.svg) matrix of distinct positive integers from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg) where the sum of any row, column, or diagonal of length ![](./Resources/Element4.svg) is always equal to the same number:  the magic constant. 

You will be given a ![](./Resources/Element5.svg) matrix ![](./Resources/Element6.svg) of integers in the inclusive range ![](./Resources/Element7.svg). We can convert any digit ![](./Resources/Element8.svg) to any other digit ![](./Resources/Element9.svg) in the range ![](./Resources/Element7.svg) at cost of ![](./Resources/Element10.svg).  Given ![](./Resources/Element6.svg), convert it into a magic square at minimal cost. Print this cost on a new line.


**Note:** The resulting magic square must contain distinct integers in the inclusive range ![](./Resources/Element7.svg).

For example, we start with the following matrix ![](./Resources/Element6.svg):  

```
5 3 4
1 5 8
6 4 2
```
We can convert it to the following magic square:

```
8 3 4
1 5 9
6 7 2
```
This took three replacements at a cost of ![](./Resources/Element11.svg).


**Function Description**

Complete the formingMagicSquare function in the editor below.  It should return an integer that represents the minimal total cost of converting the input square to a magic square.

formingMagicSquare has the following parameter(s):  


* s: a ![](./Resources/Element5.svg) array of integers

**Input Format**

Each of the lines contains three space-separated integers of row ![](./Resources/Element12.svg).  


**Constraints**


* ![](./Resources/Element13.svg)

**Output Format**

Print an integer denoting the minimum cost of turning matrix ![](./Resources/Element6.svg) into a magic square.


**Sample Input 0**

```
4 9 2
3 5 7
8 1 5
```

**Sample Output 0**

```
1
```

**Explanation 0**

If we change the bottom right value, ![](./Resources/Element14.svg), from ![](./Resources/Element15.svg) to ![](./Resources/Element16.svg) at a cost of ![](./Resources/Element17.svg), ![](./Resources/Element6.svg) becomes a magic square at the minimum possible cost.


**Sample Input 1**

```
4 8 2
4 5 7
6 1 6
```

**Sample Output 1**

```
4
```

**Explanation 1**

Using 0-based indexing, if we make 


* ![](./Resources/Element18.svg)-&gt;![](./Resources/Element19.svg) at a cost of ![](./Resources/Element20.svg) 
* ![](./Resources/Element21.svg)-&gt;![](./Resources/Element22.svg) at a cost of ![](./Resources/Element23.svg)
* ![](./Resources/Element24.svg)-&gt;![](./Resources/Element25.svg) at a cost of ![](./Resources/Element26.svg),  
then the total cost will be ![](./Resources/Element27.svg).   

