[Source](https://www.hackerrank.com/challenges/the-grid-search)
# Problem statement
Given a 2D array of digits or grid, try to find the occurrence of a given 2D pattern of digits. For example, consider the following grid:  



[//]: # (Use html instead of MD because MD doesnt support combination of 'code' and 'strong')
<pre>1234567890  
09<strong>876543</strong>21  
11<strong>111111</strong>11  
11<strong>111111</strong>11  
2222222222  
</pre>
Assume we need to look for the following 2D pattern array:  

```
876543  
111111  
111111
```
The 2D pattern begins at the second row and the third column of the grid.  The pattern is said to be present in the grid.  


**Function Description**

Complete the gridSearch function in the editor below.  It should return ```YES``` if the pattern exists in the grid, or ```NO``` otherwise.  

gridSearch has the following parameter(s):  


* G: the grid to search, an array of strings  
* P: the pattern to search for, an array of strings  





**Input Format**


The first line contains an integer ![](./Resources/Element1.svg), the number of test cases.   

Each of the ![](./Resources/Element1.svg) test cases is represented as follows: 


The first line contains two space-separated integers ![](./Resources/Element2.svg) and ![](./Resources/Element3.svg), indicating the number of rows and columns in the grid ![](./Resources/Element4.svg). 


This is followed by ![](./Resources/Element2.svg) lines, each with a string of ![](./Resources/Element3.svg) digits representing the grid ![](./Resources/Element4.svg). 


The following line contains two space-separated integers, ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg), indicating the number of rows and columns in the pattern grid ![](./Resources/Element7.svg). 


This is followed by ![](./Resources/Element5.svg) lines, each with a string of ![](./Resources/Element6.svg) digits representing the pattern ![](./Resources/Element7.svg).  





**Constraints**


![](./Resources/Element8.svg)

![](./Resources/Element9.svg)

![](./Resources/Element10.svg)

![](./Resources/Element11.svg)





**Output Format**


Display ```YES``` or ```NO```, depending on whether ![](./Resources/Element7.svg) is present in ![](./Resources/Element4.svg).





**Sample Input**


```
2
10 10
7283455864
6731158619
8988242643
3830589324
2229505813
5633845374
6473530293
7053106601
0834282956
4607924137
3 4
9505
3845
3530
15 15
400453592126560
114213133098692
474386082879648
522356951189169
887109450487496
252802633388782
502771484966748
075975207693780
511799789562806
404007454272504
549043809916080
962410809534811
445893523733475
768705303214174
650629270887160
2 2
99
99
```




**Sample Output**


```
YES
NO
```




**Explanation**


The first test in the input file is:  

```
10 10
7283455864
6731158619
8988242643
3830589324
2229505813
5633845374
6473530293
7053106601
0834282956
4607924137
3 4
9505
3845
3530
```
As one may see, the given pattern is present in the larger grid, as marked in bold below.  



[//]: # (Use html instead of MD because MD doesnt support combination of 'code' and 'strong')
<pre>7283455864  
6731158619  
8988242643  
3830589324  
222<strong>9505</strong>813  
563<strong>3845</strong>374  
647<strong>3530</strong>293  
7053106601  
0834282956  
4607924137  
</pre>
The second test in the input file is:  

```
15 15
400453592126560
114213133098692
474386082879648
522356951189169
887109450487496
252802633388782
502771484966748
075975207693780
511799789562806
404007454272504
549043809916080
962410809534811
445893523733475
768705303214174
650629270887160
2 2
99
99

```
The search pattern is:  

```
99
99
```
This cannot be found in the larger grid.