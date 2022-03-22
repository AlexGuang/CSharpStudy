using System;

namespace ConsoleGameTicTacToe
{

    internal class Program
    {
        public static string[,] meticGmae = new string[11, 11];
        public static int step = 1;
        public static string input = "";
        public static int intInput;
        public static int r;
        public static int c;
        public static string recordInput;
        public static bool IsChange;

        static void Main(string[] args)
        {
            while (true)
            {
                Initialize();
               
                GameStart();

            }



        }
        public static void Initialize()
        {
            step = 1;
            input = "";
            intInput = 0;
            r = 0;
            c = 0;
            recordInput = "";
            IsChange = false;   

        }
        public static void CreateMetric()
        {
            for (int i = 0; i < meticGmae.GetLength(0); i++)
            {
                for (int j = 0; j < meticGmae.GetLength(1); j++)
                {
                    meticGmae[i, j] = " ";
                }

            }

            for (int m = 0; m < meticGmae.GetLength(0); m++)
            {
                meticGmae[m, 3] = "|";
                meticGmae[m, 7] = "|";
            }
            for (int n = 0; n < meticGmae.GetLength(1); n++)
            {
                meticGmae[3, n] = "-";
                meticGmae[7, n] = "-";
            }
            meticGmae[3, 3] = meticGmae[3, 7] = meticGmae[7, 3] = meticGmae[7, 7] = "+";

            meticGmae[1, 1] = "1";
            meticGmae[1, 5] = "2";
            meticGmae[1, 9] = "3";
            meticGmae[5, 1] = "4";
            meticGmae[5, 5] = "5";
            meticGmae[5, 9] = "6";
            meticGmae[9, 1] = "7";
            meticGmae[9, 5] = "8";
            meticGmae[9, 9] = "9";
        }
        public static void DisplayMetric()
        {
            Console.Clear();
            for (int i = 0; i < meticGmae.GetLength(0); i++)
            {
                for (int j = 0; j < meticGmae.GetLength(1); j++)
                {
                    Console.Write(meticGmae[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            Console.WriteLine("{0} : Choose your field !", isPlay1() ? "Player 1" : "Player 2");
        }
        public static bool IsRecord(string input)
        {
            if (recordInput.Contains(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void GameStart()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            CreateMetric();
            DisplayMetric();
            DisplayMetric();
            input = Console.ReadLine();
            while (true)
            {
                
                if (!IsInputCheck())
                {                                       
                    input = Console.ReadLine();
                    continue;
                }                          
                
                recordInput += input;
                if (isPlay1())
                {
                    step++;
                    PressButton(intInput, out r, out c);

                    player1.sumString += input;
                    meticGmae[r, c] = "O";
                    
                    if (step > 5)
                    {
                        if (Player1Win(player1))
                        {
                            DisplayMetric();
                            Console.WriteLine("Player 1 has won!\n" +
                                "Press any Key to Reset the Game");
                            Console.ReadKey();
                            Console.Clear();

                            return;
                        }
                    }
                   // input = "hahahahahahah";
                }
                else
                {
                    step++;
                    PressButton(intInput, out r, out c);
                    player2.sumString += input;
                    meticGmae[r, c] = "X";
                    

                    if (step > 6)
                    {
                        if (Player1Win(player2))
                        {
                            DisplayMetric();
                            Console.WriteLine("Player 2 has won!\n" +
                                "Press any Key to Reset the Game");
                            Console.ReadKey();
                            Console.Clear();
                            return;
                        }
                    }
                    //input = "hahahahahahah";
                }
            }
        }
    
        public static bool IsInputCheck()
        {
            
            if (!int.TryParse(input, out intInput))
            {                
                Console.WriteLine("Please only enter one number from '1' to '9' ");
                Console.WriteLine();
                Console.WriteLine("{0} : Choose your field !", isPlay1() ? "Player 1" : "Player 2");
               
                return false;
            }
            else if (IsRecord(input))
            {
                Console.WriteLine("放你妈的大臭屁！");
                Console.WriteLine("Incorrect input! Please use another field!");
                Console.WriteLine();
                Console.WriteLine("{0} : Choose your field !", isPlay1() ? "Player 1" : "Player 2");
               
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isPlay1()
        {
            if (step % 2 == 1)
                return true;
            else
                return false;
        }
        public static bool Player1Win(Player player)
        {
            if (player.sumString.Contains("1") && player.sumString.Contains("2") && player.sumString.Contains("3"))
            {
                return true;
            }
            else if (player.sumString.Contains("1") && player.sumString.Contains("4") && player.sumString.Contains("7"))
            {
                return true;
            }
            else if (player.sumString.Contains("1") && player.sumString.Contains("3") && player.sumString.Contains("9"))
            {
                return true;
            }
            else if (player.sumString.Contains("2") && player.sumString.Contains("5") && player.sumString.Contains("8"))
            {
                return true;
            }
            else if (player.sumString.Contains("3") && player.sumString.Contains("6") && player.sumString.Contains("9"))
            {
                return true;
            }
            else if (player.sumString.Contains("3") && player.sumString.Contains("5") && player.sumString.Contains("7"))
            {
                return true;
            }
            else if (player.sumString.Contains("4") && player.sumString.Contains("5") && player.sumString.Contains("6"))
            {
                return true;
            }
            else if (player.sumString.Contains("9") && player.sumString.Contains("8") && player.sumString.Contains("7"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PressButton(int input, out int r, out int c)
        {
            switch (input)
            {
                case 1:
                    r = 1;
                    c = 1;
                    break;
                case 2:
                    r = 1;
                    c = 5;
                    break;
                case 3:
                    r = 1;
                    c = 9;
                    break;
                case 4:
                    r = 5;
                    c = 1;
                    break;
                case 5:
                    r = 5;
                    c = 5;
                    break;
                case 6:
                    r = 5;
                    c = 9;
                    break;
                case 7:
                    r = 9;
                    c = 1;
                    break;
                case 8:
                    r = 9;
                    c = 5;
                    break;
                case 9:
                    r = 9;
                    c = 9;
                    break;
                default:
                    r = 0;
                    c = 0;
                    break;
            }

            return;
        }
    }

}
    


