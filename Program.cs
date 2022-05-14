using System;

namespace EmployeeWageComp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to employee Wage Compuatation Program\n");
            UC9 BridgeLabz = new UC9("Bridgelabz", 20, 20, 100);
            UC9 TCS = new UC9("TCS", 40, 25, 100);
            BridgeLabz.UsCa9();
            TCS.UsCa9();
            Console.ReadLine();


        }
    }
}
