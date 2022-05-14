using System;
namespace EmployeeWageComp
{
    public class UC1
    {
        public void UsCa1()
        {
            
            const int isPresent = 1;
            Random random = new Random(); 
            int check = random.Next(0, 2);
            if (check == isPresent) 
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
