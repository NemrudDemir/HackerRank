[Source](https://www.hackerrank.com/challenges/day-of-the-programmer)
# Problem statement
Marie invented a [Time Machine](https://en.wikipedia.org/wiki/Time_machine) and wants to test it by time-traveling to visit Russia on the [Day of the Programmer](https://en.wikipedia.org/wiki/Day_of_the_Programmer) (the ![](./Resources/Element1.svg) day of the year) during a year in the inclusive range from ![](./Resources/Element2.svg) to ![](./Resources/Element3.svg). 

From ![](./Resources/Element2.svg) to ![](./Resources/Element4.svg), Russia's official calendar was the [Julian calendar](https://en.wikipedia.org/wiki/Julian_calendar); since ![](./Resources/Element5.svg) they used the [Gregorian calendar](https://en.wikipedia.org/wiki/Gregorian_calendar) system. The transition from the Julian to Gregorian calendar system occurred in ![](./Resources/Element6.svg), when the next day after January ![](./Resources/Element7.svg) was February ![](./Resources/Element8.svg). This means that in ![](./Resources/Element6.svg), February ![](./Resources/Element8.svg) was the ![](./Resources/Element9.svg) day of the year in Russia.

In both calendar systems, February is the only month with a variable amount of days; it has ![](./Resources/Element10.svg) days during a leap year, and ![](./Resources/Element11.svg) days during all other years. In the Julian calendar, leap years are divisible by ![](./Resources/Element12.svg); in the Gregorian calendar, leap years are either of the following:


* Divisible by ![](./Resources/Element13.svg).
* Divisible by ![](./Resources/Element12.svg) and not divisible by ![](./Resources/Element14.svg).
Given a year, ![](./Resources/Element15.svg), find the date of the ![](./Resources/Element1.svg) day of that year according to the official Russian calendar during that year. Then print it in the format ```dd.mm.yyyy```, where ```dd``` is the two-digit day, ```mm``` is the two-digit month, and ```yyyy``` is ![](./Resources/Element15.svg).

For example, the given ![](./Resources/Element16.svg).  ![](./Resources/Element17.svg) is divisible by ![](./Resources/Element12.svg), so it is a leap year.  The ![](./Resources/Element1.svg) day of a leap year after ![](./Resources/Element6.svg) is September 12, so the answer is ![](./Resources/Element18.svg).  


**Function Description**  

Complete the dayOfProgrammer function in the editor below.  It should return a string representing the date of the ![](./Resources/Element1.svg) day of the year given.  

dayOfProgrammer has the following parameter(s):  


* year: an integer  

**Input Format**

A single integer denoting year ![](./Resources/Element15.svg).


**Constraints**


* ![](./Resources/Element19.svg)

**Output Format**

Print the full date of Day of the Programmer during year ![](./Resources/Element15.svg) in the format ```dd.mm.yyyy```, where ```dd``` is the two-digit day, ```mm``` is the two-digit month, and ```yyyy``` is ![](./Resources/Element15.svg).


**Sample Input 0**

```
2017
```

**Sample Output 0**

```
13.09.2017
```

**Explanation 0**

In the year ![](./Resources/Element20.svg), January has ![](./Resources/Element21.svg) days, February has ![](./Resources/Element11.svg) days, March has ![](./Resources/Element21.svg) days, April has ![](./Resources/Element22.svg) days, May has ![](./Resources/Element21.svg) days, June has ![](./Resources/Element22.svg) days, July has ![](./Resources/Element21.svg) days, and August has ![](./Resources/Element21.svg) days. When we sum the total number of days in the first eight months, we get ![](./Resources/Element23.svg). Day of the Programmer is the ![](./Resources/Element1.svg) day, so then calculate ![](./Resources/Element24.svg) to determine that it falls on day ![](./Resources/Element25.svg) of the ![](./Resources/Element26.svg) month (September). We then print the full date in the specified format, which is ```13.09.2017```.


**Sample Input 1**

```
2016
```

**Sample Output 1**

```
12.09.2016
```

**Explanation 1**

Year ![](./Resources/Element27.svg) is a leap year, so February has ![](./Resources/Element10.svg) days but all the other months have the same number of days as in ![](./Resources/Element28.svg). When we sum the total number of days in the first eight months, we get ![](./Resources/Element29.svg). Day of the Programmer is the ![](./Resources/Element1.svg) day, so then calculate ![](./Resources/Element30.svg) to determine that it falls on day ![](./Resources/Element31.svg) of the ![](./Resources/Element26.svg) month (September). We then print the full date in the specified format, which is ```12.09.2016```.


**Sample Input 2**

```
1800
```

**Sample Output 2**

```
12.09.1800
```

**Explanation 2**

Since 1800 is leap year. Day lies on 12 September.

