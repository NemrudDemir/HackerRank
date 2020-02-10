[Source](https://www.hackerrank.com/challenges/migratory-birds)
# Problem statement
You have been asked to help study the population of birds migrating across the continent.  Each type of bird you are interested in will be identified by an integer value.  Each time a particular kind of bird is spotted, its id number will be added to your array of sightings. You would like to be able to find out which type of bird is most common given a list of sightings. Your task is to print the type number of that bird and if two or more types of birds are equally common, choose the type with the smallest ID number.

For example, assume your bird sightings are of types ![](./Resources/Element1.svg).  There are two each of types ![](./Resources/Element2.svg) and ![](./Resources/Element3.svg), and one sighting of type ![](./Resources/Element4.svg).  Pick the lower of the two types seen twice: type ![](./Resources/Element2.svg).  


**Function Description**

Complete the migratoryBirds function in the editor below.  It should return the lowest type number of the most frequently sighted bird.  

migratoryBirds has the following parameter(s):  


* arr: an array of integers representing types of birds sighted  

**Input Format**

The first line contains an integer denoting ![](./Resources/Element5.svg), the number of birds sighted and reported in the array ![](./Resources/Element6.svg). 


The second line describes ![](./Resources/Element6.svg) as ![](./Resources/Element5.svg) space-separated integers representing the type numbers of each bird sighted.


**Constraints**


* ![](./Resources/Element7.svg)
* It is guaranteed that each type is ![](./Resources/Element2.svg), ![](./Resources/Element3.svg), ![](./Resources/Element4.svg), ![](./Resources/Element8.svg), or ![](./Resources/Element9.svg).

**Output Format**

Print the type number of the most common bird; if two or more types of birds are equally common, choose the type with the smallest ID number.


**Sample Input 0**

```
6
1 4 4 4 5 3
```

**Sample Output 0**

```
4
```

**Explanation 0**

The different types of birds occur in the following frequencies:


* Type ![](./Resources/Element2.svg): ![](./Resources/Element2.svg) bird
* Type ![](./Resources/Element3.svg): ![](./Resources/Element10.svg) birds
* Type ![](./Resources/Element4.svg): ![](./Resources/Element2.svg) bird
* Type ![](./Resources/Element8.svg): ![](./Resources/Element4.svg) birds
* Type ![](./Resources/Element9.svg): ![](./Resources/Element2.svg) bird
The type number that occurs at the highest frequency is type ![](./Resources/Element8.svg), so we print ![](./Resources/Element8.svg) as our answer.


**Sample Input 1**

```
11
1 2 3 4 5 4 3 2 1 3 4
```

**Sample Output 1**

```
3
```

**Explanation 1**

The different types of birds occur in the following frequencies:  


* Type ![](./Resources/Element2.svg): ![](./Resources/Element3.svg)  
* Type ![](./Resources/Element3.svg): ![](./Resources/Element3.svg)  
* Type ![](./Resources/Element4.svg): ![](./Resources/Element4.svg)  
* Type ![](./Resources/Element8.svg): ![](./Resources/Element4.svg)  
* Type ![](./Resources/Element9.svg): ![](./Resources/Element2.svg)  
Two types have a frequency of ![](./Resources/Element4.svg), and the lower of those is type ![](./Resources/Element4.svg).

