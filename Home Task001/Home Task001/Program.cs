using System;

namespace HomeTask000
{
    public class Program
    {
        static void Main(string[] args)
        {
            /** 1-20 araliginda olan ededlerin hasili
                        int a = 1;
                        int[] num = { 1, 45, 20, 5, 75, 22, 15 };
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i] >= 1 && num[i] <= 20)
                            {
                                a *= num[i];
                            }
                        }
                        Console.WriteLine(a);
            **/
            /** 2-e bolunenlerin hasili
                        int[] num = { 2, 45, 20, 5, 75, 22, 15 };
                        int a = 1;
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i] % 2 == 0)
                            {
                                a *= num[i];
                            }
                        }
                        Console.WriteLine(a);
            **/
            /**
                       float n = 1;
                       float c = 0;
                       while (n>=1)
                       {
                           n = n / 10;
                           c++;
                           if (n > 0 && n < 1)
                           {
                               Console.WriteLine(c);
                               break;
                           }

                       }**/
            
            Console.WriteLine(CanDevide(42));
            Console.WriteLine(CanDevide2(42));
            Console.WriteLine(CanDevide3(42));
            
        }

        static int CanDevide(int num)
        {

            while (num % 21 == 0)
            {
                Console.WriteLine("True");
                return 21;
            }
            Console.WriteLine("False");
            return 21;
        }
        static bool CanDevide2(int num)
        {

            if(num % 21 == 0)
            {
                return true;
            }
            return false;
        }
        static bool CanDevide3(int num)
        {
            return num % 21 == 0;
        }
    }
}