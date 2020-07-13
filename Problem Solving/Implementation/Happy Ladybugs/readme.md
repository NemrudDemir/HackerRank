[Source](https://www.hackerrank.com/challenges/happy-ladybugs)
# Problem statement
Happy Ladybugs is a board game having the following properties:


* The board is represented by a string, ![](./Resources/Element1.svg), of length ![](./Resources/Element2.svg). The ![](./Resources/Element3.svg) character of the string, ![](./Resources/Element4.svg), denotes the ![](./Resources/Element3.svg) cell of the board.


    * If ![](./Resources/Element4.svg) is an underscore (i.e., ```_```), it means the ![](./Resources/Element3.svg) cell of the board is empty.
    * If ![](./Resources/Element4.svg) is an uppercase English alphabetic letter (ascii[A-Z]), it means the ![](./Resources/Element3.svg) cell contains a ladybug of color ![](./Resources/Element4.svg).
    * String ![](./Resources/Element1.svg) will not contain any other characters.


* A ladybug is happy only when its left or right adjacent cell (i.e., ![](./Resources/Element5.svg)) is occupied by another ladybug having the same color.
* In a single move, you can move a ladybug from its current position to any empty cell. 



Given the values of ![](./Resources/Element2.svg) and ![](./Resources/Element1.svg) for ![](./Resources/Element6.svg) games of Happy Ladybugs, determine if it's possible to make all the ladybugs happy. For each game, print ```YES``` on a new line if all the ladybugs can be made happy through some number of moves.  Otherwise, print ```NO```. 






As an example, ![](./Resources/Element7.svg).  You can move the rightmost ![](./Resources/Element8.svg) and ![](./Resources/Element9.svg) to make ![](./Resources/Element10.svg) and all the ladybugs are happy.  


**Function Description**

Complete the happyLadybugs function in the editor below.  It should return an array of strings, either 'YES' or 'NO', one for each test string.  

happyLadybugs has the following parameters:


* b: an array of strings that represents the initial positions and colors of the ladybugs  





**Input Format**


The first line contains an integer ![](./Resources/Element6.svg), the number of games.  

The next ![](./Resources/Element6.svg) pairs of lines are in the following format:  


* The first line contains an integer ![](./Resources/Element2.svg), the number of cells on the board.  
* The second line contains a string ![](./Resources/Element1.svg) describing the ![](./Resources/Element2.svg) cells of the board.  





**Constraints**



* ![](./Resources/Element11.svg)
* ![](./Resources/Element12.svg)





**Output Format**


For each game, print ```YES``` on a new line if it is possible to make all the ladybugs happy.  Otherwise, print ```NO```.





**Sample Input 0**


```
4
7
RBY_YBR
6
X_Y__X
2
__
6
B_RRBR
```





**Sample Output 0**


```
YES
NO
YES
YES
```





**Explanation 0**


The four games of Happy Ladybugs are explained below:


1. Initial board:  
![](./Resources/1474897921-a3088b360d-lady.png)  
After the first move:  
![](./Resources/1474897973-d5796f2e22-lady1.png)  
After the second move:  
![](./Resources/1474898037-7fb2f25594-lady2.png)  
After the third move:  
![](./Resources/1474898044-9df051fcde-lady3.png)  
Now all the ladybugs are happy, so we print ```YES``` on a new line.

2. There is no way to make the ladybug having color ```Y``` happy, so we print ```NO``` on a new line.
3. There are no unhappy ladybugs, so we print ```YES``` on a new line.
4. Move the rightmost ![](./Resources/Element8.svg) and ![](./Resources/Element9.svg) to form ![](./Resources/Element13.svg).




**Sample Input 1**


```
5
5
AABBC
7
AABBC_C
1
_
10
DD__FQ_QQF
6
AABCBC
```





**Sample Output 1**


```
NO
YES
YES
YES
NO
```