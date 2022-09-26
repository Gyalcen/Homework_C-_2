/*
Задача 1.

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32 (Console.ReadLine());
{
int FirstNumber = (num / 10) % 10;

Console.WriteLine(FirstNumber);
};
*/

/*

Задача 2.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(num);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
};
*/

/* 

Задача 3.

Console.Write("Введи цифру, которая обозначает день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Day (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("Выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("В неделе семь дней");
  }
  else Console.WriteLine("Будний день");
}

Day(dayNumber);
*/
