/* Напишите программу, которая выводит случайное число из отрезка (10, 100) и проказывает
наибольшую цифру числа

int number = new Random().Next(10, 100);
int result1 = (number/10);
int result2 = (number%10);
Console.WriteLine(number);
if (result1 > result2)
{
    Console.WriteLine($"Первая цифра больше{result1}");
}
else
{
        Console.WriteLine($"Вторая цифра больше{result2}");    
}

Напишите программу, которая будет принимать на вход 2 числаи выводить, является ли второе число 
кратным первому. Если второе число не кратно первому, то программа выводит отстаток от деления

Console.WriteLine("Введите первое чилсло");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чилсло");
int number2 = int.Parse(Console.ReadLine()!);
int result = number1%number2;

    Console.WriteLine($"{number1} кратно {number2}");
}
else
{
    Console.WriteLine($"{number1} некратно {number2}. Остаток от деления {result}");
    }*/

/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23

Console.WriteLine("Введите чилсло");
int number = int.Parse(Console.ReadLine()!);
if((number%7 == 0)&&(number%23 == 0))
{
Console.WriteLine($"Число {number} кратно и 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} некратно и 7 и 23");
}*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
//квадратом другого
/*Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);

if((number2*number2 == number1)||(number1*number1 == number2))
{
    Console.WriteLine($"Одно число является квадратом второго");
}
else{
     Console.WriteLine($"Одно число не является квадратом второго");
}*/

// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
int result = (number/100)*10 + number % 10;
Console.WriteLine($"{number} -> {result}");