using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static string timeConversion(string s) {
        var values = s.Split(':').Select(x => x.Substring(0,2)).ToList();
        var isPM = s.Remove(0,8) == "PM";
        var hours = int.Parse(values[0]);
        if(isPM || hours == 12)
            hours = (hours + 12)%24;
        if(isPM && hours < 12)
            hours += 12;

        values[0] = hours.ToString("00");
        return string.Join(":", values);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
