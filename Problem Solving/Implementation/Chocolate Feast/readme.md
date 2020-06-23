[Source](https://www.hackerrank.com/challenges/chocolate-feast)
# Problem statement
Little Bobby loves chocolate.  He frequently goes to his favorite ![](./Resources/Element1.svg) store, Penny Auntie, to buy them.  They are having a promotion at Penny Auntie.  If Bobby saves enough wrappers, he can turn them in for a free chocolate.  

For example, Bobby has ![](./Resources/Element2.svg) to spend on bars of chocolate that cost ![](./Resources/Element3.svg) each.  He can turn in ![](./Resources/Element4.svg) wrappers to receive another bar.  Initially, he buys ![](./Resources/Element5.svg) bars and has ![](./Resources/Element5.svg) wrappers after eating them.  He turns in ![](./Resources/Element6.svg) of them, leaving him with ![](./Resources/Element7.svg), for ![](./Resources/Element8.svg) more bars.  After eating those two, he has ![](./Resources/Element9.svg) wrappers, turns in ![](./Resources/Element8.svg) leaving him with ![](./Resources/Element7.svg) wrapper and his new bar.  Once he eats that one, he has ![](./Resources/Element8.svg) wrappers and turns them in for another bar.  After eating that one, he only has ![](./Resources/Element7.svg) wrapper, and his feast ends.  Overall, he has eaten ![](./Resources/Element10.svg) bars.    


**Function Description**

Complete the chocolateFeast function in the editor below.  It must return the number of chocolates Bobby can eat after taking full advantage of the promotion.

chocolateFeast has the following parameter(s):  


* n: an integer representing Bobby's initial amount of money  
* c: an integer representing the cost of a chocolate bar  
* m: an integer representing the number of wrappers he can turn in for a free bar  


**Note**: Little Bobby will always turn in his wrappers if he has enough to get a free chocolate.





**Input Format**


The first line contains an integer, ![](./Resources/Element11.svg), denoting the number of test cases to analyze. 


Each of the next ![](./Resources/Element11.svg) lines contains three space-separated integers:  ![](./Resources/Element12.svg), ![](./Resources/Element13.svg), and ![](./Resources/Element14.svg).  They represent money to spend, cost of a chocolate, and the number of wrappers he can turn in for a free chocolate. 





**Constraints**



* ![](./Resources/Element15.svg)
* ![](./Resources/Element16.svg)
* ![](./Resources/Element17.svg)
* ![](./Resources/Element18.svg)





**Output Format**


For each trip to Penny Auntie, print the total number of chocolates Bobby eats on a new line.





**Sample Input**


```
3
10 2 5
12 4 4
6 2 2
```




**Sample Output**


```
6
3
5
```




**Explanation**


Bobby makes the following ![](./Resources/Element9.svg) trips to the store:


1. He spends his ![](./Resources/Element19.svg) dollars on ![](./Resources/Element5.svg) chocolates at ![](./Resources/Element8.svg) dollars apiece. He then eats them and exchanges all ![](./Resources/Element5.svg) wrappers to get ![](./Resources/Element7.svg) more. He eats ![](./Resources/Element20.svg) chocolates.
2. He spends his ![](./Resources/Element21.svg) dollars on ![](./Resources/Element9.svg) chocolates at ![](./Resources/Element6.svg) dollars apiece.  He has ![](./Resources/Element9.svg) wrappers, but needs ![](./Resources/Element6.svg) to trade for his next chocolate. He eats ![](./Resources/Element9.svg) chocolates.  
3. He spends ![](./Resources/Element20.svg) dollars on ![](./Resources/Element9.svg) chocolates at ![](./Resources/Element8.svg) dollars apiece. He then exchanges ![](./Resources/Element8.svg) of the ![](./Resources/Element9.svg) wrappers for ![](./Resources/Element7.svg) additional piece. Next, he uses his third leftover chocolate wrapper from his initial purchase with the wrapper from his trade-in to do a second trade-in for ![](./Resources/Element7.svg) more piece. At this point he has ![](./Resources/Element7.svg) wrapper left, which is not enough to perform another trade-in. He eats ![](./Resources/Element5.svg) chocolates.




