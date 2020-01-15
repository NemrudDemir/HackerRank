[Source](https://www.hackerrank.com/challenges/birthday-cake-candles)
# Problem statement
You are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age. When she blows out the candles, she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out. 

For example, if your niece is turning ![](./Resources/Element1.svg) years old, and the cake will have ![](./Resources/Element2.svg) candles of height ![](./Resources/Element3.svg), ![](./Resources/Element4.svg), ![](./Resources/Element5.svg), ![](./Resources/Element6.svg), she will be able to blow out ![](./Resources/Element7.svg) candles successfully, since the tallest candles are of height ![](./Resources/Element8.svg) and there are ![](./Resources/Element9.svg) such candles.  


**Function Description**

Complete the function ```birthdayCakeCandles``` in the editor below.  It must return an integer representing the number of candles she can blow out.  

birthdayCakeCandles has the following parameter(s):


* ar: an array of integers representing candle heights     

**Input Format**

The first line contains a single integer, ![](./Resources/Element10.svg), denoting the number of candles on the cake. 


The second line contains ![](./Resources/Element11.svg) space-separated integers, where each integer ![](./Resources/Element12.svg) describes the height of candle ![](./Resources/Element13.svg).


**Constraints**


* ![](./Resources/Element14.svg)  
* ![](./Resources/Element15.svg)  

**Output Format**

Return the number of candles that can be blown out on a new line.


**Sample Input 0**

```
4
3 2 1 3
```

**Sample Output 0**

```
2
```

**Explanation 0**

We have one candle of height ![](./Resources/Element16.svg), one candle of height ![](./Resources/Element17.svg), and two candles of height ![](./Resources/Element18.svg). Your niece only blows out the tallest candles, meaning the candles where ![](./Resources/Element19.svg). Because there are ![](./Resources/Element20.svg) such candles, we print ![](./Resources/Element21.svg) on a new line. 

