while (true)
{
    Console.Write("Type task number(34, 36 or 38): ");
    string task = Console.ReadLine() ?? "0";
    if (task == "34") 
    {
        Task34();
        break;
    }
    else if (task == "36") 
    {
        Task36();
        break;
    }
    else if (task == "38") 
    {
        Task38();
        break;
    }
    else Console.WriteLine("Incorrect task number");
}

void Task34()  //34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
{
    int[] array = CreateArray(10, 100, 999);
    PrintArray(array);
    Console.WriteLine("Amount of even numbers in array is {0}", EvenElementCount(array));
}

void Task36()  //36.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
{
    int[] array = CreateArray(10, 0, 10);
    PrintArray(array);
    Console.WriteLine("Sum of ellemets in odd position is {0}", OddElementSum(array));
}

void Task38()  //38.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
{
    int[] array = CreateArray(10, 0, 100);
    PrintArray(array);
    Console.WriteLine("Differens between min and max elements is {0}", DiffBetweenMaxAndMin(array));
}

int[] CreateArray(int len, int elMin, int elMax)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(elMin, elMax + 1);
    }
    return array;
}

int OddElementSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
       sum += arr[i]; 
    }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write("\b" + "\b");
    Console.WriteLine("]");
}

int EvenElementCount(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

int DiffBetweenMaxAndMin(int[] arr)
{
    int diff, arrMin = arr[0], arrMax = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arrMin) arrMin = arr[i];
        if (arr[i] > arrMax) arrMax = arr[i];
    }
    diff = arrMax - arrMin;
    return diff;
}
