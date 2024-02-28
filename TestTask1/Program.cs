using System;
using System.Collections.Generic;

namespace TestTask1
{
    public class Program
    {

        public string FizzBuzz(int Number)
        {
            return Number % 3 == 0 ? (Number % 5 == 0 ? "fizz-buzz" : "fizz") : Number % 5 == 0 ? "buzz" : Number.ToString();
        }

        public string FizzBuzzMuzzGuzz(int Number)
        {
            string temp = "";

            if (Number % 3 == 0) temp += "fizz";
            if (Number % 5 == 0) temp += temp.Length > 1 ? "-buzz" : "buzz";
            if (Number % 4 == 0) temp += temp.Length > 1 ? "-muzz" : "muzz";
            if (Number % 7 == 0) temp += temp.Length > 1 ? "-guzz" : "guzz";
            if (temp.Length < 1) return Number.ToString();
            return temp;
        }

        public string GoodBoyMuzzGuzz(int Number)
        {
            string temp = "";

            if (Number % 3 == 0) temp += Number % 5 == 0 ? "good-boy" : Number % 4 == 0 || Number % 7 == 0 ? "fizz" : "dog";
            else temp = Number % 5 == 0 ? (Number % 4 == 0 || Number % 7 == 0 ? "buzz" : "cat") : "";

            if (Number % 4 == 0) temp += temp.Length > 1 ? "-muzz" : "muzz";
            if (Number % 7 == 0) temp += temp.Length > 1 ? "-guzz" : "guzz";
            if (temp.Length < 1) return Number.ToString();

            return temp;
        }

        public string Task1(int[] Sequence)
        {
            string temp = "";

            for (int i = 0; i < Sequence.Length; i++)
            {
                temp += FizzBuzz(Sequence[i]);
                if (i < Sequence.Length - 1) temp += ",";
            }

            return temp;
        }

        public string Task2(int[] Sequence)
        {
            string temp = "";

            for (int i = 0; i < Sequence.Length; i++)
            {
                temp += FizzBuzzMuzzGuzz(Sequence[i]);
                if (i < Sequence.Length - 1) temp += ",";
            }

            return temp;
        }

        public string Task3(int[] Sequence)
        {
            string temp = "";

            for (int i = 0; i < Sequence.Length; i++)
            {
                temp += GoodBoyMuzzGuzz(Sequence[i]);
                if (i < Sequence.Length - 1) temp += ",";
            }

            return temp;
        }

        static void Main(string[] args)
        {
            Program prog = new Program();

            string answer1, answer2, answer3;
            int[] test = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,60,105,420};

            answer1 = prog.Task1(test);
            answer2 = prog.Task2(test);
            answer3 = prog.Task3(test);

            Console.WriteLine("Answer to the first task: " + answer1);
            Console.WriteLine("Answer to the secont task: " + answer2);
            Console.WriteLine("Answer to the third task: " + answer3);

            Console.ReadKey();
        }
    }
}
