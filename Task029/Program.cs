//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] mas)
{
    int length = mas.Length;
    for (int index = 0; index < length; index++)
    {
        mas[index] = new Random().Next(1,100);
    }
}

void PrintArray(int[] mas)
{
    int count = mas.Length;
    for(int index = 0; index < count; index++)
    {
        Console.Write($"{mas[index]}, ");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);