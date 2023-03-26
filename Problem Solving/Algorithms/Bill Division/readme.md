[Source](https://www.hackerrank.com/challenges/bon-appetit)
# Problem statement
Anna and Brian are sharing a meal at a restuarant and they agree to split the bill equally.  Brian wants to order something that Anna is allergic to though, and they agree that Anna won't pay for that item.  Brian gets the check and calculates Anna's portion.  You must determine if his calculation is correct.

For example, assume the bill has the following prices: ![](./Resources/Element1.svg).  Anna declines to eat item ![](./Resources/Element2.svg) which costs ![](./Resources/Element3.svg).  If Brian calculates the bill correctly, Anna will pay ![](./Resources/Element4.svg).  If he includes the cost of ![](./Resources/Element5.svg), he will calculate ![](./Resources/Element6.svg).  In the second case, he should refund ![](./Resources/Element7.svg) to Anna.


**Function Description**  

Complete the bonAppetit function in the editor below.  It should print ```Bon Appetit``` if the bill is fairly split.  Otherwise, it should print the integer amount of money that Brian owes Anna.  

bonAppetit has the following parameter(s):  


* bill: an array of integers representing the cost of each item ordered  
* k: an integer representing the zero-based index of the item Anna doesn't eat  
* b: the amount of money that Anna contributed to the bill  

**Input Format**

The first line contains two space-separated integers ![](./Resources/Element8.svg) and ![](./Resources/Element9.svg), the number of items ordered and the ![](./Resources/Element10.svg)-based index of the item that Anna did not eat. 


The second line contains ![](./Resources/Element8.svg) space-separated integers ![](./Resources/Element11.svg) where ![](./Resources/Element12.svg). 


The third line contains an integer, ![](./Resources/Element13.svg), the amount of money that Brian charged Anna for her share of the bill.


**Constraints**


* ![](./Resources/Element14.svg)  
* ![](./Resources/Element15.svg)  
* ![](./Resources/Element16.svg)  
* ![](./Resources/Element17.svg)    
* The amount of money due Anna will always be an integer  

**Output Format**

If Brian did not overcharge Anna, print ```Bon Appetit``` on a new line; otherwise, print the difference (i.e., ![](./Resources/Element18.svg)) that Brian must refund to Anna.  This will always be an integer.  


**Sample Input 0**  

```
4 1
3 10 2 9
12
```

**Sample Output 0**  

```
5
```

**Explanation 0** 


Anna didn't eat item ![](./Resources/Element19.svg), but she shared the rest of the items with Brian. The total cost of the shared items is ![](./Resources/Element20.svg) and, split in half, the cost per person is ![](./Resources/Element21.svg). Brian charged her ![](./Resources/Element22.svg) for her portion of the bill. We print the amount Anna was overcharged, ![](./Resources/Element23.svg), on a new line.


**Sample Input 1**  

```
4 1
3 10 2 9
7
```

**Sample Output 1**  

```
Bon Appetit
```

**Explanation 1** 


Anna didn't eat item ![](./Resources/Element19.svg), but she shared the rest of the items with Brian. The total cost of the shared items is ![](./Resources/Element20.svg) and, split in half, the cost per person is ![](./Resources/Element21.svg). Because ![](./Resources/Element24.svg), we print ```Bon Appetit``` on a new line.  

