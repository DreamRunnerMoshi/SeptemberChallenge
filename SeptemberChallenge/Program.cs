using System;
using System.Collections.Generic;
using System.Linq;
using Testing;

namespace ChaldalInterview
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rep = new RepeatSubstringPattern();
            //rep.computeLPSArray("abcabcabcabc").ToList().ForEach(f => Console.Write(f+" "));
            //Console.WriteLine();
            //rep.computeLPSArray("abab").ToList().ForEach(f => Console.Write(f + " "));
            //Console.WriteLine();
            //rep.computeLPSArray("aba").ToList().ForEach(f => Console.Write(f + " "));
            Console.WriteLine(rep.IsRepeatSubstringPattern("ababcbacadefegdehijhklij"));
        } 
    }
}
