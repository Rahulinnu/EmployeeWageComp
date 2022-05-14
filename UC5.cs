using System;
namespace EmployeeWageComp
{
    public class UC5
    {
        public void UsCa5()
        {
            Console.WriteLine("Welcome to UC5");


            int totalWorkingHour = 0, wagePerHour = 20, dailyWage = 0;
            int totalWorkingDay = 1, workinghour;

            while (totalWorkingDay < 20)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        workinghour = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        workinghour = 4;
                        Console.WriteLine("Employee is Parttime Worker");
                        break;
                    default:
                        workinghour = 0;
                        Console.WriteLine("Employee is Absent");
                        break;


                }
                totalWorkingDay++;
                totalWorkingHour = totalWorkingHour + workinghour;

            }
            dailyWage = wagePerHour * totalWorkingHour;


            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine();
        }
    }
}
