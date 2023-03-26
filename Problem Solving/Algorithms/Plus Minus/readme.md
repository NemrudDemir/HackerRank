[Source](https://www.hackerrank.com/challenges/plus-minus)
# Problem statement
Given an array of integers, calculate the fractions of its elements that are positive,  negative, and are zeros. Print the decimal value of each fraction on a new line.


**Note:** This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to ![](./Resources/Element1.svg) are acceptable.

For example, given the array ![](./Resources/Element2.svg) there are ![](./Resources/Element3.svg) elements, two positive, two negative and one zero.  Their ratios would be ![](./Resources/Element4.svg), ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg).  It should be printed as  

```
0.400000
0.400000
0.200000
```

**Function Description**

Complete the plusMinus function in the editor below.  It should print out the ratio of positive, negative and zero items in the array, each on a separate line rounded to six decimals.  

plusMinus has the following parameter(s):


* arr: an array of integers

**Input Format**

The first line contains an integer, ![](./Resources/Element6.svg), denoting the size of the array. 


The second line contains ![](./Resources/Element6.svg) space-separated integers describing an array of numbers ![](./Resources/Element7.svg).


**Constraints**

![](./Resources/Element8.svg) 


![](./Resources/Element9.svg)  


**Output Format**

You must print the following ![](./Resources/Element10.svg) lines:


1. A decimal representing of the fraction of positive numbers in the array compared to its size.
2. A decimal representing of the fraction of negative numbers in the array compared to its size.
3. A decimal representing of the fraction of zeros in the array compared to its size.

**Sample Input**

```
6
-4 3 -9 0 4 1         
```

**Sample Output**

```
0.500000
0.333333
0.166667
```

**Explanation**

There are ![](./Resources/Element10.svg) positive numbers, ![](./Resources/Element11.svg) negative numbers, and ![](./Resources/Element12.svg) zero in the array. 


The proportions of occurrence are positive:  ![](./Resources/Element13.svg), negative:  ![](./Resources/Element14.svg) and zeros:  ![](./Resources/Element15.svg).  

