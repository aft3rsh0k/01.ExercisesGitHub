using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hotel_roms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepDays = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            if (month == "May" || month == "October")
            {
                if (sleepDays > 7 && sleepDays <= 14)
                {
                    studioPrice = 50.00;
                    apartmentPrice = 65.00;
                    double studioPriceCoast = studioPrice * 0.05;
                    double totalStudioPrice = studioPrice - studioPriceCoast;
                    double totalCashForDaysInStudio = sleepDays * totalStudioPrice;

                    double totalCashForDaysInApartment = sleepDays * apartmentPrice;

                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);
                }

                else if (sleepDays > 14)
                {
                    studioPrice = 50.00;
                    apartmentPrice = 65.00;
                    double studioPriceCoast = studioPrice * 0.30;
                    double totalStudioPrice = studioPrice - studioPriceCoast;
                    double totalCashForDaysInStudio = sleepDays * totalStudioPrice;

                    double apartmentPriceCoast = apartmentPrice * 0.10;
                    double totalApartmentPrice = apartmentPrice - apartmentPriceCoast;
                    double totalCashForDaysInApartment = sleepDays * totalApartmentPrice;

                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);
                }
                else
                {
                    studioPrice = 50.00;
                    apartmentPrice = 65.00;

                    studioPrice = studioPrice * sleepDays;
                    apartmentPrice = apartmentPrice * sleepDays;

                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (sleepDays > 14)
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    double studioPriceCoast = studioPrice * 0.20;
                    double totalStudioPrice = studioPrice - studioPriceCoast;
                    double totalCashForDaysInStudio = sleepDays * totalStudioPrice;

                    double apartmentPriceCoast = apartmentPrice * 0.10;
                    double totalApartmentPrice = apartmentPrice - apartmentPriceCoast;
                    double totalCashForDaysInApartment = sleepDays * totalApartmentPrice;

                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);
                }
                else if (sleepDays > 7 && sleepDays <= 14)
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;

                    double totalCashForDaysInStudio = sleepDays * studioPrice;
                    double totalCashForDaysInApartment = sleepDays * apartmentPrice;
                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);

                }
                else
                {
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;

                    studioPrice = studioPrice * sleepDays;
                    apartmentPrice = apartmentPrice * sleepDays;

                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            else if (month == "July" || month == "August")
            {
                if (sleepDays > 7 && sleepDays <= 14)
                {
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;

                    double totalCashForDaysInStudio = sleepDays * studioPrice;
                    double totalCashForDaysInApartment = sleepDays * apartmentPrice;

                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);
                }
                else if (sleepDays > 14)
                {
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;

                    double totalCashForDaysInStudio = sleepDays * studioPrice;
                    double apartmentPriceCoast = apartmentPrice * 0.10;
                    double totalApartmentPrice = apartmentPrice - apartmentPriceCoast;
                    double totalCashForDaysInApartment = sleepDays * totalApartmentPrice;

                    Console.WriteLine("Apartment: {0:f2} lv.", totalCashForDaysInApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", totalCashForDaysInStudio);

                }
                else
                {
                    studioPrice = 76.00;
                    apartmentPrice = 77.00;

                    studioPrice = studioPrice * sleepDays;
                    apartmentPrice = apartmentPrice * sleepDays;

                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }     
        }
    }
}
