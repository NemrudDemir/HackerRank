[Source](https://www.hackerrank.com/challenges/tutorial-intro/problem)
# Problem statement

**About Tutorial Challenges**


Many of the challenges on HackerRank are difficult and assume that you already know the relevant algorithms. These tutorial challenges are different. They break down algorithmic concepts into smaller challenges so that you can learn the algorithm by solving them.  They are intended for those who already know some programming, however. You could be a student majoring in computer science, a self-taught programmer, or an experienced developer who wants an active algorithms review.  Here's a great place to learn by doing!

The first series of challenges covers sorting. They are listed below:


**Tutorial Challenges - Sorting**

Insertion Sort challenges


* [Insertion Sort 1 - Inserting](https://www.hackerrank.com/challenges/insertionsort1)
* [Insertion Sort 2 - Sorting](https://www.hackerrank.com/challenges/insertionsort2)
* [Correctness and loop invariant](https://www.hackerrank.com/challenges/correctness-invariant)
* [Running Time of Algorithms](https://www.hackerrank.com/challenges/runningtime)

Quicksort challenges


* [Quicksort 1 - Partition](https://www.hackerrank.com/challenges/quicksort1)
* [Quicksort 2 - Sorting](https://www.hackerrank.com/challenges/quicksort2)
* [Quicksort In-place (advanced)](https://www.hackerrank.com/challenges/quicksort3)
* [Running time of Quicksort](https://www.hackerrank.com/challenges/quicksort4)

Counting sort challenges


* [Counting Sort 1 - Counting](https://www.hackerrank.com/challenges/countingsort1)
* [Counting Sort 2 - Simple sort](https://www.hackerrank.com/challenges/countingsort2)
* [Counting Sort 3 - Preparing](https://www.hackerrank.com/challenges/countingsort3)
* [Full Counting Sort (advanced)](https://www.hackerrank.com/challenges/countingsort4)

There will also be some challenges where you'll get to apply what you've learned using the completed algorithms.


**About the Challenges**


Each challenge will describe a scenario and you will code a solution. As you progress through the challenges, you will learn some important concepts in algorithms. In each challenge, you will receive input on [STDIN](http://en.wikipedia.org/wiki/Standard_streams#Standard_input_.28stdin.29) and you will need to print the correct output to STDOUT.  

There may be time limits that will force you to make your code efficient.  If you receive a "Terminated due to time out" message when you submit your solution, you'll need to reconsider your method.  If you want to test your code locally, each test case can be downloaded, inputs and expected results, using hackos.  You earn hackos as you solve challenges, and you can spend them on these tests.

For many challenges, helper methods (like an array) will be provided for you to process the input into a useful format. You can use these methods to get started with your program, or you can write your own input methods if you want. Your code just needs to print the right output to each test case. 


**Sample Challenge**


This is a simple challenge to get things started. Given a sorted array (![](./Resources/Element1.svg)) and a number (![](./Resources/Element2.svg)), can you print the index location of ![](./Resources/Element2.svg) in the array? 


**Example**

![](./Resources/Element3.svg)

![](./Resources/Element4.svg)

Return ![](./Resources/Element5.svg) for a zero-based index array.  

If you are going to use the provided code for I/O, this next section is for you.


**Function Description**

Complete the introTutorial function in the editor below.  It must return an integer representing the zero-based index of ![](./Resources/Element2.svg).  

introTutorial has the following parameter(s):


* int arr[n]: a sorted array of integers  
* int V: an integer to search for  


**Returns**


* int: the index of ![](./Resources/Element2.svg) in ![](./Resources/Element1.svg)

The next section describes the input format. You can often skip it, if you are using included methods or code stubs.


**Input Format**

The first line contains an integer, ![](./Resources/Element2.svg), a value to search for. 


The next line contains an integer, ![](./Resources/Element6.svg), the size of ![](./Resources/Element1.svg).
The last line contains ![](./Resources/Element6.svg) space-separated integers, each a value of ![](./Resources/Element7.svg) where ![](./Resources/Element8.svg).  

The next section describes the constraints and ranges of the input. You should check this section to know the range of the input.


**Constraints**


* ![](./Resources/Element9.svg)
* ![](./Resources/Element10.svg)
* ![](./Resources/Element2.svg) will occur in ![](./Resources/Element1.svg) exactly once.

This "sample" shows the first input test case. It is often useful to go through the sample to understand a challenge.


**Sample Input 0**

```
STDIN           Function
-----           --------
4               V = 4
6               arr[] size n = 6 (not passed, see function description parameters)
1 4 5 7 9 12    arr = [1, 4, 5, 7, 9, 12]
```

**Sample Output 0**

```
1
```

**Explanation 0**

![](./Resources/Element11.svg). The value ![](./Resources/Element12.svg) is the ![](./Resources/Element13.svg) element in the array.  Its index is ![](./Resources/Element14.svg) since the array indices start from ![](./Resources/Element15.svg) (see array definition under Input Format).