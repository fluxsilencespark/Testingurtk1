namespace Calculator;

class Calculator7773
{
    static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string A = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string B = Console.ReadLine();
            Console.WriteLine("Выберите операцию (+, -, *, /) ");
            string op = Console.ReadLine();

            if (Double.TryParse(A, out double a) && Double.TryParse(B, out double b))
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine(Add(a, b));
                        break;

                    case "-":
                        Console.WriteLine(Sub(a, b));
                        break;

                    case "*":
                        Console.WriteLine(Mult(a, b));
                        break;

                    case "/":
                        if (b!=0) Console.WriteLine(Div(a, b));
                        else Console.WriteLine("На ноль делить нельзя!");
                        break;

                    default:
                        Console.WriteLine("Неверная операция");
                        break;
                }
            }
            else Console.WriteLine("Ошибка: Неверный тип данных");

            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Sub(double a, double b)
            {
                return a - b;
            }

            static double Mult(double a, double b)
            {
                return a * b;
            }

            static double Div(double a, double b)
            {
                return a / b;
            }
        Console.ReadLine();
        }
}
