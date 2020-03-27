using System;
namespace lesson3
{
    public class Programm
    {
        static void Main()
        {

            decimal userBalance = 300m;
            string basket = "";
            string erroBalanceMessage = "You have'nt any money in you balance!";

        start: //Метка "start"

            System.Console.WriteLine($"You balance - {userBalance}");

            if (userBalance <= 0)
            {
                System.Console.WriteLine(erroBalanceMessage);
                goto End;
            };

            System.Console.WriteLine("" +
            "1 Cola - 10 somoni\n" +
            "2 Snikers - 7 somoni\n" +
            "3 Mars - 9 somoni\n" +
            "4 M&Ms - 4 somoni\n" +
            "5 Chipsi - 14 somoni\n" +
            "6 Exit\n" +
            "Your choice (1-6):");

            int choice = int.Parse(Console.ReadLine());

            // goto start; //идти к метке "start"
            switch (choice)
            {
                case 1:
                    {
                        if (userBalance - 10 >= 0)
                        {
                            basket += "Cola,";
                            userBalance -= 10;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("You want to continue? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;

                case 2:
                    {
                          if (userBalance - 7 >= 0)
                        {
                            basket += "Snikers,";
                            userBalance -= 7;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("You want to continue? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                         case 3:
                    {
                          if (userBalance - 9 >= 0)
                        {
                            basket += "Mars,";
                            userBalance -= 9;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("You want to continue? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    
                     case 4:
                    {
                          if (userBalance - 4 >= 0)
                        {
                            basket += "M&Ms,";
                            userBalance -= 4;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("You want to continue? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    break;
                    
                     case 5:
                    {
                          if (userBalance - 14 >= 0)
                        {
                            basket += "Chipsido,";
                            userBalance -= 14;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("You want to continue? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                
                case 6: goto End;
                default: goto start;
                break;
            }

        End:
            System.Console.WriteLine($"You product:{basket}\nYou balance:{userBalance}");
            Console.ReadKey();
        }
    }
}