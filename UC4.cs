using System;
namespace EmployeeWageComp
{
    public class UC4
    {
        public void UsCa4()
        {
            Console.WriteLine("Welcome to UC4");
            Random random = new Random();
            int empCheck = random.Next(0, 3);


            int totalWorkingHour, wagePerHour = 20, dailyWage = 0;
            switch (empCheck)
            {
                case 1:
                    totalWorkingHour = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case 2:
                    totalWorkingHour = 4;
                    Console.WriteLine("Employee is Parttime Worker");
                    break;
                default:
                    totalWorkingHour = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            dailyWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine();
        }
    }
}
