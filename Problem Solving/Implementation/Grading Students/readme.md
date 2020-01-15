[Source](https://www.hackerrank.com/challenges/grading)
# Problem statement
HackerLand University has the following grading policy:


* Every student receives a ![](./Resources/Element1.svg) in the inclusive range from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg).
* Any ![](./Resources/Element4.svg) less than ![](./Resources/Element5.svg) is a failing grade. 
Sam is a professor at the university and likes to round each student's ![](./Resources/Element6.svg) according to these rules:


* If the difference between the ![](./Resources/Element7.svg) and the next multiple of ![](./Resources/Element8.svg) is less than ![](./Resources/Element9.svg), round ![](./Resources/Element10.svg) up to the next multiple of ![](./Resources/Element11.svg).
* If the value of ![](./Resources/Element12.svg) is less than ![](./Resources/Element13.svg), no rounding occurs as the result will still be a failing grade.
For example, ![](./Resources/Element14.svg) will be rounded to ![](./Resources/Element15.svg) but ![](./Resources/Element16.svg) will not be rounded because the rounding would result in a number that is less than ![](./Resources/Element17.svg).  

Given the initial value of ![](./Resources/Element18.svg) for each of Sam's ![](./Resources/Element19.svg) students, write code to automate the rounding process.   


**Function Description**  

Complete the function gradingStudents in the editor below.  It should return an integer array consisting of rounded grades.  

gradingStudents has the following parameter(s):  


* grades:  an array of integers representing grades before rounding  

**Input Format**

The first line contains a single integer, ![](./Resources/Element20.svg), the number of students. 


Each line ![](./Resources/Element21.svg) of the ![](./Resources/Element22.svg) subsequent lines contains a single integer, ![](./Resources/Element23.svg), denoting student ![](./Resources/Element24.svg)'s grade.


**Constraints**


* ![](./Resources/Element25.svg)
* ![](./Resources/Element26.svg)

**Output Format**

For each ![](./Resources/Element27.svg), print the rounded grade on a new line.


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


1. Student ![](./Resources/Element28.svg) received a ![](./Resources/Element29.svg), and the next multiple of ![](./Resources/Element30.svg) from ![](./Resources/Element31.svg) is ![](./Resources/Element32.svg). Since ![](./Resources/Element33.svg), the student's grade is rounded to ![](./Resources/Element34.svg).
2. Student ![](./Resources/Element35.svg) received a ![](./Resources/Element36.svg), and the next multiple of ![](./Resources/Element37.svg) from ![](./Resources/Element38.svg) is ![](./Resources/Element39.svg). Since ![](./Resources/Element40.svg), the grade will not be modified and the student's final grade is ![](./Resources/Element41.svg).
3. Student ![](./Resources/Element42.svg) received a ![](./Resources/Element43.svg), and the next multiple of ![](./Resources/Element44.svg) from ![](./Resources/Element45.svg) is ![](./Resources/Element46.svg). Since ![](./Resources/Element47.svg), the student's grade will be rounded to ![](./Resources/Element48.svg).
4. Student ![](./Resources/Element49.svg) received a grade below ![](./Resources/Element50.svg), so the grade will not be modified and the student's final grade is ![](./Resources/Element51.svg).
