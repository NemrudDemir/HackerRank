[Source](https://www.hackerrank.com/challenges/beautiful-days-at-the-movies)
# Problem statement
Lily likes to play games with integers.  She has created a new game where she determines the difference between a number and its reverse.  For instance, given the number ![](./Resources/Element1.svg), its reverse is ![](./Resources/Element2.svg).  Their difference is ![](./Resources/Element3.svg).  The number ![](./Resources/Element4.svg) reversed is ![](./Resources/Element2.svg), and their difference is ![](./Resources/Element5.svg).

She decides to apply her game to decision making.  She will look at a numbered range of days and will only go to a movie on a beautiful day.

Given a range of numbered days, ![](./Resources/Element6.svg) and a number ![](./Resources/Element7.svg), determine the number of days in the range that are beautiful.  Beautiful numbers are defined as numbers where ![](./Resources/Element8.svg) is evenly divisible by ![](./Resources/Element7.svg).  If a day's value is a beautiful number, it is a beautiful day.  Print the number of beautiful days in the range.


**Function Description**  

Complete the beautifulDays function in the editor below.  It must return the number of beautiful days in the range.  

beautifulDays has the following parameter(s):  


* i: the starting day number  
* j: the ending day number  
* k: the divisor  

**Input Format**

A single line of three space-separated integers describing the respective values of ![](./Resources/Element9.svg), ![](./Resources/Element10.svg), and ![](./Resources/Element7.svg).


**Constraints**


* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg)

**Output Format**

Print the number of beautiful days in the inclusive range between ![](./Resources/Element9.svg) and ![](./Resources/Element10.svg).


**Sample Input**

```
20 23 6
```

**Sample Output**

```
2
```

**Explanation**

Lily may go to the movies on days ![](./Resources/Element13.svg), ![](./Resources/Element2.svg), ![](./Resources/Element14.svg), and ![](./Resources/Element15.svg). We perform the following calculations to determine which days are beautiful:


* Day ![](./Resources/Element13.svg) is beautiful because the following evaluates to a whole number: ![](./Resources/Element16.svg)
* Day ![](./Resources/Element2.svg) is not beautiful because the following doesn't evaluate to a whole number: ![](./Resources/Element17.svg)
* Day ![](./Resources/Element14.svg) is beautiful because the following evaluates to a whole number: ![](./Resources/Element18.svg)
* Day ![](./Resources/Element15.svg) is not beautiful because the following doesn't evaluate to a whole number: ![](./Resources/Element19.svg)
Only two days, ![](./Resources/Element13.svg) and ![](./Resources/Element14.svg), in this interval are beautiful. Thus, we print ![](./Resources/Element20.svg) as our answer.

