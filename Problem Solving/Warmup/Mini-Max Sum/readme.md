[Source](https://www.hackerrank.com/challenges/mini-max-sum)
# Problem statement
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.  

For example, ![](./Resources/Element1.svg).  Our minimum sum is ![](./Resources/Element2.svg) and our maximum sum is ![](./Resources/Element3.svg).  We would print  

```
16 24
```

**Function Description**  

Complete the miniMaxSum function in the editor below.  It should print two space-separated integers on one line: the minimum sum and the maximum sum of ![](./Resources/Element4.svg) of ![](./Resources/Element5.svg) elements.  

miniMaxSum has the following parameter(s):


* arr: an array of ![](./Resources/Element6.svg) integers  

**Input Format**

A single line of five space-separated integers.


**Constraints**

![](./Resources/Element7.svg)  


**Output Format**

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)


**Sample Input**

```
1 2 3 4 5
```

**Sample Output**

```
10 14
```

**Explanation**

Our initial numbers are ![](./Resources/Element8.svg), ![](./Resources/Element9.svg), ![](./Resources/Element10.svg), ![](./Resources/Element11.svg), and ![](./Resources/Element12.svg). We can calculate the following sums using four of the five integers:


1. If we sum everything except ![](./Resources/Element13.svg), our sum is ![](./Resources/Element14.svg).
2. If we sum everything except ![](./Resources/Element15.svg), our sum is ![](./Resources/Element16.svg).
3. If we sum everything except ![](./Resources/Element17.svg), our sum is ![](./Resources/Element18.svg).
4. If we sum everything except ![](./Resources/Element19.svg), our sum is ![](./Resources/Element20.svg).
5. If we sum everything except ![](./Resources/Element21.svg), our sum is ![](./Resources/Element22.svg).

**Hints:** Beware of integer overflow! Use 64-bit Integer.

Need help to get started? Try the [Solve Me First](https://www.hackerrank.com/challenges/solve-me-first) problem

