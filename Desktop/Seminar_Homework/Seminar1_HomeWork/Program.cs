//Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее
/*
int num1;
int num2;
int max=0;
int min=0;

Console.WriteLine("Введите число 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

// Условие, при котором должно выполняться сравнение чисел
{
if (num1 > num2) 
{
// Присваиваем числа мин и макс
    max = num1;
    min = num2;
}
else if(num1 < num2)
{
    max = num2;
    min = num1;
}
// если задать одинаковые числа, то первому числу присвоится мин, второму макс
    else
{
    min = num1;
    max = num2;
}
// Выводим мин и макс на консоль

    Console.WriteLine("max = ");
    Console.WriteLine(max);
    Console.WriteLine("min = ");
    Console.WriteLine(min);

}



// Напишите программу, которая принимает на вход 3 числа
// и выдает максимальное из этих чисел
/*
int a;
int b;
int c;

int max = 0;

Console.WriteLine("Введите число 1");
Console.WriteLine("Введите число 2");
Console.WriteLine("Введите число 3");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

// Условие, при котором должно выполняться сравнение заданных чисел
{
if (a > b && a > c)
{
    // если условие выполяется, то присваиваем максимальное значение
    max = a;
} 
// если условие не выполняется, идем дальше и сравниваем второе заданное число
else if (b > a && b > c)
{
    max = b;
}
else
{
    // если ни одно из условий не выполнено, присваиваем макс последнему числу
    max = c;
    
} 
// вывод максимального числа на консоль
Console.Write("max = ");
    Console.WriteLine(max);
}









// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли но на 2 без отстатка)
/*
int num;

Console.Write ("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

    // условие, при котором текущее значение должно делиться на 2 
    // и при делении само на себя остаток равен 0
    if (num % 2 == 0) {
    Console.WriteLine("четное");
 
    }
    // если остаток не равен 0
    else 
    Console.WriteLine("нечетное");
/*


// напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
int num;

Console.Write ("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 1;

    while(current<=num)
{
    // условие, при котором текущее значение должно делиться на 2 
    // и при делении само на себя остаток равен 0
    if (current % 2 == 0) {
    Console.Write(current + " ");
    current++;
    }
    // если остаток не равен 0, то плюсуем счетчик
    else current++;
}
*/