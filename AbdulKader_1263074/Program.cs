using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulKader_1263074
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------------Question No 1(a)-------------");
                WorkingWithDecisionAndIterationStatement();

                Console.WriteLine("----------------Question No 1(b)-------------");
                WorkingWithArithmeticOperatorWithNamingAssigningVariable();

                Console.WriteLine("----------------Question No 1(c)-------------");
                WorkingWithMethodScopeParameter();

                Console.WriteLine("----------------Question No 1(d)-------------");
                WorkingWithException();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void WorkingWithException()
        {
            try
            {
                int v1 = 15;
                int v2 = 0;
                int result;
                result = v1 / v2;
                Console.WriteLine($"result is :{result}");
            }
            catch (DivideByZeroException dx)
            {
                Console.WriteLine(dx.Message);

            }

            catch (OverflowException ox)
            {

                Console.WriteLine(ox.Message);
            }

            catch (IndexOutOfRangeException ix)
            {
                Console.WriteLine(ix.Message);

            }
            catch (FormatException fx)
            {
                Console.WriteLine(fx.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("close");
            }
        }

        private static void WorkingWithMethodScopeParameter()
        {
            addResult(10,20);
            addResult(v1:10,v2:20,v3:30);
        }

        private static void addResult(int v1, int v2, int v3=15)
        {
            Console.WriteLine($"This method is invoked for{count}");
            count++;
        }

        private static void WorkingWithArithmeticOperatorWithNamingAssigningVariable()
        {
            int value1 = 10;
            int value2 = 5;
            int result;

            result = value1 + value2;
            Console.WriteLine($"Addition result: {result}");

            result = value1 - value2;
            Console.WriteLine($"Subtract result: {result}");

            result = value1 * value2;
            Console.WriteLine($"Multiplicative result: {result}");

            result = value1 / value2;
            Console.WriteLine($"Division result: {result}");

            int a1 = 0;
            a1 = ++a1;
            Console.WriteLine($"Pefix increment of a1: {a1}");

            int a2 = 0;
            a1 = a2++;
            Console.WriteLine($"Postfix increment of a2: {a2}");

            int b2 = 0;
            a1 = --b2;
            Console.WriteLine($"Prefix decrement of b2: {b2}");

            int b1 = 0;
            a1 = b1--;
            Console.WriteLine($"Postfix decrement of b1: {b1}");
        }

      

        private static void WorkingWithDecisionAndIterationStatement()
        {
            WorkingWithIfElse();
            WorkingWithSwitchStatement();
            WorkingWithWhileLoop();
            WorkingWithForLoop();
            WorkingWithForEach();
            WorkingWithDoLoop();
        }

        private static void WorkingWithForEach()
        {
            int currentNumber = 0;
            int posCount = 0;
            int negCount = 0;
            int[] myArray = new[]{1, 5, 6, 7};
            foreach (int numbers in myArray)
            {
                currentNumber = numbers;
                if (currentNumber == 1 )
                {
                    posCount++;
                }
                else
                { negCount++; }
                Console.WriteLine($"PositiveCount{posCount} NegCount {negCount}");
            }
        }

        private static void WorkingWithDoLoop()
        {
            int value = 20;
            int value2;
            do
            {
                value2 = value + 1;
                Console.WriteLine($"Incerement value:{value2}");
            } while (value>10 && value<20);
        }

        private static void WorkingWithForLoop()
        {
            int value = 20;
            for (int i = 0; i <= value; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void WorkingWithWhileLoop()
        {
            int value = 10;          
            while (value<=10)
            {
                value = value+1;
                Console.WriteLine($"Incerement value:{value}");
            }

        }

        private static void WorkingWithSwitchStatement()
        {
            int value = 1;
            switch (value)
            {
                case 0:
                    Console.WriteLine("Today is a good day");
                    break;
                default:
                    Console.WriteLine("Today is not a good day");
                    break;
            }
        }

        private static void WorkingWithIfElse()
        {
            int value = 10;
            if (value == 10)
            {
                Console.WriteLine("Good");
            }
            else
            { Console.WriteLine("Not Good"); }
        }
    }
}
