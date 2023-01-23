//using System;

//namespace Seven
//{
//    class Programm
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter Number here");
//            int num = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(Sevenizer(num));

//        }
//        static int Sevenizer(int num)
//        {
//            if (num % 7 == 0)
//            {
//                return num;
//            }
//            else if (num < 7)
//            {
//                num = 7;
//                return num;
//            }
//            else if (num % 7 < 4)
//            {
//                return num / 7 * 7;
//            }
//            else
//            {
//                return ((num + 4) / 7) * 7;
//            }
//        }
//    }
//}



//using System;

//namespace Addme
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter number here");
//            int num = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(Adder(num));
//        }
//        static int Adder(int num)
//        {
//            int sum = 0;
//            if (num > 0)
//            {
//                for (int i = 0; i <= num; i++)
//                {
//                    sum += i;
//                }

//            }
//            else if (num == 0)
//            {

//            }
//            else
//            {
//                for (int i = 0; i >= num; i--)
//                {
//                    sum += i;

//                }
//            }
//            return sum;
//        }

//    }
//}



//using System;

//namespace Global
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter two words here to find out which one is longer");
//            string word1 = Console.ReadLine();
//            string word2 = Console.ReadLine();
//            Console.WriteLine(charCount(word1, word2));
//        }
//        static string charCount(string word1, string word2)
//        {
//            if (word1.Length == word2.Length)
//            {
//                return ($"Words {word1} and {word2} have same amount of letters");
//            }
//            else if (word1.Length > word2.Length)
//            {
//                return ($"Word {word1} is longer than Word {word2}");
//            }
//            else
//            {
//                return ($"Word {word2} is longer than Word {word1}");
//            }

//        }
//    }
//}
