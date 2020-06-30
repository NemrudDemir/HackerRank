[Source](https://www.hackerrank.com/challenges/flatland-space-stations)
# Problem statement
Flatland is a country with a number of cities, some of which have space stations.  Cities are numbered consecutively and each has a road of ![](./Resources/Element1.svg) length connecting it to the next city.  It is not a circular route, so the first city doesn't connect with the last city.  Determine the maximum distance from any city to it's nearest space station.

For example, there are ![](./Resources/Element2.svg) cities and ![](./Resources/Element3.svg) of them has a space station, city ![](./Resources/Element4.svg).  They occur consecutively along a route.  City ![](./Resources/Element5.svg) is ![](./Resources/Element6.svg) unit away and city ![](./Resources/Element7.svg) is ![](./Resources/Element8.svg) units away.  City ![](./Resources/Element4.svg) is ![](./Resources/Element9.svg) units from its nearest space station as one is located there.  The maximum distance is ![](./Resources/Element5.svg).


**Function Description**

Complete the flatlandSpaceStations function in the editor below.  It should return an integer that represents the maximum distance any city is from a space station.  

flatlandSpaceStations has the following parameter(s):  


* n: the number of cities  
* c: an integer array that contains the indices of cities with a space station, ![](./Resources/Element4.svg)-based indexing  





**Input Format**


The first line consists of two space-separated integers, ![](./Resources/Element10.svg) and ![](./Resources/Element11.svg). 


The second line contains ![](./Resources/Element11.svg) space-separated integers, the indices of each city having a space-station. These values are unordered and unique.





**Constraints**



* ![](./Resources/Element12.svg)
* ![](./Resources/Element13.svg)
* There will be at least ![](./Resources/Element4.svg) city with a space station.
* No city has more than one space station.





**Output Format**


Print an integer denoting the maximum distance that an astronaut in a Flatland city would need to travel to reach the nearest space station.


**Sample Input 0**

```
5 2
0 4
```

**Sample Output 0**

```
2
```

**Explanation 0**

This sample corresponds to following graphic:  

![](./Resources/1449763282-eddfbea90c-hreasy5.png)

The distance to the nearest space station for each city is listed below:


* ![](./Resources/Element14.svg) has distance ![](./Resources/Element15.svg), as it contains a space station.
* ![](./Resources/Element16.svg) has distance ![](./Resources/Element17.svg) to the space station in ![](./Resources/Element14.svg).
* ![](./Resources/Element18.svg) has distance ![](./Resources/Element19.svg) to the space stations in ![](./Resources/Element14.svg) and ![](./Resources/Element20.svg).
* ![](./Resources/Element21.svg) has distance ![](./Resources/Element17.svg) to the space station in ![](./Resources/Element20.svg).
* ![](./Resources/Element20.svg) has distance ![](./Resources/Element15.svg), as it contains a space station.

We then take ![](./Resources/Element22.svg).


**Sample Input 1**

```
6 6
0 1 2 4 3 5
```

**Sample Output 1**

```
0
```

**Explanation 1**

In this sample, ![](./Resources/Element23.svg) so every city has space station and we print ![](./Resources/Element9.svg) as our answer.





