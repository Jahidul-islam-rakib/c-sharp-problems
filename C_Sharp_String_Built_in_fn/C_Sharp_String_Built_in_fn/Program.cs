using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_String_Built_in_fn
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("built in method for string in c#\n\n\n");

            string s1 = "asp";
            string s11 = "asp";
            string s2 = "Asp";
            string s3 = "asp .NET Core";
            string word1 = "halar pola";
            string word2 = "lar";
            string word3 = "lara";
            string word4 = "ola";
            string word5 = "pol";
            string word8 = "";
            string word9 = "     ";
            string word6 = "halar pola    ";
            string word7 = "   halar pola";
            string word88 = "   Halar Pola  ";
            string[] str = { "hello", "kala", "manik" };
            string word10 = "Ei J vai, Shunen";

            int simpil = 4;




            Console.WriteLine("--------------- Compare() method ----------------");
            /*The C# Compare() method is used to compare first string with second string 
              lexicographically. It returns an integer value.*/
            Console.WriteLine($"\"{s1}\" compared with \"{s2}\" : {string.Compare(s1, s2)} ");
            Console.WriteLine($"\"{s2}\" compared with \"{s1}\" : {string.Compare(s2, s1)} ");
            Console.WriteLine($"\"{s1}\" compared with \"{s3}\" : {string.Compare(s1, s3)} ");
            Console.WriteLine($"\"{s1}\" compared with \"{s11}\" : {string.Compare(s1, s11)} \n\n\n");



            Console.WriteLine("--------------- Concat() method ----------------");
            /*The C# Concat() method is used to concatenate multiple string objects. It returns concatenated string. 
             * There are many overloaded methods of Concat(). */
            Console.WriteLine($"\"{s1}\" concate with \"{s2}\" : {string.Concat(s1, s2)} ");
            Console.WriteLine($"\"{s2}\" concate with \"{s1}\" with \"{s3}\" : {string.Concat(s2, s1, s3)} ");
            Console.WriteLine($"\"{s1}\" concate with \"{s11}\" with \"{s2}\" with \"{s3}\" : {string.Concat(s1, s11, s2, s3)} \n\n");



            Console.WriteLine("--------------- Contains() method ----------------");
            /*The C# Contains() method is used to return a value indicating whether the specified substring occurs within this string or not. 
             * If the specified substring is found in this string, it returns true otherwise false. */
            Console.WriteLine($"Is \"{s1}\" contains \"{s2}\" ?: {s1.Contains(s2)} ");
            Console.WriteLine($"\"{word1}\" contains \"{word2}\" ? : {word1.Contains(word2)} ");
            Console.WriteLine($"\"{word1}\" contains \"{word3}\" ? : {word1.Contains(word3)} ");
            Console.WriteLine($"\"{s1}\" contains \"{s11}\" ? : {s1.Contains(s11)} \n\n");



            Console.WriteLine("--------------- Copy() method ----------------");
            string copiedVal = string.Copy(s1);
            Console.WriteLine($"\"{s1}\" is copied to \"{copiedVal}\" : {copiedVal} \n\n");



            Console.WriteLine("--------------- EndsWith() method ----------------");
            Console.WriteLine($"Is \"{word1}\"  Ends with  \"{word4}\" ? : {word1.EndsWith(word4)} ");
            Console.WriteLine($"Is  \" {word1}\"  Ends with  \"{word5}\" ? : {word1.EndsWith(word5)} ");
            Console.WriteLine($"Is \" {word1}\"  Ends with {word3}\" ? : {word1.EndsWith(word3)} \n\n");



            Console.WriteLine("--------------- Equals() method ----------------");
            Console.WriteLine($"Is \"{s1}\"  equals with  \"{s2}\" ? : {s1.Equals(s2)} ");
            Console.WriteLine($"Is  \" {s1}\"  equals with  \"{s11}\" ? : {s1.Equals(s11)} ");
            Console.WriteLine($"Is \" {word1}\"  equals with {word3}\" ? : {word1.Equals(word3)} \n\n");


            Console.WriteLine("--------------- Format() method ----------------");
            Console.WriteLine($"Today is : {string.Format("{0:D}", DateTime.Now)} \n\n");



            Console.WriteLine("---------------  GetEnumerator() method ----------------");
            CharEnumerator ch = s1.GetEnumerator();
            Console.WriteLine($"Is \"{s1}\"  converted into : ");
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
            Console.WriteLine("\n\n");




            Console.WriteLine("--------------- GetType() method ----------------");

            Console.WriteLine($"\"{s1}\"  type: {s1.GetType()}");
            Console.WriteLine($"\"{simpil}\" type: {simpil.GetType()}\n\n");


            Console.WriteLine("--------------- IndexOf() method ----------------");
            Console.WriteLine($"\"{word1}\"  te \"a\" er index: {word1.IndexOf('a')}");
            Console.WriteLine($"\"{word1}\"  te \"pol\" er index: {word1.IndexOf('p')}\n\n");



            Console.WriteLine("--------------- Insert() method ----------------");
            string insertVal = word1.Insert(3, "-");
            Console.WriteLine($"\"{word1}\"  te \"index:3 insert:-\" er insert: {insertVal}");
            Console.WriteLine($"\"{word1}\"  te \"index:3 insert:#\" er insert: {word1.Insert(3, "#")}");
            Console.WriteLine($"\"{word1}\"  te \"index:3 insert:bal\" er insert: {word1.Insert(3, "bal")}\n\n");



            Console.WriteLine("--------------- IsNullOrEmpty() method ----------------");
            Console.WriteLine($"Is \"{word8}\"  is nul or empty ? : {string.IsNullOrEmpty(word8)} ");
            Console.WriteLine($"Is  \" {word9}\" is nul or empty ? : {string.IsNullOrEmpty(word9)} ");
            Console.WriteLine($"Is \" {word3}\" is nul or empty ? : {string.IsNullOrEmpty(word3)} \n\n");


            Console.WriteLine("--------------- IsNullOrWhiteSpace() method ----------------");
            Console.WriteLine($"Is \"{word8}\"  is nul or contains ONLY white space ? : {string.IsNullOrWhiteSpace(word8)} ");
            Console.WriteLine($"Is  \" {word9}\" is nul or contains ONLY white space ? : {string.IsNullOrWhiteSpace(word9)} ");
            Console.WriteLine($"Is \" {word3}\" is nul or contains ONLY white space ? : {string.IsNullOrWhiteSpace(word3)} \n\n");



            Console.WriteLine("--------------- Join() method ----------------");
            Console.WriteLine($"Is \"{str}\"  is joined with \"-\" : {string.Join("-", str)} ");
            Console.WriteLine($"Is  \" {str}\" is joined with  \" \": {string.Join(" ", str)} ");
            Console.WriteLine($"Is \" {str}\" is joined with \"#\": {string.Join("#", str)} \n\n");



            Console.WriteLine("--------------- LastIndexOf() method ----------------");
            Console.WriteLine($" \"{word1}\"has last index of \"l\" : {word1.LastIndexOf('l')}  \n\n");



            Console.WriteLine("--------------- Remove() method ----------------");
            Console.WriteLine($"\"{word1}\"  has remove index \"3 to 5\" : {word1.Remove(3, 5)}");
            Console.WriteLine($"\"{word1}\"  has remove index \"4\" : {word1.Remove(4)}  \n\n");


            Console.WriteLine("--------------- Replace() method ----------------");
            Console.WriteLine($"In \"{word1}\",  a replace with\"A\" : {word1.Replace("a", "AAA")} ");
            Console.WriteLine($"In \"{word1}\",  a replace with\"A\" : {word1.Replace('a', 'A')}  \n\n");



            Console.WriteLine("--------------- Split() method ----------------");
            string[] str2 = word1.Split();
            foreach (string ss in str2)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("--------------- StartsWith() method ----------------");
            Console.WriteLine($"In \"{word1}\",  Starts with\"h\" : {word1.StartsWith("h")} ");
            Console.WriteLine($"In \"{word1}\",  Starts with\"H\" : {word1.StartsWith("H")}  \n\n");



            Console.WriteLine("--------------- SubString() method ----------------");
            Console.WriteLine($"In \"{word1}\",  has substring from\"3\" : {word1.Substring(3)} ");
            Console.WriteLine($"In \"{word1}\",  has substring from\"3 to 6\" : {word1.Substring(3, 6)}  \n\n");



            Console.WriteLine("--------------- ToCharArray() method ----------------");
            Console.WriteLine($"In \"{word1}\"has divided to char array: ");
            char[] charactr = word1.ToCharArray();
            foreach (char c in charactr)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\n\n");



            Console.WriteLine("--------------- ToLower() method ----------------");
            Console.WriteLine($"In \"{word10}\",  all character will be lower : {word10.ToLower()}  \n\n");



            Console.WriteLine("--------------- ToUpper() method ----------------");
            Console.WriteLine($"In \"{word10}\",  all character will be Upper : {word10.ToUpper()}  \n\n");


            Console.WriteLine("--------------- Trim() method ----------------");
            Console.WriteLine($"In \"{word6}\", cutting all leading and trailing white space :{word6.Trim()}\"<--\"");
            Console.WriteLine($"In \"{word7}\", cutting all leading and trailing white space :{word7.Trim()}\"<--\"");
            Console.WriteLine($"In \"{word88}\", cutting all leading and trailing white space :{word88.Trim()}\"<--\" \n\n");



            Console.WriteLine("--------------- TrimEnd() method ----------------");
            Console.WriteLine($"In \"{word6}\", cutting from End a specied character -->a:{word6.TrimEnd('a')}\"<--\"");
            Console.WriteLine($"In \"{word7}\", cutting from End a specied character -->l:{word7.TrimEnd('l')}\"<--\"");
            Console.WriteLine($"In \"{word88}\", cutting  from End a specied character -->\" \":{word88.TrimEnd(' ')}\"<--\" \n\n");



            Console.WriteLine("--------------- TrimStart() method ----------------");
            Console.WriteLine($"In \"{word6}\", cutting from start \"h\" :{word6.TrimStart('h')}\"<--\"");
            Console.WriteLine($"In \"{word7}\", cutting from start \"l\" :{word7.TrimStart('l')}\"<--\"");
            Console.WriteLine($"In \"{word88}\", cutting from start \" \":{word88.TrimStart(' ')}\"<--\" \n\n");

        }
    }
}
