

namespace project1
{
    internal class Csharpoperator
    {
        //public void run()
        //{
        //    arithop();
        //}
        // void arithop()
        //{
        //    int a = 1;
        //    int b= 2;
        //    int result = a + b;
        //    Console.WriteLine(result);
        //}
        public void run()
        {
            greater();
        }
        void greater() {
            Console.WriteLine("Enter a number:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string string2 = Console.ReadLine();
            int number1 = int.Parse(string1);
            int number2 = int.Parse(string2);
            int result=(number1>number2 ? number1 : number2);
            Console.WriteLine("the greater value is "+result);
            
            
        }
       
    }
}
