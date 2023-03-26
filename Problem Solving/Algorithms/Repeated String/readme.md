[Source](https://www.hackerrank.com/challenges/repeated-string/problem)
# Problem statement
Lilah has a string, ![](./Resources/Element1.svg), of lowercase English letters that she repeated infinitely many times.

Given an integer, ![](./Resources/Element2.svg), find and print the number of letter ```a```'s in the first ![](./Resources/Element2.svg) letters of Lilah's infinite string.

For example, if the string ![](./Resources/Element3.svg) and ![](./Resources/Element4.svg), the substring we consider is ![](./Resources/Element5.svg), the first ![](./Resources/Element6.svg) characters of her infinite string.  There are ![](./Resources/Element7.svg) occurrences of ```a``` in the substring.  


**Function Description**  

Complete the repeatedString function in the editor below.  It should return an integer representing the number of occurrences of ```a``` in the prefix of length ![](./Resources/Element2.svg) in the infinitely repeating string.  

repeatedString has the following parameter(s):  


* s: a string to repeat  
* n: the number of characters to consider  

**Input Format**

The first line contains a single string, ![](./Resources/Element1.svg). 


The second line contains an integer, ![](./Resources/Element2.svg).


**Constraints**


* ![](./Resources/Element8.svg)
* ![](./Resources/Element9.svg)
* For ![](./Resources/Element10.svg) of the test cases, ![](./Resources/Element11.svg).

**Output Format**

Print a single integer denoting the number of letter ```a```'s in the first ![](./Resources/Element2.svg) letters of the infinite string created by repeating ![](./Resources/Element1.svg) infinitely many times.


**Sample Input 0**

```
aba
10
```

**Sample Output 0**

```
7
```

**Explanation 0** 


The first ![](./Resources/Element4.svg) letters of the infinite string are ```abaabaabaa```. Because there are ![](./Resources/Element12.svg) ```a```'s, we print ![](./Resources/Element12.svg) on a new line.


**Sample Input 1**

```
a
1000000000000
```

**Sample Output 1**

```
1000000000000
```

**Explanation 1** 


Because all of the first ![](./Resources/Element13.svg) letters of the infinite string are ```a```, we print ![](./Resources/Element14.svg) on a new line.

