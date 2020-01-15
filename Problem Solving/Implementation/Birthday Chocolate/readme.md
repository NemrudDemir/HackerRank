[Source](https://www.hackerrank.com/challenges/the-birthday-bar)
# Problem statement
Lily has a chocolate bar that she wants to share it with Ron for his birthday.  Each of the squares has an integer on it.  She decides to share a contiguous segment of the bar selected such that the length of the segment matches Ron's birth month and the sum of the integers on the squares is equal to his birth day.  You must determine how many ways she can divide the chocolate.

Consider the chocolate bar as an array of squares, ![](./Resources/Element1.svg).  She wants to find segments summing to Ron's birth day, ![](./Resources/Element2.svg) with a length equalling his birth month, ![](./Resources/Element3.svg).  In this case, there are two segments meeting her criteria: ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg).


**Function Description**

Complete the birthday function in the editor below.  It should return an integer denoting the number of ways Lily can divide the chocolate bar.  

birthday has the following parameter(s):  


* s: an array of integers, the numbers on each of the squares of chocolate  
* d: an integer, Ron's birth day  
* m: an integer, Ron's birth month  

**Input Format**

The first line contains an integer ![](./Resources/Element6.svg), the number of squares in the chocolate bar. 


The second line contains ![](./Resources/Element7.svg) space-separated integers ![](./Resources/Element8.svg), the numbers on the chocolate squares where ![](./Resources/Element9.svg). 


The third line contains two space-separated integers, ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg), Ron's birth day and his birth month.


**Constraints**


* ![](./Resources/Element12.svg)  
* ![](./Resources/Element13.svg), where (![](./Resources/Element14.svg))     
* ![](./Resources/Element15.svg)  
* ![](./Resources/Element16.svg)

**Output Format**

Print an integer denoting the total number of ways that Lily can portion her chocolate bar to share with Ron.


**Sample Input 0**

```
5
1 2 1 3 2
3 2
```

**Sample Output 0**

```
2
```

**Explanation 0**

Lily wants to give Ron ![](./Resources/Element17.svg) squares summing to ![](./Resources/Element18.svg).  The following two segments meet the criteria:

![](./Resources/1489060874-a04ddb06cf-choco4.png)


**Sample Input 1**

```
6
1 1 1 1 1 1
3 2
```

**Sample Output 1**

```
0
```

**Explanation 1**

Lily only wants to give Ron ![](./Resources/Element19.svg) consecutive squares of chocolate whose integers sum to ![](./Resources/Element20.svg). There are no possible pieces satisfying these constraints:

![](./Resources/1489060978-e33d905668-choco5.png)

Thus, we print ![](./Resources/Element21.svg) as our answer.


**Sample Input 2**

```
1
4
4 1
```

**Sample Output 2**

```
1
```

**Explanation 2**

Lily only wants to give Ron ![](./Resources/Element22.svg) square of chocolate with an integer value of ![](./Resources/Element23.svg). Because the only square of chocolate in the bar satisfies this constraint, we print ![](./Resources/Element24.svg) as our answer.

