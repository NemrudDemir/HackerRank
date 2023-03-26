[Source](https://www.hackerrank.com/challenges/between-two-sets)
# Problem statement
You will be given two arrays of integers and asked to determine all integers that satisfy the following two conditions:  


1. The elements of the first array are all factors of the integer being considered
2. The integer being considered is a factor of all elements of the second array
These numbers are referred to as being between the two arrays.  You must determine how many such numbers exist.

For example, given the arrays ![](./Resources/Element1.svg) and ![](./Resources/Element2.svg), there are two numbers between them: ![](./Resources/Element3.svg) and ![](./Resources/Element4.svg).  ![](./Resources/Element5.svg), ![](./Resources/Element6.svg), ![](./Resources/Element7.svg) and ![](./Resources/Element8.svg) for the first value.  Similarly, ![](./Resources/Element9.svg), ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg), ![](./Resources/Element12.svg).  


**Function Description**  

Complete the getTotalX function in the editor below.  It should return the number of integers that are betwen the sets.  

getTotalX has the following parameter(s):  


* a: an array of integers  
* b: an array of integers  

**Input Format**

The first line contains two space-separated integers, ![](./Resources/Element13.svg) and ![](./Resources/Element14.svg), the number of elements in array ![](./Resources/Element15.svg) and the number of elements in array ![](./Resources/Element16.svg). 


The second line contains ![](./Resources/Element13.svg) distinct space-separated integers describing ![](./Resources/Element17.svg) where ![](./Resources/Element18.svg). 


The third line contains ![](./Resources/Element14.svg) distinct space-separated integers describing ![](./Resources/Element19.svg) where ![](./Resources/Element20.svg).


**Constraints**


* ![](./Resources/Element21.svg)
* ![](./Resources/Element22.svg)
* ![](./Resources/Element23.svg)

**Output Format**

Print the number of integers that are considered to be between ![](./Resources/Element15.svg) and ![](./Resources/Element16.svg).


**Sample Input**

```
2 3
2 4
16 32 96
```

**Sample Output**

```
3
```

**Explanation**

2 and 4 divide evenly into 4, 8, 12 and 16. 


4, 8 and 16 divide evenly into 16, 32, 96.  

4, 8 and 16 are the only three numbers for which each element of a is a factor and each is a factor of all elements of b. 

