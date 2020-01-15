[Source](https://www.hackerrank.com/challenges/kangaroo)
# Problem statement
You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity). 


* The first kangaroo starts at location ![](./Resources/Element1.svg) and moves at a rate of ![](./Resources/Element2.svg) meters per jump. 
* The second kangaroo starts at location ![](./Resources/Element3.svg) and moves at a rate of ![](./Resources/Element4.svg) meters per jump.
You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.  If it is possible, return ```YES```, otherwise return ```NO```.

For example, kangaroo ![](./Resources/Element5.svg) starts at ![](./Resources/Element6.svg) with a jump distance ![](./Resources/Element7.svg) and kangaroo ![](./Resources/Element8.svg) starts at ![](./Resources/Element9.svg) with a jump distance of ![](./Resources/Element10.svg). After one jump, they are both at ![](./Resources/Element11.svg), (![](./Resources/Element12.svg), ![](./Resources/Element13.svg)), so our answer is ```YES```.


**Function Description**

Complete the function kangaroo in the editor below.  It should return ```YES``` if they reach the same position at the same time, or ```NO``` if they don't.  

kangaroo has the following parameter(s):  


* x1, v1: integers, starting position and jump distance for kangaroo 1
* x2, v2: integers, starting position and jump distance for kangaroo 2

**Input Format**

A single line of four space-separated integers denoting the respective values of ![](./Resources/Element14.svg), ![](./Resources/Element15.svg), ![](./Resources/Element16.svg), and ![](./Resources/Element17.svg).


**Constraints**


* ![](./Resources/Element18.svg)  
* ![](./Resources/Element19.svg)  
* ![](./Resources/Element20.svg)  

**Output Format**

Print ```YES``` if they can land on the same location at the same time; otherwise, print ```NO```.


**Note:** The two kangaroos must land at the same location after making the same number of jumps.


**Sample Input 0**

```
0 3 4 2
```

**Sample Output 0**

```
YES
```

**Explanation 0**

The two kangaroos jump through the following sequence of locations:

![](./Resources/1516005283-e74e76ff0c-kangaroo.png)

From the image, it is clear that the kangaroos meet at the same location (number ![](./Resources/Element21.svg) on the number line) after same number of jumps (![](./Resources/Element22.svg) jumps), and we print ```YES```.


**Sample Input 1**

```
0 2 5 3
```

**Sample Output 1**

```
NO
```

**Explanation 1**

The second kangaroo has a starting location that is ahead (further to the right) of the first kangaroo's starting location (i.e., ![](./Resources/Element23.svg)). Because the second kangaroo moves at a faster rate (meaning ![](./Resources/Element24.svg)) and is already ahead of the first kangaroo, the first kangaroo will never be able to catch up. Thus, we print NO. 

