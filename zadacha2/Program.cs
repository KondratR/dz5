// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int GetSum(int[] myArray)
{
    int result = 0;
    for (int i = 1; i < myArray.Length; i=i+2)
    {
        result = myArray[i] + result;
    }
    return result;
}


int[] myArray = GenArray(6, 10, 100);
PrintArray(myArray);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {GetSum(myArray)}");