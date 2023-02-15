// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: "); //Ввыдо в терминал приглашение пользователя для ввода числа
int numberA = Convert.ToInt32(Console.ReadLine()); //Получение числа из терминала
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    System.Console.WriteLine("Большее число:" + numberA);
    System.Console.WriteLine("Меньшее число: " + numberB);
}
else
{
    System.Console.WriteLine("Большее число:" + numberB);
    System.Console.WriteLine("Меньшее число: " + numberA);
}
