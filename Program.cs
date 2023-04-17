using System;

namespace HelloWorld

{    class Game

    {
        

        static void Question1()
        {
            Console.WriteLine(" Question 1: What country has great animals like a large bird called an emu a cute and cuddly Koala or a big hopping kangaroo?");
        }
        static void Question2()
        {
            Console.WriteLine(" Question 2: What is the most slippery country in the world?");
        }
        static void Question3()
        {
            Console.WriteLine(" Question 3: What is the tallest man a live");
        }
         static void Question4()
        {
            Console.WriteLine(" Question 4: What is the tallest man a live");
        }
        static void Question5()
        {
            Console.WriteLine(" Question 5: What is the tallest man a live");
        }
        static void Question6()
        {
            Console.WriteLine(" Question 6: What is the tallest man a live");
        }
         static void Question7()
        {
            Console.WriteLine(" Question 7: What is the tallest man a live");
        }
        static void Question8()
        {
            Console.WriteLine(" Question 8: What is the tallest man a live");
        }
        static void Question9()
        {
            Console.WriteLine(" Question 9: What is the tallest man a live");
        }
        static void Question10()
        {
            Console.WriteLine("Question 10: What is the tallest man a live");
        }


        static void Main(string[] args)
        {
            string[] answer = {"Australia", "Greece", "2", "3", "4", "5", "6", "7", "8", "9"};
            string answer1;
            string answer2;
            string answer3;
            string answer4;
            string answer5;
            string answer6;
            string answer7;
            string answer8;
            string answer9;
            string answer10;
            int point = 0;

           Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to Riddle Game about countries {playerName} !");
            Console.WriteLine("Let start !");
            Question1();
            answer1 = Console.ReadLine();
            if (answer1 == answer[0])
            {
                point += 1;
                Console.WriteLine("");
        
            }
            else
            {
                Console.WriteLine("");
                point -= 1;
            }
            Question2();
            answer2 = Console.ReadLine();
            if (answer2 == answer[1])
            {
                point += 1;
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question3();
            answer3 = Console.ReadLine();
            if (answer3 == answer[2])
            {
                Console.WriteLine("");
            }
            else 
            {
                Console.WriteLine("");
            }
            Question4();
            answer4 = Console.ReadLine();
            if (answer4 == answer[3])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question5();
            answer5 = Console.ReadLine();
            if (answer5 == answer[4])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question6();
            answer6 = Console.ReadLine();
            if (answer6 == answer[5])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question7();
            answer7 = Console.ReadLine();
            if (answer7 == answer[6])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question8();
            answer8 = Console.ReadLine();
            if (answer8 == answer[7])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question9();
            answer9 = Console.ReadLine();
            if (answer9 == answer[8])
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Question10();
            answer10 = Console.ReadLine();
            if (answer10 == answer[9])
            {
                Console.WriteLine("");   
            }
            else
            {
                Console.WriteLine("");
            }

            }
        }      
      }