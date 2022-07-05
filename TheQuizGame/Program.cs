using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizGame
{
    internal class Program
    {
        //Arrays for Menu
        //Array showing the three category options the user can choose
        public static string[] categorys = { "GeneralKnowledge", "Entertainment", "Science" };
        //String array of the number input options the user can select 
        public static string[] menuOptions = { "1", "2", "3" };

        //users input 
        public static string input = "";

        //users options for the questions
        public static string[] answerOptions = { "t", "f" };
        public static string userAnswer = "";

        //score starts at 0
        public static int score = 0;


        //Start of code for the Menu
        public static void Menu()
        {
            //The menu that will be displayed to the user
            Console.WriteLine("Welcome to The Quiz!");
            Console.WriteLine("You will be given 5 questions in which you will need to answer by saying whether they are True [T] or False [F]. Each question answered correctly you will recive 1+ point.");

            Console.WriteLine("\n");
            Console.WriteLine("Please select a category to start...");
            Console.WriteLine("\tGeneral Knowledge - Press [1]");
            Console.WriteLine("\tEntertainment - Press [2]");
            Console.WriteLine("\tScience - Press [3]");



            CheckInput();

            if (input == "1")
            {
                GeneralKnowledge();
            }

            if (input == "2")
            {
                Entertainment();
            }

            if (input == "3")
            {
                Science();
            }
        }//end of menu
        //function that checks the users input for menu is valid
        public static void CheckInput()
        {
            bool check = false;

            while (check == false)
            {
                input = Console.ReadLine();
                //only allowing 1,2,3
                foreach (string temp in menuOptions)
                {
                    check = input.Equals(temp);

                    if (check)
                    {
                        break;
                    }

                }//end of foreasch

                if (check)
                {
                    Console.WriteLine("You pressed [" + input + "]");
                }
                else
                {
                    Console.WriteLine("Your input is not valid, please try again by pressing [1] [2] or [3]");
                }
            }//end of while loop
        }// end of CheckInput

        //function checks if user answers are valid
        public static void CheckAnswers()
        {
            bool check = false;

            while (check == false)
            {
                userAnswer = Console.ReadLine();
                //only allowing user to input t/f 
                foreach (string temp in answerOptions)
                {
                    check = userAnswer.Equals(temp);

                    if (check)
                    {
                        break;
                    }

                }//end of foreasch

                if (check)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please try again by pressing [T] or [F]");
                }
            }//end of while loop
        }
        public static void GeneralKnowledge()
        {
            if (input == "1")
            {
                //Arrays of answers for this category
                string[] generalKnowledgeAnswer = { "t", "f", "f", "t", "f" };
                //Displays message to user
                Display();
                //Code for General Knowledge questions
                Console.WriteLine("Months that begin with Sunday will always have a Friday the 13th");
                CheckAnswers();
                if (userAnswer == generalKnowledgeAnswer[0])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Russia is the largest populated country in the world");
                CheckAnswers();
                if (userAnswer == generalKnowledgeAnswer[1])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\n");
                Console.WriteLine("‘A’ is the most commonly used letter in the English language");
                CheckAnswers();
                if (userAnswer == generalKnowledgeAnswer[2])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. It is the letter 'E'");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Vending machines kill more people a year than sharks");
                CheckAnswers();
                if (userAnswer == generalKnowledgeAnswer[3])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\n");
                Console.WriteLine("The larger the pepper is the hotter it is");
                CheckAnswers();
                if (userAnswer == generalKnowledgeAnswer[4])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
                End();
            }//End General Knowledge

        }

        public static void Entertainment()
        {
            if (input == "2")
            {
                //Array of answers for this category
                string[] entertainmentAnswers = { "t", "f", "t", "t", "f" };
                //Displays message to user
                Display();
                //Code for entertainment questions
                Console.WriteLine("\nWill Smith has a 10 year Oscar ban after slapping Chris Rock at the 2022 Oscars");
                CheckAnswers();
                if (userAnswer == entertainmentAnswers[0])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\nAvengers: Endgame is ranked number 1 for highest grossing film");
                CheckAnswers();
                if (userAnswer == entertainmentAnswers[1])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. It is ranked 2nd after Avatar");
                }
                Console.WriteLine("\n");
                Console.WriteLine("There are only 4 theatres located on the street of Broadway");
                CheckAnswers();
                if (userAnswer == entertainmentAnswers[2])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Every episode title (except one) of the show Grey's Anatomy is named after a song title");
                CheckAnswers();
                if (userAnswer == entertainmentAnswers[3])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
                Console.WriteLine("\n");
                Console.WriteLine("All the kardashians/Jenners names start with the letter 'K'");
                CheckAnswers();
                if (userAnswer == entertainmentAnswers[4])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. There is a brother named Rob");
                }
                End();

            }//end Entertainment
        }

        public static void Science()
        {
            if (input == "3")
            {
                //Array of answers for this category
                string[] scienceAnswers = { "t", "f", "t", "f", "f" };
                //Displays message to user
                Display();
                //Code for science questions 

                Console.WriteLine("Anti-matter is the opposite of matter");
                CheckAnswers();
                if (userAnswer == scienceAnswers[0])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\n");
                Console.WriteLine("The moon is just 50 percent of the mass of the Earth");
                CheckAnswers();
                if (userAnswer == scienceAnswers[1])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. It is only less than 1 percent");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Jupiter and Saturn have diamond rain");
                CheckAnswers();
                if (userAnswer == scienceAnswers[2])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                Console.WriteLine("\n");
                Console.WriteLine("There are five different blood groups");
                CheckAnswers();
                if (userAnswer == scienceAnswers[3])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. There are 8");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Metorolgy is the study of meteorites");
                CheckAnswers();
                if (userAnswer == scienceAnswers[4])
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. It is the study of weather");
                }
                //Takes user to the end where they see score
                End();
            }//End Science
        }

        public static void Display()
        {
            Console.WriteLine("\nTrue or False:");
        }
        public static void End()
        {
            //Number of questions per category
            double num1 = 5;
            //percentage out of 100
            int num2 = 100;

            //What users see when they finish the questions
            Console.WriteLine("\nDone!");
            Console.WriteLine("You got " + ((score / num1) * num2) + "% of answers correct with a score of: " + score);
            Console.WriteLine("\nGo back to menu to check out the other categories!");
            //End menu
            Console.WriteLine("\tMenu - Press [M]");
            Console.WriteLine("\tExit - Press [X]");
            input = Console.ReadLine();

            if (input == "m")
            {
                Menu();
            }

            if (input == "x")
            {
                Console.WriteLine("Thank you for playing!");
            }
        }//End of section
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
