using System;
namespace EmployeeWageComp
{
    public class UC2
    {
        public void UsCa2()
        {
            Random random = new Random();
            int is_fulltime = 1;
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            int empCheck = random.Next(0, 2);

            if (empCheck == is_fulltime)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total wage of a day: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                dailyWage = totalWorkingHour * 0;
                Console.WriteLine("Total wage of a day: " + dailyWage);

            }
            Console.ReadLine();
        }
    }
}
