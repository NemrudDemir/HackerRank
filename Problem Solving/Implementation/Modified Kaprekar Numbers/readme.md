[Source](https://www.hackerrank.com/challenges/kaprekar-numbers)
# Problem statement
A modified Kaprekar number is a positive whole number with a special property.  If you square it, then split the number into two integers and sum those integers, you have the same value you started with.

Consider a positive whole number ![](./Resources/Element1.svg) with ![](./Resources/Element2.svg) digits.  We square ![](./Resources/Element1.svg) to arrive at a number that is either ![](./Resources/Element3.svg) digits long or ![](./Resources/Element4.svg) digits long.  Split the string representation of the square into two parts, ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg).  The right hand part, ![](./Resources/Element6.svg) must be ![](./Resources/Element2.svg) digits long.  The left is the remaining substring.  Convert those two substrings back to integers, add them and see if you get ![](./Resources/Element1.svg).

For example, if ![](./Resources/Element7.svg), ![](./Resources/Element8.svg) then ![](./Resources/Element9.svg). We split that into two strings and convert them back to integers ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg).  We test ![](./Resources/Element12.svg), so this is not a modified Kaprekar number.  If ![](./Resources/Element13.svg), still ![](./Resources/Element8.svg), and ![](./Resources/Element14.svg).  This gives us ![](./Resources/Element15.svg), the original ![](./Resources/Element1.svg). 


**Note:** r may have leading zeros.  

Here's an explanation from Wikipedia about the 
**ORIGINAL** [Kaprekar Number](https://en.wikipedia.org/wiki/Kaprekar_number) (spot the difference!):  

> In mathematics, a Kaprekar number for a given base is a non-negative integer, the representation of whose square in that base can be split into two parts that add up to the original number again. For instance, 45 is a Kaprekar number, because 45² = 2025 and 20+25 = 45.

Given two positive integers ![](./Resources/Element16.svg) and ![](./Resources/Element17.svg) where ![](./Resources/Element16.svg) is lower than ![](./Resources/Element17.svg), write a program to print the modified Kaprekar numbers in the range between ![](./Resources/Element16.svg) and ![](./Resources/Element17.svg), inclusive.


**Function Description**

Complete the kaprekarNumbers function in the editor below.  It should print the list of modified Kaprekar numbers in ascending order.  

kaprekarNumbers has the following parameter(s):  


* p: an integer   
* q: an integer   





**Input Format**


The first line contains the lower integer limit ![](./Resources/Element16.svg). 


The second line contains the upper integer limit ![](./Resources/Element17.svg).  


**Note**: Your range should be inclusive of the limits.





**Constraints**


![](./Resources/Element18.svg)





**Output Format**


Output each modified Kaprekar number in the given range, space-separated on a single line. If no modified Kaprekar numbers exist in the given range, print ```INVALID RANGE```.





**Sample Input**


```
1
100
```




**Sample Output**


1 9 45 55 99  





**Explanation**


![](./Resources/Element19.svg), ![](./Resources/Element20.svg), ![](./Resources/Element21.svg), ![](./Resources/Element22.svg), and ![](./Resources/Element23.svg) are the Kaprekar Numbers in the given range.





