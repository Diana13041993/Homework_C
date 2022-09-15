
/*/ // Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// void Polli (string num)
//  {
//  if (num [0] == num [4] && num [1] == num [3])
//  {
//     Console.WriteLine ("Полиндром");
// }
// else {
//     Console.WriteLine ("Не полиндром или вне границ");
//     }
//  }
// Console.WriteLine("Введите пятизначное число");
// string num1 = Console.ReadLine();

// Polli(num1);


//Напишите программу, которая принимает на вход число N и выдает таблицу
// кубов чисел от 1 до N

/* void Cub(int n) 
 { 
 int curr = 1; 
 //цикл продолжается до тех пор, пока текущ значение будет меньше или равно N
 while(curr<=n) 
     { 
        считаем и выводим куб числа
     Console.Write (curr*curr*curr + ", "); 
     curr++; 
     } 
     
 } 
 // вводим число
 Console.Write("Введите число: "); 
 int num = Convert.ToInt32(Console.ReadLine()); 
 if(num <= 0) Console.Write("Некорректный ввод"); 
 
 else Cub(num); */


// Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве


void dot(int x1, int y1, int z1, int x2, int y2, int z2)
{
    
    double xd = 0;
    double yd = 0;
    double zd = 0;
    // формула для нахождения расстояния между точек:
    xd= ((x2-x1) * (x2-x1)); 
    yd= ((y2-y1) * (y2-y1)); 
    zd= ((z2-z1) * (z2-z1));
    Console.WriteLine(Math.Sqrt((xd+yd+zd))) ;
}
//вводим точки координат
Console.Write("Введите х1: ");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите х2: ");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 =Convert.ToInt32(Console.ReadLine());

// получаем ответ 
dot(x1, y1, z1, x2, y2, z2);

/*