[Source](https://www.hackerrank.com/challenges/strange-advertising)
# Problem statement
HackerLand Enterprise is adopting a new viral advertising strategy. When they launch a new product, they advertise it to exactly ![](./Resources/Element1.svg) people on social media. 

On the first day, half of those ![](./Resources/Element1.svg) people (i.e., ![](./Resources/Element2.svg)) like the advertisement and each shares it with ![](./Resources/Element3.svg) of their friends. At the beginning of the second day, ![](./Resources/Element4.svg) people receive the advertisement. 

Each day, ![](./Resources/Element5.svg) of the recipients like the advertisement and will share it with ![](./Resources/Element3.svg) friends on the following day.  Assuming nobody receives the advertisement twice, determine how many people have liked the ad by the end of a given day, beginning with launch day as day ![](./Resources/Element6.svg).

For example, assume you want to know how many have liked the ad by the end of the ![](./Resources/Element7.svg) day.

```
Day
Shared
Liked
Cumulative
1
5
2
2
2
6
3
5
3
9
4
9
4
12
6
15
5
18
9
24
```
The cumulative number of likes is ![](./Resources/Element8.svg).  


**Function Description**  

Complete the viralAdvertising function in the editor below.  It should return the cumulative number of people who have liked the ad at a given time.  

viralAdvertising has the following parameter(s):  


* n: the integer number of days  

**Input Format**

A single integer, ![](./Resources/Element9.svg), denoting a number of days.


**Constraints**


* ![](./Resources/Element10.svg)

**Output Format**

Print the number of people who liked the advertisement during the first ![](./Resources/Element9.svg) days.


**Sample Input**

```
3
```

**Sample Output**

```
9
```

**Explanation**

This example is depicted in the following diagram:  

![](./Resources/1475677928-3788004924-strangead.png)

![](./Resources/Element11.svg) people liked the advertisement on the first day, ![](./Resources/Element3.svg) people liked the advertisement on the second day and ![](./Resources/Element12.svg) people liked the advertisement on the third day, so the answer is ![](./Resources/Element13.svg).

