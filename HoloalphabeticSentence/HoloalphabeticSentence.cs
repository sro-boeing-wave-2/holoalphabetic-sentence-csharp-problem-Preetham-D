using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            Regex reg = new Regex("[^A-Z]");
            HashSet<char> distinct = new HashSet<char>();
            foreach (char x in reg.Replace(input.ToUpper(), ""))
            {
                distinct.Add(x);
            }
            return ((distinct.Count) == 26)? true : false;
            //if (distinct.Count == 26)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
