using System;
namespace EmployeeWageComp
{
    public class UC9
    {


        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        private string companyName;
        private int wagePerHour, maxWorkingDays, maxWorkingHours, totalMonthWage;
        public UC9(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void UsCa9()
        {
            int empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0;
            Random random = new Random();
            while (empTotalHour <= maxWorkingHours && empTotalWorkDays <= maxWorkingDays)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        empWorkHour = 4;
                        break;
                    default:
                        empWorkHour = 0;
                        break;
                }
                empDailyWage = empWorkHour * wagePerHour;

                totalMonthWage += empDailyWage;
                empTotalWorkDays++;
                empTotalHour += empWorkHour;
            }
            if (empTotalHour > maxWorkingHours)
            {
                int a = empTotalHour - maxWorkingHours;
                empTotalHour -= a;
                int wage = a * wagePerHour;
                totalMonthWage -= wage;
            }
            if (empTotalWorkDays > maxWorkingDays)
            {
                empTotalWorkDays -= 1;
            }
            Console.WriteLine("\n\nCompany Name : " + companyName);
            Console.WriteLine($"\nEmployee total working days for {companyName} company is : {empTotalWorkDays}");
            Console.WriteLine($"Employee total working hours for {companyName} company is : {empTotalHour}\n");
            Console.WriteLine($"Employee Total Month Wage for {companyName} company is : {totalMonthWage}\n");
        }
    }
}
    


