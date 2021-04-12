using System;

namespace StarPattern
{
    class Program
    {
        int i, j, k;


        //  *
        //  **
        //  ***
        //  ****
        //  *****
        public void Triangle1()
        { 
        for (i = 1; i <= 5; i++)
              {
                  for (j = 1; j <= i; j++) 
                  {
                      Console.Write("*");
                  }
      Console.WriteLine();
              }
       Console.ReadLine(); 
        }

        //    *
        //   **
        //  ***
        // ****
        //*****

        public void Triangle2()
        {

              for (i = 5; i >= 1; i--)
               {
                   for (j = 1; j < i; j++)
                   {
                       Console.Write(" ");
                   }

                   for (k = 5; k >= i; k--)
                   {
                       Console.Write("*");
                   }

                   Console.WriteLine();
               }
               Console.ReadLine();
        }

        //*****
        //*****
        //*****
        //*****
        //*****

        public void Rectangle()
        {
            for (i = 5; i >= 1; i--)
            {
                for (j = 5; j >= 1; j--)


                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }


        //   *****
        //   ****
        //   ***
        //   **
        //   *

        public void InvtTriangle1()

        {
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)

                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //   *****
        //    ****
        //     ***
        //      **
        //       *

        public void InvtTriangle2()

        {
            for (i = 5; i >= 1; i--)
            {
                for (j = 5; j > i; j--)

                {
                    Console.Write(" ");
                }
                for (k=1;k<=i;k++)

                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //*
        // **
        //  ***
        //   ****
        //    *****

        public void Invttriangle3()

        {
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j < i; j++)

                {
                    Console.Write(" ");
                }
                for (k = 1; k < i ; k++)

                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void Pyramid()

        {

            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num-i+1; j++)

                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)

                {
                    Console.Write(j);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Pyramid1()

        {

            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
           
           for (i = 1; i <= num; i++)
            {
                for (j = 1; j <  i ; j++)

                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (num * 2 -(i * 2 - 1)); k++)

                {
                    Console.Write(i);
                  //  Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void Diamond()

        {
            int num, count = 1;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            count = num - 1;
            for (k = 1; k <= num; k++)
            {
                for (i = 1; i <= count; i++)      
                {
                    Console.Write(" "); 
                }
                count--;
                for(i= 1;i<=2*k-1;i++)
                {

                    Console.Write("*");
                }Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= num; k++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (i = 1; i <= 2 * (num - k) - 1; i++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

            static void Main(string[] args)
        {

            Program star = new Program();
            Console.WriteLine("Star Triangle Pattern1");
            star.Triangle1();
            Console.WriteLine("Star Triangle Pattern2");
            star.Triangle2();
            Console.WriteLine("Inverted Triangle Pattern1");
            star.InvtTriangle1();
            Console.WriteLine(" Inverted Triangle Pattern2");
            star.InvtTriangle2();
            Console.WriteLine(" Inverted Triangle Pattern3");
            star.Invttriangle3();
            Console.WriteLine("Star Pyramid Pattern");
            star.Pyramid();
            Console.WriteLine("Star inverted Pyramid Pattern");
            star.Pyramid1();
            Console.WriteLine("Star Diamond Pattern");
            star.Diamond();




        }
    }
}
