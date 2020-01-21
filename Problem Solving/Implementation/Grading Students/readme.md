[Source](https://www.hackerrank.com/challenges/grading)
# Problem statement
HackerLand University has the following grading policy:


* Every student receives a ![](./Resources/Element1.svg) in the inclusive range from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg).
* Any ![](./Resources/Element1.svg) less than ![](./Resources/Element4.svg) is a failing grade. 
Sam is a professor at the university and likes to round each student's ![](./Resources/Element1.svg) according to these rules:


* If the difference between the ![](./Resources/Element1.svg) and the next multiple of ![](./Resources/Element5.svg) is less than ![](./Resources/Element6.svg), round ![](./Resources/Element1.svg) up to the next multiple of ![](./Resources/Element5.svg).
* If the value of ![](./Resources/Element1.svg) is less than ![](./Resources/Element7.svg), no rounding occurs as the result will still be a failing grade.
For example, ![](./Resources/Element8.svg) will be rounded to ![](./Resources/Element9.svg) but ![](./Resources/Element10.svg) will not be rounded because the rounding would result in a number that is less than ![](./Resources/Element4.svg).  

Given the initial value of ![](./Resources/Element1.svg) for each of Sam's ![](./Resources/Element11.svg) students, write code to automate the rounding process.   


**Function Description**  

Complete the function gradingStudents in the editor below.  It should return an integer array consisting of rounded grades.  

gradingStudents has the following parameter(s):  


* grades:  an array of integers representing grades before rounding  

**Input Format**

The first line contains a single integer, ![](./Resources/Element11.svg), the number of students. 


Each line ![](./Resources/Element12.svg) of the ![](./Resources/Element11.svg) subsequent lines contains a single integer, ![](./Resources/Element13.svg), denoting student ![](./Resources/Element12.svg)'s grade.


**Constraints**


* ![](./Resources/Element14.svg)
* ![](./Resources/Element15.svg)

**Output Format**

For each ![](./Resources/Element13.svg), print the rounded grade on a new line.


**Sample Input 0**

```
4
73
67
38
33
```

**Sample Output 0**

```
75
67
40
33
```

**Explanation 0**

![](./Resources/1484768684-54439977a1-curving2.png)


1. Student ![](./Resources/Element16.svg) received a ![](./Resources/Element17.svg), and the next multiple of ![](./Resources/Element5.svg) from ![](./Resources/Element17.svg) is ![](./Resources/Element18.svg). Since ![](./Resources/Element19.svg), the student's grade is rounded to ![](./Resources/Element18.svg).
2. Student ![](./Resources/Element20.svg) received a ![](./Resources/Element21.svg), and the next multiple of ![](./Resources/Element5.svg) from ![](./Resources/Element21.svg) is ![](./Resources/Element22.svg). Since ![](./Resources/Element23.svg), the grade will not be modified and the student's final grade is ![](./Resources/Element21.svg).
3. Student ![](./Resources/Element6.svg) received a ![](./Resources/Element7.svg), and the next multiple of ![](./Resources/Element5.svg) from ![](./Resources/Element7.svg) is ![](./Resources/Element4.svg). Since ![](./Resources/Element24.svg), the student's grade will be rounded to ![](./Resources/Element4.svg).
4. Student ![](./Resources/Element25.svg) received a grade below ![](./Resources/Element7.svg), so the grade will not be modified and the student's final grade is ![](./Resources/Element26.svg).
