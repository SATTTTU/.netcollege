//namespace project1
//{
//    internal class Function
//    {
//        public void salary()
//        {
//            int totalHours = 0, totalSalary = 0;
//            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

//            Console.WriteLine("Enter the hourly wage:");
//            string wageValue = Console.ReadLine();
//            int hourlyWage = int.Parse(wageValue); 
//            int[] dailyHours = new int[7]; 
//            for (int i = 0; i < 7; i++)
//            {
//                dailyHours[i] = i + 1; 
//            }
//            while (true)
//            {
//                Console.WriteLine("\nEnter the day of the week to calculate the salary:");
//                string dayValue = Console.ReadLine();
//                int day = int.Parse(dayValue);
//                if (day == 0|| day>7)
//                {
//                    break;
//                }
//                // Validate day input
//                if (day < 1 || day > 7)
//                {
//                    Console.WriteLine("Invalid day");
//                    continue;
//                }
//                totalHours = 0;
//                for (int i = 0; i < day; i++)
//                {
//                    totalHours += dailyHours[i];
//                }
//                totalSalary = totalHours * hourlyWage; 
//                Console.WriteLine($"\nTotal Hours Worked up to {daysOfWeek[day - 1]}: {totalHours}");
//                Console.WriteLine($"Total Salary up to {daysOfWeek[day - 1]}: {totalSalary}");
//                break;
//            }
//        }
//    }
//}
