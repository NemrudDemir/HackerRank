[Source](https://www.hackerrank.com/challenges/electronics-shop/problem)
# Problem statement
Monica wants to buy a keyboard and a USB drive from her favorite electronics store. The store has several models of each.  Monica wants to spend as much as possible for the ![](./Resources/Element1.svg) items, given her budget.

Given the price lists for the store's keyboards and USB drives, and Monica's budget, find and print the amount of money Monica will spend. If she doesn't have enough money to both a keyboard and a USB drive, print ```-1``` instead.  She will buy only the two required items.

For example, suppose she has ![](./Resources/Element2.svg) to spend.  Three types of keyboards cost ![](./Resources/Element3.svg).  Two USB drives cost ![](./Resources/Element4.svg).  She could purchase a ![](./Resources/Element5.svg), or a ![](./Resources/Element6.svg).  She chooses the latter.  She can't buy more than ![](./Resources/Element1.svg) items so she can't spend exactly ![](./Resources/Element7.svg).  


**Function Description**  

Complete the getMoneySpent function in the editor below.  It should return the maximum total price for the two items within Monica's budget, or ![](./Resources/Element8.svg) if she cannot afford both items.  

getMoneySpent has the following parameter(s):  


* keyboards: an array of integers representing keyboard prices  
* drives:  an array of integers representing drive prices  
* b: the units of currency in Monica's budget  

**Input Format**

The first line contains three space-separated integers ![](./Resources/Element9.svg), ![](./Resources/Element10.svg), and ![](./Resources/Element11.svg), her budget, the number of keyboard models and the number of USB drive models. 


The second line contains ![](./Resources/Element10.svg) space-separated integers ![](./Resources/Element12.svg), the prices of each keyboard model. 


The third line contains ![](./Resources/Element11.svg) space-separated integers ![](./Resources/Element13.svg), the prices of the USB drives.


**Constraints**


* ![](./Resources/Element14.svg)
* ![](./Resources/Element15.svg)
* The price of each item is in the inclusive range ![](./Resources/Element16.svg).

**Output Format**

Print a single integer denoting the amount of money Monica will spend. If she doesn't have enough money to buy one keyboard and one USB drive, print ```-1``` instead.


**Sample Input 0**

```
10 2 3
3 1
5 2 8
```

**Sample Output 0**

```
9
```

**Explanation 0**

She can buy the ![](./Resources/Element17.svg) keyboard and the ![](./Resources/Element18.svg) USB drive for a total cost of ![](./Resources/Element19.svg).


**Sample Input 1**

```
5 1 1
4
5
```

**Sample Output 1**

```
-1
```

**Explanation 1**

There is no way to buy one keyboard and one USB drive because ![](./Resources/Element20.svg), so we print ![](./Resources/Element21.svg).

