[Source](https://www.hackerrank.com/challenges/climbing-the-leaderboard)
# Problem statement
Alice is playing an arcade game and wants to climb to the top of the leaderboard and wants to track her ranking. The game uses [Dense Ranking](https://en.wikipedia.org/wiki/Ranking#Dense_ranking_.28.221223.22_ranking.29), so its leaderboard works like this:  


* The player with the highest score is ranked number ![](./Resources/Element1.svg) on the leaderboard. 
* Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.
For example, the four players on the leaderboard have high scores of ![](./Resources/Element2.svg), ![](./Resources/Element3.svg), ![](./Resources/Element3.svg), and ![](./Resources/Element4.svg). Those players will have ranks ![](./Resources/Element1.svg), ![](./Resources/Element5.svg), ![](./Resources/Element5.svg), and ![](./Resources/Element6.svg), respectively.  If Alice's scores are ![](./Resources/Element7.svg), ![](./Resources/Element4.svg) and ![](./Resources/Element8.svg), her rankings after each game are ![](./Resources/Element9.svg), ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg). 


**Function Description**  

Complete the climbingLeaderboard function in the editor below.  It should return an integer array where each element ![](./Resources/Element12.svg) represents Alice's rank after the ![](./Resources/Element13.svg) game.

climbingLeaderboard has the following parameter(s):  


* scores: an array of integers that represent leaderboard scores  
* alice: an array of integers that represent Alice's scores  

**Input Format**

The first line contains an integer ![](./Resources/Element14.svg), the number of players on the leaderboard. 


The next line contains ![](./Resources/Element14.svg) space-separated integers ![](./Resources/Element15.svg), the leaderboard scores in decreasing order. 


The next line contains an integer, ![](./Resources/Element16.svg), denoting the number games Alice plays. 


The last line contains ![](./Resources/Element16.svg) space-separated integers ![](./Resources/Element17.svg), the game scores.


**Constraints**


* ![](./Resources/Element18.svg)
* ![](./Resources/Element19.svg)
* ![](./Resources/Element20.svg) for ![](./Resources/Element21.svg)
* ![](./Resources/Element22.svg) for ![](./Resources/Element23.svg)
* The existing leaderboard, ![](./Resources/Element24.svg), is in descending order.
* Alice's scores, ![](./Resources/Element25.svg), are in ascending order.

**Subtask**

For ![](./Resources/Element26.svg) of the maximum score:


* ![](./Resources/Element27.svg)
* ![](./Resources/Element28.svg)

**Output Format**

Print ![](./Resources/Element16.svg) integers. The ![](./Resources/Element13.svg) integer should indicate Alice's rank after playing the ![](./Resources/Element13.svg) game. 

