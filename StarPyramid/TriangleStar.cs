using System;
using System.Collections.Generic;
using System.Text;

namespace StarPyramid
{
    class TriangleStar
    {
        public static void TrianglePattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }

        public static void ReverseTriangle()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int row = n; row >= 1; row--)
            {

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        public static void Pyramid()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }

        public static void DiamondPyramid()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
              
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void HoloSquare()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n || i == j || i + j == n)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void AlphabatPattern()
        {
            //Console.Write("Enter the maximum number of * line:");
            //int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 6; i++)//row
            {

                for (int j = 1; j <= 6; j++)//column
                {
                    if (i == 1 || j == 1 || j == 6 || i == 3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void BPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n / 2 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
        public static void CPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void DPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void EPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n/2 || i == n || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void FPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n/2 || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void GPattern()
        {
            Console.Write("Enter the maximum number of * line:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || i == n/2 && j >= n/2 || j ==5 && i >= 5)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void HPattern()
        {
          
            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || j == 6 || i == 3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void IPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 || j == 3 || i == 6)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void JPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 || j == 3 || i == 6 && j<=3 || j == 1 && i>=3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void KPattern()
        {

            for (int i = 1; i <= 7; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || i+j == 6 || i-j == 2)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void LPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || i == 6)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void MPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || i==j && j<=3 || j==6 || i == 2 && j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void NPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || i == j || j == 6)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void OPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if ((j == 1 || j == 6) && i >= 2 && i <= 5 || (i == 1 || i == 6) && j >= 2 && j <= 5)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void PPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 && j < 5 || j == 1 || i == 3 && j<5 || i == 2 && j==5)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void QPattern()
        {

            for (int i = 1; i <= 8; i++)
            {

                for (int j = 1; j <= 7; j++)
                {
                    if ((j == 1 || j == 6) && i >= 2 && i <= 5 || (i == 1 || i == 6) && j >= 2 && j <= 5 || (i == 5 || i == 6 || i == 7) && i - j == 0 )
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void RPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || (i == 1 || i == 3)  && j < 5 || (j == 5 && i > 1 && i < 3) || j == i - 1 )
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void SPattern()
        {

            for (int i = 1; i <= 7; i++)
            {

                for (int j = 1; j <= 7; j++)
                {
                    if ((i == 1 || j == 1) && i < 5 || i == 4 || j == 7 && i > 4 || i == 7 )
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
        public static void TPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void UPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (j == 1 || i == 6 || j == 6)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void VPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 12; j++)
                {
                    if (i == j || i + j == 12)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void WPattern()
        {

            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5 || i - j == 0 && j >= 4 && j <= 4 || i + j == 6 && j >= 2 && j <= 3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void XPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == j || i + j == 7)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void YPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if ((i == j && j < 4 )|| (i + j == 7 && i < 4) || j == 3 && i > 3)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void ZPattern()
        {

            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 || i + j == 7 || i == 6)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        public static void ReversePyramid()
        {
            for (int i = 1 ; i <= 6; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (j >= i && j <= 8-i)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            

        }
    }
    
}
