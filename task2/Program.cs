// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
Console.Write("Input threedigit number : ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("second digit of the number: " +stringNumber[1]);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Input number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("third number: " + anyNumberText[3]);
} 
else
    {
        Console.WriteLine("empty third number: ");
    }
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7) 
{
    Console.WriteLine("(a day off -> yes");
}
    else if (dayNumber < 1 || dayNumber == 7) 
{
    Console.WriteLine("i don't know what day it is: ");
}
    else Console.WriteLine("it's not a day off -> no ");
}

CheckingTheDayOfTheWeek(dayNumber);
