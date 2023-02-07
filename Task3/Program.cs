//В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
if (m!=n)
{


    double[,] matrix = new double[m, n];
    FillArray(matrix);




    double[,] matrizm = new double[matrix.GetLength(0),1];
   
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        double sum= matrix[k, 0];
        
              
        for (int l = 1; l < matrix.GetLength(1); l++)
        {
            sum  =sum + matrix[k, l];
            matrizm[k,0]=sum;
            
        }
        
    }

    int Index=0;  
    double Minimum=0;
    for (int a=1; a< matrizm.GetLength(0); a++)

    {
        Minimum = matrizm[0,0];
        if ( Minimum > matrizm[a,0])
        {
            Minimum = matrizm[a,0];
            Index=a;
        }
    }
   
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    PrintArray(matrizm) ;
    Console.WriteLine("строкa с индексом");
    Console.WriteLine(Index);
    Console.WriteLine("имеет наименьшую сумму элементов");
    Console.WriteLine(Minimum);


}

else
{
    Console.Write("матрица не прямоугольная ");
}