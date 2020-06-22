[Source](https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem)
# Problem statement
David has several containers, each with a number of balls in it.  He has just enough containers to sort each type of ball he has into its own container.  David wants to sort the balls using his sort method.

As an example, David has ![](./Resources/Element1.svg) containers and ![](./Resources/Element2.svg) different types of balls, both of which are numbered from ![](./Resources/Element3.svg) to ![](./Resources/Element4.svg). The distribution of ball types per container are described by an ![](./Resources/Element5.svg) matrix of integers, ![](./Resources/Element6.svg). For example, consider the following diagram for ![](./Resources/Element7.svg):

![](./Resources/1485811368-9e78c98652-swapping-balls.png)

In a single operation, David can swap two balls located in different containers.

The diagram below depicts a single swap operation:

![](./Resources/1485811849-e97b84e218-swapping-balls-ps-1.png)

David wants to perform some number of swap operations such that:


* Each container contains only balls of the same type.
* No two balls of the same type are located in different containers.

You must perform ![](./Resources/Element8.svg) queries where each query is in the form of a matrix, ![](./Resources/Element9.svg). For each query, print ```Possible``` on a new line if David can satisfy the conditions above for the given matrix.  Otherwise, print ```Impossible```.  


**Function Description**  

Complete the organizingContainers function in the editor below.  It should return a string, either ```Possible``` or ```Impossible```.  

organizingContainers has the following parameter(s):  


* containter: a two dimensional array of integers that represent the number of balls of each color in each container  


**Input Format**

The first line contains an integer ![](./Resources/Element8.svg), the number of queries.  

Each of the next ![](./Resources/Element8.svg) sets of lines is as follows:  


1. The first line contains an integer ![](./Resources/Element10.svg), the number of containers (rows) and ball types (columns).        
2. Each of the next ![](./Resources/Element10.svg) lines contains ![](./Resources/Element10.svg) space-separated integers describing row ![](./Resources/Element11.svg).

**Constraints**


* ![](./Resources/Element12.svg)  
* ![](./Resources/Element13.svg)  
* ![](./Resources/Element14.svg)


**Scoring**


* For ![](./Resources/Element15.svg) of score, ![](./Resources/Element16.svg).  
* For ![](./Resources/Element17.svg) of score, ![](./Resources/Element13.svg).


**Output Format**

For each query, print ```Possible``` on a new line if David can satisfy the conditions above for the given matrix.  Otherwise, print ```Impossible```.


**Sample Input 0**

```
2
2
1 1
1 1
2
0 2
1 1
```

**Sample Output 0**

```
Possible
Impossible
```

**Explanation 0**

We perform the following ![](./Resources/Element18.svg) queries:


1. The diagram below depicts one possible way to satisfy David's requirements for the first query:
![](./Resources/1485813936-37f8a37dad-swapping-balls-sample-0-0.png) 
Thus, we print ```Possible``` on a new line.
2. The diagram below depicts the matrix for the second query:
![](./Resources/1485814141-d283776840-swapping-balls-sample-0-2.png) 
No matter how many times we swap balls of type ![](./Resources/Element19.svg) and ![](./Resources/Element20.svg) between the two containers, we'll never end up with one container only containing type ![](./Resources/Element19.svg) and the other container only containing type ![](./Resources/Element20.svg). Thus, we print ```Impossible``` on a new line.

**Sample Input 1**

```
2
3
1 3 1
2 1 2
3 3 3
3
0 2 1
1 1 1
2 0 0
```

**Sample Output 1**

```
Impossible
Possible
```
