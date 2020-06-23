[Source](https://www.hackerrank.com/challenges/halloween-sale?h_r=profile)
# Problem statement
You wish to buy video games from the famous online video game store Mist.

Usually, all games are sold at the same price, ![](./Resources/Element1.svg) dollars. However, they are planning to have the seasonal Halloween Sale next month in which you can buy games at a cheaper price. Specifically, the first game you buy during the sale will be sold at ![](./Resources/Element1.svg) dollars, but every subsequent game you buy will be sold at exactly ![](./Resources/Element2.svg) dollars less than the cost of the previous one you bought. This will continue until the cost becomes less than or equal to ![](./Resources/Element3.svg) dollars, after which every game you buy will cost ![](./Resources/Element3.svg) dollars each.

For example, if ![](./Resources/Element4.svg), ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg), then the following are the costs of the first ![](./Resources/Element7.svg) games you buy, in order:



![](./Resources/Element8.svg)

You have ![](./Resources/Element9.svg) dollars in your Mist wallet. How many games can you buy during the Halloween Sale?





**Input Format**


The first and only line of input contains four space-separated integers ![](./Resources/Element1.svg), ![](./Resources/Element2.svg), ![](./Resources/Element3.svg) and ![](./Resources/Element9.svg).  





**Constraints**



* ![](./Resources/Element10.svg)
* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg)





**Output Format**


Print a single line containing a single integer denoting the maximum number of games you can buy.





**Sample Input 0**


```
20 3 6 80
```





**Sample Output 0**


```
6
```





**Explanation 0**


We have ![](./Resources/Element4.svg), ![](./Resources/Element5.svg) and ![](./Resources/Element6.svg), the same as in the problem statement. We also have ![](./Resources/Element13.svg) dollars. We can buy ![](./Resources/Element14.svg) games since they cost ![](./Resources/Element15.svg) dollars. However, we cannot buy a ![](./Resources/Element16.svg)th game. Thus, the answer is ![](./Resources/Element14.svg).  





**Sample Input 1**


```
20 3 6 85
```





**Sample Output 1**


```
7
```





**Explanation 1**


This is the same as the previous case, except this time we have ![](./Resources/Element17.svg) dollars. This time, we can buy ![](./Resources/Element16.svg) games since they cost ![](./Resources/Element18.svg) dollars. However, we cannot buy an ![](./Resources/Element19.svg)th game. Thus, the answer is ![](./Resources/Element16.svg).  





