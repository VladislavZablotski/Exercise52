int[,] array = new int[3,4];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}

double[] AverageColumnArray = new double[array.GetLength(1)];
double Sum;
for (int i = 0; i < array.GetLength(1); i++)
{
    Sum=0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        Sum+=array[j,i];
    }
    AverageColumnArray[i]=Sum/array.GetLength(0);
}
Console.WriteLine();
Console.Write("Средние значения по столбцам равны: ");

for (int i = 0; i < AverageColumnArray.Length; i++)
{
    Console.Write($"{Math.Round(AverageColumnArray[i],2)}, ");
}
