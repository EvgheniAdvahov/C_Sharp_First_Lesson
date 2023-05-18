string[,] table = new string[2, 5];
// String.Empty
//table [0,0] table [0,1] table [0,2] ....table [0,4]
//table [1,0] table [1,1] table [1,2] ....table [1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int collums = 0; collums < 5; collums++)
//     {
//         System.Console.WriteLine($"-{table[rows, collums]}-");
//     }

// }

// void PrintArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int collums = 0; collums < matr.GetLength(1); collums++)
//         {
//             System.Console.Write($"{matr[rows, collums]} ");
//         }
//     System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int collums = 0; collums < matr.GetLength(1); collums++)
//         {
//             matr[rows, collums] = new Random().Next(0,10);
//         }
//     }
// }

// int[,] matrix = new int [3,4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);


// =======================================================================================================================


// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrinImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // System.Console.Write($"{image[i,j]}");
//             if(image[i,j] == 0) System.Console.Write($" ");
//             else System.Console.Write($"+");
//         }
//         System.Console.WriteLine();
//     }
// }


// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] =1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrinImage(pic);
// FillImage(13, 13);
// PrinImage(pic);


// ============================================================================================================

// double Factorial (int n)
// {
//     //1! ==1
//     //0! ==1
//     if( n== 1) return 1;
//     else return n * Factorial(n - 1);
// }
// System.Console.WriteLine(Factorial(5)); // 1*2*3 = 6

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }

// =======================================================================================================================


// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-1)

// int Fibonachi (int n)
// {
//     if(n==1 || n==2) return 1;
//     else  return Fibonachi(n-1) + Fibonachi(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     System.Console.WriteLine($"f({i}) = {Fibonachi(i)}");
// }

// =============================================================================

// void Print()
// {
//     System.Console.WriteLine("Hello");
//     Print();
// }

// Print();

void Increment(int i)
{
    System.Console.WriteLine(i);
    if (i >= 5)
        return;
    i++;
    Increment(i);
}

Increment(0);



