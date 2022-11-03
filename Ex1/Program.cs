//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NumberDegree(int num, int degr)
{
    int res = 1;
    for (int i = 1; i <= degr; i++)
    {
        res = res*num;
    }
    System.Console.WriteLine($"{num} в степени {degr} равно {res}");
}


int osn = SetNumber("Введите основание:");
int step = SetNumber("Введите степень:");
NumberDegree(osn, step);