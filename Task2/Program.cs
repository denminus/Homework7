//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная)
void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = Math.Round(new Random().NextDouble() *10, 3);
}
}
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}



    



int m =ReadInt("Введите количество строк: ");
int n =ReadInt("Введите количество столбцов: ");
if (m==n)
{


    double[,] matrix = new double[m, n];
    FillArray(matrix);




    double[,] matrizm = new double[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrizm[j, i] = matrix[i, j];
        }
    }

   
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    PrintArray(matrizm) ;
}

else
{
    Console.Write("Заменить строки на столбцы  невозможно , матрица не квадратная ");
}