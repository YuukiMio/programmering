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
            Console.WriteLine(" Question 3: What is the fastest country in the world?");
        }
         static void Question4()
        {
            Console.WriteLine(" Question 4: Which country hurts?");
        }
        static void Question5()
        {
            Console.WriteLine(" Question 5: What country can you eat?");
        }
        static void Question6()
        {
            Console.WriteLine(" Question 6: Which country is the name of a woman?");
        }
         static void Question7()
        {
            Console.WriteLine(" Question 7: Which country wants more food?");
        }
        static void Question8()
        {
            Console.WriteLine(" Question 8: Which country likes basketball?");
        }
        static void Question9()
        {
            Console.WriteLine(" Question 9: This is an Asian country whose capital is Tokyo they have a red and white flag And some wear a kimono?");
        }
        static void Question10()
        {
            Console.WriteLine("Question 10: What is the only country in Southeast Asia that was never colonized?");
        }


        static void Main(string[] args)
        {
            string[] answer = {"Australia", "Greece", "Russia", "Spain", "Turkey", "Georgia", "Hungary", "Jordan", "Japan", "Thailand"};
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
            Console.WriteLine(" Note : answer must start with capital letter!!!!");
            Question1();
            answer1 = Console.ReadLine();
            if (answer1 == answer[0])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
        
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[0]}");
                Console.WriteLine($"You have {point} point");
            }
            Question2();
            answer2 = Console.ReadLine();
            if (answer2 == answer[1])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[1]}");
                Console.WriteLine($"You have {point} point");
            }
            Question3();
            answer3 = Console.ReadLine();
            if (answer3 == answer[2])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");  
            }
            else 
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[2]}");
                Console.WriteLine($"You have {point} point");
            }
            Question4();
            answer4 = Console.ReadLine();
            if (answer4 == answer[3])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[3]}");
                Console.WriteLine($"You have {point} point");
            }
            Question5();
            answer5 = Console.ReadLine();
            if (answer5 == answer[4])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point"); 
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[4]}");
                Console.WriteLine($"You have {point} point");
            }
            Question6();
            answer6 = Console.ReadLine();
            if (answer6 == answer[5])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[5]}");
                Console.WriteLine($"You have {point} point");
            }
            Question7();
            answer7 = Console.ReadLine();
            if (answer7 == answer[6])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[6]}");
                Console.WriteLine($"You have {point} point");
            }
            Question8();
            answer8 = Console.ReadLine();
            if (answer8 == answer[7])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[7]}");
                Console.WriteLine($"You have {point} point");
            }
            Question9();
            answer9 = Console.ReadLine();
            if (answer9 == answer[8])
            {
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[8]}");
                Console.WriteLine($"You have {point} point");
            }
            Question10();
            answer10 = Console.ReadLine();
            if (answer10 == answer[9])
            {  
                point += 1;
                Console.WriteLine("Your answer is correct");
                Console.WriteLine($"You have {point} point");
            }
            else
            {
                Console.WriteLine("Your answer is wrong");
                Console.WriteLine($"The right answer is {answer[9]}");
                Console.WriteLine($"You have {point} point");
            }
            Console.WriteLine("Congratulations you have now answers all the questions");
            Console.WriteLine($"Your results is {point} point!!!!");

            }
        }      
      }