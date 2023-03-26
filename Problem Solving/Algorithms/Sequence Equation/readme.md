[Source](https://www.hackerrank.com/challenges/permutation-equation)
# Problem statement
Given a sequence of ![](./Resources/Element1.svg) integers, ![](./Resources/Element2.svg) where each element is distinct and satisfies ![](./Resources/Element3.svg). For each ![](./Resources/Element4.svg) where ![](./Resources/Element5.svg), find any integer ![](./Resources/Element6.svg) such that ![](./Resources/Element7.svg) and print the value of ![](./Resources/Element6.svg) on a new line.

For example, assume the sequence ![](./Resources/Element8.svg).  Each value of ![](./Resources/Element4.svg) between ![](./Resources/Element9.svg) and ![](./Resources/Element10.svg), the length of the sequence, is analyzed as follows:


1. ![](./Resources/Element11.svg), so ![](./Resources/Element12.svg)
2. ![](./Resources/Element13.svg), so ![](./Resources/Element14.svg)
3. ![](./Resources/Element15.svg), so ![](./Resources/Element16.svg)
4. ![](./Resources/Element17.svg), so ![](./Resources/Element18.svg)
5. ![](./Resources/Element19.svg), so ![](./Resources/Element20.svg)
The values for ![](./Resources/Element6.svg) are ![](./Resources/Element21.svg).  


**Function Description**  

Complete the permutationEquation function in the editor below.  It should return an array of integers that represent the values of ![](./Resources/Element6.svg).  

permutationEquation has the following parameter(s):  


* p: an array of integers  

**Input Format**

The first line contains an integer ![](./Resources/Element1.svg), the number of elements in the sequence. 


The second line contains ![](./Resources/Element1.svg) space-separated integers ![](./Resources/Element22.svg) where ![](./Resources/Element23.svg).


**Constraints**


* ![](./Resources/Element24.svg)
* ![](./Resources/Element25.svg), where ![](./Resources/Element23.svg).
* Each element in the sequence is distinct.

**Output Format**

For each ![](./Resources/Element4.svg) from ![](./Resources/Element9.svg) to ![](./Resources/Element1.svg), print an integer denoting any valid ![](./Resources/Element6.svg) satisfying the equation ![](./Resources/Element7.svg) on a new line.


**Sample Input 0**

```
3
2 3 1
```

**Sample Output 0**

```
2
3
1
```

**Explanation 0**

Given the values of ![](./Resources/Element26.svg), ![](./Resources/Element27.svg), and ![](./Resources/Element28.svg), we calculate and print the following values for each ![](./Resources/Element4.svg) from ![](./Resources/Element9.svg) to ![](./Resources/Element1.svg):


1. ![](./Resources/Element29.svg), so we print the value of ![](./Resources/Element30.svg) on a new line.
2. ![](./Resources/Element31.svg), so we print the value of ![](./Resources/Element32.svg) on a new line.
3. ![](./Resources/Element33.svg), so we print the value of ![](./Resources/Element34.svg) on a new line.

**Sample Input 1**

```
5
4 3 5 1 2
```

**Sample Output 1**

```
1
3
5
4
2
```
