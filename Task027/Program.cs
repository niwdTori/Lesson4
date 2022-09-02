//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberOfDigits(int number)
{
    int count = 0;
    number = Math.Abs(number);
    while(number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int count = NumberOfDigits(a);
int sum = 0;
int b = 1;
for (int i = 0; i <= count; i++)
{
    int c = a/b %10;
    sum = sum + c;
    b = b * 10;
}

Console.WriteLine(sum);