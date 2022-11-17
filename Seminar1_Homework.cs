// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее  
//Console.WriteLine("Введите 2 целых числа");
//string num1 = Console.ReadLine();
//string num2 = Console.ReadLine();
//if (Int32.Parse(num1)>Int32.Parse(num2))
//{
  //  Console.WriteLine("Большее число: "+ num1 + ", меньшее число: " + num2);
//}
//else
//{
  //  Console.WriteLine("Большее число: "+ num2 + ", меньшее число: " + num1);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("Введите число а:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число b:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число c:");
//int num3 = Convert.ToInt32(Console.ReadLine());

//int max=num1;

//if(num2 > max) max = num2;
//if(num3 > max) max = num3;

//Console.WriteLine($"a = {num1}, b = {num2}, c = {num3} -> max = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string num = Console.ReadLine();
if(Int32.Parse(num)%2==0){
    Console.WriteLine("Число чётное");
}
else{
    Console.WriteLine("Число нечётное");
}