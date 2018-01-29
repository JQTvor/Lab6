using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Lab6
    {
        public void index()
        {
            string vowels = "aeiou";

            Console.WriteLine("Welcome to  the Pig Latin Translator! \nEnter a line to be translated:");
            string answer = Console.ReadLine().ToLower();
            char[] letters = answer.ToCharArray();


            foreach (string word in answer.Split())
            {
                string first = answer.Substring(0, 1);
                string rest = answer.Substring(1, answer.Length - 1);
                int curL = vowels.IndexOf(first);
                string end = String.Concat(answer, " ", first, " ", rest);


                if (curL == -1)
                {
                    answer = rest + first + "ay";
                }
                else
                {
                    answer = word + "way";
                }
            }
            Console.WriteLine(answer);
            Console.WriteLine("Would you like to pig-up another word?");
            answer = Console.ReadLine().ToLower();
            if(answer == "y")
            {
                index();
            }

        }

        public void Array()
        {
            Console.WriteLine("Welcome to  the Pig Latin Translator! \nEnter a line to be translated:");
            string answer = Console.ReadLine().ToLower();
            char[] letters = answer.ToCharArray();

            char[] vowels = {'a', 'e', 'i', 'o', 'u');
            foreach(char cur in letters)
            {

            }
        
        }

        public void Math()
        {
            Console.WriteLine("Welcome to  the Pig Latin Translator! \nEnter a line to be translated:");
            string answer = Console.ReadLine().ToLower();
            char[] letters = answer.ToCharArray();

            foreach (int i in letters)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("math");
        }














        static void Main(string[] args)
        {
            Console.WriteLine("How would you like to solve pig latin issues? \nWith an index = i" + 
                "\nWith a char array = a \nWith math = M");
            string answer = Console.ReadLine().ToUpper();
                Lab6 L6 = new Lab6();

            if (answer == "I")
            {

                L6.index();
   
            }
            if (answer == "A")
            {
                L6.Array();
            }
            if(answer == "M")
            {
                L6.Math();
            }

            else
            { Console.WriteLine("Perhaps some other time then."); }
        }


    }
}
