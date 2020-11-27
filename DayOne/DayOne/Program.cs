using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Program obj = new Program();
            int repitation=0;

            Console.WriteLine("Enter your choice:");

            Console.WriteLine("1.Sum Of Two\n 2. powerOfTwo\n 3.Leap Year");

            while (repitation != 3)
            {
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:

                        obj.sumOfTwo();
                        break;
                    case 2:
                        obj.powerOfTwo();
                        break;
                    case 3:
                        obj.findLeapYear();
                        break;
                    default:
                        Console.WriteLine("Invalid option..");
                        break;
                }
                repitation++;
            }
           
        }

        public void sumOfTwo() { 

             Console.WriteLine("Enter Two Number :");

             int x = Convert.ToInt32(Console.ReadLine());

             int y = Convert.ToInt32(Console.ReadLine());

             int sum = x + y;

            Console.WriteLine("{0} Sum of number : ", sum);


        }
        public void powerOfTwo()
        {

            int value;

            Console.WriteLine("Enter the Number for finding power of 2");

            value = Convert.ToInt32(Console.ReadLine());

            double powValues = Math.Pow(value, 2);

            Console.WriteLine("{0} root of given number : ", powValues);

        }   
        int year;
        public void findLeapYear() {

            Console.WriteLine("Enter Four Digit Number:");

            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            } else
            {
                Console.WriteLine("{0} is not Leap Year", year);
            }
        }
    }
}
    