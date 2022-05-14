using System;
namespace EmployeeWageComp
{
    public class UC6
    {
        public void UsCa6()
        {
            Console.WriteLine("Welcome to UC6");

            int totalWorkingday = 0, empratePerHour = 20, totalhour = 0;
            int num_of_workingDay = 20, max_Hour_In_a_month = 100, empHrs = 0;
            int totalSalary = 0;

            while (totalhour <= max_Hour_In_a_month && totalWorkingday < num_of_workingDay)

            {
                totalWorkingday++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);

                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is doing parttime:");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalhour += empHrs;
                Console.WriteLine("Day :" + totalWorkingday + "Daily worked hour", +empHrs);
            }
            totalSalary = totalhour * empratePerHour;
            Console.WriteLine("Total Employee wage is: " + totalSalary);
            Console.ReadLine();
        }
    }
}
