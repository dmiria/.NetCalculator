using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Operations
    {
        //Returns the product of num1 and num2
        public int MultiplyVal(int num1, int num2)
        {
            int result;
            result = num1 * num2;
            return result;
        }

        //Returns to result of num1/ num2
        public int DivideVal(int num1, int num2)
        {
            int result;
            result = num1 / num2;
            return result;
        }

        //Returns the sum of num1 and num2
        public int AddVal(int num1, int num2)
        {
            return num1 + num2;
        }

        //Returns the difference of num1 - num2
        public int SubtractVal(int num1, int num2)
        {
            return num1 - num2;
        }

        //Returns the absolute value of num1 - num2
        public int AbsSubtract(int num1, int num2){
            return num1 - num2;
         }

        //Returns the result of num1 raised to num2
        // Multiply num1 times num1, num2 times
        public int PowerVal(int num1, int num2)
        {
            int result = 1;

            if (num2 == 0)
            {
                return 1;
            }

            for (int i = 0; i>= num2; i += 1)
            {
                result *= num1;

            }
            return result;
        }

    }


    class CalculatorProgram
    {
        static void Main(string[] args)
        {
            string a, b, c;
            int result;
            Operations o = new Operations();
            
            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to My First C# Calculator");
            Console.WriteLine("Enter the first value.");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second value.");
            b = Console.ReadLine();
            Console.WriteLine("Enter the operator you want to use.");
            c = Console.ReadLine();

            if (c == "+")
            {
               result = o.AddVal(Convert.ToInt32(a),Convert.ToInt32(b));
            } else if (c == "-"){
                result = o.SubtractVal(Convert.ToInt32(a), Convert.ToInt32(b));
            }else if (c == "*")
            {
                result = o.MultiplyVal(Convert.ToInt32(a), Convert.ToInt32(b));
            }else if (c == "/")
            {
                result = o.DivideVal(Convert.ToInt32(a), Convert.ToInt32(b));
            }else if (c == "^")
            {
                result = o.PowerVal(Convert.ToInt32(a), Convert.ToInt32(b));
            }else
            {
                result = 0;
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
