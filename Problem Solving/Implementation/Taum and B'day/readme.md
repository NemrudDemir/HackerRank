[Source](https://www.hackerrank.com/challenges/taum-and-bday)
# Problem statement
Taum is planning to celebrate the birthday of his friend, Diksha. There are two types of gifts that Diksha wants from Taum: one is black and the other is white. To make her happy, Taum has to buy ![](./Resources/Element1.svg) black gifts and ![](./Resources/Element2.svg) white gifts. 


* The cost  of each black gift is ![](./Resources/Element3.svg) units.  
* The cost of every white gift is ![](./Resources/Element4.svg) units.  
* The cost of converting each black gift into white gift or vice versa is ![](./Resources/Element5.svg) units.  

Help Taum by deducing the minimum amount he needs to spend on Diksha's gifts.  

For example, if Taum wants to buy ![](./Resources/Element6.svg) black gifts and ![](./Resources/Element7.svg) white gifts at a cost of ![](./Resources/Element8.svg) and conversion cost ![](./Resources/Element9.svg), we see that he can buy a black gift for ![](./Resources/Element10.svg) and convert it to a white gift for ![](./Resources/Element11.svg), making the total cost of each white gift ![](./Resources/Element12.svg).  That matches the cost of a white gift, so he can do that or just buy black gifts and white gifts.  Either way, the overall cost is ![](./Resources/Element13.svg).  


**Function Description**  

Complete the function taumBday in the editor below.  It should return the minimal cost of obtaining the desired gifts.  

taumBday has the following parameter(s):  


* b: the number of black gifts  
* w: the number of white gifts  
* bc: the cost of a black gift  
* wc: the cost of a white gift  
* z: the cost to convert one color gift to the other color  


**Input Format**

The first line will contain an integer ![](./Resources/Element14.svg), the number of test cases. 

The next ![](./Resources/Element14.svg) pairs of lines are as follows: 


- The first line contains the values of integers ![](./Resources/Element1.svg) and ![](./Resources/Element2.svg). 


- The next line contains the values of integers ![](./Resources/Element3.svg), ![](./Resources/Element4.svg), and ![](./Resources/Element5.svg).  


**Constraints**

![](./Resources/Element15.svg) 


![](./Resources/Element16.svg)


**Output Format**

![](./Resources/Element14.svg) lines, each containing an integer: the minimum amount of units Taum needs to spend on gifts.


**Sample Input**

```
5
10 10
1 1 1
5 9
2 3 4
3 6
9 1 1
7 7
4 2 1
3 3
1 9 2
```

**Sample Output**

```
20
37
12
35
12
```

**Explanation**


* Test Case #01: 
Since black gifts cost the same as white, there is no benefit to converting the gifts.  Taum will have to buy each gift for 1 unit.  The cost of buying all gifts will be: ![](./Resources/Element17.svg).  


* Test Case #02: 
Again, we can't decrease the cost of black or white gifts by converting colors. ![](./Resources/Element5.svg) is too high.  We will buy gifts at their original prices, so the cost of buying all gifts will be: ![](./Resources/Element18.svg). 


* Test Case #03: 
Since ![](./Resources/Element19.svg), we will buy ![](./Resources/Element20.svg) white gifts at their original price of ![](./Resources/Element11.svg). ![](./Resources/Element6.svg) of the gifts must be black, and the cost per conversion, ![](./Resources/Element9.svg).  Total cost is ![](./Resources/Element21.svg).


* Test Case #04: 
Similarly, we will buy ![](./Resources/Element22.svg) white gifts at their original price, ![](./Resources/Element23.svg). For black gifts, we will first buy white ones and color them to black, so that their cost will be reduced to ![](./Resources/Element24.svg). So cost of buying all gifts will be: ![](./Resources/Element25.svg).


* Test Case #05: 
We will buy black gifts at their original price, ![](./Resources/Element26.svg). For white gifts, we will first black gifts worth ![](./Resources/Element26.svg) unit and color them to white for ![](./Resources/Element27.svg) units.  The cost for white gifts is reduced to ![](./Resources/Element28.svg) units. The cost of buying all gifts will be: ![](./Resources/Element29.svg).