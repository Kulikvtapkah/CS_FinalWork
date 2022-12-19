// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

void ShowNaturalEvens(int min, int max)
{
    System.Console.Write(min);
    min += 2;
    if (min <= max)
    {
        System.Console.Write(", ");
        ShowNaturalEvens(min, max);
    }
    else System.Console.Write(".");

}

int M = EnterSmth("Введите М");
int N = EnterSmth("Введите N");

if (N < M) { int k = M; M = N; N = k; }
if (M < 2) M = 2; 
else M = M + M % 2;

if (N < 2) System.Console.Write("К сожалению, нечего выводить(");
else
{
    System.Console.WriteLine("Четные натуральные числа между М и N:");
    ShowNaturalEvens(M, N);
}
