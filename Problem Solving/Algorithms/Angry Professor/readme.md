[Source](https://www.hackerrank.com/challenges/angry-professor)
# Problem statement
A Discrete Mathematics professor has a class of students. Frustrated with their lack of discipline, he decides to cancel class if fewer than some number of students are present when class starts.  Arrival times go from on time (![](./Resources/Element1.svg)) to arrived late (![](./Resources/Element2.svg)).

Given the arrival time of each student and a threshhold number of attendees, determine if the class is canceled.


**Input Format**

The first line of input contains ![](./Resources/Element3.svg), the number of test cases. 

Each test case consists of two lines.  

The first line has two space-separated integers, ![](./Resources/Element4.svg) and ![](./Resources/Element5.svg), the number of students (size of ![](./Resources/Element6.svg)) and the cancellation threshold. 


The second line contains ![](./Resources/Element4.svg) space-separated integers (![](./Resources/Element7.svg)) describing the arrival times for each student.


**Note:** Non-positive arrival times (![](./Resources/Element8.svg)) indicate the student arrived early or on time; positive arrival times (![](./Resources/Element9.svg)) indicate the student arrived ![](./Resources/Element10.svg) minutes late.

For example, there are ![](./Resources/Element11.svg) students who arrive at times ![](./Resources/Element12.svg).  Four are there on time, and two arrive late.  If there must be ![](./Resources/Element13.svg) for class to go on, in this case the class will continue.  If there must be ![](./Resources/Element14.svg), then class is cancelled.  


**Function Description**

Complete the angryProfessor function in the editor below.  It must return ```YES``` if class is cancelled, or ```NO``` otherwise.  

angryProfessor has the following parameter(s):  


* k: the threshold number of students  
* a: an array of integers representing arrival times  

**Constraints**


* ![](./Resources/Element15.svg)  
* ![](./Resources/Element16.svg)  
* ![](./Resources/Element17.svg)  
* ![](./Resources/Element18.svg)

**Output Format**

For each test case, print the word ```YES``` if the class is canceled or ```NO``` if it is not. 


**Note** 


If a student arrives exactly on time ![](./Resources/Element19.svg), the student is considered to have entered before the class started.


**Sample Input**

```
2
4 3
-1 -3 4 2
4 2
0 -1 2 1
```

**Sample Output**

```
YES
NO
```

**Explanation**

For the first test case, ![](./Resources/Element20.svg). The professor wants at least ![](./Resources/Element21.svg) students in attendance, but only ![](./Resources/Element22.svg) have arrived on time (![](./Resources/Element23.svg) and ![](./Resources/Element24.svg)) so the class is cancelled.

For the second test case, ![](./Resources/Element25.svg). The professor wants at least ![](./Resources/Element22.svg) students in attendance, and there are ![](./Resources/Element22.svg) who have arrived on time (![](./Resources/Element26.svg) and ![](./Resources/Element24.svg)) so the class is not cancelled.

