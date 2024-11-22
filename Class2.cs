

//namespace project1
//{
//    internal class Class2
//    {
//        public void classroom()
//        {
//            Console.WriteLine("Enter a number:");
//            string number1 = Console.ReadLine();
//            int one = int.Parse(number1);
//            if (one == 1)
//            {
//                Console.WriteLine("Its Sunday");
//            }
//            else if (one == 2)
//            {
//                Console.WriteLine("its Monday");
//            }
//            else
//            {
//                Console.WriteLine("its nit any day");
//            }
//            {

//            }
//        }
//        // public void classroom2() {
//        //    Console.WriteLine("Enter a number:");
//        //    string number1 = Console.ReadLine();
//        //    int one = int.Parse(number1);
//        //    string two = Console.ReadLine();

//        //    switch (two) {
//        //        case "1":
//        //                   Console.WriteLine("Its Sunday");
//        //                    break;
//        //        case "2":
//        //                  Console.WriteLine("Its Sunday");
//        //                   break;
//        //        default:
//        //            Console.WriteLine("enter valid one");
//        //            break;
//        //    }


//        //}
//        //for looping 
//        public void subject3()
//        {
//            Console.WriteLine("Enter the first number");
//            string num1 = Console.ReadLine();
//            int sir = int.Parse(num1);
//            for (int i = 0; i < sir; i += i + 2)
//            {
//                Console.WriteLine(i);

//            }
//        }
//        //while loop
//        public void subject4()
//        {
//            Console.WriteLine("Enter the first number");
//            string num2 = Console.ReadLine();
//            int sat = int.Parse(num2);
//            while (sat % 2 == 0)
//            {
//                Console.WriteLine(sat);
//                sat = sat + 1;
//            }
//        }
//        //do while loop
//        public void subject5()
//        {
//            int input;

//            Console.WriteLine("Enter numbers. The loop will stop when you enter 10.");

//            do
//            {
//                try
//                {
//                    Console.Write("Enter a number: ");
//                    //input = int.Parse(Console.ReadLine());
//                    Console.WriteLine($"You entered: {input}");
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Invalid input. Please enter a valid integer.");
//                    input = 0; // Assign a default value to continue the loop.
//                }
//            }
//            while (input != 10);

//            Console.WriteLine("Loop terminated because you entered 10.");
//        }

//    }
//}
