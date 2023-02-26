
// Напишите цикл который принимает на вход два числа А и В и возводит число А в натуральную степень В.
Console.Clear();
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
for (int i =1; i< b; i++)
{
    step = step*a;
}
Console.WriteLine("A в степени B :"+step);
