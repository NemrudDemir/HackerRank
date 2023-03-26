[Source](https://www.hackerrank.com/challenges/utopian-tree)
# Problem statement
The Utopian Tree goes through 2 cycles of growth every year. Each spring, it doubles in height. Each summer, its height increases by 1 meter.

Laura plants a Utopian Tree sapling with a height of 1 meter at the onset of spring. How tall will her tree be after ![](./Resources/Element1.svg) growth cycles?

For example, if the number of growth cycles is ![](./Resources/Element2.svg), the calculations are as follows:

```
Period  Height
0          1
1          2
2          3
3          6
4          7
5          14
```

**Function Description**

Complete the utopianTree function in the editor below.  It should return the integer height of the tree after the input number of growth cycles.  

utopianTree has the following parameter(s):


* n:  an integer, the number of growth cycles to simulate  

**Input Format**

The first line contains an integer, ![](./Resources/Element3.svg), the number of test cases. 


![](./Resources/Element3.svg) subsequent lines each contain an integer, ![](./Resources/Element1.svg), denoting the number of cycles for that test case.


**Constraints**

![](./Resources/Element4.svg) 


![](./Resources/Element5.svg)


**Output Format**

For each test case, print the height of the Utopian Tree after ![](./Resources/Element1.svg) cycles. Each height must be printed on a new line.


**Sample Input**

```
3
0
1
4
```

**Sample Output**

```
1
2
7
```

**Explanation**

There are 3 test cases.

In the first case (![](./Resources/Element6.svg)), the initial height (![](./Resources/Element7.svg)) of the tree remains unchanged.

In the second case (![](./Resources/Element8.svg)), the tree doubles in height and is ![](./Resources/Element9.svg) meters tall after the spring cycle.

In the third case (![](./Resources/Element10.svg)), the tree doubles its height in spring (![](./Resources/Element8.svg), ![](./Resources/Element11.svg)), then grows a meter in summer (![](./Resources/Element12.svg), ![](./Resources/Element13.svg)), then doubles after the next spring (![](./Resources/Element14.svg), ![](./Resources/Element15.svg)), and grows another meter after summer (![](./Resources/Element10.svg), ![](./Resources/Element16.svg)). Thus, at the end of 4 cycles, its height is ![](./Resources/Element17.svg) meters.

