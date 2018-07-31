using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            string x = "y";
            while (x == "y")
            {
                Console.WriteLine("Please provide the car make:");
                string Make = ValidateString(Console.ReadLine());

                Console.WriteLine("Please provide the car model:");
                string Model = ValidateString(Console.ReadLine());

                Console.WriteLine("Please provide the car year:");
                int Year = ValidateInt(Console.ReadLine());

                Console.WriteLine("Please provide the car price:");
                double Price = ValidateFloat(Console.ReadLine());

                Cars temp = new Cars(Make, Model, Year, Price);
                cars.Add(temp);



                Console.WriteLine("Would you like to add another car? (type 'y' if yes)");
                if (ValidateString(Console.ReadLine()) != "y")
                {
                    x = "n";
                }                
            }
            PrintList(cars);
            Console.ReadLine();
        }
        public static void PrintList(List<Cars> cars)
        {
            Console.Write("#    Year".PadRight(13));
            Console.Write("Make".PadRight(10));
            Console.Write("Model".PadRight(10));
            Console.WriteLine("Price");

            Console.Write("=    ====".PadRight(13));
            Console.Write("====".PadRight(10));
            Console.Write("=====".PadRight(10));
            Console.WriteLine("=====");

            int x = 1;
            foreach (Cars c in cars)
            {
                Console.Write($"{x})   {c.Year}".PadRight(13));
                Console.Write(c.Make.PadRight(10));
                Console.Write(c.Model.PadRight(10));
                Console.WriteLine($"${c.Price}");
                x = x + 1;
                Console.WriteLine("=========================================");
            }
        }
        public static int ValidateInt(string UserInput1)
        {//Extended Chalenge
            try
            {
                int.Parse(UserInput1);
                return (int.Parse(UserInput1));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return 0;
            }
        }
        public static float ValidateFloat(string UserInput1)
        {//Extended Chalenge
            try
            {
                float.Parse(UserInput1);
                return (float.Parse(UserInput1));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return 0;
            }
        }
        public static string ValidateString(string UserInput)
        {//Extended Chalenge
            try
            {
                UserInput = UserInput.ToLower();
                return (UserInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "0";
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return "0";
            }
        }
    }
}
