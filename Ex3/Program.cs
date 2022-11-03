// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine("Введите новый элемент массива ");
    arr[i] = int.Parse(Console.ReadLine());
}
System.Console.Write("[");
for (int i = 0; i < arr.Length-1; i++)
{
    System.Console.Write(arr[i]);
    System.Console.Write(", ");
}
System.Console.Write(arr[7] + "]");