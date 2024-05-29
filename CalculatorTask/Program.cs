namespace CalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<double> calculator = new Calculator<double>();
            Console.WriteLine(calculator.Sum(10.2, 12.4));
            while (true)
            {
                DisplayMenu();
                string input = Console.ReadLine();
                int operation;
                bool isSuccessed=int.TryParse(input, out operation);
                if (isSuccessed)
                {
                     switch (operation)
                    {
                        case 0:
                        return;
                        case 1:
                           firstNumDesc: Console.WriteLine("enter first num");
                           string  inputSum = Console.ReadLine();
                            double num1;
                            if (!double.TryParse(inputSum,out num1))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto  firstNumDesc;
                            }
                              secondNumDesc: Console.WriteLine("enter second num");
                              inputSum = Console.ReadLine();
                            double num2;
                            if (!double.TryParse(inputSum, out num2))
                            {
                                Console.WriteLine("please enter correct second Num ");
                                goto secondNumDesc;
                            }
                            Console.WriteLine(calculator.Sum(num1, num2));
                            break;
                        case 2:
                        firstNumSubtractDesc: Console.WriteLine("enter first num");
                            inputSum = Console.ReadLine();
                            double subtractNum1;
                            if (!double.TryParse(inputSum, out subtractNum1))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto firstNumSubtractDesc;
                            }
                             secondNumSubtractDesc: Console.WriteLine("enter second num");

                            inputSum = Console.ReadLine();
                            double subtractNum2;
                            if (!double.TryParse(inputSum, out subtractNum2))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto secondNumSubtractDesc;
                            }

                            Console.WriteLine(calculator.Subtract(subtractNum1, subtractNum2));
                            break;
                        case 3:
                        firstNumMultiplyDesc: Console.WriteLine("enter first num");
                            inputSum = Console.ReadLine();
                            double multiplyNum1;
                            if (!double.TryParse(inputSum, out multiplyNum1))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto firstNumMultiplyDesc;
                            }
                              secondNumMultiplyDesc: Console.WriteLine("enter second num");

                            inputSum = Console.ReadLine();
                            double multiplyNum2;
                            if (!double.TryParse(inputSum, out multiplyNum2))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto secondNumMultiplyDesc;
                            }
                            Console.WriteLine(calculator.Multiply(multiplyNum1, multiplyNum2));
                        break;
                        case 4:
                          
                        firstNumDivideDesc: Console.WriteLine("enter first num");
                            inputSum = Console.ReadLine();
                            double divideNum1;
                            if (!double.TryParse(inputSum, out divideNum1))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto firstNumDivideDesc;
                            }
                        secondNumDevideDesc: Console.WriteLine("enter second num");

                            inputSum = Console.ReadLine();
                            double divideNum2;
                            if (!double.TryParse(inputSum, out divideNum2))
                            {
                                Console.WriteLine("please enter correct first Num ");
                                goto secondNumDevideDesc;
                            }
                            if (divideNum2==0)
                            {
                                Console.WriteLine("Can not be divide 0");
                                goto secondNumDevideDesc; 
                            }
                            Console.WriteLine(calculator.Divide(divideNum1, divideNum2));
                            break;
                        default: 
                            Console.WriteLine("invalid operation!!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input !!!");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("___ MENU ___");
            Console.WriteLine("1 - Sum \n 2 - Subtract \n 3 - Multiply \n 4 - Divide \n 0 - Exit");
        }
      
    }
}
