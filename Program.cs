using System;

namespace searchrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string _initialString = Console.ReadLine();
            Console.WriteLine("Please enter the sub string you wish to find: ");
            string _subString = Console.ReadLine();
            Console.WriteLine("Please enter a string to replace the given substring: ");
            string _stringReplacer = Console.ReadLine();

            Console.WriteLine("Your new string is " + replacer(_initialString, _subString, _stringReplacer));
        }

        public  static string replacer(string str, string subStr, string strRep){

            if (!str.Contains(subStr)) { 
                return str; 
            } 

            // if(str.StartsWith(subStr))
            //     return strRep + replacer(str.Substring(subStr.Length, str.Length - subStr.Length), subStr, strRep);
            // else{
            //     return str[0] + replacer(str.Substring(1, str.Length - 1), subStr, strRep);
            // }

            return replacer(
                str.Replace(subStr, strRep),
                subStr,
                strRep);
        }
    }
}
