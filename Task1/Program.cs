// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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


void PoryadokStrok(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1)-1; j++)
{
        int minPosition= j;
        int a = 0;
        for ( a = j+1; a< matr.GetLength(1); a++)
        {
               
                if (matr[ i, a ] < matr[ i,minPosition ])
                {
                    minPosition=a;
                }
        }
        double temp=matr[ i, j ];
        matr[ i, j ]= matr[ i,minPosition ];
        matr[ i,minPosition ]=temp;
}
}
}



int m =ReadInt("Введите количество строк: ");
int n =ReadInt("Введите количество столбцов: ");

double[,] matrix = new double[m, n];





FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
PoryadokStrok(matrix);
Console.WriteLine();
PrintArray(matrix);