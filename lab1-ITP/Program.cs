namespace lab1_ITP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Input character and print ascii
            Console.WriteLine("Enter character : ");
            char character=char.Parse(Console.ReadLine());

            int AsciiCode=(int)character;
            Console.WriteLine("Ascii of this character ="+ AsciiCode);
            Console.WriteLine("-------------------------");
            #endregion

            #region Q2  Input number and print hexadecimal
            Console.WriteLine("Enter number : ");
            int number = int.Parse(Console.ReadLine());

            string HexaDecimal= number.ToString("X");
            Console.WriteLine("HexaDecimal for this number = " + HexaDecimal);

            Console.WriteLine("-------------------------");

            #endregion  

            #region Q3 Input two numbers and print its sum   , mul , div

            Console.Write("Enter first number :");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("Enter seconed number :");
            int number2 = int.Parse(Console.ReadLine());

            int sum =number1+number2;
            float multiple = number1 * number2;
            float division= number1 / number2;
            Console.WriteLine("sum of number1 and number2 = " + sum);
            Console.WriteLine("multiple of number1 and number2 = " + multiple);
            Console.WriteLine("division of number1 and number2 = " + division);

            Console.WriteLine("-------------------------");


            #endregion  

            #region Q4 Enter number and print if it's odd or even
            Console.WriteLine("please enter number to check it is odd or even : ");
            int Number=int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
            Console.WriteLine("-------------------------");

            #endregion

            #region Q5 Enter two numbers and operation and print results according two the entered operation
            Console.WriteLine(" Enter the first number :");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("choose  the operation '+' or '-' or '/' or '*' ");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seconde number :");
            double num2 = double.Parse(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine($"the result of {num1}+ {num2}={num1 + num2}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"resukt of {num1}-{num2}= {num1 - num2} ");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"result of {num1}*{num2}={num1 * num2}");
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Exeption , please enter anthor number ");
                }
                else
                {
                    Console.WriteLine($"result of {num1}/{num2}={num1 / num2}");
                }
            }
            else
            {
                Console.WriteLine("please choose valid operator ");
            }

            #endregion
        }


    }
}
