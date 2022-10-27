//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine()!);

int ReverseDigit(int num)
{
    int rev_num = 0;
    while (num > 0)
    {
        rev_num = rev_num * 10 + num % 10;
        num = num / 10;

    }
    return rev_num;
}
    int rev_num = ReverseDigit(num);
    if (rev_num == num)
        Console.WriteLine("Да");

    else
        Console.WriteLine("Нет");


