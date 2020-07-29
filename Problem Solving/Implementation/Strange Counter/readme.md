[Source](https://www.hackerrank.com/challenges/strange-code?h_r=profile)
# Problem statement
Bob has a strange counter. At the first second, it displays the number ![](./Resources/Element1.svg). Each second, the number displayed by the counter decrements by ![](./Resources/Element2.svg) until it reaches ![](./Resources/Element2.svg). 

The counter counts down in cycles. In next second, the timer resets to ![](./Resources/Element3.svg) and continues counting down. The diagram below shows the counter values for each time ![](./Resources/Element4.svg) in the first three cycles:

![](./Resources/1469447349-bae87a5071-strange1.png)

Find and print the value displayed by the counter at time ![](./Resources/Element4.svg).  


**Function Description**

Complete the strangeCounter function in the editor below.  It should return the integer value displayed by the counter at time ![](./Resources/Element4.svg).  

strangeCounter has the following parameter(s):  


* t: an integer  





**Input Format**


A single integer denoting the value of ![](./Resources/Element4.svg).





**Constraints**



* ![](./Resources/Element5.svg)


**Subtask**


* ![](./Resources/Element6.svg) for ![](./Resources/Element7.svg) of the maximum score.





**Output Format**


Print the value displayed by the strange counter at the given time ![](./Resources/Element4.svg).





**Sample Input**


```
4
```




**Sample Output**


```
6
```




**Explanation**


Time ![](./Resources/Element8.svg) marks the beginning of the second cycle.  It is double the number displayed at the beginning of the first cycle:![](./Resources/Element9.svg). This is also shown in the diagram in the Problem Statement above.