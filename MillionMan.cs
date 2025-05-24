using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Cool_Coding
{
    class ProgramTwo
    {
        static string[] Question(string subj)
        {
            string que = "_";
            string ans = "_";
            string[] ast = {"What is the 6th planet in the solar system?",
                            "What is the bigest planet in the solar system?",
                            "How many plantes are in the solar system?",
                            "What is the scope of the Earth?",
                            "Is the sun in the solar system is the bigest sun in the universe?"};

            string[] ani = {"Do elephents can jump?",
                            "Which animal has a Pinscher breed?",
                            "Does the dodo animal extinct?",
                            "How many dog-years is 1 human-year?",
                            "Complete the song: Dance ______"};

            string[] eng = {"How do you say 'yes' when someone asked you a question: Yes, I am / Yes, I'm ?",
                            "Is:'I've finished watching the series' past simple/present perfect?",
                            "Complete have/has: The dogs ____ 4 legs",
                            "Flown - V1/V2/V3?",
                            "True/False - The word 'human' are only privileged for men, not to women"};

            string[] mat = {"10(2x + 6) = 100\nx = ?",
                            "What comes first? power (ex. 3^2 or 3**2) or parenthesis (ex. () or [] or {} )?",
                            "How much is 5! ?",
                            "How much is 8^3 or 8**3 ?",
                            "What is the squre root of 169?"};

            string[] cou = {"In which country the eiffel tower located?",
                            "What sea does Israel border to the south? ",
                            "What is the bigest country today?",
                            "Northern Ireland, Wales, Scotland and England make up the _______",
                            "Which country hosted the 2022 world cup?"};

            string[] cap = {"Paris is the capital of?",
                            "What is the name of the israeli capital?",
                            "What is the capital of Egypt?",
                            "Amsterdam is the capital of?",
                            "Berlin is the capital of?"};

            string[] fla = {"This is the flag of...\nBlack\nRed\nYellow",
                            "Which country has a Star of David on it's flag?",
                            "Which country has 13 lines and 50 stars on it's flag?",
                            "This is the flag of...\nBlue | White | Red",
                            "This is the flag of...\nRed\nWhite\nblue"};

            string[] com = {"CPU i7 is belong to intel / AMD ?",
                            "Keyboard, Mice, Mic are input / output ?",
                            "Headphones, Monitor, Speaker are input / output ?",
                            "RGB stands for ______",
                            "True/False - computer can work without RAM?"};

            string[] pho = {"Phone 14 pro max belong to the company ______",
                            "Which phone company haven't created a phone with 4 cameras?",
                            "Does Apple created iPhone 9 ?",
                            "Which phone comapny created a foldable phone?",
                            "Phone S22 ultra belong to the company _______"};

            string[] seq = {"601 = 2\n547 = 0\n794 = 1\n180 = 3\n869 = ?",
                            "5, 20, 10, 40, 20, 80, ?",
                            "7, 9, 11, 13, 15, ?",
                            "1, 1, 3, 5, 8, 13, ?",
                            "1, 2, 3, 5, 7, 11, ?"};

            string[] fri = {"In which season did Joey start to say his famous line \"How you doin'\" ?",
                            "How many pages does the letter that Rachel wrote to Ross have?",
                            "What is the name of the high school Monica, Ross and Rachel went to?",
                            "What is the name of Rachel's boyfriend who didn't speak English and was from another country?",
                            "How many nipples does Chandler have?"};
            
            string[] soc = {"How many minutes are added in total in extra time?",
                            "Which country won the 2022 World Cup?",
                            "In what year did Israel participated in the World Cup?",
                            "According to the official FIFA rulebook, how many seconds can a goalkeeper hold the ball?",
                            "The UEFA Champions League occur every how many years?"};

            string[] jud = {"How many candles do we light in Hannucka in total?",
                            "How many days do we count in the Counting of the Omer?",
                            "What is the name of the man who led the Israelites out of Egypt? (In his jewish name)",
                            "How many breastplate stones are there?",
                            "What is the biblical name of the land of Israel?"};

            string[] min = {"How many dimensions are in the game?",
                            "What creature drops both iron and poppies?",
                            "What is the rarest color of sheep that you can find?",
                            "How many blocks are needed to build a full beacon? (Excluding the beacon itself)",
                            "What sneaky mob goes kaboom when you light it up with Flint and Steel?"};

            string[] hum = {"How many senses do humans have?",
                            "Which organ is responsible for pumping blood throughout the body?",
                            "What is the water percentage in an adult man?",
                            "What is the largest organ?",
                            "What is the name of the male genitalia?"};
            
            string[] _ast = {"Saturn","Jupiter","8","40,000","No",};
            string[] _ani = {"No","Dog","Yes","7","Monkey"};
            string[] _eng = {"Yes, I am","Present Perfect","Have","V3","False"};
            string[] _mat = {"2","Power","120","512","13"};
            string[] _cou = {"France","Red Sea","Rusia","UK","Qatar"};
            string[] _cap = {"France","Jerusalem","Cairo","Netherlands","Germany"};
            string[] _fla = {"Germany","Israel","USA","France","Netherlands"};
            string[] _com = {"Intel","Input","Output","Red Green Blue","False"};
            string[] _pho = {"Apple","Apple","No","Samsung","Samsung"};
            string[] _seq = {"4","40","17","21","13"};
            string[] _fri = {"4","18","Lincoln High","Paolo","3"};
            string[] _soc = {"30","Argentina","1970","6","1"};
            string[] _jud = {"44","49","Moshe","12","Canaan"};
            string[] _min = {"3","Iron Golem","Pink","164","Creeper"};
            string[] _hum = {"5","Heart","60","Skin","Penis"};

            Random numQue = new Random();
            int queNum = numQue.Next(0,5);

            switch (subj)
            {
                case "Astronomy":
                    que = ast[queNum];
                    ans = _ast[queNum];
                    break;
                case "Animals":
                    que = ani[queNum];
                    ans = _ani[queNum];
                    break;
                case "English":
                    que = eng[queNum];
                    ans = _eng[queNum];
                    break;
                case "Math":
                    que = mat[queNum];
                    ans = _mat[queNum];
                    break;
                case "Countries":
                    que = cou[queNum];
                    ans = _cou[queNum];
                    break;
                case "Capitals":
                    que = cap[queNum];
                    ans = _cap[queNum];
                    break;
                case "Flags":
                    que = fla[queNum];
                    ans = _fla[queNum];
                    break;
                case "Computers":
                    que = com[queNum];
                    ans = _com[queNum];
                    break;
                case "Phones":
                    que = pho[queNum];
                    ans = _pho[queNum];
                    break;
                case "Sequences":
                    que = seq[queNum];
                    ans = _seq[queNum];
                    break;
                case "Friends":
                    que = fri[queNum];
                    ans = _fri[queNum];
                    break;
                case "Soccer":
                    que = soc[queNum];
                    ans = _soc[queNum];
                    break;
                case "Judaism":
                    que = jud[queNum];
                    ans = _jud[queNum];
                    break;
                case "Minecraft":
                    que = min[queNum];
                    ans = _min[queNum];
                    break;
                case "Human Body":
                    que = hum[queNum];
                    ans = _hum[queNum];
                    break;
            }
            string[] queAns = {que,ans};

            return queAns;
        }

        static List<string> usedSubjects = new List<string>();

        static string ChosQue()
        {
            int firSub, secSub;

            string _sub = "_";
            string firstSubject, secondSubject;
            string chosenSub;

            Random sub = new Random();

            string[] subjcets = {"Astronomy","Animals","English","Math","Countries","Capitals","Flags","Computers","Phones","Sequences","Friends",
                                "Soccer","Judaism","Minecraft","Human Body"};

            do
            {
                firSub = sub.Next(0,15);
                firstSubject = subjcets[firSub];
            } while(usedSubjects.Contains(firstSubject));

            do
            {
                secSub = sub.Next(0,15);
                secondSubject = subjcets[secSub];
            } while(secondSubject == firstSubject || usedSubjects.Contains(secondSubject));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(firstSubject + " / " + secondSubject + " ?");
            PlayerColor();
            chosenSub = Console.ReadLine() ?? "";
            while(chosenSub == "" || (chosenSub.ToLower() != firstSubject.ToLower() && chosenSub.ToLower() != secondSubject.ToLower()))
            {
                ComputerColor();
                Console.WriteLine("Invalid subject! Try again: ");
                PlayerColor();
                chosenSub = Console.ReadLine() ?? " ";
            }

            usedSubjects.Add(chosenSub);

            ComputerColor();
            if(chosenSub.ToLower() == firstSubject.ToLower())
            {
                Console.WriteLine("You chose "+firstSubject+"!");
                _sub = firstSubject;
            } else
            {
                Console.WriteLine("You chose "+secondSubject+"!");
                _sub = secondSubject;
            }
            return _sub;
        }

        static void Main2(string[] args)
        {
            Console.Title = "MillioMan Game";

            // Something

            int balance, originalBalance;
            string finalAns;
            
            string name;
            string ans;
            string _sub;

            string[] backQue;

            Thread.Sleep(500);
            Console.WriteLine("Welcome to MillioMan!");
            Thread.Sleep(1500);
            Console.WriteLine("Here you will answer 10 questions to get 1M$ and become a MillioMan!");
            Thread.Sleep(2000);
            Console.WriteLine("If you answer wrong you will lose ALL of your progress - so BE CAREFUL!");
            Thread.Sleep(2000);
            Console.Write("What is your name? ");
            PlayerColor();
            name = Console.ReadLine() ?? "";
            while(name == "")
            {
                ComputerColor();
                Console.WriteLine("Invalid answer! Try again: ");
                PlayerColor();
                name = Console.ReadLine() ?? " ";
            }

            ComputerColor();
            Console.Write("And what is your bank account's balance? ");
            PlayerColor();
            string temp = Console.ReadLine() ?? "";
            while(temp == "")
            {
                bool invalid = false;
                for(int i=0; i<temp.Length ; i++)
                {
                    if(temp[i] < '0' || temp[i] > '9')
                    {
                        invalid = true;
                    }
                }
                if(invalid)
                {
                    ComputerColor();
                    Console.WriteLine("Invalid answer! Try again: ");
                    PlayerColor();
                    temp = Console.ReadLine() ?? "";
                }
            }
            balance = Convert.ToInt32(temp);
            originalBalance = balance;

            ComputerColor();
            Console.WriteLine("There are a few important notes that you need to know:");
            Thread.Sleep(1000);
            Console.WriteLine("1. If you can, right in shortcuts (for example: 'USA' instead of 'United States of America')");
            Console.WriteLine("2. If you need to answer a number, type the number and not the word (for examle: '9' instead of 'nine')");
            Console.WriteLine("3. If there is, answer according to the format specified in the question itself (for example: '(True/False)')");
            Console.WriteLine("4. Watch out for any spelling mistake. You don't need to mind the upper/lower case (for example: both 'No' and 'no' are fine)");
            Console.WriteLine("Ready?");
            PlayerColor();
            Console.ReadLine();

            ComputerColor();
            do
            {
                GameOn();

                string[] questionNumberX = {"First", "Second", "Third", "Forth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth (and last!)"};
                for (int i = 1; i <= 10; i++)
                {
                    ComputerColor();
                    Console.WriteLine(questionNumberX[i-1] + " question:");
                    Thread.Sleep(1000);

                    _sub = ChosQue();
                    Thread.Sleep(1000);

                    Console.WriteLine("Your question is:\n");
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    backQue = Question(_sub);
                    Console.WriteLine(backQue[0]);
                    
                    PlayerColor();
                    ans = Console.ReadLine() ?? "";
                    while(ans == "")
                    {
                        ComputerColor();
                        Console.WriteLine("Invalid answer! Try again: ");
                        PlayerColor();
                        ans = Console.ReadLine() ?? " ";
                    }

                    ComputerColor();
                    Thread.Sleep(1000);
                    Console.WriteLine("\nAnd...");
                    Thread.Sleep(1500);
                    if (ans.ToLower() == backQue[1].ToLower())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("YOU ARE RIGHT! Good Job!");
                        ComputerColor();
                        Thread.Sleep(1500);
                        Console.WriteLine("You got 100,000$");
                        balance += 100000;
                        Thread.Sleep(1500);
                        Console.WriteLine("Your balance is now: " + FullBalance(balance));
                        Thread.Sleep(2000);
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your answer is wrong...");
                        Thread.Sleep(2000);
                        ComputerColor();
                        Console.WriteLine("You lost all your progress, so your balance is back to: " + FullBalance(originalBalance));
                        balance = originalBalance;
                        break;
                    }

                    if(i != 10)
                    {
                        Console.WriteLine("\nAre you ready to keep going?");
                        PlayerColor();
                        Console.ReadLine();
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    } else
                    {
                        Console.WriteLine("\nCongratulation! you finished the game!");
                        Thread.Sleep(1500);
                        Console.WriteLine("Feels good to be a millionaire right?");
                    }
                }
                Thread.Sleep(1500);
                Console.WriteLine("Do you want to play again? (Yes/No)");
                PlayerColor();
                finalAns = Console.ReadLine() ?? "";
                ComputerColor();                    
            } while (finalAns.ToLower() == "yes");

            Thread.Sleep(1000);
            Console.WriteLine("Too bad...");
            Thread.Sleep(1000);
            Console.WriteLine("Well, Good Bye!");
            Thread.Sleep(2000);
        }
        
        public static string FullBalance(int balance)
        {
            string fullBalance = "";
            for(int i=balance.ToString().Length-1; i>=0; i--)
            {
                fullBalance += balance.ToString()[balance.ToString().Length - 1 - i];
                if(i %3 == 0 && i != 0)
                {
                    fullBalance += ",";
                }
            }
            return fullBalance + "$";
        }

        public static void GameOn()
        {
            Console.WriteLine("Nice! Let's get started!");
            Thread.Sleep(1500);
            Console.WriteLine("The game is starting in...");
            Thread.Sleep(500);
            for (int i = 3; i > 0; i--)
            {
                if(i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else if(i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                } else if(i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("G");Thread.Sleep(500);
            Console.Write("A");Thread.Sleep(500);
            Console.Write("M");Thread.Sleep(500);
            Console.Write("E");Thread.Sleep(500);
            Console.Write(" O");Thread.Sleep(500);
            Console.Write("N");Thread.Sleep(500);
            Console.Write("!");Thread.Sleep(500);
            Console.Write("!");Thread.Sleep(500);
            Console.WriteLine("!");
            ComputerColor();
            Thread.Sleep(2000);
        }

        public static void ComputerColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PlayerColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}