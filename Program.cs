// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа
/*
int SecondNumber()
{
int num;
Console.WriteLine ("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
// Условие при котором считвается только трехзначное число
if(num>=100 && num<=999)
{
    Console.WriteLine("Number is - " + num);
    //делим на 10 и ищем остаток для нахождения 2 числа
        int dec = num / 10;
        int ed = dec % 10;
        int result = ed;
        return result;
}
// если условие не выполняется, то получаем 0
else 
{
    Console.WriteLine("Вы ввели неверное число!");
    int n = 0;
    return n;

если использовать void, то не нужно возвращать 0
}   
}

    int number = SecondNumber();
     Console.WriteLine("Ответ - " + number);


Второй вариант

void SecondNumber()
{
int num;
Console.WriteLine ("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
// Условие при котором считвается только трехзначное число
if(num>=100 && num<=999)
{
    Console.WriteLine("Number is - " + num);
    //делим на 10 и ищем остаток для нахождения 2 числа
        int dec = num / 10;
        int ed = dec % 10;
        int result = ed;
        Console.WriteLine("Ответ - " + result);
}
// если условие не выполняется
else 
{
    Console.WriteLine("Вы ввели неверное число!");


// Напишите программу, которая выводит третью цифру заданного числа или 
// или сообщает, что третьей цифры нет


void Third(int num)


//Напишите программу, которая принимает на вход цифру, обозначающую день
//недели, и проверяет, является ли этот день выходным

void Nday (int num)
{ 
    // условие выходных дней
  if (num == 7 || num == 6) 
  { Console.WriteLine ("Ееее, выходной "); } 
    // условие исключений
  else if ( num == 0 || num > 7)
  { Console.WriteLine ("Ты с какой планеты?");
  }
    // все остальное рабочие дни
  else { 
    Console.WriteLine("О нет, опять работа"); 
  } 
} 
Console.WriteLine("Введи день недели: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
Nday(num);
{
    // Условие, при котором заданное число будет меньше или равно 100
    if(num>=100)
{
    // Зацикливаем до тех пор, пока число не будет трехзначным
    while(num>1000)
    {
    num = num / 10;
    }
    int thr = num % 10;
    Console.WriteLine("Третья цифра:  " + thr);
}
else{
    // если число двухзначное или меньше, то:
    Console.WriteLine("Третьей цифры нет");
}
}
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
Third(num);
*/


