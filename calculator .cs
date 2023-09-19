namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double firstnomber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double secondnomber = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию : " + "+;" + " " + "-;" + " " + "*;" + " " + "/;" + " " + "sqrt - извлечь корень первого числа");
            string action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine("Результат сложения =" + (firstnomber + secondnomber));
            }
            else if(action == "-")
            {
                Console.WriteLine("Результат вычитания =" + (firstnomber - secondnomber));
            }
            else if (action == "*")
            {
                Console.WriteLine("Результат умножения =" + (firstnomber * secondnomber));
            }
            else if (action == "/")
            {
                if (secondnomber == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    Console.WriteLine("Результат деления =" + (firstnomber / secondnomber));
                }
                
            }
            else if (action == "sqrt")
            {
                Console.WriteLine("Результат извлечения корня первого числа =" + ( Math.Sqrt(firstnomber)));
                Console.WriteLine("Результат извлечения корня второго числа =" + ( Math.Sqrt(secondnomber)));
            }
            else
            {
                Console.WriteLine("Выберите коректную опперацию");
            }

            Console.ReadLine();
        }
    }
}