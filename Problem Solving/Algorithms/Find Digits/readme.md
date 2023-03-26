[Source](https://www.hackerrank.com/challenges/find-digits)
# Problem statement
An integer ![](./Resources/Element1.svg) is a divisor of an integer ![](./Resources/Element2.svg) if the remainder of ![](./Resources/Element3.svg).  

Given an integer, for each digit that makes up the integer determine whether it is a divisor.  Count the number of divisors occurring within the integer.  


**Note:** Each digit is considered to be unique, so each occurrence of the same digit should be counted (e.g. for ![](./Resources/Element4.svg), ![](./Resources/Element5.svg) is a divisor of ![](./Resources/Element6.svg) each time it occurs so the answer is ![](./Resources/Element7.svg)).


**Function Description**

Complete the findDigits function in the editor below.  It should return an integer representing the number of digits of ![](./Resources/Element1.svg) that are divisors of ![](./Resources/Element1.svg).  

findDigits has the following parameter(s):


* n: an integer to analyze

**Input Format**

The first line is an integer, ![](./Resources/Element8.svg), indicating the number of test cases. 


The ![](./Resources/Element8.svg) subsequent lines each contain an integer, ![](./Resources/Element2.svg).  


**Constraints**

![](./Resources/Element9.svg) 


![](./Resources/Element10.svg)


**Output Format**

For every test case, count the number of digits in ![](./Resources/Element2.svg) that are divisors of ![](./Resources/Element2.svg).  Print each answer on a new line.


**Sample Input**

```
2
12
1012
```

**Sample Output**

```
2
3
```

**Explanation**

The number ![](./Resources/Element11.svg) is broken into two digits, ![](./Resources/Element5.svg) and ![](./Resources/Element12.svg). When ![](./Resources/Element11.svg) is divided by either of those two digits, the remainder is ![](./Resources/Element13.svg) so they are both divisors.

The number ![](./Resources/Element14.svg) is broken into four digits, ![](./Resources/Element5.svg), ![](./Resources/Element13.svg), ![](./Resources/Element5.svg), and ![](./Resources/Element12.svg). ![](./Resources/Element14.svg) is evenly divisible by its digits ![](./Resources/Element5.svg), ![](./Resources/Element5.svg), and ![](./Resources/Element12.svg), but it is not divisible by ![](./Resources/Element13.svg) as division by zero is undefined.

