using System;
namespace EmployeeWageComp
{
    public class UC7
    {

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORK_HOURS = 100;
            public static void Usca7() 
            {
                int totalMonthWage = 0, empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0;
                Random random = new Random(); 
                while (empTotalHour <= MAX_WORK_HOURS && empTotalWorkDays <= MAX_WORKING_DAYS) 
                {
                    int check = random.Next(0, 3); 
                                                   
                    switch (check)
                    {
                        case IS_FULL_TIME:
                            Console.WriteLine("Employee is Present for Full Time");
                            empWorkHour = 8;
                            break;

                        case IS_PART_TIME:
                            Console.WriteLine("Employee is Present for Part Time");
                            empWorkHour = 4;
                            break;

                        default:
                            Console.WriteLine("Employee is Absent");
                            empWorkHour = 0;
                            break;
                    }
                    empDailyWage = empWorkHour * WAGE_PER_HOUR; 
                    Console.WriteLine($"Employee Daily Wage for Day {empTotalWorkDays} : {empDailyWage}\n");
                    totalMonthWage += empDailyWage; 
                    empTotalWorkDays++;
                    empTotalHour += empWorkHour;
                }
                if (empTotalHour > MAX_WORK_HOURS) 
                {
                    int a = empTotalHour - MAX_WORK_HOURS;
                    empTotalHour -= a;
                    int wage = a * WAGE_PER_HOUR; 
                    totalMonthWage -= wage; 
                if (empTotalWorkDays > MAX_WORKING_DAYS)
                {
                    empTotalWorkDays -= 1;
                }
                Console.WriteLine($"\nEmployee total working days  : {empTotalWorkDays}");
                Console.WriteLine($"Employee total working hours  : {empTotalHour}\n");
                Console.WriteLine($"\nEmployee Total Month Wage : {totalMonthWage}\n");
                Console.ReadLine();
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
                Usca7();
            }
        }
    }
}
