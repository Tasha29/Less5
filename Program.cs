using System;

namespace Less5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                lab5_1();
                Console.WriteLine("");
                // lab5_2();
                Console.WriteLine("");
                lab5_3_1();
                Console.WriteLine("");
                lab5_3_4();
                Console.WriteLine("");
                lab5_62();
            }

            void lab5_1()

            {
                int[] mus = new int[] { 37, 0, 50, 46, 34, 46, 0, 13 };

                for (int n = 0; n < mus.Length; n++)

                    Console.WriteLine($"mus[{ n }]={mus[n]}");

            }

            void lab5_2()

            {
                int[] mus = new int[10];
                string zn = "";//вводимое значение

                for (int i = 0; i < mus.Length; i++)

                {
                    Console.Write("Введи єлемент массива {0}=", i + 1);
                    zn = Console.ReadLine();
                }
            }
            void lab5_3_1()

            {
                double[] mus2 = new double[15];
                Random r = new Random();

                {

                    for (int i = 0; i < mus2.Length; i++)

                    {
                        mus2[i] = Convert.ToDouble(r.Next(-500, 501) / 10.00); ;

                        //mus2[i] = r.Next(1/1000);

                        //Array.Sort(mus2);
                        //Array.Reverse(mus2);

                        //Console.WriteLine(mus2[i] + " ");
                        Console.WriteLine($"mus2[{i}]={mus2[i]}" + "");

                    }
                }
            }

            void lab5_3_4()
            {

                int[] mus2 = new int[15];
                Random r = new Random();

                for (int i = 0; i < mus2.Length; i++)
                {
                    mus2[i] = r.Next(11);
                    //Array.Sort(mus2);

                    Console.WriteLine($"mus2[{i}]={mus2[i]}" + "");
                }
            }
            void lab5_62()
            {
                int z = 5;
                int[] mus1 = new int[z];//Вариант для массива случ чисел
                //int[] mus1 = new int[] {1,2,3,4};//Вариант для массива с обьявленными переменными
                Random v = new Random();
                int even_sum = 0;
                Console.WriteLine("Исх данные массива mus1:");

                for (int i = 0; i < mus1.Length; i++)
                {
                    //Console.WriteLine(mus1[i]);
                    Console.WriteLine(mus1[i]=v.Next(0,z));
                    if (mus1[i] % 2 == 0)
                    even_sum+=mus1[i];
                    
                }                
                Console.WriteLine("");//для красоты пропустила строку
                Console.WriteLine("Сумма чётных чисел в массиве: {0}", even_sum);
            }
        }
    }         
}
