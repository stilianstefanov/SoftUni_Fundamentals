using System;

namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
               
                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus}) 
                
                if (attendance > maxAttendance)
                {
                    double totalBonus = Math.Round(((double)attendance / lecturesCount) * (5 + additionalBonus));
                    maxBonus = totalBonus;
                    maxAttendance = attendance;
                }
            }
            
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
