[Source](https://www.hackerrank.com/challenges/acm-icpc-team)
# Problem statement
There are a number of people who will be attending [ACM-ICPC World Finals](https://en.wikipedia.org/wiki/ACM_International_Collegiate_Programming_Contest). Each of them may be well versed in a number of topics. Given a list of topics known by each attendee, you must determine the maximum number of topics a 2-person team can know. Also find out how many ways a team can be formed to know that many topics.  Lists will be in the form of bit strings, where each string represents an attendee and each position in that string represents a field of knowledge, 1 if its a known field or 0 if not.

For example, given three attendees' data as follows:

```
10101
11110
00010
```
These are all possible teams that can be formed:

```
Members Subjects
(1,2)   [1,2,3,4,5]
(1,3)   [1,3,4,5]
(2,3)   [1,2,3,4]
```
In this case, the first team will know all 5 subjects.  They are the only team that can be created knowing that many subjects.


**Function Description**  

Complete the acmTeam function in the editor below.  It should return an integer array with two elements: the maximum number of topics any team can know and the number of teams that can be formed that know that maximum number of topics.  

acmTeam has the following parameter(s):  


* topic: a string of binary digits  

**Input Format**

The first line contains two space-separated integers ![](./Resources/Element1.svg) and ![](./Resources/Element2.svg), where ![](./Resources/Element1.svg) represents the number of attendees and ![](./Resources/Element2.svg) represents the number of topics.  

Each of the next ![](./Resources/Element1.svg) lines contains a binary string of length ![](./Resources/Element2.svg). If the ![](./Resources/Element3.svg)<sup>th</sup> line's ![](./Resources/Element4.svg)<sup>th</sup> character is ![](./Resources/Element5.svg), then the ![](./Resources/Element3.svg)<sup>th</sup> person knows the ![](./Resources/Element4.svg)<sup>th</sup> topic.


**Constraints**

![](./Resources/Element6.svg) 


![](./Resources/Element7.svg) 


**Output Format**

On the first line, print the maximum number of topics a 2-person team can know. 


On the second line, print the number of ways to form a 2-person team that knows the maximum number of topics.


**Sample Input**

```
4 5
10101
11100
11010
00101
```

**Sample Output**

```
5
2
```

**Explanation**

Calculating topics known for all permutations of 2 attendees we get:  

![](./Resources/Element8.svg) 


![](./Resources/Element9.svg) 


![](./Resources/Element10.svg) 


![](./Resources/Element11.svg) 


![](./Resources/Element12.svg) 


![](./Resources/Element13.svg)  

The 2 teams (1, 3) and (3, 4) know all 5 topics which is maximal.

