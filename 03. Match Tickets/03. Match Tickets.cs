using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double result = 0;
            switch (category)
            {
                case "Normal":
                    if (people <= 4)
                    {
                        double cash = allMoney * 0.75;
                        double bilets = people * 249.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 9)
                    {
                        double cash = allMoney * 0.6;
                        double bilets = people * 249.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 24)
                    {
                        double cash = allMoney * 0.5;
                        double bilets = people * 249.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 59)
                    {
                        double cash = allMoney * 0.4;
                        double bilets = people * 249.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people > 49)
                    {
                        double cash = allMoney * 0.25;
                        double bilets = people * 249.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }break;
                    //VIP part
                case "VIP":
                    if (people <= 4)
                    {
                        double cash = allMoney * 0.75;
                        double bilets = people * 499.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 9)
                    {
                        double cash = allMoney * 0.6;
                        double bilets = people * 499.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 24)
                    {
                        double cash = allMoney * 0.5;
                        double bilets = people * 499.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people <= 49)
                    {
                        double cash = allMoney * 0.4;
                        double bilets = people * 499.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }
                    if (people > 49)
                    {
                        double cash = allMoney * 0.25;
                        double bilets = people * 499.99;
                        result = Math.Abs(allMoney - cash) - bilets;
                        if (result >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(result));
                        }
                        break;

                    }break;

                    
            }
        }
    }
}
