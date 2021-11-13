using System;

public class ProgPara {
    static void Main(string[] args) {
        foreach (var arg in args) {
            Console.WriteLine(arg);
        }
        Counter c = new Counter();
        var s1 = 0;
        var s2 = 0;
        if (args.Length > 0) {
            int.TryParse(args[0], out s1);
        }
        if (args.Length > 1) {
            int.TryParse(args[1], out s2);
        }
        c.Add(s1); c.Add(s2);
        Console.WriteLine("val = " + c.Val());
    }
}