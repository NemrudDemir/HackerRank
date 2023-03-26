[Source](https://www.hackerrank.com/challenges/append-and-delete)
# Problem statement
You have a string of lowercase English alphabetic letters. You can perform two types of operations on the string:


1. Append a lowercase English alphabetic letter to the end of the string.
2. Delete the last character in the string. Performing this operation on an empty string results in an empty string.
Given an integer, ![](./Resources/Element1.svg), and two strings, ![](./Resources/Element2.svg) and ![](./Resources/Element3.svg), determine whether or not you can convert ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg) by performing exactly ![](./Resources/Element1.svg) of the above operations on ![](./Resources/Element2.svg). If it's possible, print ```Yes```.  Otherwise, print ```No```.

For example, strings ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg).  Our number of moves, ![](./Resources/Element6.svg).  To convert ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg), we first delete all of the characters in ![](./Resources/Element7.svg) moves.  Next we add each of the characters of ![](./Resources/Element3.svg) in order.  On the ![](./Resources/Element8.svg) move, you will have the matching string.  If there had been more moves available, they could have been eliminated by performing multiple deletions on an empty string.  If there were fewer than ![](./Resources/Element9.svg) moves, we would not have succeeded in creating the new string.  


**Function Description**  

Complete the appendAndDelete function in the editor below.  It should return a string, either ```Yes``` or ```No```.  

appendAndDelete has the following parameter(s):  


* s: the initial string  
* t: the desired string  
* k: an integer that represents the number of operations  

**Input Format**

The first line contains a string ![](./Resources/Element2.svg), the initial string. 


The second line contains a string ![](./Resources/Element3.svg), the desired final string. 


The third line contains an integer ![](./Resources/Element1.svg), the number of operations.


**Constraints**


* ![](./Resources/Element10.svg)
* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg)
* ![](./Resources/Element2.svg) and ![](./Resources/Element3.svg) consist of lowercase English alphabetic letters, ![](./Resources/Element13.svg).

**Output Format**

Print ```Yes``` if you can obtain string ![](./Resources/Element3.svg) by performing exactly ![](./Resources/Element1.svg) operations on ![](./Resources/Element2.svg). Otherwise, print ```No```.


**Sample Input 0**

```
hackerhappy
hackerrank
9
```

**Sample Output 0**

```
Yes
```

**Explanation 0**

We perform ![](./Resources/Element14.svg) delete operations to reduce string ![](./Resources/Element2.svg) to ```hacker```. Next, we perform ![](./Resources/Element15.svg) append operations (i.e., ```r```, ```a```, ```n```, and ```k```), to get ```hackerrank```. Because we were able to convert ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg) by performing exactly ![](./Resources/Element16.svg) operations, we print ```Yes```.


**Sample Input 1**

```
aba
aba
7
```

**Sample Output 1**

```
Yes
```

**Explanation 1**

We perform ![](./Resources/Element15.svg) delete operations to reduce string ![](./Resources/Element2.svg) to the empty string (recall that, though the string will be empty after ![](./Resources/Element7.svg) deletions, we can still perform a delete operation on an empty string to get the empty string). Next, we perform ![](./Resources/Element7.svg) append operations (i.e., ```a```, ```b```, and ```a```). Because we were able to convert ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg) by performing exactly ![](./Resources/Element17.svg) operations, we print ```Yes```.


**Sample Input 2**

```
ashley
ash
2
```

**Sample Output 2**

```
No
```

**Explanation 2**

To convert ```ashley``` to ```ash``` a minimum of ![](./Resources/Element7.svg) steps are needed. Hence we print ```No``` as answer. 

