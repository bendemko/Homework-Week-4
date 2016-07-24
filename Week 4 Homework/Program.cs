using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Homework
{
    class Program
    {
        static void Main(string[] args)

        ////PROBLEM 1
        {

            Phrase("Ben Demko is tired");

        }

        static void Phrase(string value)
        {
            string reverse = string.Empty;

            char chSplit = ' ';

            string[] words = value.Split(new char[] { chSplit }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)

            {
                reverse = word + chSplit + reverse;
            }

            Console.WriteLine(reverse);

        }





        //PROBLEM 2


        //{
        //    NameMonth("BEN", "JUNE");

        //}

        //static string NameMonth(string name, string month)

        //{


        //    switch (month)
        //    {
        //        case "JANUARY":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "FEBRUARY":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;

        //        case "MARCH":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "APRIL":
        //            Console.WriteLine(name + " is an " + month + " baby");
        //            break;
        //        case "MAY":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "JUNE":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "JULY":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "AUGUST":
        //            Console.WriteLine(name + " is an " + month + " baby");
        //            break;
        //        case "SEPTEMBER":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "OCTOBER":
        //            Console.WriteLine(name + " is an " + month + " baby");
        //            break;
        //        case "NOVEMBER":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;
        //        case "DECEMBER":
        //            Console.WriteLine(name + " is a " + month + " baby");
        //            break;

        //    }
        //    string final = name + month;
        //    return final;


        //}


        //PROBLEM 3

        //{
        //    CapitalizeName("ben ", "demko");

        //}



        //static string CapitalizeName(string name, string last)



        //{

        //    name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);
        //    last = last[0].ToString().ToUpper() + last.Substring(1, last.Length - 1);

        //    Console.WriteLine(name + last);



        //    string final = name + last;
        //    return final;


        //}

        //Problem 4

        //{
        //    RemoveZero("it's Fri0day!");

        //}


        //static string RemoveZero(string phrase)


        //{

        //    if (phrase.Contains("0"))

        //    {

        //        phrase = phrase.Replace("0", "");

        //        Console.WriteLine(phrase);

        //    }

        //    else

        //    {
        //        Console.WriteLine("This string is ok!");
        //    }


        //    string final = phrase;
        //    return final;

        //}









    }
}
