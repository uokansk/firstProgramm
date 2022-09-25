// двухмерный массив

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// int[,] matrixNew = new int[3, 4];
// for (int i = 0; i < matrixNew.GetLength(0); i++)
// {
//     for (int j = 0; j < matrixNew.GetLength(1); j++)
//     {
//         Console.Write($"{matrixNew[i, j]} ");
//     }
//     Console.WriteLine();
// }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}


int[,] matrixNew = new int[3, 4];
PrintArray(matrixNew);
Console.WriteLine();
FillArray(matrixNew);
PrintArray(matrixNew);