// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rand.Next(leftRange, rightRange + 1) + rand.NextDouble()),3);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


double GetMax(double[] myArray)
{
    double max = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray [i]>max)
        {
            max = myArray[i];
        }
    }
    return max;
}
double GetMin(double[] myArray)
{
    double min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray [i]<min)
        {
            min = myArray[i];
        }
    }
    return min;
}

double[] myArray = GenArray(6, 1, 100);
PrintArray(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {GetMax(myArray)-GetMin(myArray)}");