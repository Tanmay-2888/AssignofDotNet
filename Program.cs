using System;

namespace AssignofDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
// checking if the number is divisible by 5 and 11

         /*   int num;
         num = 25;

         Console.WriteLine("Number: "+num);

         
         if (num % 5 == 0 && num % 11 == 0) {
            Console.WriteLine("Divisible by 5 and 11");
         } else {
            Console.WriteLine("Not divisible by 5 and 11");
         }
         Console.ReadLine();*/

         //Pattern1
        //  for (int row = 1; row <= 4; ++row)
        // {
        //     for (int col = 1; col <= row; ++col)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        // }

        //Pattern2
        // int i, j;
        //     int MAX = 4;
 
        //     for (i = MAX; i >= 0; i--)
        //     {
        //         for (j = 0; j <= i; j++)
        //         {
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        //     Console.ReadLine();

    //Pattern3
    // int n;
 
    //         Console.WriteLine();
 
    //         for(int i = 1; i < 6; i++)
    //         {
    //             for(int j = 1; j <= i; j++)
    //                 Console.Write(j.ToString());
    //             Console.WriteLine();
    //         }

    //Pattern 4
    // int i, j;
    //         int space = 4;
    //         int MAX = space;
 
    //         for (i = 0; i < MAX; i++)
    //         {
 
    //             for (j = 0; j < space; j++)
    //             {
    //                 Console.Write(" ");
    //             }
    //             for (j = 0; j <= i; j++)
    //             {
    //                 Console.Write("* ");
    //             }
 
    //             Console.Write("\n");
    //             space--;   
    //         }
    //         Console.ReadLine();

//Pattern 5
//     int x, y;
// for (x = 5; x >= 1; x--)
// {
// for (y = 1; y <= x; y++)
// {
// Console.Write(y);
// }
// Console.WriteLine();
// }
// Console.ReadLine();


//Pattern 6

// int x, y;
// for (x = 1; x <= 5; x++)
// {
// for (y = 5; y >= x; y--)
// {
// Console.Write(y);
// }
// Console.WriteLine();
// }
// Console.ReadLine();


//             int bNum,pwr;
//  int result;
// Console.Write("\n\n Recursion : Calculate power of any number :\n");
// Console.Write("------------------------------------------------\n");	
     
//  Console.Write(" Input the base  value : ");
//  bNum = Convert.ToInt32(Console.ReadLine());
     
//  Console.Write(" Input the exponent : ");
//  pwr = Convert.ToInt32(Console.ReadLine());
     
//  result=CalcuOfPower(bNum,pwr);
     
//  Console.Write(" The value of {0} to the power of {1} is : {2} \n\n",bNum,pwr,result);
// 	}

// public static int CalcuOfPower( int x,int y)
//  {
//   if (y == 0)
//    return 1;
//   else
//    return x * CalcuOfPower( x, y - 1 );

// {
// int number = 0, count = 0;
// Console.Write("Enter number :");
// number = Convert.ToInt32(Console.ReadLine());
// while (number > 0)
// {
// number = number / 10;
// count++;
// }
// Console.WriteLine("Number of digits is : " + count);
// Console.ReadLine();

// catch (Exception ex)
//  {
// Console.WriteLine(ex.Message);
// }
// Console.ReadKey(); 
// }

// int num, n, rev_no, r;
// Console.WriteLine("Palindrome Number from 1 to 500");
// for (num = 100; num <= 500; num++)
// {
// rev_no = 0;
//  n = num;
//  while (n != 0)
// {
//  r = n % 10;
//  rev_no = rev_no * 10 + r;
//  n = n / 10;
// }
// if (num == rev_no)
// Console.Write(num +" ");
// }
//  Console.ReadKey();

  }

        }
    }

