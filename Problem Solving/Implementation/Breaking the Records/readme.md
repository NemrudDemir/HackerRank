[Source](https://www.hackerrank.com/challenges/breaking-best-and-worst-records)
# Problem statement
Maria plays college basketball and wants to go pro.  Each season she maintains a record of her play.  She tabulates the number of times she breaks her season record for most points and least points in a game.  Points scored in the first game establish her record for the season, and she begins counting from there.

For example, assume her scores for the season are represented in the array ![](./Resources/Element1.svg).  Scores are in the same order as the games played.  She would tabulate her results as follows:

```
                                 Count
Game  Score  Minimum  Maximum   Min Max
 0      12     12       12       0   0
 1      24     12       24       0   1
 2      10     10       24       1   1
 3      24     10       24       1   1
```
Given Maria's scores for a season, find and print the number of times she breaks her records for most and least points scored during the season.


**Function Description**  

Complete the breakingRecords function in the editor below.  It must return an integer array containing the numbers of times she broke her records.  Index ![](./Resources/Element2.svg) is for breaking most points records, and index ![](./Resources/Element3.svg) is for breaking least points records.  

breakingRecords has the following parameter(s):  


* scores: an array of integers  

**Input Format**

The first line contains an integer ![](./Resources/Element4.svg), the number of games. 


The second line contains ![](./Resources/Element5.svg) space-separated integers describing the respective values of ![](./Resources/Element6.svg).


**Constraints**


* ![](./Resources/Element7.svg)
* ![](./Resources/Element8.svg)

**Output Format**

Print two space-seperated integers describing the respective numbers of times her best (highest) score increased and her worst (lowest) score decreased.


**Sample Input 0**

```
9
10 5 20 20 4 5 2 25 1
```

**Sample Output 0**

```
2 4
```

**Explanation 0**

The diagram below depicts the number of times Maria broke her best and worst records throughout the season:

![](./Resources/1487360234-6bca5c518d-breakingbest3.png)

She broke her best record twice (after games ![](./Resources/Element9.svg) and ![](./Resources/Element10.svg)) and her worst record four times (after games ![](./Resources/Element11.svg), ![](./Resources/Element12.svg), ![](./Resources/Element13.svg), and ![](./Resources/Element14.svg)), so we print ```2 4``` as our answer. Note that she did not break her record for best score during game ![](./Resources/Element15.svg), as her score during that game was not strictly greater than her best record at the time.


**Sample Input 1**

```
10
3 4 21 36 10 28 35 5 24 42
```

**Sample Output 1**

```
4 0
```

**Explanation 1**

The diagram below depicts the number of times Maria broke her best and worst records throughout the season:

![](./Resources/1487360375-aee4388234-breakingbest5.png)

She broke her best record four times (after games ![](./Resources/Element16.svg), ![](./Resources/Element17.svg), ![](./Resources/Element18.svg), and ![](./Resources/Element19.svg)) and her worst record zero times (no score during the season was lower than the one she earned during her first game), so we print ```4 0``` as our answer.

