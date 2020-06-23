[Source](https://www.hackerrank.com/challenges/encryption)
# Problem statement
An English text needs to be encrypted using the following encryption scheme. 


First, the spaces are removed from the text. Let ![](./Resources/Element1.svg) be the length of this text. 


Then, characters are written into a grid, whose rows and columns have the following constraints:



![](./Resources/Element2.svg)

For example, the sentence ![](./Resources/Element3.svg), after removing spaces is ![](./Resources/Element4.svg) characters long.  ![](./Resources/Element5.svg) is between ![](./Resources/Element6.svg) and ![](./Resources/Element7.svg), so it is written in the form of a grid with 7 rows and 8 columns. 

```
ifmanwas  
meanttos          
tayonthe  
groundgo  
dwouldha  
vegivenu  
sroots
```

* Ensure that ![](./Resources/Element8.svg)   
* If multiple grids satisfy the above conditions, choose the one with the minimum area, i.e. ![](./Resources/Element9.svg).  

The encoded message is obtained by displaying the characters in a column, inserting a space, and then displaying the next column and inserting a space, and so on. For example, the encoded message for the above rectangle is:  

```imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau```  

You will be given a message to encode and print.


**Function Description**  

Complete the encryption function in the editor below.  It should return a single string composed as described.  

encryption has the following parameter(s):  


* s: a string to encrypt  


**Input Format**

One line of text, the string ![](./Resources/Element10.svg)


**Constraints**

![](./Resources/Element11.svg) 


![](./Resources/Element10.svg) is comprised only of characters in the range ascii[a-z].


**Output Format**

Print the encoded message on one line as described.


**Sample Input**

```
haveaniceday
```

**Sample Output 0**

```
hae and via ecy
```

**Explanation 0**  

![](./Resources/Element12.svg), ![](./Resources/Element13.svg) is between ![](./Resources/Element14.svg) and ![](./Resources/Element15.svg). 


Rewritten with ![](./Resources/Element14.svg) rows and ![](./Resources/Element15.svg) columns:

```
have
anic
eday
```

**Sample Input 1**

```
feedthedog    
```

**Sample Output 1**

```
fto ehg ee dd
```

**Explanation 1**  

![](./Resources/Element16.svg), ![](./Resources/Element17.svg) is between ![](./Resources/Element14.svg) and ![](./Resources/Element15.svg). 


Rewritten with ![](./Resources/Element14.svg) rows and ![](./Resources/Element15.svg) columns:  

```
feed
thed
og
```

**Sample Input 2**

```
chillout
```

**Sample Output 2**

```
clu hlt io
```

**Explanation 2**  

![](./Resources/Element18.svg), ![](./Resources/Element19.svg) is between ![](./Resources/Element20.svg) and ![](./Resources/Element14.svg). 


Rewritten with ![](./Resources/Element14.svg) columns and ![](./Resources/Element14.svg) rows (![](./Resources/Element21.svg) so we have to use ![](./Resources/Element22.svg).)

```
chi
llo
ut
```
